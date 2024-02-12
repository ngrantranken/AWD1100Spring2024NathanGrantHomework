namespace HW03_02b
{
    partial class frmOrdersExceptions
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
            btnExit = new Button();
            btnClear = new Button();
            btnValidate = new Button();
            txtEstDeliveryDays = new TextBox();
            txtQuantity = new TextBox();
            txtItemNumber = new TextBox();
            lblValidOrNot = new Label();
            lblEstDeliveryDays = new Label();
            lblQuantity = new Label();
            lblItemNumber = new Label();
            SuspendLayout();
            // 
            // btnExit
            // 
            btnExit.Location = new Point(186, 149);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 23);
            btnExit.TabIndex = 19;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(186, 120);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 23);
            btnClear.TabIndex = 18;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(186, 95);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(100, 23);
            btnValidate.TabIndex = 17;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += btnValidate_Click;
            // 
            // txtEstDeliveryDays
            // 
            txtEstDeliveryDays.Location = new Point(186, 66);
            txtEstDeliveryDays.Name = "txtEstDeliveryDays";
            txtEstDeliveryDays.Size = new Size(100, 23);
            txtEstDeliveryDays.TabIndex = 16;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(186, 40);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 15;
            // 
            // txtItemNumber
            // 
            txtItemNumber.Location = new Point(186, 14);
            txtItemNumber.Name = "txtItemNumber";
            txtItemNumber.Size = new Size(100, 23);
            txtItemNumber.TabIndex = 14;
            // 
            // lblValidOrNot
            // 
            lblValidOrNot.AutoSize = true;
            lblValidOrNot.Location = new Point(76, 178);
            lblValidOrNot.Name = "lblValidOrNot";
            lblValidOrNot.Size = new Size(0, 15);
            lblValidOrNot.TabIndex = 13;
            // 
            // lblEstDeliveryDays
            // 
            lblEstDeliveryDays.AutoSize = true;
            lblEstDeliveryDays.Location = new Point(10, 74);
            lblEstDeliveryDays.Name = "lblEstDeliveryDays";
            lblEstDeliveryDays.Size = new Size(170, 15);
            lblEstDeliveryDays.TabIndex = 12;
            lblEstDeliveryDays.Text = "Estimated Delivery Days [1, 30]:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(89, 48);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(91, 15);
            lblQuantity.TabIndex = 11;
            lblQuantity.Text = "Quantity [1, 12]:";
            // 
            // lblItemNumber
            // 
            lblItemNumber.AutoSize = true;
            lblItemNumber.Location = new Point(46, 22);
            lblItemNumber.Name = "lblItemNumber";
            lblItemNumber.Size = new Size(134, 15);
            lblItemNumber.TabIndex = 10;
            lblItemNumber.Text = "Item Number [100, 999]:";
            // 
            // frmOrdersExceptions
            // 
            AcceptButton = btnValidate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(325, 215);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnValidate);
            Controls.Add(txtEstDeliveryDays);
            Controls.Add(txtQuantity);
            Controls.Add(txtItemNumber);
            Controls.Add(lblValidOrNot);
            Controls.Add(lblEstDeliveryDays);
            Controls.Add(lblQuantity);
            Controls.Add(lblItemNumber);
            Name = "frmOrdersExceptions";
            Text = "Order Validator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnExit;
        private Button btnClear;
        private Button btnValidate;
        private TextBox txtEstDeliveryDays;
        private TextBox txtQuantity;
        private TextBox txtItemNumber;
        private Label lblValidOrNot;
        private Label lblEstDeliveryDays;
        private Label lblQuantity;
        private Label lblItemNumber;
    }
}
