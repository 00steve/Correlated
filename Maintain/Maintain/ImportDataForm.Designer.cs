using System.Windows.Forms;

namespace Maintain
{
    partial class ImportDataForm : Form
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
            this.data = new System.Windows.Forms.DataGridView();
            this.sheetLabel = new System.Windows.Forms.Label();
            this.sheetComboBox = new System.Windows.Forms.ComboBox();
            this.measuresList = new System.Windows.Forms.ListBox();
            this.measuresLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.measureLabelsTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // data
            // 
            this.data.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data.Location = new System.Drawing.Point(403, 13);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(931, 614);
            this.data.TabIndex = 0;
            // 
            // sheetLabel
            // 
            this.sheetLabel.AutoSize = true;
            this.sheetLabel.Location = new System.Drawing.Point(12, 16);
            this.sheetLabel.Name = "sheetLabel";
            this.sheetLabel.Size = new System.Drawing.Size(35, 13);
            this.sheetLabel.TabIndex = 1;
            this.sheetLabel.Text = "Sheet";
            // 
            // sheetComboBox
            // 
            this.sheetComboBox.FormattingEnabled = true;
            this.sheetComboBox.Location = new System.Drawing.Point(116, 13);
            this.sheetComboBox.Name = "sheetComboBox";
            this.sheetComboBox.Size = new System.Drawing.Size(270, 21);
            this.sheetComboBox.TabIndex = 2;
            // 
            // measuresList
            // 
            this.measuresList.FormattingEnabled = true;
            this.measuresList.Location = new System.Drawing.Point(116, 100);
            this.measuresList.Name = "measuresList";
            this.measuresList.Size = new System.Drawing.Size(270, 95);
            this.measuresList.TabIndex = 3;
            // 
            // measuresLabel
            // 
            this.measuresLabel.AutoSize = true;
            this.measuresLabel.Location = new System.Drawing.Point(12, 101);
            this.measuresLabel.Name = "measuresLabel";
            this.measuresLabel.Size = new System.Drawing.Size(59, 13);
            this.measuresLabel.TabIndex = 4;
            this.measuresLabel.Text = "Measure(s)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Measure labels";
            // 
            // measureLabelsTextBox
            // 
            this.measureLabelsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.measureLabelsTextBox.Location = new System.Drawing.Point(116, 40);
            this.measureLabelsTextBox.Name = "measureLabelsTextBox";
            this.measureLabelsTextBox.Size = new System.Drawing.Size(270, 20);
            this.measureLabelsTextBox.TabIndex = 6;
            // 
            // ImportDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 639);
            this.Controls.Add(this.measureLabelsTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.measuresLabel);
            this.Controls.Add(this.measuresList);
            this.Controls.Add(this.sheetComboBox);
            this.Controls.Add(this.sheetLabel);
            this.Controls.Add(this.data);
            this.Name = "ImportDataForm";
            this.Text = "ImportExcelForm";
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data;
        private System.Windows.Forms.Label sheetLabel;
        private ComboBox sheetComboBox;
        private ListBox measuresList;
        private Label measuresLabel;
        private Label label1;
        private TextBox measureLabelsTextBox;
    }
}