using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IB1.Service;

namespace IB1
{
    public partial class PasswordPanel : UserControl
    {
        private PersonService personService;

        public PasswordPanel(PersonService personService)
        {
            InitializeComponent();
            this.personService = personService;
        }


        //login
        private void buttonLogin_Click(object sender, EventArgs e)
        {

            try
            {
                string login = textBoxName.Text;
                if (!personService.CheckLoginExist(login))
                {
                    var dialog = MessageBox.Show("Продолжить?", "Логин не найден", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialog == DialogResult.No)
                    {
                        MessageBox.Show("Приложение закрывается");
                        Application.Exit();
                    }
                    return;
                }
                if (personService.Login(login, textBoxPassword.Text))
                {
                    textBoxName.Text = "";
                    textBoxPassword.Text = "";
                    Visible = false;
                }
                else
                {
                    if (PersonService.NUMBER_TRY_OF_LOGIN > 0)
                    {
                        MessageBox.Show("Пароль неверный. Попробуйте еще раз. Попыток осталось: "
                            + PersonService.NUMBER_TRY_OF_LOGIN);
                    }
                    else
                    {
                        MessageBox.Show("Попытки закончились. Программа закрывается", "Неверный пароль",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Application.Exit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
