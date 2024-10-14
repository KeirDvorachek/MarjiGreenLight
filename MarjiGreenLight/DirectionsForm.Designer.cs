namespace MarjiGreenLight {
    partial class frmDirections {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDirections));
            lblSteps = new Label();
            lblUrl = new Label();
            txtInsertUrl = new TextBox();
            btnSave = new Button();
            btnClose = new Button();
            SuspendLayout();
            // 
            // lblSteps
            // 
            lblSteps.AutoSize = true;
            lblSteps.Location = new Point(12, 9);
            lblSteps.Name = "lblSteps";
            lblSteps.Size = new Size(504, 90);
            lblSteps.TabIndex = 0;
            lblSteps.Text = resources.GetString("lblSteps.Text");
            // 
            // lblUrl
            // 
            lblUrl.AutoSize = true;
            lblUrl.Location = new Point(12, 131);
            lblUrl.Name = "lblUrl";
            lblUrl.Size = new Size(34, 15);
            lblUrl.TabIndex = 1;
            lblUrl.Text = "URL :";
            // 
            // txtInsertUrl
            // 
            txtInsertUrl.Location = new Point(52, 128);
            txtInsertUrl.Name = "txtInsertUrl";
            txtInsertUrl.Size = new Size(464, 23);
            txtInsertUrl.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(171, 173);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += this.btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(289, 173);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmDirections
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(528, 207);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(txtInsertUrl);
            Controls.Add(lblUrl);
            Controls.Add(lblSteps);
            Name = "frmDirections";
            Text = "Directions";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSteps;
        private Label lblUrl;
        private TextBox txtInsertUrl;
        private Button btnSave;
        private Button btnClose;
    }
}