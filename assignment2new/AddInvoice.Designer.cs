namespace assignment2new
{
    partial class AddInvoice
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
            customer = new Label();
            customerCodeInput = new TextBox();
            label2 = new Label();
            numberOfPeopleInput = new TextBox();
            label3 = new Label();
            customerNameInput = new TextBox();
            label4 = new Label();
            thisMonthNumberInput = new TextBox();
            label5 = new Label();
            lastMonthNumberInput = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            calculateButton = new Button();
            consumptionLabel = new Label();
            priceLabel = new Label();
            subtotalLabel = new Label();
            envFeeLabel = new Label();
            VATLabel = new Label();
            totalLabel = new Label();
            customerTypeCombobox = new ComboBox();
            currentMonthCombobox = new ComboBox();
            SuspendLayout();
            // 
            // customer
            // 
            customer.AutoSize = true;
            customer.Location = new Point(39, 24);
            customer.Name = "customer";
            customer.Size = new Size(111, 20);
            customer.TabIndex = 0;
            customer.Text = "Customer Code";
            customer.Click += label1_Click;
            // 
            // customerCodeInput
            // 
            customerCodeInput.Location = new Point(39, 60);
            customerCodeInput.Name = "customerCodeInput";
            customerCodeInput.Size = new Size(236, 27);
            customerCodeInput.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(498, 24);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 2;
            label2.Text = "Customer Type";
            // 
            // numberOfPeopleInput
            // 
            numberOfPeopleInput.Location = new Point(498, 147);
            numberOfPeopleInput.Name = "numberOfPeopleInput";
            numberOfPeopleInput.Size = new Size(236, 27);
            numberOfPeopleInput.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(498, 111);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 4;
            label3.Text = "Number of People";
            // 
            // customerNameInput
            // 
            customerNameInput.Location = new Point(39, 147);
            customerNameInput.Name = "customerNameInput";
            customerNameInput.Size = new Size(236, 27);
            customerNameInput.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 111);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 6;
            label4.Text = "Customer Name";
            // 
            // thisMonthNumberInput
            // 
            thisMonthNumberInput.Location = new Point(498, 230);
            thisMonthNumberInput.Name = "thisMonthNumberInput";
            thisMonthNumberInput.Size = new Size(236, 27);
            thisMonthNumberInput.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(498, 194);
            label5.Name = "label5";
            label5.Size = new Size(236, 20);
            label5.TabIndex = 8;
            label5.Text = "This month's water meter readings";
            // 
            // lastMonthNumberInput
            // 
            lastMonthNumberInput.Location = new Point(39, 230);
            lastMonthNumberInput.Name = "lastMonthNumberInput";
            lastMonthNumberInput.Size = new Size(236, 27);
            lastMonthNumberInput.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(39, 194);
            label6.Name = "label6";
            label6.Size = new Size(236, 20);
            label6.TabIndex = 10;
            label6.Text = "Last month's water meter readings";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 303);
            label7.Name = "label7";
            label7.Size = new Size(104, 20);
            label7.TabIndex = 12;
            label7.Text = "Current Month";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(772, 31);
            label8.Name = "label8";
            label8.Size = new Size(173, 20);
            label8.TabIndex = 14;
            label8.Text = "Amount of consumption:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(772, 70);
            label9.Name = "label9";
            label9.Size = new Size(44, 20);
            label9.TabIndex = 15;
            label9.Text = "Price:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(772, 147);
            label10.Name = "label10";
            label10.Size = new Size(128, 20);
            label10.TabIndex = 17;
            label10.Text = "Environment Fees:";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(772, 108);
            label11.Name = "label11";
            label11.Size = new Size(68, 20);
            label11.TabIndex = 16;
            label11.Text = "Subtotal:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(772, 224);
            label12.Name = "label12";
            label12.Size = new Size(96, 41);
            label12.TabIndex = 19;
            label12.Text = "Total:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(772, 185);
            label13.Name = "label13";
            label13.Size = new Size(75, 20);
            label13.TabIndex = 18;
            label13.Text = "VAT(10%):";
            // 
            // calculateButton
            // 
            calculateButton.BackColor = SystemColors.MenuHighlight;
            calculateButton.Location = new Point(512, 312);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(183, 59);
            calculateButton.TabIndex = 20;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = false;
            calculateButton.Click += calculateButton_Click;
            // 
            // consumptionLabel
            // 
            consumptionLabel.Location = new Point(959, 27);
            consumptionLabel.Name = "consumptionLabel";
            consumptionLabel.Size = new Size(190, 43);
            consumptionLabel.TabIndex = 22;
            consumptionLabel.Text = "0";
            consumptionLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // priceLabel
            // 
            priceLabel.Location = new Point(959, 70);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(190, 20);
            priceLabel.TabIndex = 23;
            priceLabel.Text = "0";
            priceLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // subtotalLabel
            // 
            subtotalLabel.Location = new Point(959, 108);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new Size(190, 20);
            subtotalLabel.TabIndex = 24;
            subtotalLabel.Text = "0";
            subtotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // envFeeLabel
            // 
            envFeeLabel.Location = new Point(959, 147);
            envFeeLabel.Name = "envFeeLabel";
            envFeeLabel.Size = new Size(190, 20);
            envFeeLabel.TabIndex = 25;
            envFeeLabel.Text = "0";
            envFeeLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // VATLabel
            // 
            VATLabel.Location = new Point(959, 185);
            VATLabel.Name = "VATLabel";
            VATLabel.Size = new Size(190, 20);
            VATLabel.TabIndex = 26;
            VATLabel.Text = "0";
            VATLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // totalLabel
            // 
            totalLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalLabel.Location = new Point(878, 217);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(271, 54);
            totalLabel.TabIndex = 27;
            totalLabel.Text = "0";
            totalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // customerTypeCombobox
            // 
            customerTypeCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            customerTypeCombobox.DropDownWidth = 300;
            customerTypeCombobox.FormattingEnabled = true;
            customerTypeCombobox.Items.AddRange(new object[] { "Household customer", "Administrative agency, public services", "Production units", "Business services" });
            customerTypeCombobox.Location = new Point(498, 59);
            customerTypeCombobox.Name = "customerTypeCombobox";
            customerTypeCombobox.Size = new Size(236, 28);
            customerTypeCombobox.TabIndex = 28;
            customerTypeCombobox.SelectedIndexChanged += customerTypeCombobox_SelectedIndexChanged;
            // 
            // currentMonthCombobox
            // 
            currentMonthCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            currentMonthCombobox.FormattingEnabled = true;
            currentMonthCombobox.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            currentMonthCombobox.Location = new Point(39, 343);
            currentMonthCombobox.Name = "currentMonthCombobox";
            currentMonthCombobox.Size = new Size(236, 28);
            currentMonthCombobox.TabIndex = 29;
            // 
            // AddInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Khaki;
            Controls.Add(currentMonthCombobox);
            Controls.Add(customerTypeCombobox);
            Controls.Add(totalLabel);
            Controls.Add(VATLabel);
            Controls.Add(envFeeLabel);
            Controls.Add(subtotalLabel);
            Controls.Add(priceLabel);
            Controls.Add(consumptionLabel);
            Controls.Add(calculateButton);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(lastMonthNumberInput);
            Controls.Add(label6);
            Controls.Add(thisMonthNumberInput);
            Controls.Add(label5);
            Controls.Add(customerNameInput);
            Controls.Add(label4);
            Controls.Add(numberOfPeopleInput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(customerCodeInput);
            Controls.Add(customer);
            Name = "AddInvoice";
            Size = new Size(1359, 483);
            Load += AddInvoice_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label customer;
        private TextBox customerCodeInput;
        private Label label2;
        private TextBox numberOfPeopleInput;
        private Label label3;
        private TextBox customerNameInput;
        private Label label4;
        private TextBox thisMonthNumberInput;
        private Label label5;
        private TextBox lastMonthNumberInput;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Button calculateButton;
        private Label consumptionLabel;
        private Label priceLabel;
        private Label subtotalLabel;
        private Label envFeeLabel;
        private Label VATLabel;
        private Label totalLabel;
        private ComboBox customerTypeCombobox;
        private ComboBox currentMonthCombobox;
    }
}
