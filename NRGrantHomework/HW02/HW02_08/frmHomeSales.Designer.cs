namespace HW02_08
{
    partial class frmHomeSales
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
            lblSale = new Label();
            lblSalespeople = new Label();
            lblDSales = new Label();
            lblESales = new Label();
            lblFSales = new Label();
            lblTotalSales = new Label();
            lblTopSalesperson = new Label();
            txtSale = new TextBox();
            btnDanielle = new Button();
            btnEdward = new Button();
            btnFrancis = new Button();
            SuspendLayout();
            // 
            // lblSale
            // 
            lblSale.AutoSize = true;
            lblSale.Location = new Point(12, 9);
            lblSale.Name = "lblSale";
            lblSale.Size = new Size(137, 15);
            lblSale.TabIndex = 0;
            lblSale.Text = "How much was the sale?";
            // 
            // lblSalespeople
            // 
            lblSalespeople.AutoSize = true;
            lblSalespeople.Location = new Point(12, 53);
            lblSalespeople.Name = "lblSalespeople";
            lblSalespeople.Size = new Size(113, 15);
            lblSalespeople.TabIndex = 1;
            lblSalespeople.Text = "Who made the sale?";
            // 
            // lblDSales
            // 
            lblDSales.AutoSize = true;
            lblDSales.Location = new Point(12, 97);
            lblDSales.Name = "lblDSales";
            lblDSales.Size = new Size(84, 15);
            lblDSales.TabIndex = 2;
            lblDSales.Text = "Danielle Sales: ";
            // 
            // lblESales
            // 
            lblESales.AutoSize = true;
            lblESales.Location = new Point(12, 112);
            lblESales.Name = "lblESales";
            lblESales.Size = new Size(81, 15);
            lblESales.TabIndex = 3;
            lblESales.Text = "Edward Sales: ";
            // 
            // lblFSales
            // 
            lblFSales.AutoSize = true;
            lblFSales.Location = new Point(12, 127);
            lblFSales.Name = "lblFSales";
            lblFSales.Size = new Size(79, 15);
            lblFSales.TabIndex = 4;
            lblFSales.Text = "Francis Sales: ";
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Location = new Point(12, 142);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(73, 15);
            lblTotalSales.TabIndex = 5;
            lblTotalSales.Text = "Grand Total: ";
            // 
            // lblTopSalesperson
            // 
            lblTopSalesperson.AutoSize = true;
            lblTopSalesperson.Location = new Point(12, 157);
            lblTopSalesperson.Name = "lblTopSalesperson";
            lblTopSalesperson.Size = new Size(0, 15);
            lblTopSalesperson.TabIndex = 6;
            // 
            // txtSale
            // 
            txtSale.Location = new Point(12, 27);
            txtSale.Name = "txtSale";
            txtSale.Size = new Size(137, 23);
            txtSale.TabIndex = 7;
            // 
            // btnDanielle
            // 
            btnDanielle.Location = new Point(12, 71);
            btnDanielle.Name = "btnDanielle";
            btnDanielle.Size = new Size(75, 23);
            btnDanielle.TabIndex = 8;
            btnDanielle.Text = "Danielle";
            btnDanielle.UseVisualStyleBackColor = true;
            btnDanielle.Click += btnDanielle_Click;
            // 
            // btnEdward
            // 
            btnEdward.Location = new Point(93, 71);
            btnEdward.Name = "btnEdward";
            btnEdward.Size = new Size(75, 23);
            btnEdward.TabIndex = 9;
            btnEdward.Text = "Edward";
            btnEdward.UseVisualStyleBackColor = true;
            btnEdward.Click += btnEdward_Click;
            // 
            // btnFrancis
            // 
            btnFrancis.Location = new Point(174, 71);
            btnFrancis.Name = "btnFrancis";
            btnFrancis.Size = new Size(75, 23);
            btnFrancis.TabIndex = 10;
            btnFrancis.Text = "Francis";
            btnFrancis.UseVisualStyleBackColor = true;
            btnFrancis.Click += btnFrancis_Click;
            // 
            // frmHomeSales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(260, 179);
            Controls.Add(btnFrancis);
            Controls.Add(btnEdward);
            Controls.Add(btnDanielle);
            Controls.Add(txtSale);
            Controls.Add(lblTopSalesperson);
            Controls.Add(lblTotalSales);
            Controls.Add(lblFSales);
            Controls.Add(lblESales);
            Controls.Add(lblDSales);
            Controls.Add(lblSalespeople);
            Controls.Add(lblSale);
            Name = "frmHomeSales";
            Text = "Home Sales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSale;
        private Label lblSalespeople;
        private Label lblDSales;
        private Label lblESales;
        private Label lblFSales;
        private Label lblTotalSales;
        private Label lblTopSalesperson;
        private TextBox txtSale;
        private Button btnDanielle;
        private Button btnEdward;
        private Button btnFrancis;
    }
}
