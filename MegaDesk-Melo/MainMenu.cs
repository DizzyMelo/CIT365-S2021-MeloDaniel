using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Melo
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to exit the application?", "Confirm", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
                Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddQuote addquote = new AddQuote();
            addquote.Show();
            //Hide();
        }

        private void viewQuotesButton_Click(object sender, EventArgs e)
        {
            ViewAllQuotes view = new ViewAllQuotes();
            view.Show();
        }

        private void searchQuotesButton_Click(object sender, EventArgs e)
        {
            SearchQuotes search = new SearchQuotes();
            search.Show();
        }
    }
}
