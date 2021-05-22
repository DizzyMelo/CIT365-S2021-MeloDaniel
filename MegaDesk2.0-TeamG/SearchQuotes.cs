using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MegaDesk_Melo
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            searchCombobox.DataSource = Enum.GetValues(typeof(DesktopMaterial));
            //DeskQuote quote = new DeskQuote();
            //List<ShowQuote> items = quote.ReadQuotes();
            //searchDataGridView.DataSource = items;
        }

        private void searchCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DeskQuote quote = new DeskQuote();
            DesktopMaterial material = (DesktopMaterial) searchCombobox.SelectedItem;
            List<ShowQuote> items = quote.FilterQuotes(material);
            searchDataGridView.DataSource = items;
        }

        private void displayAllButton_Click(object sender, EventArgs e)
        {
            searchCombobox.DataSource = Enum.GetValues(typeof(DesktopMaterial));
            DeskQuote quote = new DeskQuote();
            List<ShowQuote> items = quote.ReadQuotes("quotes.json");
            searchDataGridView.DataSource = items;
        }
    }
}
