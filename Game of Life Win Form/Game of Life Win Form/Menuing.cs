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

        public static Menu_main Menu_main = new Menu_main();
        public static Menu_newGame Menu_newGame = new Menu_newGame();
        public static Matchfield Matchfield = new Matchfield();
        public static Menu_startGame Menu_startGame=new Menu_startGame();

        public static void OpenForm(Form newForm, Form oldForm)
        {
            newForm.WindowState = oldForm.WindowState;
            newForm.Show();
            oldForm.Hide();
        }

        //public static void RepositionComponents()
        //{
        //    var components = CurrentForm.Controls;

        //    var x_offset = (CurrentForm.Size.Width - PreviousForm.Size.Width) / 2;
        //    var y_offset = (CurrentForm.Size.Height - PreviousForm.Size.Height) / 2;

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
        //            case Panel panel:
        //                panel.Location = new Point(panel.Location.X + x_offset, panel.Location.Y + y_offset);
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
        //    PreviousForm.Size = form.Size;
        //}

        //public static void LoadForm(object sender, EventArgs e)
        //{
        //    var form = sender as Form;
        //    PreviousForm.Size = form.Size;
        //}
    }
}
