namespace Cafe.WfaUI
{
    partial class FormAdminPanel
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ekleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newCategoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showEmployeesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTitlesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productCategoryToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.showProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.userControlAddUpdateDelete1 = new Cafe.WfaUI.UserControlAddUpdateDelete();
            this.userControlOrderPage1 = new Cafe.WfaUI.UserControlOrderPage();
            this.buttonListOrder = new System.Windows.Forms.Button();
            this.userControlListOrder1 = new Cafe.WfaUI.UserControlListOrder();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.ekleToolStripMenuItem,
            this.showToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(193, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(49, 25);
            this.toolStripMenuItem1.Text = "File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // ekleToolStripMenuItem
            // 
            this.ekleToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ekleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryToolStripMenuItem,
            this.productCategoryToolStripMenuItem});
            this.ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            this.ekleToolStripMenuItem.Size = new System.Drawing.Size(53, 25);
            this.ekleToolStripMenuItem.Text = "Add";
            // 
            // categoryToolStripMenuItem
            // 
            this.categoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEmployeeToolStripMenuItem,
            this.newTitleToolStripMenuItem});
            this.categoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            this.categoryToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.categoryToolStripMenuItem.Text = "Employee/Title";
            // 
            // newEmployeeToolStripMenuItem
            // 
            this.newEmployeeToolStripMenuItem.Name = "newEmployeeToolStripMenuItem";
            this.newEmployeeToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.newEmployeeToolStripMenuItem.Text = "New Employee";
            // 
            // newTitleToolStripMenuItem
            // 
            this.newTitleToolStripMenuItem.Name = "newTitleToolStripMenuItem";
            this.newTitleToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.newTitleToolStripMenuItem.Text = "New Title";
            // 
            // productCategoryToolStripMenuItem
            // 
            this.productCategoryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newProductToolStripMenuItem,
            this.newCategoryToolStripMenuItem});
            this.productCategoryToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productCategoryToolStripMenuItem.Name = "productCategoryToolStripMenuItem";
            this.productCategoryToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.productCategoryToolStripMenuItem.Text = "Product/Category";
            // 
            // newProductToolStripMenuItem
            // 
            this.newProductToolStripMenuItem.Name = "newProductToolStripMenuItem";
            this.newProductToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.newProductToolStripMenuItem.Text = "New Product";
            // 
            // newCategoryToolStripMenuItem
            // 
            this.newCategoryToolStripMenuItem.Name = "newCategoryToolStripMenuItem";
            this.newCategoryToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.newCategoryToolStripMenuItem.Text = "New Category";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeTitleToolStripMenuItem,
            this.productCategoryToolStripMenuItem1});
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(64, 25);
            this.showToolStripMenuItem.Text = "Show";
            // 
            // employeeTitleToolStripMenuItem
            // 
            this.employeeTitleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showEmployeesToolStripMenuItem,
            this.showTitlesToolStripMenuItem});
            this.employeeTitleToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.employeeTitleToolStripMenuItem.Name = "employeeTitleToolStripMenuItem";
            this.employeeTitleToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.employeeTitleToolStripMenuItem.Text = "Employee/Title";
            // 
            // showEmployeesToolStripMenuItem
            // 
            this.showEmployeesToolStripMenuItem.Name = "showEmployeesToolStripMenuItem";
            this.showEmployeesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.showEmployeesToolStripMenuItem.Text = "Show Employees";
            // 
            // showTitlesToolStripMenuItem
            // 
            this.showTitlesToolStripMenuItem.Name = "showTitlesToolStripMenuItem";
            this.showTitlesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.showTitlesToolStripMenuItem.Text = "Show Titles";
            // 
            // productCategoryToolStripMenuItem1
            // 
            this.productCategoryToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showProductsToolStripMenuItem,
            this.showCategoriesToolStripMenuItem});
            this.productCategoryToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productCategoryToolStripMenuItem1.Name = "productCategoryToolStripMenuItem1";
            this.productCategoryToolStripMenuItem1.Size = new System.Drawing.Size(181, 22);
            this.productCategoryToolStripMenuItem1.Text = "Product/Category";
            // 
            // showProductsToolStripMenuItem
            // 
            this.showProductsToolStripMenuItem.Name = "showProductsToolStripMenuItem";
            this.showProductsToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.showProductsToolStripMenuItem.Text = "Show Products";
            // 
            // showCategoriesToolStripMenuItem
            // 
            this.showCategoriesToolStripMenuItem.Name = "showCategoriesToolStripMenuItem";
            this.showCategoriesToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.showCategoriesToolStripMenuItem.Text = "Show Categories";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(12, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 70);
            this.button1.TabIndex = 2;
            this.button1.Text = "Take Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(12, 123);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 70);
            this.button2.TabIndex = 3;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // userControlAddUpdateDelete1
            // 
            this.userControlAddUpdateDelete1.Location = new System.Drawing.Point(182, 47);
            this.userControlAddUpdateDelete1.Name = "userControlAddUpdateDelete1";
            this.userControlAddUpdateDelete1.Size = new System.Drawing.Size(1330, 533);
            this.userControlAddUpdateDelete1.TabIndex = 4;
            // 
            // userControlOrderPage1
            // 
            this.userControlOrderPage1.Location = new System.Drawing.Point(182, 47);
            this.userControlOrderPage1.Name = "userControlOrderPage1";
            this.userControlOrderPage1.Size = new System.Drawing.Size(1344, 533);
            this.userControlOrderPage1.TabIndex = 5;
            // 
            // buttonListOrder
            // 
            this.buttonListOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonListOrder.Location = new System.Drawing.Point(12, 199);
            this.buttonListOrder.Name = "buttonListOrder";
            this.buttonListOrder.Size = new System.Drawing.Size(163, 70);
            this.buttonListOrder.TabIndex = 6;
            this.buttonListOrder.Text = "List Orders";
            this.buttonListOrder.UseVisualStyleBackColor = true;
            this.buttonListOrder.Click += new System.EventHandler(this.buttonListOrder_Click);
            // 
            // userControlListOrder1
            // 
            this.userControlListOrder1.Location = new System.Drawing.Point(182, 47);
            this.userControlListOrder1.Name = "userControlListOrder1";
            this.userControlListOrder1.Size = new System.Drawing.Size(1344, 533);
            this.userControlListOrder1.TabIndex = 7;
            // 
            // FormAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 280);
            this.Controls.Add(this.userControlListOrder1);
            this.Controls.Add(this.buttonListOrder);
            this.Controls.Add(this.userControlOrderPage1);
            this.Controls.Add(this.userControlAddUpdateDelete1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FormAdminPanel";
            this.Text = "FormAdminPanel";
            this.Load += new System.EventHandler(this.FormAdminPanel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ekleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newCategoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeTitleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showEmployeesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showTitlesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productCategoryToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem showProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showCategoriesToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private UserControlAddUpdateDelete userControlAddUpdateDelete1;
        private UserControlOrderPage userControlOrderPage1;
        private System.Windows.Forms.Button buttonListOrder;
        private UserControlListOrder userControlListOrder1;
    }
}