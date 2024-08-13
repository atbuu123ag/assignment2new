namespace assignment2new
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            addToolStripMenuItem = new ToolStripMenuItem();
            manageInvoicesToolStripMenuItem = new ToolStripMenuItem();
            manageInvoices = new ManageInvoices();
            addInvoice = new AddInvoice();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { addToolStripMenuItem, manageInvoicesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1170, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(102, 24);
            addToolStripMenuItem.Text = "Add Invoice";
            addToolStripMenuItem.Click += addToolStripMenuItem_Click;
            // 
            // manageInvoicesToolStripMenuItem
            // 
            manageInvoicesToolStripMenuItem.Name = "manageInvoicesToolStripMenuItem";
            manageInvoicesToolStripMenuItem.Size = new Size(134, 24);
            manageInvoicesToolStripMenuItem.Text = "Manage Invoices";
            manageInvoicesToolStripMenuItem.Click += manageInvoicesToolStripMenuItem_Click;
            // 
            // manageInvoices
            // 
            manageInvoices.BackColor = Color.LightSteelBlue;
            manageInvoices.InvoiceManager = null;
            manageInvoices.Location = new Point(0, 31);
            manageInvoices.Name = "manageInvoices";
            manageInvoices.Size = new Size(1440, 552);
            manageInvoices.TabIndex = 1;
            // 
            // addInvoice
            // 
            addInvoice.BackColor = Color.Khaki;
            addInvoice.InvoiceManager = null;
            addInvoice.Location = new Point(0, 31);
            addInvoice.Name = "addInvoice";
            addInvoice.Size = new Size(1440, 552);
            addInvoice.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1170, 583);
            Controls.Add(addInvoice);
            Controls.Add(manageInvoices);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Water Bills";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem manageInvoicesToolStripMenuItem;
        private ManageInvoices manageInvoices;
        private AddInvoice addInvoice;
    }
}
