
namespace MegaDesk_Melo
{
    partial class SearchQuotes
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
            this.searchDataGridView = new System.Windows.Forms.DataGridView();
            this.searchCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.displayAllButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchDataGridView
            // 
            this.searchDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchDataGridView.Location = new System.Drawing.Point(12, 117);
            this.searchDataGridView.Name = "searchDataGridView";
            this.searchDataGridView.RowTemplate.Height = 25;
            this.searchDataGridView.Size = new System.Drawing.Size(863, 232);
            this.searchDataGridView.TabIndex = 0;
            this.searchDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // searchCombobox
            // 
            this.searchCombobox.FormattingEnabled = true;
            this.searchCombobox.Location = new System.Drawing.Point(102, 61);
            this.searchCombobox.Name = "searchCombobox";
            this.searchCombobox.Size = new System.Drawing.Size(121, 23);
            this.searchCombobox.TabIndex = 1;
            this.searchCombobox.SelectedIndexChanged += new System.EventHandler(this.searchCombobox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select Material";
            // 
            // displayAllButton
            // 
            this.displayAllButton.Location = new System.Drawing.Point(777, 61);
            this.displayAllButton.Name = "displayAllButton";
            this.displayAllButton.Size = new System.Drawing.Size(98, 23);
            this.displayAllButton.TabIndex = 3;
            this.displayAllButton.Text = "Display All";
            this.displayAllButton.UseVisualStyleBackColor = true;
            this.displayAllButton.Click += new System.EventHandler(this.displayAllButton_Click);
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 361);
            this.Controls.Add(this.displayAllButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchCombobox);
            this.Controls.Add(this.searchDataGridView);
            this.Name = "SearchQuotes";
            this.Text = "SearchQuotes";
            this.Load += new System.EventHandler(this.SearchQuotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.searchDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView searchDataGridView;
        private System.Windows.Forms.ComboBox searchCombobox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button displayAllButton;
    }
}