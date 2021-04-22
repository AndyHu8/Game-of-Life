using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_of_Life_Win_Form
{
    public class Menuing : Form
    {
        public static Form CurrentForm { get; private set; }

        public static void OpenForm(Form newForm, Form oldForm)
        {
            CurrentForm = CurrentForm != newForm ? newForm : CurrentForm;
            CurrentForm.Show();
            oldForm.Close();
        }
    }
}
