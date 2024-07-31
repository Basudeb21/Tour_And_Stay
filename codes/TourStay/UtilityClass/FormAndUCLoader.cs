using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TourStay.FormScreens;
using TourStay.LogoutSystem;

namespace TourStay.UtilityClass
{
    internal class FormAndUCLoader
    {
        public void changeUC(UserControl uc, Panel pnl)
        {
            uc.Dock = DockStyle.Fill;
            pnl.Controls.Clear();
            pnl.Controls.Add(uc);
            uc.BringToFront();
        }

        public void changeForm(Form cform, Form nform)
        {
            cform.Hide();
            nform.Show();
        }

        public void closeParentForm(Form frm)
        {
            Form ParentForm = frm.FindForm();
            if (ParentForm != null)
            {
                ParentForm.Hide();
            }
        }

        public void closeAllForm()
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is HotelForm)
                {
                    form.Hide();
                }
                if (form is UserForm)
                {
                    form.Hide();
                }
                if (form is LoginScreen)
                {
                    form.Hide();
                }
                if (form is LogoutForm)
                {
                    form.Hide();
                }
            }
            LoginScreen f1 = new LoginScreen();
            f1.Show();

        }
    }
}
