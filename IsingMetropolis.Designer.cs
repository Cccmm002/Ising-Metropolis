namespace IsingMetropolis
{
    partial class IsingMetropolis
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picDraw = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            this.cmdInit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numJ = new System.Windows.Forms.NumericUpDown();
            this.numT = new System.Windows.Forms.NumericUpDown();
            this.numM = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numInterval = new System.Windows.Forms.NumericUpDown();
            this.numWidth = new System.Windows.Forms.ComboBox();
            this.numHeight = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numJ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // picDraw
            // 
            this.picDraw.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picDraw.Location = new System.Drawing.Point(12, 12);
            this.picDraw.Name = "picDraw";
            this.picDraw.Size = new System.Drawing.Size(512, 512);
            this.picDraw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picDraw.TabIndex = 0;
            this.picDraw.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numHeight);
            this.groupBox1.Controls.Add(this.numWidth);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numM);
            this.groupBox1.Controls.Add(this.numT);
            this.groupBox1.Controls.Add(this.numJ);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 530);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(512, 142);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numInterval);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmdStop);
            this.groupBox2.Controls.Add(this.cmdStart);
            this.groupBox2.Location = new System.Drawing.Point(12, 678);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(431, 50);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drawing Control";
            // 
            // cmdStart
            // 
            this.cmdStart.Enabled = false;
            this.cmdStart.Location = new System.Drawing.Point(6, 19);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(75, 23);
            this.cmdStart.TabIndex = 0;
            this.cmdStart.Text = "&Start";
            this.cmdStart.UseVisualStyleBackColor = true;
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdStop
            // 
            this.cmdStop.Enabled = false;
            this.cmdStop.Location = new System.Drawing.Point(88, 19);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.Size = new System.Drawing.Size(75, 23);
            this.cmdStop.TabIndex = 1;
            this.cmdStop.Text = "St&op";
            this.cmdStop.UseVisualStyleBackColor = true;
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // cmdInit
            // 
            this.cmdInit.Location = new System.Drawing.Point(449, 697);
            this.cmdInit.Name = "cmdInit";
            this.cmdInit.Size = new System.Drawing.Size(75, 23);
            this.cmdInit.TabIndex = 3;
            this.cmdInit.Text = "&Initialize";
            this.cmdInit.UseVisualStyleBackColor = true;
            this.cmdInit.Click += new System.EventHandler(this.cmdInit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coupling Constant(&J) Value:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "&Temperature:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "External &Magnetic Field:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "&Width:";
            // 
            // numJ
            // 
            this.numJ.DecimalPlaces = 2;
            this.numJ.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numJ.Location = new System.Drawing.Point(150, 18);
            this.numJ.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numJ.Name = "numJ";
            this.numJ.Size = new System.Drawing.Size(120, 20);
            this.numJ.TabIndex = 4;
            this.numJ.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // numT
            // 
            this.numT.DecimalPlaces = 1;
            this.numT.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numT.Location = new System.Drawing.Point(150, 45);
            this.numT.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numT.Name = "numT";
            this.numT.Size = new System.Drawing.Size(120, 20);
            this.numT.TabIndex = 5;
            this.numT.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numM
            // 
            this.numM.DecimalPlaces = 1;
            this.numM.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numM.Location = new System.Drawing.Point(150, 72);
            this.numM.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numM.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            this.numM.Name = "numM";
            this.numM.Size = new System.Drawing.Size(120, 20);
            this.numM.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(132, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "&Height:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(169, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Steps each Se&cond:";
            // 
            // numInterval
            // 
            this.numInterval.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numInterval.Location = new System.Drawing.Point(279, 22);
            this.numInterval.Maximum = new decimal(new int[] {
            9900000,
            0,
            0,
            0});
            this.numInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numInterval.Name = "numInterval";
            this.numInterval.Size = new System.Drawing.Size(121, 20);
            this.numInterval.TabIndex = 3;
            this.numInterval.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numInterval.ValueChanged += new System.EventHandler(this.numInterval_ValueChanged);
            // 
            // numWidth
            // 
            this.numWidth.FormattingEnabled = true;
            this.numWidth.Items.AddRange(new object[] {
            "32",
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048"});
            this.numWidth.Location = new System.Drawing.Point(51, 98);
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(75, 21);
            this.numWidth.TabIndex = 10;
            this.numWidth.Text = "128";
            // 
            // numHeight
            // 
            this.numHeight.FormattingEnabled = true;
            this.numHeight.Items.AddRange(new object[] {
            "32",
            "64",
            "128",
            "256",
            "512",
            "1024",
            "2048"});
            this.numHeight.Location = new System.Drawing.Point(179, 98);
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(75, 21);
            this.numHeight.TabIndex = 11;
            this.numHeight.Text = "128";
            // 
            // IsingMetropolis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 735);
            this.Controls.Add(this.cmdInit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picDraw);
            this.MaximizeBox = false;
            this.Name = "IsingMetropolis";
            this.Text = "Metropolis Method for Ising Model";
            this.Load += new System.EventHandler(this.IsingMetropolis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDraw)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numJ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picDraw;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Button cmdInit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numM;
        private System.Windows.Forms.NumericUpDown numT;
        private System.Windows.Forms.NumericUpDown numJ;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numInterval;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox numHeight;
        private System.Windows.Forms.ComboBox numWidth;
    }
}

