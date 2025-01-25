using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
        }

        private void backToMenuBtn_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            this.Close();
        }

        internal void LoadQuote(DeskQuote quote)
        {
            nameView.Text = quote.customerName;
            dateView.Text = quote.date.ToString("MM/dd/yyyy");
            widthView.Text = quote.width.ToString()+" in.";
            depthView.Text = quote.depth.ToString()+" in.";
            drawerView.Text = quote.drawers.ToString();
            materialView.Text = quote.material.ToString();
            orderView.Text = quote.order.ToString() + " days";
            priceView.Text = "$"+quote.price.ToString();

        }
    }
}
