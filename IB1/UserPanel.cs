using System.Windows.Forms;
using IB1.Service;
using IB1.Panel;

namespace IB1
{
    public partial class UserPanel : UserControl
    {
        private PersonService personService;
        private PasswordChangePanel passwordChangePanel1;

        public UserPanel(PersonService personService)
        {
            this.personService = personService;
            passwordChangePanel1 = new PasswordChangePanel(personService);
            passwordChangePanel1.Visible = false;
            Controls.Add(passwordChangePanel1);
            InitializeComponent();
        }

        //edit password
        private void buttonChangePass_Click(object sender, System.EventArgs e)
        {
            passwordChangePanel1.Visible = true;
        }

        //logout
        private void buttonLogout_Click(object sender, System.EventArgs e)
        {
            var dialog = MessageBox.Show("Выйти из аккаунта?", "Выход", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                personService.Logout();
                Visible = false;
            }
        }
    }
}
