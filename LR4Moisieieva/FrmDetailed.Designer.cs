namespace LR4Moisieieva
{
    partial class FrmDetailed
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            mainLayout = new TableLayoutPanel();
            leftLayout = new TableLayoutPanel();
            label1 = new Label();
            lblTime = new Label();
            label2 = new Label();
            tbCPU = new TextBox();
            label3 = new Label();
            tbDevice = new TextBox();
            label4 = new Label();
            lblFreeMem = new Label();
            label5 = new Label();
            lblOccupiedMem = new Label();
            label6 = new Label();
            label7 = new Label();
            lbCPUQueue = new ListBox();
            lbDeviceQueue = new ListBox();
            rightLayout = new TableLayoutPanel();
            label8 = new Label();
            nudIntensity = new NumericUpDown();
            label9 = new Label();
            nudMinBurst = new NumericUpDown();
            label10 = new Label();
            nudMaxBurst = new NumericUpDown();
            label11 = new Label();
            nudMinAddr = new NumericUpDown();
            label12 = new Label();
            nudMaxAddr = new NumericUpDown();
            label13 = new Label();
            cbRamSize = new ComboBox();
            rbManual = new RadioButton();
            rbAuto = new RadioButton();
            btnStart = new Button();
            btnWork = new Button();
            btnSessionEnd = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            mainLayout.SuspendLayout();
            leftLayout.SuspendLayout();
            rightLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudIntensity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinBurst).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxBurst).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinAddr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxAddr).BeginInit();
            SuspendLayout();
            // 
            // mainLayout
            // 
            mainLayout.ColumnCount = 2;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainLayout.Controls.Add(leftLayout, 0, 0);
            mainLayout.Controls.Add(rightLayout, 1, 0);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(12);
            mainLayout.RowCount = 1;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(700, 380);
            mainLayout.TabIndex = 0;
            // 
            // leftLayout
            // 
            leftLayout.ColumnCount = 2;
            leftLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            leftLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            leftLayout.Controls.Add(label1, 0, 0);
            leftLayout.Controls.Add(lblTime, 1, 0);
            leftLayout.Controls.Add(label2, 0, 1);
            leftLayout.Controls.Add(tbCPU, 1, 1);
            leftLayout.Controls.Add(label3, 0, 2);
            leftLayout.Controls.Add(tbDevice, 1, 2);
            leftLayout.Controls.Add(label4, 0, 3);
            leftLayout.Controls.Add(lblFreeMem, 1, 3);
            leftLayout.Controls.Add(label5, 0, 4);
            leftLayout.Controls.Add(lblOccupiedMem, 1, 4);
            leftLayout.Controls.Add(label6, 0, 5);
            leftLayout.Controls.Add(label7, 1, 5);
            leftLayout.Controls.Add(lbCPUQueue, 0, 6);
            leftLayout.Controls.Add(lbDeviceQueue, 1, 6);
            leftLayout.Dock = DockStyle.Fill;
            leftLayout.Location = new Point(15, 15);
            leftLayout.Name = "leftLayout";
            leftLayout.Padding = new Padding(0, 0, 10, 0);
            leftLayout.RowCount = 7;
            leftLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            leftLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            leftLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            leftLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            leftLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            leftLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 8F));
            leftLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 42F));
            leftLayout.Size = new Size(332, 350);
            leftLayout.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(155, 35);
            label1.TabIndex = 0;
            label1.Text = "Такт:";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTime
            // 
            lblTime.Dock = DockStyle.Fill;
            lblTime.Location = new Point(164, 0);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(155, 35);
            lblTime.TabIndex = 1;
            lblTime.Text = "0";
            lblTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 35);
            label2.Name = "label2";
            label2.Size = new Size(155, 35);
            label2.TabIndex = 2;
            label2.Text = "ЦП:";
            label2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbCPU
            // 
            tbCPU.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbCPU.Location = new Point(164, 39);
            tbCPU.Name = "tbCPU";
            tbCPU.ReadOnly = true;
            tbCPU.Size = new Size(155, 27);
            tbCPU.TabIndex = 3;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 70);
            label3.Name = "label3";
            label3.Size = new Size(155, 35);
            label3.TabIndex = 4;
            label3.Text = "Пристрій:";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbDevice
            // 
            tbDevice.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tbDevice.Location = new Point(164, 74);
            tbDevice.Name = "tbDevice";
            tbDevice.ReadOnly = true;
            tbDevice.Size = new Size(155, 27);
            tbDevice.TabIndex = 5;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 105);
            label4.Name = "label4";
            label4.Size = new Size(155, 35);
            label4.TabIndex = 6;
            label4.Text = "Вільно ОП:";
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFreeMem
            // 
            lblFreeMem.Dock = DockStyle.Fill;
            lblFreeMem.Location = new Point(164, 105);
            lblFreeMem.Name = "lblFreeMem";
            lblFreeMem.Size = new Size(155, 35);
            lblFreeMem.TabIndex = 7;
            lblFreeMem.Text = "0";
            lblFreeMem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(3, 140);
            label5.Name = "label5";
            label5.Size = new Size(155, 35);
            label5.TabIndex = 8;
            label5.Text = "Зайнято ОП:";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblOccupiedMem
            // 
            lblOccupiedMem.Dock = DockStyle.Fill;
            lblOccupiedMem.Location = new Point(164, 140);
            lblOccupiedMem.Name = "lblOccupiedMem";
            lblOccupiedMem.Size = new Size(155, 35);
            lblOccupiedMem.TabIndex = 9;
            lblOccupiedMem.Text = "0";
            lblOccupiedMem.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(3, 175);
            label6.Name = "label6";
            label6.Size = new Size(155, 28);
            label6.TabIndex = 10;
            label6.Text = "Черга ЦП:";
            label6.TextAlign = ContentAlignment.BottomLeft;
            // 
            // label7
            // 
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(164, 175);
            label7.Name = "label7";
            label7.Size = new Size(155, 28);
            label7.TabIndex = 11;
            label7.Text = "Черга пристрою:";
            label7.TextAlign = ContentAlignment.BottomLeft;
            // 
            // lbCPUQueue
            // 
            lbCPUQueue.Dock = DockStyle.Fill;
            lbCPUQueue.IntegralHeight = false;
            lbCPUQueue.Location = new Point(3, 206);
            lbCPUQueue.Name = "lbCPUQueue";
            lbCPUQueue.Size = new Size(155, 141);
            lbCPUQueue.TabIndex = 12;
            // 
            // lbDeviceQueue
            // 
            lbDeviceQueue.Dock = DockStyle.Fill;
            lbDeviceQueue.IntegralHeight = false;
            lbDeviceQueue.Location = new Point(164, 206);
            lbDeviceQueue.Name = "lbDeviceQueue";
            lbDeviceQueue.Size = new Size(155, 141);
            lbDeviceQueue.TabIndex = 13;
            // 
            // rightLayout
            // 
            rightLayout.ColumnCount = 2;
            rightLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            rightLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            rightLayout.Controls.Add(label8, 0, 0);
            rightLayout.Controls.Add(nudIntensity, 1, 0);
            rightLayout.Controls.Add(label9, 0, 1);
            rightLayout.Controls.Add(nudMinBurst, 1, 1);
            rightLayout.Controls.Add(label10, 0, 2);
            rightLayout.Controls.Add(nudMaxBurst, 1, 2);
            rightLayout.Controls.Add(label11, 0, 3);
            rightLayout.Controls.Add(nudMinAddr, 1, 3);
            rightLayout.Controls.Add(label12, 0, 4);
            rightLayout.Controls.Add(nudMaxAddr, 1, 4);
            rightLayout.Controls.Add(label13, 0, 5);
            rightLayout.Controls.Add(cbRamSize, 1, 5);
            rightLayout.Controls.Add(rbManual, 0, 6);
            rightLayout.Controls.Add(rbAuto, 1, 6);
            rightLayout.Controls.Add(btnStart, 0, 7);
            rightLayout.Controls.Add(btnWork, 0, 8);
            rightLayout.Controls.Add(btnSessionEnd, 0, 9);
            rightLayout.Dock = DockStyle.Fill;
            rightLayout.Location = new Point(353, 15);
            rightLayout.Name = "rightLayout";
            rightLayout.Padding = new Padding(10, 0, 0, 0);
            rightLayout.RowCount = 10;
            rightLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 9.5F));
            rightLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 9.5F));
            rightLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 9.5F));
            rightLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 9.5F));
            rightLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 9.5F));
            rightLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 9.5F));
            rightLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            rightLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            rightLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            rightLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 11F));
            rightLayout.Size = new Size(332, 350);
            rightLayout.TabIndex = 1;
            // 
            // label8
            // 
            label8.Dock = DockStyle.Fill;
            label8.Location = new Point(13, 0);
            label8.Name = "label8";
            label8.Size = new Size(155, 33);
            label8.TabIndex = 0;
            label8.Text = "Інтенсивність:";
            label8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudIntensity
            // 
            nudIntensity.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nudIntensity.DecimalPlaces = 2;
            nudIntensity.Increment = new decimal(new int[] { 1, 0, 0, 65536 });
            nudIntensity.Location = new Point(174, 3);
            nudIntensity.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nudIntensity.Name = "nudIntensity";
            nudIntensity.Size = new Size(155, 27);
            nudIntensity.TabIndex = 1;
            nudIntensity.Value = new decimal(new int[] { 5, 0, 0, 65536 });
            // 
            // label9
            // 
            label9.Dock = DockStyle.Fill;
            label9.Location = new Point(13, 33);
            label9.Name = "label9";
            label9.Size = new Size(155, 33);
            label9.TabIndex = 2;
            label9.Text = "Мін. інтервал:";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudMinBurst
            // 
            nudMinBurst.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nudMinBurst.Location = new Point(174, 36);
            nudMinBurst.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMinBurst.Name = "nudMinBurst";
            nudMinBurst.Size = new Size(155, 27);
            nudMinBurst.TabIndex = 3;
            nudMinBurst.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label10
            // 
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(13, 66);
            label10.Name = "label10";
            label10.Size = new Size(155, 33);
            label10.TabIndex = 4;
            label10.Text = "Макс. інтервал:";
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudMaxBurst
            // 
            nudMaxBurst.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nudMaxBurst.Location = new Point(174, 69);
            nudMaxBurst.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMaxBurst.Name = "nudMaxBurst";
            nudMaxBurst.Size = new Size(155, 27);
            nudMaxBurst.TabIndex = 5;
            nudMaxBurst.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label11
            // 
            label11.Dock = DockStyle.Fill;
            label11.Location = new Point(13, 99);
            label11.Name = "label11";
            label11.Size = new Size(155, 33);
            label11.TabIndex = 6;
            label11.Text = "Мін. адр. простір:";
            label11.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudMinAddr
            // 
            nudMinAddr.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nudMinAddr.Location = new Point(174, 102);
            nudMinAddr.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudMinAddr.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMinAddr.Name = "nudMinAddr";
            nudMinAddr.Size = new Size(155, 27);
            nudMinAddr.TabIndex = 7;
            nudMinAddr.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label12
            // 
            label12.Dock = DockStyle.Fill;
            label12.Location = new Point(13, 132);
            label12.Name = "label12";
            label12.Size = new Size(155, 33);
            label12.TabIndex = 8;
            label12.Text = "Макс. адр. простір:";
            label12.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // nudMaxAddr
            // 
            nudMaxAddr.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            nudMaxAddr.Location = new Point(174, 135);
            nudMaxAddr.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudMaxAddr.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudMaxAddr.Name = "nudMaxAddr";
            nudMaxAddr.Size = new Size(155, 27);
            nudMaxAddr.TabIndex = 9;
            nudMaxAddr.Value = new decimal(new int[] { 100, 0, 0, 0 });
            // 
            // label13
            // 
            label13.Dock = DockStyle.Fill;
            label13.Location = new Point(13, 165);
            label13.Name = "label13";
            label13.Size = new Size(155, 33);
            label13.TabIndex = 10;
            label13.Text = "Розмір ОП:";
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbRamSize
            // 
            cbRamSize.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbRamSize.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRamSize.Items.AddRange(new object[] { 1024, 2048, 4096, 8192 });
            cbRamSize.Location = new Point(174, 168);
            cbRamSize.Name = "cbRamSize";
            cbRamSize.Size = new Size(155, 28);
            cbRamSize.TabIndex = 11;
            // 
            // rbManual
            // 
            rbManual.Checked = true;
            rbManual.Dock = DockStyle.Fill;
            rbManual.Location = new Point(13, 201);
            rbManual.Name = "rbManual";
            rbManual.Size = new Size(155, 29);
            rbManual.TabIndex = 12;
            rbManual.TabStop = true;
            rbManual.Text = "Ручний режим";
            rbManual.CheckedChanged += rbMode_CheckedChanged;
            // 
            // rbAuto
            // 
            rbAuto.Dock = DockStyle.Fill;
            rbAuto.Location = new Point(174, 201);
            rbAuto.Name = "rbAuto";
            rbAuto.Size = new Size(155, 29);
            rbAuto.TabIndex = 13;
            rbAuto.Text = "Автоматичний режим";
            rbAuto.CheckedChanged += rbMode_CheckedChanged;
            // 
            // btnStart
            // 
            rightLayout.SetColumnSpan(btnStart, 2);
            btnStart.Dock = DockStyle.Fill;
            btnStart.Location = new Point(13, 236);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(316, 32);
            btnStart.TabIndex = 14;
            btnStart.Text = "Збереження налаштувань";
            btnStart.Click += btnStart_Click;
            // 
            // btnWork
            // 
            rightLayout.SetColumnSpan(btnWork, 2);
            btnWork.Dock = DockStyle.Fill;
            btnWork.Enabled = false;
            btnWork.Location = new Point(13, 274);
            btnWork.Name = "btnWork";
            btnWork.Size = new Size(316, 32);
            btnWork.TabIndex = 15;
            btnWork.Text = "Робочий такт";
            btnWork.Click += btnWork_Click;
            // 
            // btnSessionEnd
            // 
            rightLayout.SetColumnSpan(btnSessionEnd, 2);
            btnSessionEnd.Dock = DockStyle.Fill;
            btnSessionEnd.Enabled = false;
            btnSessionEnd.Location = new Point(13, 312);
            btnSessionEnd.Name = "btnSessionEnd";
            btnSessionEnd.Size = new Size(316, 35);
            btnSessionEnd.TabIndex = 16;
            btnSessionEnd.Text = "Завершення сеансу";
            btnSessionEnd.Click += btnSessionEnd_Click;
            // 
            // timer1
            // 
            timer1.Interval = 500;
            timer1.Tick += timer1_Tick;
            // 
            // FrmDetailed
            // 
            ClientSize = new Size(700, 380);
            Controls.Add(mainLayout);
            MinimumSize = new Size(650, 350);
            Name = "FrmDetailed";
            Text = "LR4Moisieieva";
            mainLayout.ResumeLayout(false);
            leftLayout.ResumeLayout(false);
            leftLayout.PerformLayout();
            rightLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nudIntensity).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinBurst).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxBurst).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinAddr).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMaxAddr).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.TableLayoutPanel mainLayout;
        private System.Windows.Forms.TableLayoutPanel leftLayout;
        private System.Windows.Forms.TableLayoutPanel rightLayout;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox tbCPU;
        private System.Windows.Forms.TextBox tbDevice;
        private System.Windows.Forms.Label lblFreeMem;
        private System.Windows.Forms.Label lblOccupiedMem;
        private System.Windows.Forms.ListBox lbCPUQueue;
        private System.Windows.Forms.ListBox lbDeviceQueue;
        private System.Windows.Forms.NumericUpDown nudIntensity;
        private System.Windows.Forms.NumericUpDown nudMinBurst;
        private System.Windows.Forms.NumericUpDown nudMaxBurst;
        private System.Windows.Forms.NumericUpDown nudMinAddr;
        private System.Windows.Forms.NumericUpDown nudMaxAddr;
        private System.Windows.Forms.ComboBox cbRamSize;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.Button btnSessionEnd;
        private System.Windows.Forms.RadioButton rbManual;
        private System.Windows.Forms.RadioButton rbAuto;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}