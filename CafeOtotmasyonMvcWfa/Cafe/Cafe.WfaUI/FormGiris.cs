using Cafe.Bll.Abstracts;
using Cafe.Bll.Concretes.Managers;
using Cafe.Dal.Concretes.EntityFramework;
using Cafe.Entity.Concretes;
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
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }
        IEmployeeService _employeeManager = EmployeeManager.CreateSingleton(new EfEmployeeDal());

        private void buttonGiris_Click(object sender, EventArgs e)
        {
            string username = textKullaniciAdi.Text;
            string password = textSifre.Text;
            Employee loginEmployee = _employeeManager.GetEmployee(username,password);
            if (loginEmployee!=null)
            {
                MessageBox.Show("Giris Basarili","Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormAdminPanel formAdminPanel = new FormAdminPanel(this,loginEmployee);
                textKullaniciAdi.Clear();
                textSifre.Clear();
                formAdminPanel.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanici adi ve şifre yanlis","Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
