using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Game_of_Life_Win_Form
{
    public class Menuing : Form
    {
        public static Form CurrentForm { get; private set; }

        public static void OpenForm(Form newForm, Form oldForm)
        {
            CurrentForm = CurrentForm != newForm ? newForm : CurrentForm;
            CurrentForm.Location = oldForm.Location;
            CurrentForm.StartPosition = FormStartPosition.Manual;
            CurrentForm.Show();
            oldForm.Hide();
        }
    }
}
