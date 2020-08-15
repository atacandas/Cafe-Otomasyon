using Cafe.Bll.Abstracts;
using Cafe.Bll.Concretes.Managers;
using Cafe.Dal.Concretes.EntityFramework;
using Cafe.Entity.Concretes;
using Cafe.WfaUI.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafe.WfaUI
{
    public partial class FormAdminPanel : Form
    {
        public Employee _loginEmployee;
        FormGiris _formGiris;
        public FormAdminPanel()
        {
            InitializeComponent();       
        }
        public FormAdminPanel(FormGiris formGiris, Employee loginEmployee)
        {
            InitializeComponent();
            _loginEmployee = loginEmployee;
            _formGiris = formGiris;
        }
        private void FormAdminPanel_Load(object sender, EventArgs e)
        {
            userControlAddUpdateDelete1.Hide();
            userControlOrderPage1.Hide();
            userControlListOrder1.Hide();
            this.Text =_loginEmployee.UserName;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1600, 700);
            userControlAddUpdateDelete1.Show();
            userControlListOrder1.Hide();
            userControlOrderPage1.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1600, 700);
            userControlAddUpdateDelete1.Hide();
            userControlOrderPage1.Show();
            userControlListOrder1.Hide();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formGiris.Close();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _formGiris.Show();
            _loginEmployee = null;
            this.Close();
            
        }

        private void buttonListOrder_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(1600, 700);
            userControlListOrder1.Show();
            userControlOrderPage1.Hide();
            userControlAddUpdateDelete1.Hide();
        }
    }
}
