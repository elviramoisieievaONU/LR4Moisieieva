using System;
using System.Windows.Forms;

namespace LR4Moisieieva
{
    public partial class FrmDetailed : Form
    {
        private ViewDetailed viewDetailed { get; set; }

        public FrmDetailed()
        {
            InitializeComponent();
            cbRamSize.SelectedItem = cbRamSize.Items[0];
            viewDetailed = new ViewDetailed(new Model(), new Controller(), this);
            viewDetailed.DataBind();
        }

        public Label LblTime
        {
            get { return lblTime; }
        }

        public TextBox TbCPU
        {
            get { return tbCPU; }
        }

        public TextBox TbDevice
        {
            get { return tbDevice; }
        }

        public Label LblFreeMem
        {
            get { return lblFreeMem; }
        }

        public Label LblOccupiedMem
        {
            get { return lblOccupiedMem; }
        }

        public ListBox LbCPUQueue
        {
            get { return lbCPUQueue; }
        }

        public ListBox LbDeviceQueue
        {
            get { return lbDeviceQueue; }
        }

        public NumericUpDown NudIntensity
        {
            get { return nudIntensity; }
        }

        public NumericUpDown NudMinBurst
        {
            get { return nudMinBurst; }
        }

        public NumericUpDown NudMaxBurst
        {
            get { return nudMaxBurst; }
        }

        public NumericUpDown NudMinAddr
        {
            get { return nudMinAddr; }
        }

        public NumericUpDown NudMaxAddr
        {
            get { return nudMaxAddr; }
        }

        public ComboBox CbRamSize
        {
            get { return cbRamSize; }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            sessionPreparation();
            viewDetailed.ReactToUserActions(ModelOperations.SaveSettings);
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            viewDetailed.ReactToUserActions(ModelOperations.WorkingCycle);
        }

        private void btnSessionEnd_Click(object sender, EventArgs e)
        {
            viewDetailed.ReactToUserActions(ModelOperations.EndOfSession);
            endOfSession();
            UpdateSettings();
        }

        private void sessionPreparation()
        {
            btnStart.Enabled = false;
            btnSessionEnd.Enabled = true;
            btnWork.Enabled = rbManual.Checked;
            nudIntensity.Enabled = false;
            nudMinBurst.Enabled = false;
            nudMaxBurst.Enabled = false;
            nudMinAddr.Enabled = false;
            nudMaxAddr.Enabled = false;
            cbRamSize.Enabled = false;

            if (rbAuto.Checked)
            {
                timer1.Start();
            }
        }

        private void endOfSession()
        {
            timer1.Stop();
            btnStart.Enabled = true;
            btnSessionEnd.Enabled = false;
            btnWork.Enabled = false;
            nudIntensity.Enabled = true;
            nudMinBurst.Enabled = true;
            nudMaxBurst.Enabled = true;
            nudMinAddr.Enabled = true;
            nudMaxAddr.Enabled = true;
            cbRamSize.Enabled = true;
        }

        private void rbMode_CheckedChanged(object sender, EventArgs e)
        {
            if (!btnStart.Enabled)
            {
                if (rbAuto.Checked)
                {
                    btnWork.Enabled = false;
                    timer1.Start();
                }
                else
                {
                    timer1.Stop();
                    btnWork.Enabled = true;
                }
            }
        }

        private void UpdateSettings()
        {
            nudIntensity.DataBindings[0].WriteValue();
            nudMinBurst.DataBindings[0].WriteValue();
            nudMaxBurst.DataBindings[0].WriteValue();
            nudMinAddr.DataBindings[0].WriteValue();
            nudMaxAddr.DataBindings[0].WriteValue();
            cbRamSize.DataBindings[0].WriteValue();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            viewDetailed.ReactToUserActions(ModelOperations.WorkingCycle);
        }
    }
}