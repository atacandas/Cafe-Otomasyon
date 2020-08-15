namespace Cafe.WfaUI
{
    partial class UserControlListOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.grpbxOrders = new System.Windows.Forms.GroupBox();
            this.dateTimeOrder1 = new System.Windows.Forms.DateTimePicker();
            this.buttonEnterByDatetime = new System.Windows.Forms.Button();
            this.buttonEnterEmployeeName = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textEnterEmployeeName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonShowAllOrder = new System.Windows.Forms.Button();
            this.dataGridOrder = new System.Windows.Forms.DataGridView();
            this.dateTimeOrder2 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridOrderDetail = new System.Windows.Forms.DataGridView();
            this.grpbxOrders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // grpbxOrders
            // 
            this.grpbxOrders.Controls.Add(this.label3);
            this.grpbxOrders.Controls.Add(this.dateTimeOrder2);
            this.grpbxOrders.Controls.Add(this.dateTimeOrder1);
            this.grpbxOrders.Controls.Add(this.buttonEnterByDatetime);
            this.grpbxOrders.Controls.Add(this.buttonEnterEmployeeName);
            this.grpbxOrders.Controls.Add(this.label2);
            this.grpbxOrders.Controls.Add(this.textEnterEmployeeName);
            this.grpbxOrders.Controls.Add(this.label1);
            this.grpbxOrders.Controls.Add(this.buttonShowAllOrder);
            this.grpbxOrders.Controls.Add(this.dataGridOrder);
            this.grpbxOrders.Location = new System.Drawing.Point(3, 3);
            this.grpbxOrders.Name = "grpbxOrders";
            this.grpbxOrders.Size = new System.Drawing.Size(739, 527);
            this.grpbxOrders.TabIndex = 2;
            this.grpbxOrders.TabStop = false;
            this.grpbxOrders.Text = "Orders";
            // 
            // dateTimeOrder1
            // 
            this.dateTimeOrder1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimeOrder1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeOrder1.Location = new System.Drawing.Point(152, 46);
            this.dateTimeOrder1.Name = "dateTimeOrder1";
            this.dateTimeOrder1.Size = new System.Drawing.Size(78, 20);
            this.dateTimeOrder1.TabIndex = 8;
            // 
            // buttonEnterByDatetime
            // 
            this.buttonEnterByDatetime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEnterByDatetime.Location = new System.Drawing.Point(356, 18);
            this.buttonEnterByDatetime.Name = "buttonEnterByDatetime";
            this.buttonEnterByDatetime.Size = new System.Drawing.Size(95, 49);
            this.buttonEnterByDatetime.TabIndex = 7;
            this.buttonEnterByDatetime.Text = "Show";
            this.buttonEnterByDatetime.UseVisualStyleBackColor = true;
            this.buttonEnterByDatetime.Click += new System.EventHandler(this.buttonEnterByDatetime_Click);
            // 
            // buttonEnterEmployeeName
            // 
            this.buttonEnterEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEnterEmployeeName.Location = new System.Drawing.Point(637, 18);
            this.buttonEnterEmployeeName.Name = "buttonEnterEmployeeName";
            this.buttonEnterEmployeeName.Size = new System.Drawing.Size(95, 49);
            this.buttonEnterEmployeeName.TabIndex = 6;
            this.buttonEnterEmployeeName.Text = "Show";
            this.buttonEnterEmployeeName.UseVisualStyleBackColor = true;
            this.buttonEnterEmployeeName.Click += new System.EventHandler(this.buttonEnterEmployeeName_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(458, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Employee Name";
            // 
            // textEnterEmployeeName
            // 
            this.textEnterEmployeeName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textEnterEmployeeName.Location = new System.Drawing.Point(458, 40);
            this.textEnterEmployeeName.Name = "textEnterEmployeeName";
            this.textEnterEmployeeName.Size = new System.Drawing.Size(173, 26);
            this.textEnterEmployeeName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(148, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Show Orders By Datetime";
            // 
            // buttonShowAllOrder
            // 
            this.buttonShowAllOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonShowAllOrder.Location = new System.Drawing.Point(6, 17);
            this.buttonShowAllOrder.Name = "buttonShowAllOrder";
            this.buttonShowAllOrder.Size = new System.Drawing.Size(136, 51);
            this.buttonShowAllOrder.TabIndex = 2;
            this.buttonShowAllOrder.Text = "Show All Orders";
            this.buttonShowAllOrder.UseVisualStyleBackColor = true;
            this.buttonShowAllOrder.Click += new System.EventHandler(this.buttonShowAllOrder_Click);
            // 
            // dataGridOrder
            // 
            this.dataGridOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrder.Location = new System.Drawing.Point(6, 77);
            this.dataGridOrder.Name = "dataGridOrder";
            this.dataGridOrder.Size = new System.Drawing.Size(727, 444);
            this.dataGridOrder.TabIndex = 0;
            this.dataGridOrder.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOrder_CellClick);
            // 
            // dateTimeOrder2
            // 
            this.dateTimeOrder2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimeOrder2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeOrder2.Location = new System.Drawing.Point(257, 46);
            this.dateTimeOrder2.Name = "dateTimeOrder2";
            this.dateTimeOrder2.Size = new System.Drawing.Size(78, 20);
            this.dateTimeOrder2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(236, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "-";
            // 
            // dataGridOrderDetail
            // 
            this.dataGridOrderDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOrderDetail.Location = new System.Drawing.Point(748, 80);
            this.dataGridOrderDetail.Name = "dataGridOrderDetail";
            this.dataGridOrderDetail.Size = new System.Drawing.Size(593, 217);
            this.dataGridOrderDetail.TabIndex = 11;
            // 
            // UserControlListOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridOrderDetail);
            this.Controls.Add(this.grpbxOrders);
            this.Name = "UserControlListOrder";
            this.Size = new System.Drawing.Size(1344, 533);
            this.Load += new System.EventHandler(this.UserControlListOrder_Load);
            this.grpbxOrders.ResumeLayout(false);
            this.grpbxOrders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOrderDetail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpbxOrders;
        private System.Windows.Forms.Button buttonEnterByDatetime;
        private System.Windows.Forms.Button buttonEnterEmployeeName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textEnterEmployeeName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonShowAllOrder;
        private System.Windows.Forms.DataGridView dataGridOrder;
        private System.Windows.Forms.DateTimePicker dateTimeOrder1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeOrder2;
        private System.Windows.Forms.DataGridView dataGridOrderDetail;
    }
}
