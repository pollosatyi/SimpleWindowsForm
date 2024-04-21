namespace SimpleForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            nudResolution = new NumericUpDown();
            nudDensity = new NumericUpDown();
            label2 = new Label();
            bStart = new Button();
            bStop = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudResolution).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDensity).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.FixedPanel = FixedPanel.Panel1;
            splitContainer1.IsSplitterFixed = true;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(bStop);
            splitContainer1.Panel1.Controls.Add(bStart);
            splitContainer1.Panel1.Controls.Add(nudDensity);
            splitContainer1.Panel1.Controls.Add(label2);
            splitContainer1.Panel1.Controls.Add(nudResolution);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Size = new Size(800, 450);
            splitContainer1.SplitterDistance = 138;
            splitContainer1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(654, 446);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(9, 13);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 0;
            label1.Text = "Resolution";
            // 
            // nudResolution
            // 
            nudResolution.Location = new Point(9, 41);
            nudResolution.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            nudResolution.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudResolution.Name = "nudResolution";
            nudResolution.Size = new Size(120, 23);
            nudResolution.TabIndex = 2;
            nudResolution.TextAlign = HorizontalAlignment.Right;
            nudResolution.Value = new decimal(new int[] { 3, 0, 0, 0 });
            // 
            // nudDensity
            // 
            nudDensity.Location = new Point(10, 108);
            nudDensity.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudDensity.Name = "nudDensity";
            nudDensity.Size = new Size(120, 23);
            nudDensity.TabIndex = 4;
            nudDensity.TextAlign = HorizontalAlignment.Right;
            nudDensity.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(10, 80);
            label2.Name = "label2";
            label2.Size = new Size(62, 20);
            label2.TabIndex = 3;
            label2.Text = "Density";
            label2.Click += label2_Click;
            // 
            // bStart
            // 
            bStart.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            bStart.Location = new Point(11, 144);
            bStart.Name = "bStart";
            bStart.Size = new Size(116, 52);
            bStart.TabIndex = 5;
            bStart.Text = "Start";
            bStart.UseVisualStyleBackColor = true;
            bStart.Click += bStart_Click;
            // 
            // bStop
            // 
            bStop.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            bStop.Location = new Point(11, 202);
            bStop.Name = "bStop";
            bStop.Size = new Size(116, 46);
            bStop.TabIndex = 6;
            bStop.Text = "Stop";
            bStop.UseVisualStyleBackColor = true;
            bStop.Click += bStop_Click;
            // 
            // timer1
            // 
            timer1.Interval = 40;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudResolution).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDensity).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private PictureBox pictureBox1;
        private NumericUpDown nudResolution;
        private Label label1;
        private NumericUpDown nudDensity;
        private Label label2;
        private Button bStop;
        private Button bStart;
        private System.Windows.Forms.Timer timer1;
    }
}
