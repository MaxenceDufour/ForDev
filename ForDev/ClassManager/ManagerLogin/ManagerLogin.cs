using BusinessClassPortable;
using ForDev.ClassManager.ManagerLogin;
using System;
using System.Windows.Forms;
using EncodingDll;

namespace ForDev
{
    /// <summary>
    /// Class ManagerLogin
    /// </summary>
    public class ManagerLogin
    {
        public event EventHandler<PersonConnectedEventArgs> EventConnection;
        public Person PersonConnected;
        public UcLogin UcLogin { get; set; } = new UcLogin();

        /// <summary>
        /// Check if the user exists in the db
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void Login_Click(object sender, EventArgs e)
        {
            if (UcLogin.textBoxLogin.Text.Length != 0 && UcLogin.textBoxPass.Text.Length != 0)
            {
                PersonConnected = new Person();
                PersonConnected = Controller.CheckAccess(UcLogin.textBoxLogin.Text.Trim(), Convert.ToBase64String(EncodingPass.SalAndHash(UcLogin.textBoxPass.Text)));
                if (PersonConnected == null)
                    MessageBox.Show(Properties.Resources.BADLOGIN, Properties.Resources.CAPTIONLOGIN, MessageBoxButtons.OK);
                else
                {
                    UcLogin.LoginTextBox.Clear();
                    UcLogin.PassTextBox.Clear();
                    UcLogin.Enabled = false;
                    UcLogin.Visible = false;
                    if (EventConnection != null)
                        EventConnection(this, new PersonConnectedEventArgs {PersonConnected = PersonConnected });
                }
            }
            else
                MessageBox.Show(Properties.Resources.BADLOGIN, Properties.Resources.CAPTIONLOGIN, MessageBoxButtons.OK);
        }

        /// <summary>
        /// Variable modification after disconnection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnDisconnected(object sender, EventArgs e)
        {
            PersonConnected = null;
            UcLogin.Visible = true;
            UcLogin.Enabled = true;
        }
    }
}
