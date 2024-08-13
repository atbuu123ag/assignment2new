namespace assignment2new
{
    partial class ManageInvoices
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            invoicesDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)invoicesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // invoicesDataGridView
            // 
            invoicesDataGridView.BackgroundColor = Color.LightSteelBlue;
            invoicesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            invoicesDataGridView.Location = new Point(0, 0);
            invoicesDataGridView.Name = "invoicesDataGridView";
            invoicesDataGridView.RowHeadersWidth = 51;
            invoicesDataGridView.Size = new Size(1429, 564);
            invoicesDataGridView.TabIndex = 0;
            // 
            // ManageInvoices
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            Controls.Add(invoicesDataGridView);
            Name = "ManageInvoices";
            Size = new Size(1432, 580);
            ((System.ComponentModel.ISupportInitialize)invoicesDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView invoicesDataGridView;
    }
}
