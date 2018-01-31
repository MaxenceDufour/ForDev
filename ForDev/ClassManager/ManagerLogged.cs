using BusinessClassPortable;
using ForDev.ClassManager.ManagerLogin;
using System;
using System.Windows.Forms;

namespace ForDev
{
    /// <summary>
    /// Class ManagerLogged
    /// </summary>
    public class ManagerLogged : IDisposable
    {
        private bool connection;

        public event EventHandler UpdateClick;
        public event EventHandler LogoutClick;
        public event EventHandler ProfilClick;
        public event EventHandler TopicAdd;
        public UcLogged UcLogged;

        /// <summary>
        /// Build the user part
        /// </summary>
        /// <param name="Person">Represents the registered user</param>
        private void BuildLogged(Person PersonConnected)
        {
            UcLogged = new UcLogged();
            UcLogged.Dock = DockStyle.Top;
            UcLogged.FirstName.Text = PersonConnected.PersonFirstName;
            UcLogged.LastName.Text = PersonConnected.PersonLastName;
            UcLogged.ProfilClick += new EventHandler(this.Profil_Click);
            UcLogged.LogOutClick += new EventHandler(this.LogOut_Click);
            UcLogged.TopicAdd += new EventHandler(this.TopicAdd_Click);
        }

        /// <summary>
        /// Modify the behavior after connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">object person</param>
        public void OnConnected(object sender, PersonConnectedEventArgs e)
        {
            BuildLogged(e.PersonConnected);
        }

        /// <summary>
        /// Modifies the behavior after disconnection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnDisconnected(object sender, EventArgs e)
        {
            UcLogged.Dispose();
        }

        /// <summary>
        /// Call the build method of the profile tab
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Profil_Click(object sender, EventArgs e)
        {
            if (ProfilClick != null)
                ProfilClick(this, e);
        }

        /// <summary>
        /// Close the user's session
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LogOut_Click(object sender, EventArgs e)
        {
            if (LogoutClick != null)
                LogoutClick(this, e);
        }

        /// <summary>
        /// Opens the topic addition part
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopicAdd_Click(object sender, EventArgs e)
        {
            if (TopicAdd != null)
                TopicAdd(this, e);
        }

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            UcLogged.Dispose();
        }
    }
}
