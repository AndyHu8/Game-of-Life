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

        //public static void RepositionComponents()
        //{
        //    var components = CurrentForm.Controls;

        //    var x_offset = (CurrentForm.Size.Width - PreviousSize.Width) / 2;
        //    var y_offset = (CurrentForm.Size.Height - PreviousSize.Height) / 2;

        //    foreach (var component in components)
        //    {
        //        switch (component)
        //        {
        //            case Button button:
        //                button.Location = new Point(button.Location.X + x_offset, button.Location.Y + y_offset);
        //                break;
        //            case Label label:
        //                //label.Location = new Point(label.Location.X + x_offset, label.Location.Y + y_offset);
        //                break;
        //            default:
        //                throw new Exception("Not implemented yet");
        //        }
        //    }
        //}

        //public static void ResizeForm(object sender, EventArgs e)
        //{
        //    var form = sender as Form;
        //    CurrentForm = form;
        //    RepositionComponents();
        //    PreviousSize = form.Size;
        //}

        //public static void LoadForm(object sender, EventArgs e)
        //{
        //    var form = sender as Form;
        //    PreviousSize = form.Size;
        //}
    }
}
