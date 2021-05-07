using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MegaDesk_Melo
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {
            //{ Oak, Laminate, Pine, Rosewood, Venner }
            System.Object[] objects = new System.Object[5];
            System.Object[] rushObjects = new System.Object[3];

            objects[0] = "Oak";
            objects[1] = "Laminate";
            objects[2] = "Pine";
            objects[3] = "Rosewood";
            objects[4] = "Venner";

            rushObjects[0] = "3 Days";
            rushObjects[1] = "5 Days";
            rushObjects[2] = "7 Days";

            materialComboBox.Items.AddRange(objects);
            materialComboBox.SelectedIndex = 0;

            rushOptionComboBox.Items.AddRange(rushObjects);
            rushOptionComboBox.SelectedIndex = 0;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            Desk desk = new Desk();
            try
            {
                desk.Width = Validator.ValidateWidth(widthTextBox.Text);
                desk.Depth = Validator.ValidateDepth(depthTextBox.Text);
            }
            catch(ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private bool nonNumberEntered = false;

        private void depthTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;

            if(e.KeyCode < Keys.D0 || e.KeyCode> Keys.D9)
            {
                if(e.KeyCode < Keys.NumPad0 || e.KeyCode < Keys.NumPad9)
                {
                    if(e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }

            if(Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void depthTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered)
                e.Handled = true;
        }

        private void drawerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void drawerTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                int numDrawers = Convert.ToInt32(drawerTextBox.Text);
                int cost = 50 * numDrawers;
                drawerCostLabel.Text = "X  $50.00  =  $" + cost.ToString() + ".00";
            }
            catch (Exception)
            {
                drawerCostLabel.Text = "X  $50.00  =";
            }
        }
    }
}
