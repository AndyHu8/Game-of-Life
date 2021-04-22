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
        public static Form CurrentForm { get; set; }
        public static Size PreviousSize { get; set; }

        public static void OpenForm(Form newForm, Form oldForm)
        {
            CurrentForm = CurrentForm != newForm ? newForm : CurrentForm;
            CurrentForm.Location = oldForm.Location;
            CurrentForm.StartPosition = FormStartPosition.Manual;
            CurrentForm.Show();
            oldForm.Hide();
        }

        public static void RepositionComponents()
        {
            var components = CurrentForm.Controls;

            foreach (var component in components)
            {
                switch (component)
                {
                    case Button button:
                        var x_offset = CurrentForm.Size.Width - PreviousSize.Width;
                        var y_offset = CurrentForm.Size.Height - PreviousSize.Height;
                        button.Location.Offset(x_offset, y_offset);
                        break;
                    default:
                        throw new Exception("Not implemented yet");
                }
            }
        }
    }
}
