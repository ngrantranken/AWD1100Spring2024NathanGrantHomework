namespace HW03_02a
{
    partial class frmOrdersValidation
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
            lblItemNumber = new Label();
            lblQuantity = new Label();
            lblEstDeliveryDays = new Label();
            lblValidOrNot = new Label();
            txtItemNumber = new TextBox();
            txtQuantity = new TextBox();
            txtEstDeliveryDays = new TextBox();
            btnValidate = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblItemNumber
            // 
            lblItemNumber.AutoSize = true;
            lblItemNumber.Location = new Point(48, 20);
            lblItemNumber.Name = "lblItemNumber";
            lblItemNumber.Size = new Size(134, 15);
            lblItemNumber.TabIndex = 0;
            lblItemNumber.Text = "Item Number [100, 999]:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(91, 46);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(91, 15);
            lblQuantity.TabIndex = 1;
            lblQuantity.Text = "Quantity [1, 12]:";
            // 
            // lblEstDeliveryDays
            // 
            lblEstDeliveryDays.AutoSize = true;
            lblEstDeliveryDays.Location = new Point(12, 72);
            lblEstDeliveryDays.Name = "lblEstDeliveryDays";
            lblEstDeliveryDays.Size = new Size(170, 15);
            lblEstDeliveryDays.TabIndex = 2;
            lblEstDeliveryDays.Text = "Estimated Delivery Days [1, 30]:";
            // 
            // lblValidOrNot
            // 
            lblValidOrNot.AutoSize = true;
            lblValidOrNot.Location = new Point(78, 176);
            lblValidOrNot.Name = "lblValidOrNot";
            lblValidOrNot.Size = new Size(0, 15);
            lblValidOrNot.TabIndex = 3;
            // 
            // txtItemNumber
            // 
            txtItemNumber.Location = new Point(188, 12);
            txtItemNumber.Name = "txtItemNumber";
            txtItemNumber.Size = new Size(100, 23);
            txtItemNumber.TabIndex = 4;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(188, 38);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 5;
            // 
            // txtEstDeliveryDays
            // 
            txtEstDeliveryDays.Location = new Point(188, 64);
            txtEstDeliveryDays.Name = "txtEstDeliveryDays";
            txtEstDeliveryDays.Size = new Size(100, 23);
            txtEstDeliveryDays.TabIndex = 6;
            // 
            // btnValidate
            // 
            btnValidate.Location = new Point(188, 93);
            btnValidate.Name = "btnValidate";
            btnValidate.Size = new Size(100, 23);
            btnValidate.TabIndex = 7;
            btnValidate.Text = "Validate";
            btnValidate.UseVisualStyleBackColor = true;
            btnValidate.Click += btnValidate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(188, 118);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(100, 23);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(188, 147);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(100, 23);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // frmOrdersValidation
            // 
            AcceptButton = btnValidate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnExit;
            ClientSize = new Size(345, 227);
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
            Name = "frmOrdersValidation";
            Text = "Order Validator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblItemNumber;
        private Label lblQuantity;
        private Label lblEstDeliveryDays;
        private Label lblValidOrNot;
        private TextBox txtItemNumber;
        private TextBox txtQuantity;
        private TextBox txtEstDeliveryDays;
        private Button btnValidate;
        private Button btnClear;
        private Button btnExit;
    }
}
