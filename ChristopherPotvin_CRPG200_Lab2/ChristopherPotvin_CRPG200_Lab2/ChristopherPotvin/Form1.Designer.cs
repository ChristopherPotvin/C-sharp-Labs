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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAcctNum = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblAcctNumber = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNumCust = new System.Windows.Forms.TextBox();
            this.txtSumRes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSumComm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSumInd = new System.Windows.Forms.TextBox();
            this.lstCustomerData = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 9);
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
            this.lblUser.Location = new System.Drawing.Point(129, 30);
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
            this.cmbUser.Location = new System.Drawing.Point(223, 28);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(121, 24);
            this.cmbUser.TabIndex = 2;
            this.cmbUser.SelectedIndexChanged += new System.EventHandler(this.cmbUser_SelectedIndexChanged);
            // 
            // lblPowerUsed
            // 
            this.lblPowerUsed.AutoSize = true;
            this.lblPowerUsed.BackColor = System.Drawing.Color.Transparent;
            this.lblPowerUsed.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPowerUsed.Location = new System.Drawing.Point(100, 159);
            this.lblPowerUsed.Name = "lblPowerUsed";
            this.lblPowerUsed.Size = new System.Drawing.Size(117, 16);
            this.lblPowerUsed.TabIndex = 3;
            this.lblPowerUsed.Text = "Power Used (kWh) :";
            // 
            // txtPower
            // 
            this.txtPower.BackColor = System.Drawing.Color.White;
            this.txtPower.Location = new System.Drawing.Point(223, 158);
            this.txtPower.Name = "txtPower";
            this.txtPower.Size = new System.Drawing.Size(121, 23);
            this.txtPower.TabIndex = 4;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.BackColor = System.Drawing.Color.Transparent;
            this.lblAmount.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(153, 288);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(65, 16);
            this.lblAmount.TabIndex = 5;
            this.lblAmount.Text = "Cost ($) : ";
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.Color.White;
            this.txtAmount.Enabled = false;
            this.txtAmount.Location = new System.Drawing.Point(223, 287);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(121, 23);
            this.txtAmount.TabIndex = 6;
            // 
            // lblPeak
            // 
            this.lblPeak.AutoSize = true;
            this.lblPeak.BackColor = System.Drawing.Color.Transparent;
            this.lblPeak.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeak.Location = new System.Drawing.Point(31, 200);
            this.lblPeak.Name = "lblPeak";
            this.lblPeak.Size = new System.Drawing.Size(187, 16);
            this.lblPeak.TabIndex = 7;
            this.lblPeak.Text = "Power Used during Peak (kWh) :";
            // 
            // txtPeak
            // 
            this.txtPeak.BackColor = System.Drawing.Color.White;
            this.txtPeak.Location = new System.Drawing.Point(223, 202);
            this.txtPeak.Name = "txtPeak";
            this.txtPeak.Size = new System.Drawing.Size(121, 23);
            this.txtPeak.TabIndex = 8;
            // 
            // lblOff
            // 
            this.lblOff.AutoSize = true;
            this.lblOff.BackColor = System.Drawing.Color.Transparent;
            this.lblOff.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOff.Location = new System.Drawing.Point(10, 242);
            this.lblOff.Name = "lblOff";
            this.lblOff.Size = new System.Drawing.Size(208, 16);
            this.lblOff.TabIndex = 9;
            this.lblOff.Text = "Power Used during Off-Peak (kWh) :";
            // 
            // txtOff
            // 
            this.txtOff.BackColor = System.Drawing.Color.White;
            this.txtOff.Location = new System.Drawing.Point(223, 244);
            this.txtOff.Name = "txtOff";
            this.txtOff.Size = new System.Drawing.Size(121, 23);
            this.txtOff.TabIndex = 10;
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Century", 9.75F);
            this.btnClear.Location = new System.Drawing.Point(334, 356);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 27);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Century", 9.75F);
            this.btnExit.Location = new System.Drawing.Point(701, 449);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(69, 24);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.txtAcctNum);
            this.groupBox1.Controls.Add(this.txtCustName);
            this.groupBox1.Controls.Add(this.lblCustName);
            this.groupBox1.Controls.Add(this.lblAcctNumber);
            this.groupBox1.Controls.Add(this.lblOff);
            this.groupBox1.Controls.Add(this.lblUser);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.cmbUser);
            this.groupBox1.Controls.Add(this.lblPowerUsed);
            this.groupBox1.Controls.Add(this.txtOff);
            this.groupBox1.Controls.Add(this.txtPower);
            this.groupBox1.Controls.Add(this.lblAmount);
            this.groupBox1.Controls.Add(this.txtPeak);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.lblPeak);
            this.groupBox1.Font = new System.Drawing.Font("Century", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 389);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Caculate Customer Charge";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(239, 316);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 28);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAcctNum
            // 
            this.txtAcctNum.Location = new System.Drawing.Point(223, 115);
            this.txtAcctNum.Name = "txtAcctNum";
            this.txtAcctNum.Size = new System.Drawing.Size(121, 23);
            this.txtAcctNum.TabIndex = 16;
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(223, 81);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(121, 23);
            this.txtCustName.TabIndex = 15;
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustName.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustName.Location = new System.Drawing.Point(106, 84);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(106, 16);
            this.lblCustName.TabIndex = 14;
            this.lblCustName.Text = "Customer Name :";
            // 
            // lblAcctNumber
            // 
            this.lblAcctNumber.AutoSize = true;
            this.lblAcctNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblAcctNumber.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcctNumber.Location = new System.Drawing.Point(106, 118);
            this.lblAcctNumber.Name = "lblAcctNumber";
            this.lblAcctNumber.Size = new System.Drawing.Size(107, 16);
            this.lblAcctNumber.TabIndex = 13;
            this.lblAcctNumber.Text = "Account Number :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(464, 314);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Sum of Residential Charges :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(464, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 16);
            this.label5.TabIndex = 23;
            this.label5.Text = "Sum of Commercial Charges :";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(643, 423);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(100, 20);
            this.txtSum.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(476, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 16);
            this.label6.TabIndex = 24;
            this.label6.Text = "Sum of Industrial Charges :";
            // 
            // txtNumCust
            // 
            this.txtNumCust.Location = new System.Drawing.Point(643, 279);
            this.txtNumCust.Name = "txtNumCust";
            this.txtNumCust.ReadOnly = true;
            this.txtNumCust.Size = new System.Drawing.Size(100, 20);
            this.txtNumCust.TabIndex = 19;
            // 
            // txtSumRes
            // 
            this.txtSumRes.Location = new System.Drawing.Point(643, 313);
            this.txtSumRes.Name = "txtSumRes";
            this.txtSumRes.ReadOnly = true;
            this.txtSumRes.Size = new System.Drawing.Size(100, 20);
            this.txtSumRes.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(467, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Total Number of Customers :";
            // 
            // txtSumComm
            // 
            this.txtSumComm.Location = new System.Drawing.Point(643, 350);
            this.txtSumComm.Name = "txtSumComm";
            this.txtSumComm.ReadOnly = true;
            this.txtSumComm.Size = new System.Drawing.Size(100, 20);
            this.txtSumComm.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(517, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Sum of all Charges :";
            // 
            // txtSumInd
            // 
            this.txtSumInd.Location = new System.Drawing.Point(643, 383);
            this.txtSumInd.Name = "txtSumInd";
            this.txtSumInd.ReadOnly = true;
            this.txtSumInd.Size = new System.Drawing.Size(100, 20);
            this.txtSumInd.TabIndex = 27;
            // 
            // lstCustomerData
            // 
            this.lstCustomerData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lstCustomerData.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lstCustomerData.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCustomerData.FormattingEnabled = true;
            this.lstCustomerData.HorizontalScrollbar = true;
            this.lstCustomerData.ItemHeight = 12;
            this.lstCustomerData.Location = new System.Drawing.Point(457, 53);
            this.lstCustomerData.Name = "lstCustomerData";
            this.lstCustomerData.ScrollAlwaysVisible = true;
            this.lstCustomerData.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lstCustomerData.Size = new System.Drawing.Size(345, 206);
            this.lstCustomerData.TabIndex = 500;
            this.lstCustomerData.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(589, 35);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label7.Size = new System.Drawing.Size(82, 15);
            this.label7.TabIndex = 501;
            this.label7.Text = "Customer List";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(814, 485);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lstCustomerData);
            this.Controls.Add(this.txtSumInd);
            this.Controls.Add(this.txtSumComm);
            this.Controls.Add(this.txtSumRes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumCust);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        public System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAcctNum;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblAcctNumber;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNumCust;
        private System.Windows.Forms.TextBox txtSumRes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSumComm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSumInd;
        private System.Windows.Forms.ListBox lstCustomerData;
        private System.Windows.Forms.Label label7;
    }
}

