using System;
using System.Buffers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;

namespace LR4Moisieieva
{
    public class Model : INotifyPropertyChanged
    {
        public SystemClock Clock { get; private set; }
        public Resource Cpu { get; private set; }
        public Resource Device { get; private set; }
        public Memory Ram { get; private set; }

        private PriorityQueue<Process, long> readyQueue;
        public PriorityQueue<Process, long> ReadyQueue
        {
            get { return readyQueue; }
            set
            {
                readyQueue = value;
                OnPropertyChanged();
            }
        }

        private Queue<Process> deviceQueue;
        public Queue<Process> DeviceQueue
        {
            get { return deviceQueue; }
            set
            {
                deviceQueue = value;
                OnPropertyChanged();
            }
        }

        private IdGenerator idGen;
        private CPUScheduler cpuScheduler;
        private MemoryManager memoryManager;
        private DeviceScheduler deviceScheduler;
        private Random processRand;

        private Settings modelSettings;
        public Settings ModelSettings
        {
            get { return modelSettings; }
            set { modelSettings = value; }
        }

        public Model()
        {
            Clock = new SystemClock();
            Cpu = new Resource();
            Device = new Resource();
            Ram = new Memory();
            readyQueue = new PriorityQueue<Process, long>();
            deviceQueue = new Queue<Process>();
            idGen = new IdGenerator();
            cpuScheduler = new CPUScheduler(Cpu, readyQueue);
            memoryManager = new MemoryManager();
            deviceScheduler = new DeviceScheduler(Device, deviceQueue);
            modelSettings = new Settings();
            processRand = new Random();
        }

        public void SaveSettings()
        {
            Ram.Save(modelSettings.ValueOfRAMSize);
            memoryManager.Save(Ram);
        }

        public void WorkingCycle()
        {
            Clock.WorkingCycle();

            if (processRand.NextDouble() <= modelSettings.Intensity)
            {
                Process proc = new Process(idGen.Id,
                    processRand.Next(modelSettings.MinValueOfAddrSpace, modelSettings.MaxValueOfAddrSpace + 1));

                if (memoryManager.Allocate(proc) != null)
                {
                    proc.BurstTime = processRand.Next(modelSettings.MinValueOfBurstTime, modelSettings.MaxValueOfBurstTime + 1);
                    readyQueue.Enqueue(proc, proc.BurstTime);
                    OnPropertyChanged("ReadyQueue");
                }
            }

            Cpu.WorkingCycle();
            Device.WorkingCycle();

            if (Cpu.IsFree() && readyQueue.Count > 0)
            {
                cpuScheduler.Session();
                Subscribe(Cpu.ActiveProcess);
                OnPropertyChanged("ReadyQueue");
            }

            if (Device.IsFree() && deviceQueue.Count > 0)
            {
                deviceScheduler.Session();
                Subscribe(Device.ActiveProcess);
                OnPropertyChanged("DeviceQueue");
            }
        }

        public void Clear()
        {
            if (!Cpu.IsFree()) Unsubscribe(Cpu.ActiveProcess);
            if (!Device.IsFree()) Unsubscribe(Device.ActiveProcess);

            Cpu.Clear();
            Device.Clear();
            Ram.Clear();
            readyQueue.Clear();
            deviceQueue.Clear();
            Clock.Clear();
            idGen.Clear();

            OnPropertyChanged("ReadyQueue");
            OnPropertyChanged("DeviceQueue");
        }

        private void Subscribe(Process proc)
        {
            if (proc != null)
            {
                proc.ResourceFreeing += ResourceFreeingEventHandler;
            }
        }

        private void Unsubscribe(Process proc)
        {
            if (proc != null)
            {
                proc.ResourceFreeing -= ResourceFreeingEventHandler;
            }
        }

        private void ResourceFreeingEventHandler(object sender, EventArgs e)
        {
            Process proc = sender as Process;
            Unsubscribe(proc);

            if (proc.Status == ProcessStatus.terminated)
            {
                Cpu.Clear();
                memoryManager.Free(proc);
            }
            else if (proc.Status == ProcessStatus.waiting)
            {
                Cpu.Clear();
                proc.ResetWorkTime();
                proc.BurstTime = processRand.Next(modelSettings.MinValueOfBurstTime, modelSettings.MaxValueOfBurstTime + 1);
                deviceQueue.Enqueue(proc);
                OnPropertyChanged("DeviceQueue");
            }
            else if (proc.Status == ProcessStatus.ready)
            {
                Device.Clear();
                proc.ResetWorkTime();
                proc.BurstTime = processRand.Next(modelSettings.MinValueOfBurstTime, modelSettings.MaxValueOfBurstTime + 1);
                readyQueue.Enqueue(proc, proc.BurstTime);
                OnPropertyChanged("ReadyQueue");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}