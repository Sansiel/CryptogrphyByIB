using IB1.Dto;
using IB1.Panel;
using IB1.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace IB1
{
    public partial class Main : Form
    {

        PersonService personService;
        private AdminPanel adminPanel1;
        private PasswordPanel passwordPanel1;
        private UserPanel userPanel1;
        private PasswordChangePanel passwordChangePanel1;

        public Main()
        {
            personService = new PersonService();
            adminPanel1 = new AdminPanel(personService);
            passwordPanel1 = new PasswordPanel(personService);
            userPanel1 = new UserPanel(personService);
            passwordChangePanel1 = new PasswordChangePanel(personService);
            InitializeComponent();

            //
            Controls.Add(passwordPanel1);
            Controls.Add(passwordChangePanel1);
            Controls.Add(adminPanel1);
            Controls.Add(userPanel1);
            //
            passwordChangePanel1.Visible = false;
            adminPanel1.Visible = false;
            userPanel1.Visible = false;
            //
            personService.GetAll();
            personService.SaveAll();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            personService.SaveAll();
            personService.DeleteTempFile();
        }

        private void passwordPanel1_VisibleChanged(object sender, EventArgs e)
        {
            if (!passwordPanel1.Visible)
            {
                if (PersonService.CURRENT_PERSON.IsFirstTime)
                {
                    passwordChangePanel1.Visible = true;
                }
                MessageBox.Show("Привет, " + PersonService.CURRENT_PERSON.Login);
                if (PersonService.CURRENT_PERSON is AdminDto)
                {
                    adminPanel1.Visible = true;
                    adminPanel1.SetUsersToView();
                }
                else if (PersonService.CURRENT_PERSON is UserDto)
                {
                    userPanel1.Visible = true;
                }

            }
        }

        private void adminPanel1_VisibleChanged(object sender, EventArgs e)
        {
            if (!adminPanel1.Visible)
            {
                passwordPanel1.Visible = true;
            }
        }

        private void userPanel1_VisibleChanged(object sender, EventArgs e)
        {
            if (!userPanel1.Visible)
            {
                passwordPanel1.Visible = true;
            }
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            passwordPanel1.VisibleChanged += new System.EventHandler(this.passwordPanel1_VisibleChanged);
            adminPanel1.VisibleChanged += new System.EventHandler(this.adminPanel1_VisibleChanged);
            userPanel1.VisibleChanged += new System.EventHandler(this.userPanel1_VisibleChanged);

        }

        private void оПрограмме_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Шупинский В.А. ПИбд-41.\n" +
                "Пароль - Отсутствие подряд расположенных одинаковых символов.\n" +
                "Шифрование - CFB. Хеширование - MD5."
                );
        }
    }
}

