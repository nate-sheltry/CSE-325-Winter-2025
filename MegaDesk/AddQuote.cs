using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MegaDesk;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
            listMaterials.DataSource = Enum.GetValues(typeof(DesktopMaterial));
            listRush.DataSource = new List<string>(Constants.order.Keys);
        }

        private void backToMenuBtn_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();
        }

        private void numericInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        
        }

        private bool validateInput(int min, int max, TextBox obj, string str, bool showError = false)
        {
            string error = "";
            int value;
            try
            {
                value = Int32.Parse(obj.Text);
            } catch {
                MessageBox.Show($"Failed to parse value in {str} field.");
                return false;
            }
            obj.BackColor = Color.White;
            obj.ForeColor = Color.Black;

            if (value < min)
            {
                error = $"{str} cannot go below the minimum value of {min}.";
            }
            else if (value > max)
            {
                error = $"{str} cannot exceeded maximum value of {max}.";
            }

            if (error.Length > 0)
            {
                obj.BackColor = Color.Gold;
                obj.ForeColor = Color.Red;
                if (showError)
                    MessageBox.Show(error);
                return false;
            }
            return true;
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void widthInput_ValueChanged(object sender, EventArgs e)
        {
            validateInput(Desk.widthMin, Desk.widthMax, (TextBox)sender, "Width");
        }

        private void depthInput_ValueChanged(object sender, EventArgs e)
        {
            validateInput(Desk.depthMin, Desk.depthMax, (TextBox)sender, "Depth");
        }

        private void drawerInput_ValueChanged(object sender, EventArgs e)
        {
            validateInput(Desk.drawerMin, Desk.drawerMax, (TextBox)sender, "Drawers");
        }

        private void addQuoteBtn_Click(object sender, EventArgs e)
        {
            string name = nameInput.Text.Trim();

            if (name.Length < 2){
                MessageBox.Show("Please enter a customer name.");
                return;
            }

            if (
                !validateInput(Desk.widthMin, Desk.widthMax,
                    (TextBox)widthInput, "Width", true) ||
                !validateInput(Desk.depthMin, Desk.depthMax, 
                    (TextBox)depthInput, "Depth", true) ||
                !validateInput(Desk.drawerMin, Desk.drawerMax, 
                    (TextBox)drawerInput, "Drawers", true)
            ) return;

            try
            {
                int width = Int32.Parse(((TextBox)widthInput).Text.Trim());
                int depth = Int32.Parse(((TextBox)depthInput).Text.Trim());
                int drawers = Int32.Parse(((TextBox)drawerInput).Text.Trim());

                DeskQuote newQuote = new DeskQuote(
                    width, depth, drawers,
                    Constants.order[(string)listRush.SelectedItem],
                    (DesktopMaterial)listMaterials.SelectedItem,
                    name);
                System.Diagnostics.Debug.WriteLine(newQuote.ToString());

                DisplayQuote viewQuote = new DisplayQuote();
                viewQuote.Tag = this.Tag;
                viewQuote.LoadQuote(newQuote);
                viewQuote.Show(this);
                this.Hide();

            } catch {
                System.Diagnostics.Debug.WriteLine("Error Occurred");
                MessageBox.Show("Error Occurred parsing Desk information. Please Try Again.");
            }
}
    }
}
