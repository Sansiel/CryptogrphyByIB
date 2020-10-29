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
using IB1.Dto;
using IB1.Panel;

namespace IB1
{
    public partial class AdminPanel : UserControl
    {
        private PersonService personService;
        private PasswordChangePanel passwordChangePanel1;
        private int numberPerson;

        public AdminPanel(PersonService personService)
        {
            this.personService = personService;
            passwordChangePanel1 = new PasswordChangePanel(personService);
            Controls.Add(this.passwordChangePanel1);
            InitializeComponent();
            passwordChangePanel1.Visible = false;
        }

        //exit
        private void buttonExit_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error");
            }
        }

        public void SetUsersToView()
        {
            dataGridView1.Rows.Clear();
            foreach (var person in PersonService.DICT_PERSONS.Values)
            {
                if (person is UserDto)
                {
                    dataGridView1.Rows.Add( person.Login, ((UserDto)person).IsBlocked, ((UserDto)person).HaveRestrictionsPassword);
                }
            }
            dataGridView1.Refresh();
        }

        //logout
        private void buttonLogout_Click(object sender, EventArgs e)
        {
            var dialog = MessageBox.Show("Выйти из аккаунта?", "Выход", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                personService.Logout();
                Visible = false;
            }

        }

        //All User
        private void buttonAllUser_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;
            groupBoxUser.Visible = false;
            SetUsersToView();
        }

        //One user
        private void buttonOneUser_Click(object sender, EventArgs e)
        {
            SetVisible(false);
            numberPerson = 1;
            GetOneUser();
        }

        //Save
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string info;
            UserDto user = new UserDto(textBoxLogin.Text);
            info = personService.Add(user) ? "Пользователь создан" :
                 "Пользователь с таким логином уже существует";
            textBoxLogin.Text = "";
            MessageBox.Show(info);
        }

        //Add user
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            SetVisible(true);
        }

        private void SetVisible(bool isAdd)
        {
            dataGridView1.Visible = false;
            groupBoxUser.Visible = true;
            groupBox3.Visible = !isAdd;
            groupBox4.Visible = !isAdd;
            buttonSave.Visible = isAdd;
            textBoxLogin.Enabled = isAdd;
            textBoxLogin.Text = "";
        }

        //Edit password
        private void buttonChangePass_Click(object sender, EventArgs e)
        {
            passwordChangePanel1.Visible = true;
        }

        //Edit value
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            EditOneUser(dataGridView1[0, e.RowIndex].Value.ToString(),
                (bool)dataGridView1[1, e.RowIndex].Value, (bool)dataGridView1[2, e.RowIndex].Value);
        }

        //<<
        private void buttonLeftLeft_Click(object sender, EventArgs e)
        {
            numberPerson = 1;
            GetOneUser();
        }

        //<
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            numberPerson--;
            GetOneUser();
        }

        //>
        private void buttonRight_Click(object sender, EventArgs e)
        {
            numberPerson++;
            GetOneUser();
        }

        //>>
        private void buttonRightRight_Click(object sender, EventArgs e)
        {
            numberPerson = PersonService.DICT_PERSONS.Count - 1;
            GetOneUser();
        }

        private void GetOneUser()
        {
            if (numberPerson > 0 && numberPerson < PersonService.DICT_PERSONS.Count)
            {
                UserDto person = PersonService.DICT_PERSONS.ElementAt(numberPerson).Value as UserDto;
                textBoxLogin.Text = person.Login;
                checkBoxIsBlock.Checked = person.IsBlocked;
                checkBoxIsHardPassword.Checked = person.HaveRestrictionsPassword;
            }
            if (numberPerson == 0)
            {
                numberPerson = 1;
            }
            if (numberPerson == PersonService.DICT_PERSONS.Count)
            {
                numberPerson = PersonService.DICT_PERSONS.Count - 1;
            }
        }

        private void EditOneUser(string login, bool isBlocked, bool haveHardPassword)
        {
            UserDto user = new UserDto(login, isBlocked, haveHardPassword);
            personService.SetBlockAndPasswordRestriction(user);
        }


        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            EditOneUser(textBoxLogin.Text, checkBoxIsBlock.Checked, checkBoxIsHardPassword.Checked);
        }
    }
}
