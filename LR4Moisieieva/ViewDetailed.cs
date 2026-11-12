using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

namespace LR4Moisieieva
{
    public class ViewDetailed : View
    {
        private FrmDetailed frm;

        public ViewDetailed(Model model, Controller controller, FrmDetailed frm) :
            base(model, controller)
        {
            this.frm = frm;
        }

        public override void DataBind()
        {
            frm.LblTime.DataBindings.Add(new Binding("Text", model.Clock, "Clock"));
            frm.TbCPU.DataBindings.Add(new Binding("Text", model.Cpu, "ActiveProcess", true));
            frm.TbDevice.DataBindings.Add(new Binding("Text", model.Device, "ActiveProcess", true));
            frm.LblFreeMem.DataBindings.Add(new Binding("Text", model.Ram, "FreeSize"));
            frm.LblOccupiedMem.DataBindings.Add(new Binding("Text", model.Ram, "OccupiedSize"));

            Binding intensityBinding = new Binding("Value", model.ModelSettings, "Intensity");
            intensityBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.NudIntensity.DataBindings.Add(intensityBinding);

            Binding minBurstBinding = new Binding("Value", model.ModelSettings, "MinValueOfBurstTime");
            minBurstBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.NudMinBurst.DataBindings.Add(minBurstBinding);

            Binding maxBurstBinding = new Binding("Value", model.ModelSettings, "MaxValueOfBurstTime");
            maxBurstBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.NudMaxBurst.DataBindings.Add(maxBurstBinding);

            Binding minAddrBinding = new Binding("Value", model.ModelSettings, "MinValueOfAddrSpace");
            minAddrBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.NudMinAddr.DataBindings.Add(minAddrBinding);

            Binding maxAddrBinding = new Binding("Value", model.ModelSettings, "MaxValueOfAddrSpace");
            maxAddrBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.NudMaxAddr.DataBindings.Add(maxAddrBinding);

            Binding ramSizeBinding = new Binding("SelectedItem", model.ModelSettings, "ValueOfRAMSize", true);
            ramSizeBinding.ControlUpdateMode = ControlUpdateMode.Never;
            frm.CbRamSize.DataBindings.Add(ramSizeBinding);

            Subscribe();
        }

        public override void DataUnbind()
        {
            frm.LblTime.DataBindings.RemoveAt(0);
            frm.TbCPU.DataBindings.RemoveAt(0);
            frm.TbDevice.DataBindings.RemoveAt(0);
            frm.LblFreeMem.DataBindings.RemoveAt(0);
            frm.LblOccupiedMem.DataBindings.RemoveAt(0);

            frm.NudIntensity.DataBindings.RemoveAt(0);
            frm.NudMinBurst.DataBindings.RemoveAt(0);
            frm.NudMaxBurst.DataBindings.RemoveAt(0);
            frm.NudMinAddr.DataBindings.RemoveAt(0);
            frm.NudMaxAddr.DataBindings.RemoveAt(0);
            frm.CbRamSize.DataBindings.RemoveAt(0);

            Unsubscribe();
        }

        private void Subscribe()
        {
            model.PropertyChanged += PropertyChangedHandler;
        }

        private void Unsubscribe()
        {
            model.PropertyChanged -= PropertyChangedHandler;
        }

        private void PropertyChangedHandler(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "ReadyQueue")
            {
                updateListBox(model.ReadyQueue, frm.LbCPUQueue);
            }
            else if (e.PropertyName == "DeviceQueue")
            {
                updateListBox(model.DeviceQueue, frm.LbDeviceQueue);
            }
        }

        private void updateListBox(Queue<Process> queue, ListBox lb)
        {
            lb.Items.Clear();
            if (queue.Count != 0)
                lb.Items.AddRange(queue.ToArray());
        }

        private void updateListBox(PriorityQueue<Process, long> queue, ListBox lb)
        {
            lb.Items.Clear();
            if (queue.Count != 0)
                lb.Items.AddRange(queue.UnorderedItems.Select(x => x.Element).ToArray());
        }
    }
}