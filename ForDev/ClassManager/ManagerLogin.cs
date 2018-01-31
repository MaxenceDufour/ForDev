using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessClass;
using UserEditor;

namespace ForDev
{
    public class ManagerLogin
    {
        public event EventHandler EventConnection;

        private bool connection;
        public Controller Controller { get; set; } = new Controller();
        public Person PersonConnected { get; set; }
        public ManagerLogged MLogged { get; set; }
        public UcLogin UcLogin { get; set; } = new UcLogin();

        public ManagerLogin()
        {
           UcLogin.ButtonClick += new EventHandler(Login_Click);
        }

        public void Login_Click(object sender, EventArgs e)
        {
            if (UcLogin.textBoxLogin.Text.Length != 0 && UcLogin.textBoxPass.Text.Length != 0)
            {
                PersonConnected = new Person();
                PersonConnected = Controller.CheckAccess(UcLogin.textBoxLogin.Text, UcLogin.textBoxPass.Text);
                if (PersonConnected == null)
                {
                    string message = "Le login ou le mot de pass est inconnu dans la base de données!";
                    string caption = "Erreur de login";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;
                    MessageBox.Show(message, caption, buttons);
                }
                else
                {
                    if (EventConnection != null)
                        EventConnection(this, e);
                }
            }
            else
            {
                string message = "Le login ou le pass est peut-être mal renseigner.";
                string caption = "Erreur de login";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }
    }
}
