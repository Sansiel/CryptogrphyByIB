using IB1.Service;
using System;
using System.Windows.Forms;

namespace IB1.Panel
{
    public partial class PasswordChangePanel : UserControl
    {
        private PersonService personService;
        private PasswordService passwordService;

        public PasswordChangePanel(PersonService personService)
        {
            InitializeComponent();
            this.personService = personService;
            passwordService = new PasswordService();
        }


        //back
        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (!PersonService.CURRENT_PERSON.IsFirstTime)
            {
                Visible = false;
            }
            else
            {
                MessageBox.Show("Необходимо задать пароль");
            }
            EmptyTextBoxes();
        }

        //save
        private void buttonSave_Click(object sender, EventArgs e)
        {
            bool stoper = true;
            foreach (char nPass in textBoxNewPass.Text)
            {
                if (textBoxNewPass.Text.Contains(""+ nPass + nPass)) stoper = false;
            }

            try
            {
                if (stoper) {
                    string oldPassword = passwordService.doHash(textBoxOldPass.Text);
                    if (PersonService.CURRENT_PERSON.Password.Equals(oldPassword))
                    {
                        if (textBoxNewPass.Text.Equals(textBoxRepeatPass.Text))
                        {
                            if (oldPassword.Equals(passwordService.doHash(textBoxNewPass.Text)))
                            {
                                MessageBox.Show("Старый и новый пароль должны отличаться");
                            }
                            else if (personService.SetPasswordForUser(textBoxNewPass.Text))
                            {
                                MessageBox.Show("Пароль изменен!");
                                if (buttonBack.Visible)
                                {
                                    personService.SetPersonNotFirstTime();
                                    EmptyTextBoxes();
                                    Visible = false;
                                }
                            }
                            else
                            {
                                var dialog = MessageBox.Show("Продолжить?", "Пароль не подходит!", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                                if (dialog == DialogResult.No)
                                {
                                    if (PersonService.CURRENT_PERSON.IsFirstTime)
                                    {
                                        MessageBox.Show("Приложение закрывается");
                                        Application.Exit();
                                    }
                                    else
                                    {
                                        Visible = false;
                                    }
                                }
                                else if (dialog == DialogResult.Cancel)
                                {
                                    if (!PersonService.CURRENT_PERSON.IsFirstTime)
                                    {
                                        Visible = false;
                                    }
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show("Пароли не совпадают!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Текущий пароль не верный");
                    }
                }
                else
                {
                    MessageBox.Show("Пароли содержат повторияющиеся символы");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void EmptyTextBoxes()
        {
            textBoxOldPass.Text = "";
            textBoxNewPass.Text = "";
            textBoxRepeatPass.Text = "";
        }
    }
}
