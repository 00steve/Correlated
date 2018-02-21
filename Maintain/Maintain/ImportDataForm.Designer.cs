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
            this.excelData = new System.Windows.Forms.DataGridView();
            this.sheetLabel = new System.Windows.Forms.Label();
            this.sheetComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.excelData)).BeginInit();
            this.SuspendLayout();
            // 
            // excelData
            // 
            this.excelData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.excelData.Location = new System.Drawing.Point(12, 77);
            this.excelData.Name = "excelData";
            this.excelData.Size = new System.Drawing.Size(1322, 361);
            this.excelData.TabIndex = 0;
            // 
            // sheetLabel
            // 
            this.sheetLabel.AutoSize = true;
            this.sheetLabel.Location = new System.Drawing.Point(13, 13);
            this.sheetLabel.Name = "sheetLabel";
            this.sheetLabel.Size = new System.Drawing.Size(35, 13);
            this.sheetLabel.TabIndex = 1;
            this.sheetLabel.Text = "Sheet";
            // 
            // sheetComboBox
            // 
            this.sheetComboBox.FormattingEnabled = true;
            this.sheetComboBox.Location = new System.Drawing.Point(77, 10);
            this.sheetComboBox.Name = "sheetComboBox";
            this.sheetComboBox.Size = new System.Drawing.Size(242, 21);
            this.sheetComboBox.TabIndex = 2;
            // 
            // ImportDataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1346, 450);
            this.Controls.Add(this.sheetComboBox);
            this.Controls.Add(this.sheetLabel);
            this.Controls.Add(this.excelData);
            this.Name = "ImportDataForm";
            this.Text = "ImportExcelForm";
            ((System.ComponentModel.ISupportInitialize)(this.excelData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView excelData;
        private System.Windows.Forms.Label sheetLabel;
        private ComboBox sheetComboBox;
    }
}