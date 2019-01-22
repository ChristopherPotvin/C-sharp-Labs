namespace CP_Lab4
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label orderIDLabel;
            System.Windows.Forms.Label shippedDateLabel;
            System.Windows.Forms.Label requiredDateLabel;
            System.Windows.Forms.Label orderDateLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.order_DetailDataGridView = new System.Windows.Forms.DataGridView();
            this.order_DetailBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderIDComboBox = new System.Windows.Forms.ComboBox();
            this.OrderTotaltextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shippedDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.requiredDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.orderDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            orderIDLabel = new System.Windows.Forms.Label();
            shippedDateLabel = new System.Windows.Forms.Label();
            requiredDateLabel = new System.Windows.Forms.Label();
            orderDateLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.order_DetailDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_DetailBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // orderIDLabel
            // 
            orderIDLabel.AutoSize = true;
            orderIDLabel.Location = new System.Drawing.Point(25, 51);
            orderIDLabel.Name = "orderIDLabel";
            orderIDLabel.Size = new System.Drawing.Size(50, 13);
            orderIDLabel.TabIndex = 3;
            orderIDLabel.Text = "Order ID:";
            // 
            // shippedDateLabel
            // 
            shippedDateLabel.AutoSize = true;
            shippedDateLabel.Location = new System.Drawing.Point(212, 363);
            shippedDateLabel.Name = "shippedDateLabel";
            shippedDateLabel.Size = new System.Drawing.Size(75, 13);
            shippedDateLabel.TabIndex = 7;
            shippedDateLabel.Text = "Shipped Date:";
            // 
            // requiredDateLabel
            // 
            requiredDateLabel.AutoSize = true;
            requiredDateLabel.Location = new System.Drawing.Point(222, 55);
            requiredDateLabel.Name = "requiredDateLabel";
            requiredDateLabel.Size = new System.Drawing.Size(79, 13);
            requiredDateLabel.TabIndex = 11;
            requiredDateLabel.Text = "Required Date:";
            // 
            // orderDateLabel
            // 
            orderDateLabel.AutoSize = true;
            orderDateLabel.Location = new System.Drawing.Point(239, 21);
            orderDateLabel.Name = "orderDateLabel";
            orderDateLabel.Size = new System.Drawing.Size(62, 13);
            orderDateLabel.TabIndex = 12;
            orderDateLabel.Text = "Order Date:";
            // 
            // order_DetailDataGridView
            // 
            this.order_DetailDataGridView.AutoGenerateColumns = false;
            this.order_DetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.order_DetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.order_DetailDataGridView.DataSource = this.order_DetailBindingSource;
            this.order_DetailDataGridView.Location = new System.Drawing.Point(12, 165);
            this.order_DetailDataGridView.Name = "order_DetailDataGridView";
            this.order_DetailDataGridView.Size = new System.Drawing.Size(542, 163);
            this.order_DetailDataGridView.TabIndex = 1;
            // 
            // order_DetailBindingSource
            // 
            this.order_DetailBindingSource.DataSource = typeof(CP_Lab4.Order_Detail);
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.AutoGenerateColumns = false;
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.orderDataGridView.DataSource = this.orderBindingSource;
            this.orderDataGridView.Location = new System.Drawing.Point(12, 90);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.Size = new System.Drawing.Size(542, 69);
            this.orderDataGridView.TabIndex = 2;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(CP_Lab4.Order);
            // 
            // orderIDComboBox
            // 
            this.orderIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.order_DetailBindingSource, "OrderID", true));
            this.orderIDComboBox.FormattingEnabled = true;
            this.orderIDComboBox.Location = new System.Drawing.Point(81, 48);
            this.orderIDComboBox.Name = "orderIDComboBox";
            this.orderIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.orderIDComboBox.TabIndex = 4;
            this.orderIDComboBox.SelectedIndexChanged += new System.EventHandler(this.orderIDComboBox_SelectedIndexChanged);
            // 
            // OrderTotaltextBox
            // 
            this.OrderTotaltextBox.Location = new System.Drawing.Point(102, 359);
            this.OrderTotaltextBox.Name = "OrderTotaltextBox";
            this.OrderTotaltextBox.ReadOnly = true;
            this.OrderTotaltextBox.Size = new System.Drawing.Size(100, 20);
            this.OrderTotaltextBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Order Total :";
            // 
            // shippedDateTimePicker
            // 
            this.shippedDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "ShippedDate", true));
            this.shippedDateTimePicker.Location = new System.Drawing.Point(293, 359);
            this.shippedDateTimePicker.Name = "shippedDateTimePicker";
            this.shippedDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.shippedDateTimePicker.TabIndex = 8;
            this.shippedDateTimePicker.Value = new System.DateTime(2019, 1, 13, 17, 28, 27, 0);
            // 
            // requiredDateTimePicker
            // 
            this.requiredDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "RequiredDate", true));
            this.requiredDateTimePicker.Enabled = false;
            this.requiredDateTimePicker.Location = new System.Drawing.Point(307, 51);
            this.requiredDateTimePicker.Name = "requiredDateTimePicker";
            this.requiredDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.requiredDateTimePicker.TabIndex = 12;
            // 
            // orderDateTimePicker
            // 
            this.orderDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.orderBindingSource, "OrderDate", true));
            this.orderDateTimePicker.Enabled = false;
            this.orderDateTimePicker.Location = new System.Drawing.Point(307, 17);
            this.orderDateTimePicker.Name = "orderDateTimePicker";
            this.orderDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.orderDateTimePicker.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(513, 357);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn1.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ProductID";
            this.dataGridViewTextBoxColumn2.HeaderText = "ProductID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn3.HeaderText = "UnitPrice";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn4.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Discount";
            this.dataGridViewTextBoxColumn5.HeaderText = "Discount";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "OrderID";
            this.dataGridViewTextBoxColumn7.HeaderText = "OrderID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn8.HeaderText = "CustomerID";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "OrderDate";
            this.dataGridViewTextBoxColumn10.HeaderText = "OrderDate";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "RequiredDate";
            this.dataGridViewTextBoxColumn11.HeaderText = "RequiredDate";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "ShippedDate";
            this.dataGridViewTextBoxColumn12.HeaderText = "ShippedDate";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 402);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(orderDateLabel);
            this.Controls.Add(this.orderDateTimePicker);
            this.Controls.Add(requiredDateLabel);
            this.Controls.Add(this.requiredDateTimePicker);
            this.Controls.Add(shippedDateLabel);
            this.Controls.Add(this.shippedDateTimePicker);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderTotaltextBox);
            this.Controls.Add(orderIDLabel);
            this.Controls.Add(this.orderIDComboBox);
            this.Controls.Add(this.orderDataGridView);
            this.Controls.Add(this.order_DetailDataGridView);
            this.Name = "Form1";
            this.Text = "S";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.order_DetailDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.order_DetailBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource order_DetailBindingSource;
        private System.Windows.Forms.DataGridView order_DetailDataGridView;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.ComboBox orderIDComboBox;
        private System.Windows.Forms.TextBox OrderTotaltextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker shippedDateTimePicker;
        private System.Windows.Forms.DateTimePicker requiredDateTimePicker;
        private System.Windows.Forms.DateTimePicker orderDateTimePicker;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
    }
}

