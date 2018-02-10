using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalSystemUI
{
    public class ValidateForms
    {
        //Validate Text Fields
        public bool ValidateTextFields(object sender, ConsoleCancelEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (String.IsNullOrEmpty(textBox.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        //Check CheckBox Selections

        public bool CheckSelectedPosition()
        {
            CreateEmployee employee = new CreateEmployee();

            if (employee.PositionsCheckedBox.SelectedItems.Count > -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }


}
