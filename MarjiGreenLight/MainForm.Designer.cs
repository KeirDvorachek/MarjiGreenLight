namespace MarjiGreenLight {
    partial class frmMain {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            lblStatus = new Label();
            btnRun = new Button();
            btnLog = new Button();
            pbTrafficLight = new PictureBox();
            btnClose = new Button();
            btnDirections = new Button();
            ((System.ComponentModel.ISupportInitialize)pbTrafficLight).BeginInit();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(11, 8);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(108, 15);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "Registration Status:";
            // 
            // btnRun
            // 
            btnRun.Location = new Point(120, 22);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(100, 23);
            btnRun.TabIndex = 1;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += this.btnRun_Click;
            // 
            // btnLog
            // 
            btnLog.Location = new Point(120, 51);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(100, 23);
            btnLog.TabIndex = 2;
            btnLog.Text = "Log";
            btnLog.UseVisualStyleBackColor = true;
            // 
            // pbTrafficLight
            // 
            pbTrafficLight.BackColor = Color.Red;
            pbTrafficLight.Location = new Point(14, 27);
            pbTrafficLight.Name = "pbTrafficLight";
            pbTrafficLight.Size = new Size(100, 100);
            pbTrafficLight.TabIndex = 3;
            pbTrafficLight.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(120, 80);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(100, 23);
            btnClose.TabIndex = 4;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnDirections
            // 
            btnDirections.Location = new Point(120, 109);
            btnDirections.Name = "btnDirections";
            btnDirections.Size = new Size(100, 23);
            btnDirections.TabIndex = 5;
            btnDirections.Text = "Directions";
            btnDirections.UseVisualStyleBackColor = true;
            btnDirections.Click += btnDirections_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(229, 143);
            Controls.Add(btnDirections);
            Controls.Add(btnClose);
            Controls.Add(pbTrafficLight);
            Controls.Add(btnLog);
            Controls.Add(btnRun);
            Controls.Add(lblStatus);
            Name = "frmMain";
            Text = "MarjiGreenLight";
            ((System.ComponentModel.ISupportInitialize)pbTrafficLight).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private Button btnRun;
        private Button btnLog;
        private PictureBox pbTrafficLight;
        private Button btnClose;
        private Button btnDirections;
    }
}
