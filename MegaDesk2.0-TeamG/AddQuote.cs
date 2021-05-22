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

        DeskQuote saveQuote;

        private void AddQuote_Load(object sender, EventArgs e)
        {
            System.Object[] rushObjects = new System.Object[4];

            rushObjects[0] = "3 Days";
            rushObjects[1] = "5 Days";
            rushObjects[2] = "7 Days";
            rushObjects[3] = "14 Days";


            materialComboBox.DataSource = Enum.GetValues(typeof(DesktopMaterial));
            materialComboBox.SelectedIndex = 0;

            rushOptionComboBox.Items.AddRange(rushObjects);
            rushOptionComboBox.SelectedIndex = 3;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            Desk desk = new Desk();
            try
            {
                desk.Width = Convert.ToInt32(widthTextBox.Text);
                desk.Depth = Convert.ToInt32(depthTextBox.Text);
                desk.NumDrawers = Convert.ToInt32(drawerTextBox.Text);
                //hard-coded
                desk.SurfaceMaterial = (DesktopMaterial) materialComboBox.SelectedIndex;
            }
            catch (FormatException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            finally
            {
                DeskQuote quote = new DeskQuote();
                quote.Name = nameTextBox.Text;
                quote.Desk = desk;
                quote.Date = DateTime.Now;
                quote.RushOption = setOrderPeriod(rushOptionComboBox.SelectedIndex);
                int total = quote.calculateTotalPrice();
                totalLabel.Text = "Total: $" + total.ToString() + ".00";

                saveQuote = quote;
            }
            
        }

        private int setOrderPeriod(int index)
        {
            switch (index)
            {
                case 0:
                    return 3;
                case 1:
                    return 5;
                case 2:
                    return 7; 
                default:
                    return 14;
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

        private void depthTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(depthTextBox, "");
        }

        private void depthTextBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            int input;
            try 
            {
                input = Convert.ToInt32(depthTextBox.Text);
            }
            catch (FormatException)
            {
                e.Cancel = true;
                errorMsg = "Please, provide an integer number!";
                this.errorProvider1.SetError(depthTextBox, errorMsg);
                return;
            }
            
            if (!Validator.ValidateDepth(input, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                depthTextBox.Select(0, depthTextBox.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(depthTextBox, errorMsg);
            }
        }

        private void widthTextBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            int input;
            try
            {
                input = Convert.ToInt32(widthTextBox.Text);
            }
            catch (FormatException)
            {
                e.Cancel = true;
                errorMsg = "Please, provide an integer number!";
                this.errorProvider1.SetError(widthTextBox, errorMsg);
                return;
            }

            if (!Validator.ValidateWidth(input, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                widthTextBox.Select(0, widthTextBox.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(widthTextBox, errorMsg);
            }
        }

        private void widthTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(widthTextBox, "");
        }

        private void depthTextBox_TextChanged(object sender, EventArgs e)
        {
            this.calculateArea();
        }

        private void widthTextBox_TextChanged(object sender, EventArgs e)
        {
            this.calculateArea();
        }

        private void calculateArea()
        {
            try
            {
                int size = Convert.ToInt32(widthTextBox.Text) * Convert.ToInt32(depthTextBox.Text);
                areaLabel.Text = "Area: " + size.ToString() + " in";
                int cost = size < 1000 ? 0 : (size - 1000);
                areaCosLabel.Text = $"Area Cost: ${cost}.00";
            }
            catch (Exception)
            {
                areaLabel.Text = "Area:";
                areaCosLabel.Text = "Area Cost: $0.00";
            }
        }

        private void materialComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string material = materialComboBox.GetItemText(materialComboBox.SelectedItem);
            int cost = selectDesktopMaterialCost(material);
            materialCostLabel.Text = $"Material Cost: ${cost}.00";
        }

        private void rushOptionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int depth = Convert.ToInt32(depthTextBox.Text);
                int width = Convert.ToInt32(widthTextBox.Text);
                int cost = selectRushOrderCost(depth, width, rushOptionComboBox.SelectedIndex);
                rushOptionCostLabel.Text = $"Rush Option Cost: ${cost}.00";
            }
            catch(Exception)
            {
                rushOptionCostLabel.Text = $"Rush Option Cost: $0.00";
            }
            
        }

        private int selectDesktopMaterialCost(String material)
        {
            int cost = 0;
            switch (material)
            {
                case "Oak":
                    cost = 200;
                    break;

                case "Laminate":
                    cost = 100;
                    break;

                case "Pine":
                    cost = 50;
                    break;

                case "Rosewood":
                    cost = 300;
                    break;

                case "Venner":
                    cost = 125;
                    break;
            }
            return cost;
        }

        private int selectRushOrderCost(int depth, int width, int rushOption)
        {
            int cost = 0;
            int size = width * depth;

            switch (rushOption)
            {
                case 0:
                    if (size < 1000)
                        cost = 60;
                    else if (size >= 1000 && size < 2000)
                        cost = 70;
                    else
                        cost = 80;
                    break;
                case 1:
                    if (size < 1000)
                        cost = 40;
                    else if (size >= 1000 && size < 2000)
                        cost = 50;
                    else
                        cost = 60;
                    break;
                case 2:
                    if (size < 1000)
                        cost = 30;
                    else if (size >= 1000 && size < 2000)
                        cost = 35;
                    else
                        cost = 40;
                    break;
                default:
                    cost = 0;
                    break;
            }

            return cost;
        }

        private void drawerTextBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            int input;
            try
            {
                input = Convert.ToInt32(drawerTextBox.Text);
            }
            catch (FormatException)
            {
                e.Cancel = true;
                errorMsg = "Please, provide an integer number!";
                this.errorProvider1.SetError(drawerTextBox, errorMsg);
                return;
            }

            if (!Validator.ValidateNumDrawers(input, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                drawerTextBox.Select(0, drawerTextBox.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(drawerTextBox, errorMsg);
            }
        }

        private void drawerTextBox_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(drawerTextBox, "");
        }

        private void nameTextBox_Validating(object sender, CancelEventArgs e)
        {
            string errorMsg;
            string name = nameTextBox.Text;
            
            if (!Validator.ValidateName(name, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                nameTextBox.Select(0, nameTextBox.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(nameTextBox, errorMsg);
            }
        }

        private void nameTextBox_Validated(object sender, EventArgs e)
        {
            this.errorProvider1.SetError(nameTextBox, "");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (saveQuote == null)
            {
                MessageBox.Show("Please, complete the quote!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            bool res = saveQuote.Save(saveQuote, "quotes.json");

            if(res)
            {
                MessageBox.Show("Quote saved", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Something went wrong while saving the quote", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
