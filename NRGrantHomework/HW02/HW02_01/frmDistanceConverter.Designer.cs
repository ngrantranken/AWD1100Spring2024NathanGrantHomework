namespace HW02_01
{
    partial class frmDistanceConverter
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
            lblMiles = new Label();
            lblKilometers = new Label();
            lblResult = new Label();
            txtMiles = new TextBox();
            txtKilometers = new TextBox();
            btnConvertToKm = new Button();
            btnConvertToMi = new Button();
            SuspendLayout();
            // 
            // lblMiles
            // 
            lblMiles.AutoSize = true;
            lblMiles.Font = new Font("Segoe UI", 12F);
            lblMiles.Location = new Point(23, 44);
            lblMiles.Name = "lblMiles";
            lblMiles.Size = new Size(130, 21);
            lblMiles.TabIndex = 0;
            lblMiles.Text = "Distance in miles:";
            // 
            // lblKilometers
            // 
            lblKilometers.AutoSize = true;
            lblKilometers.Font = new Font("Segoe UI", 12F);
            lblKilometers.Location = new Point(190, 44);
            lblKilometers.Name = "lblKilometers";
            lblKilometers.Size = new Size(166, 21);
            lblKilometers.TabIndex = 1;
            lblKilometers.Text = "Distance in kilometers:";
            // 
            // lblResult
            // 
            lblResult.AutoSize = true;
            lblResult.Font = new Font("Segoe UI", 12F);
            lblResult.Location = new Point(190, 180);
            lblResult.Name = "lblResult";
            lblResult.Size = new Size(0, 21);
            lblResult.TabIndex = 2;
            // 
            // txtMiles
            // 
            txtMiles.Font = new Font("Segoe UI", 12F);
            txtMiles.Location = new Point(53, 68);
            txtMiles.Name = "txtMiles";
            txtMiles.Size = new Size(100, 29);
            txtMiles.TabIndex = 3;
            // 
            // txtKilometers
            // 
            txtKilometers.Font = new Font("Segoe UI", 12F);
            txtKilometers.Location = new Point(256, 68);
            txtKilometers.Name = "txtKilometers";
            txtKilometers.Size = new Size(100, 29);
            txtKilometers.TabIndex = 4;
            // 
            // btnConvertToKm
            // 
            btnConvertToKm.Font = new Font("Segoe UI", 12F);
            btnConvertToKm.Location = new Point(53, 103);
            btnConvertToKm.Name = "btnConvertToKm";
            btnConvertToKm.Size = new Size(100, 56);
            btnConvertToKm.TabIndex = 5;
            btnConvertToKm.Text = "Convert To KM";
            btnConvertToKm.UseVisualStyleBackColor = true;
            btnConvertToKm.Click += btnConvertToKm_Click;
            // 
            // btnConvertToMi
            // 
            btnConvertToMi.Font = new Font("Segoe UI", 12F);
            btnConvertToMi.Location = new Point(256, 103);
            btnConvertToMi.Name = "btnConvertToMi";
            btnConvertToMi.Size = new Size(100, 56);
            btnConvertToMi.TabIndex = 6;
            btnConvertToMi.Text = "Convert to Mi";
            btnConvertToMi.UseVisualStyleBackColor = true;
            btnConvertToMi.Click += btnConvertToMi_Click;
            // 
            // frmDistanceConverter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(398, 229);
            Controls.Add(btnConvertToMi);
            Controls.Add(btnConvertToKm);
            Controls.Add(txtKilometers);
            Controls.Add(txtMiles);
            Controls.Add(lblResult);
            Controls.Add(lblKilometers);
            Controls.Add(lblMiles);
            Name = "frmDistanceConverter";
            Text = "Distance Converter";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMiles;
        private Label lblKilometers;
        private Label lblResult;
        private TextBox txtMiles;
        private TextBox txtKilometers;
        private Button btnConvertToKm;
        private Button btnConvertToMi;
    }
}
