namespace kalkulator_ip
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
            this.IPBox = new System.Windows.Forms.MaskedTextBox();
            this.A = new System.Windows.Forms.Label();
            this.MaskaTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.networkAddressTextBox = new System.Windows.Forms.MaskedTextBox();
            this.AdresSieci = new System.Windows.Forms.Label();
            this.BroadcastTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ipOktet1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.ipOktet2 = new System.Windows.Forms.NumericUpDown();
            this.ipOktet3 = new System.Windows.Forms.NumericUpDown();
            this.ipOktet4 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.cidrText = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ipOktet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOktet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOktet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOktet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidrText)).BeginInit();
            this.SuspendLayout();
            // 
            // IPBox
            // 
            this.IPBox.Location = new System.Drawing.Point(156, 190);
            this.IPBox.Mask = "###\\.###\\.###\\.###";
            this.IPBox.Name = "IPBox";
            this.IPBox.Size = new System.Drawing.Size(87, 23);
            this.IPBox.TabIndex = 0;
            this.IPBox.Text = "255255255255";
            // 
            // A
            // 
            this.A.AutoSize = true;
            this.A.Location = new System.Drawing.Point(100, 198);
            this.A.Name = "A";
            this.A.Size = new System.Drawing.Size(50, 15);
            this.A.TabIndex = 1;
            this.A.Text = "AdresIP:";
            this.A.Click += new System.EventHandler(this.label1_Click);
            // 
            // MaskaTextBox
            // 
            this.MaskaTextBox.Location = new System.Drawing.Point(156, 217);
            this.MaskaTextBox.Mask = "###\\.###\\.###\\.###";
            this.MaskaTextBox.Name = "MaskaTextBox";
            this.MaskaTextBox.Size = new System.Drawing.Size(87, 23);
            this.MaskaTextBox.TabIndex = 0;
            this.MaskaTextBox.Text = "255255255255";
            this.MaskaTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Maska:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(249, 181);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(113, 125);
            this.CalculateButton.TabIndex = 2;
            this.CalculateButton.Text = "Przekalkuluj";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateIP);
            // 
            // networkAddressTextBox
            // 
            this.networkAddressTextBox.Location = new System.Drawing.Point(156, 246);
            this.networkAddressTextBox.Mask = "###\\.###\\.###\\.###";
            this.networkAddressTextBox.Name = "networkAddressTextBox";
            this.networkAddressTextBox.ReadOnly = true;
            this.networkAddressTextBox.Size = new System.Drawing.Size(87, 23);
            this.networkAddressTextBox.TabIndex = 0;
            this.networkAddressTextBox.Text = "055055055055";
            this.networkAddressTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // AdresSieci
            // 
            this.AdresSieci.AutoSize = true;
            this.AdresSieci.Location = new System.Drawing.Point(86, 249);
            this.AdresSieci.Name = "AdresSieci";
            this.AdresSieci.Size = new System.Drawing.Size(64, 15);
            this.AdresSieci.TabIndex = 1;
            this.AdresSieci.Text = "AdresSieci:";
            this.AdresSieci.Click += new System.EventHandler(this.label1_Click);
            // 
            // BroadcastTextBox
            // 
            this.BroadcastTextBox.Location = new System.Drawing.Point(156, 273);
            this.BroadcastTextBox.Mask = "###\\.###\\.###\\.###";
            this.BroadcastTextBox.Name = "BroadcastTextBox";
            this.BroadcastTextBox.ReadOnly = true;
            this.BroadcastTextBox.Size = new System.Drawing.Size(87, 23);
            this.BroadcastTextBox.TabIndex = 0;
            this.BroadcastTextBox.Text = "055055055055";
            this.BroadcastTextBox.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Adres rozgloszeniowy:";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // ipOktet1
            // 
            this.ipOktet1.Location = new System.Drawing.Point(68, 16);
            this.ipOktet1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ipOktet1.Name = "ipOktet1";
            this.ipOktet1.Size = new System.Drawing.Size(56, 23);
            this.ipOktet1.TabIndex = 3;
            this.ipOktet1.Value = new decimal(new int[] {
            225,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "AdresIP:";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // ipOktet2
            // 
            this.ipOktet2.Location = new System.Drawing.Point(130, 16);
            this.ipOktet2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ipOktet2.Name = "ipOktet2";
            this.ipOktet2.Size = new System.Drawing.Size(56, 23);
            this.ipOktet2.TabIndex = 3;
            this.ipOktet2.Value = new decimal(new int[] {
            225,
            0,
            0,
            0});
            // 
            // ipOktet3
            // 
            this.ipOktet3.Location = new System.Drawing.Point(192, 16);
            this.ipOktet3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ipOktet3.Name = "ipOktet3";
            this.ipOktet3.Size = new System.Drawing.Size(56, 23);
            this.ipOktet3.TabIndex = 3;
            this.ipOktet3.Value = new decimal(new int[] {
            225,
            0,
            0,
            0});
            // 
            // ipOktet4
            // 
            this.ipOktet4.Location = new System.Drawing.Point(254, 16);
            this.ipOktet4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ipOktet4.Name = "ipOktet4";
            this.ipOktet4.Size = new System.Drawing.Size(56, 23);
            this.ipOktet4.TabIndex = 3;
            this.ipOktet4.Value = new decimal(new int[] {
            225,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Maska:";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // cidrText
            // 
            this.cidrText.Location = new System.Drawing.Point(68, 42);
            this.cidrText.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.cidrText.Name = "cidrText";
            this.cidrText.Size = new System.Drawing.Size(56, 23);
            this.cidrText.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(44, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 314);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cidrText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ipOktet4);
            this.Controls.Add(this.ipOktet3);
            this.Controls.Add(this.ipOktet2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ipOktet1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BroadcastTextBox);
            this.Controls.Add(this.AdresSieci);
            this.Controls.Add(this.networkAddressTextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MaskaTextBox);
            this.Controls.Add(this.A);
            this.Controls.Add(this.IPBox);
            this.Name = "Form1";
            this.Text = "!";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ipOktet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOktet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOktet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipOktet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidrText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox IPBox;
        private System.Windows.Forms.Label A;
        private System.Windows.Forms.MaskedTextBox MaskaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.MaskedTextBox networkAddressTextBox;
        private System.Windows.Forms.Label AdresSieci;
        private System.Windows.Forms.MaskedTextBox BroadcastTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown ipOctet1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown ipOktet1;
        private System.Windows.Forms.NumericUpDown ipOktet2;
        private System.Windows.Forms.NumericUpDown ipOktet3;
        private System.Windows.Forms.NumericUpDown ipOktet4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown cidrText;
        private System.Windows.Forms.Button button1;
    }
}

