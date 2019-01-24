namespace ChristopherPotvin
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.lblPowerUsed = new System.Windows.Forms.Label();
            this.txtPower = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblPeak = new System.Windows.Forms.Label();
            this.txtPeak = new System.Windows.Forms.TextBox();
            this.lblOff = new System.Windows.Forms.Label();
            this.txtOff = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "\"Power R Us\"";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(493, 73);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(84, 16);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Type of User :";
            // 
            // cmbUser
            // 
            this.cmbUser.BackColor = System.Drawing.Color.White;
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Items.AddRange(new object[] {
            "Residential",
            "Commercial",
            "Industrial"});
            this.cmbUser.Location = new System.Drawing.Point(587, 71);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(121, 21);
            this.cmbUser.TabIndex = 2;
            this.cmbUser.SelectedIndexChanged += new System.EventHandler(this.cmbUser_SelectedIndexChanged);
            // 
            // lblPowerUsed
            // 
            this.lblPowerUsed.AutoSize = true;
            this.lblPowerUsed.BackColor = System.Drawing.Color.Transparent;
            this.lblPowerUsed.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerUsed.Location = new System.Drawing.Point(464, 126);
            this.lblPowerUsed.Name = "lblPowerUsed";
            this.lblPowerUsed.Size = new System.Drawing.Size(117, 16);
            this.lblPowerUsed.TabIndex = 3;
            this.lblPowerUsed.Text = "Power Used (kWh) :";
            // 
            // txtPower
            // 
            this.txtPower.BackColor = System.Drawing.Color.White;
            this.txtPower.Location = new System.Drawing.Point(587, 125);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(121, 20);
            this.txtPower.TabIndex = 4;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(517, 255);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 16);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Cost ($) : ";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.White;
            this.txtAmount.Location = new System.Drawing.Point(587, 254);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(121, 20);
            this.txtAmount.TabIndex = 6;
            // 
            // lblPeak
            // 
            this.lblPeak.AutoSize = true;
            this.lblPeak.BackColor = System.Drawing.Color.Transparent;
            this.lblPeak.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeak.Location = new System.Drawing.Point(395, 167);
            this.lblPeak.Name = "lblPeak";
            this.lblPeak.Size = new System.Drawing.Size(187, 16);
            this.lblPeak.TabIndex = 7;
            this.lblPeak.Text = "Power Used during Peak (kWh) :";
            // 
            // txtPeak
            // 
            this.txtPeak.BackColor = System.Drawing.Color.White;
            this.txtPeak.Location = new System.Drawing.Point(587, 169);
            this.txtPeak.Name = "txtPeak";
            this.txtPeak.Size = new System.Drawing.Size(121, 20);
            this.txtPeak.TabIndex = 8;
            // 
            // lblOff
            // 
            this.lblOff.AutoSize = true;
            this.lblOff.BackColor = System.Drawing.Color.Transparent;
            this.lblOff.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOff.Location = new System.Drawing.Point(374, 209);
            this.lblOff.Name = "lblOff";
            this.lblOff.Size = new System.Drawing.Size(208, 16);
            this.lblOff.TabIndex = 9;
            this.lblOff.Text = "Power Used during Off-Peak (kWh) :";
            // 
            // txtOff
            // 
            this.txtOff.BackColor = System.Drawing.Color.White;
            this.txtOff.Location = new System.Drawing.Point(587, 211);
            this.txtOff.Name = "txtOff";
            this.txtOff.Size = new System.Drawing.Size(121, 20);
            this.txtOff.TabIndex = 10;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(557, 299);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(77, 33);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(654, 299);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 33);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(687, 387);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(69, 24);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(768, 423);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtOff);
            this.Controls.Add(this.lblOff);
            this.Controls.Add(this.txtPeak);
            this.Controls.Add(this.lblPeak);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.txtPower);
            this.Controls.Add(this.lblPowerUsed);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblPowerUsed;
        private System.Windows.Forms.TextBox txtPower;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblPeak;
        private System.Windows.Forms.TextBox txtPeak;
        private System.Windows.Forms.Label lblOff;
        private System.Windows.Forms.TextBox txtOff;
        private System.Windows.Forms.Button btnCalculate;
        public System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

