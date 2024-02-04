namespace HW02_05
{
    partial class frmHurricaneScale
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
            lblWindSpeed = new Label();
            lblCategory = new Label();
            txtWindSpeed = new TextBox();
            txtCategory = new TextBox();
            btnEstimate = new Button();
            SuspendLayout();
            // 
            // lblWindSpeed
            // 
            lblWindSpeed.AutoSize = true;
            lblWindSpeed.Location = new Point(12, 9);
            lblWindSpeed.Name = "lblWindSpeed";
            lblWindSpeed.Size = new Size(73, 15);
            lblWindSpeed.TabIndex = 0;
            lblWindSpeed.Text = "Wind Speed:";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(199, 9);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(58, 15);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category:";
            // 
            // txtWindSpeed
            // 
            txtWindSpeed.Location = new Point(12, 27);
            txtWindSpeed.Name = "txtWindSpeed";
            txtWindSpeed.Size = new Size(100, 23);
            txtWindSpeed.TabIndex = 2;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(199, 28);
            txtCategory.Name = "txtCategory";
            txtCategory.ReadOnly = true;
            txtCategory.Size = new Size(100, 23);
            txtCategory.TabIndex = 3;
            // 
            // btnEstimate
            // 
            btnEstimate.Location = new Point(118, 27);
            btnEstimate.Name = "btnEstimate";
            btnEstimate.Size = new Size(75, 23);
            btnEstimate.TabIndex = 4;
            btnEstimate.Text = "Estimate";
            btnEstimate.UseVisualStyleBackColor = true;
            btnEstimate.Click += this.btnEstimate_Click;
            // 
            // frmHurricaneScale
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 80);
            Controls.Add(btnEstimate);
            Controls.Add(txtCategory);
            Controls.Add(txtWindSpeed);
            Controls.Add(lblCategory);
            Controls.Add(lblWindSpeed);
            Name = "frmHurricaneScale";
            Text = "Hurricane Scale";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWindSpeed;
        private Label lblCategory;
        private TextBox txtWindSpeed;
        private TextBox txtCategory;
        private Button btnEstimate;
    }
}
