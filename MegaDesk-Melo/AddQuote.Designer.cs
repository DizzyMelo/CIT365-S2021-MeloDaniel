
namespace MegaDesk_Melo
{
    partial class AddQuote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.depthTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.areaLabel = new System.Windows.Forms.Label();
            this.areaCosLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.drawerTextBox = new System.Windows.Forms.TextBox();
            this.drawerCostLabel = new System.Windows.Forms.Label();
            this.materialComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rushOptionComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(203, 70);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(39, 15);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(248, 70);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(357, 23);
            this.nameTextBox.TabIndex = 1;
            // 
            // depthTextBox
            // 
            this.depthTextBox.Location = new System.Drawing.Point(248, 99);
            this.depthTextBox.Name = "depthTextBox";
            this.depthTextBox.Size = new System.Drawing.Size(100, 23);
            this.depthTextBox.TabIndex = 2;
            this.depthTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.depthTextBox_KeyDown);
            this.depthTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.depthTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Depth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Width";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(406, 99);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(100, 23);
            this.widthTextBox.TabIndex = 3;
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(523, 102);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(34, 15);
            this.areaLabel.TabIndex = 6;
            this.areaLabel.Text = "Area:";
            // 
            // areaCosLabel
            // 
            this.areaCosLabel.AutoSize = true;
            this.areaCosLabel.Location = new System.Drawing.Point(203, 138);
            this.areaCosLabel.Name = "areaCosLabel";
            this.areaCosLabel.Size = new System.Drawing.Size(70, 15);
            this.areaCosLabel.TabIndex = 7;
            this.areaCosLabel.Text = "Area Cost: $";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Drawers";
            // 
            // drawerTextBox
            // 
            this.drawerTextBox.Location = new System.Drawing.Point(248, 175);
            this.drawerTextBox.Name = "drawerTextBox";
            this.drawerTextBox.Size = new System.Drawing.Size(100, 23);
            this.drawerTextBox.TabIndex = 4;
            this.drawerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.drawerTextBox_KeyPress);
            this.drawerTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.drawerTextBox_KeyUp);
            // 
            // drawerCostLabel
            // 
            this.drawerCostLabel.AutoSize = true;
            this.drawerCostLabel.Location = new System.Drawing.Point(361, 178);
            this.drawerCostLabel.Name = "drawerCostLabel";
            this.drawerCostLabel.Size = new System.Drawing.Size(67, 15);
            this.drawerCostLabel.TabIndex = 10;
            this.drawerCostLabel.Text = "X  $50.00  =";
            // 
            // materialComboBox
            // 
            this.materialComboBox.FormattingEnabled = true;
            this.materialComboBox.Location = new System.Drawing.Point(248, 227);
            this.materialComboBox.Name = "materialComboBox";
            this.materialComboBox.Size = new System.Drawing.Size(121, 23);
            this.materialComboBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Material";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 230);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Material Cost: $";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Rush Option Cost: $";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(169, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Rush Option";
            // 
            // rushOptionComboBox
            // 
            this.rushOptionComboBox.FormattingEnabled = true;
            this.rushOptionComboBox.Location = new System.Drawing.Point(248, 256);
            this.rushOptionComboBox.Name = "rushOptionComboBox";
            this.rushOptionComboBox.Size = new System.Drawing.Size(121, 23);
            this.rushOptionComboBox.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(198, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 15);
            this.label9.TabIndex = 18;
            this.label9.Text = "Total: $";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(286, 381);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(209, 36);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // AddQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rushOptionComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.materialComboBox);
            this.Controls.Add(this.drawerCostLabel);
            this.Controls.Add(this.drawerTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.areaCosLabel);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.depthTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.nameLabel);
            this.Name = "AddQuote";
            this.Text = "Total: $";
            this.Load += new System.EventHandler(this.AddQuote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox depthTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Label areaCosLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox drawerTextBox;
        private System.Windows.Forms.Label drawerCostLabel;
        private System.Windows.Forms.ComboBox materialComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox rushOptionComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button calculateButton;
    }
}