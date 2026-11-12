using System;

namespace LR4Moisieieva
{
    public enum ProcessStatus { ready, running, waiting, terminated }

    public class Process
    {
        private long id;
        private long workTime;
        private Random procRand = new Random();

        public string name { get; private set; }
        public long BurstTime { get; set; }
        public ProcessStatus Status { get; set; }
        public long AddrSpace { get; private set; }

        public event EventHandler ResourceFreeing;

        public Process(long pId, long addrSpace)
        {
            id = pId;
            AddrSpace = addrSpace;
            name = "P" + pId;
            Status = ProcessStatus.ready;
        }

        public void IncreaseWorkTime()
        {
            if (workTime < BurstTime)
            {
                workTime++;
            }
            if (workTime == BurstTime)
            {
                if (Status == ProcessStatus.running)
                {
                    Status = procRand.Next(0, 2) == 0 ? ProcessStatus.terminated : ProcessStatus.waiting;
                }
                else
                {
                    Status = ProcessStatus.ready;
                }
                OnResourceFreeing();
            }
        }

        public void ResetWorkTime()
        {
            workTime = 0;
        }

        public override string ToString()
        {
            return name + " (" + workTime + "/" + BurstTime + ")";
        }

        private void OnResourceFreeing()
        {
            if (ResourceFreeing != null)
            {
                ResourceFreeing(this, EventArgs.Empty);
            }
        }
    }
}