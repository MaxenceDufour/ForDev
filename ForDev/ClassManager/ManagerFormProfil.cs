using ForDev.ClassManager.ManagerLogin;
using System;
using System.Windows.Forms;
using BusinessClassPortable;
using EncodingDll;

namespace ForDev
{
    /// <summary>
    /// Class ManagerFormProfil
    /// </summary>
    public class ManagerFormProfil
    {
        private Person _person;
        public event EventHandler UpdateClick;

        /// <summary>
        /// Built the profile part
        /// </summary>
        /// <returns>user control formProfil</returns>
        public UcFormProfil BuildProfil()
        {
            UcFormProfil fp = new UcFormProfil();
            fp.FirstName.Text = _person.PersonFirstName;
            fp.LastName.Text = _person.PersonLastName;
            fp.Email.Text = _person.Email;
            fp.UpdateClick += new EventHandler(UpdatePass_Click);
            return fp;
        }
       
        /// <summary>
        /// Update password
        /// </summary>
        /// <param name="sender">userc control formProfil</param>
        /// <param name="e"></param>
        private void UpdatePass_Click(object sender, EventArgs e)
        {
            UcFormProfil UCFP = (UcFormProfil) sender;
            if (UpdateClick != null)
                UpdateClick(this, e);

            Person Person = new Person();
            Person = Controller.CheckAccess(_person.PersonFirstName, Convert.ToBase64String(EncodingPass.SalAndHash(UCFP.Pass.Text)));
            if (Person == null || Person.PersonId != _person.PersonId ||
                UCFP.textBoxNewPass1.Text != UCFP.textBoxNewPass2.Text ||
                UCFP.textBoxNewPass1.Text == Properties.Resources.EMPTY)
                MessageBox.Show(Properties.Resources.BADPASSWORD, Properties.Resources.CAPTIONEMPTYFIELDS,
                    MessageBoxButtons.OK);
            else
                Controller.UpdatePassword(_person.PersonId,
                    Convert.ToBase64String(EncodingPass.SalAndHash(UCFP.textBoxNewPass1.Text)));
        }

        /// <summary>
        /// Modify the behavior after connection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnConnected(object sender, PersonConnectedEventArgs e)
        {
            _person = e.PersonConnected;
        }
    }
}
