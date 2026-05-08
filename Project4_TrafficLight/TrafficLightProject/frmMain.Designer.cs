namespace TrafficLightProject
{
    partial class frmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctrlTrafficLight3 = new TrafficLightProject.ctrlTrafficLight();
            this.ctrlTrafficLight2 = new TrafficLightProject.ctrlTrafficLight();
            this.ctrlTrafficLight1 = new TrafficLightProject.ctrlTrafficLight();
            this.SuspendLayout();
            // 
            // ctrlTrafficLight3
            // 
            this.ctrlTrafficLight3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlTrafficLight3.CurrentColor = TrafficLightProject.ctrlTrafficLight.enLightColor.Green;
            this.ctrlTrafficLight3.GreenColorWaitingTime = ((short)(10));
            this.ctrlTrafficLight3.Location = new System.Drawing.Point(427, 24);
            this.ctrlTrafficLight3.Name = "ctrlTrafficLight3";
            this.ctrlTrafficLight3.OrangeColorWaitingTime = ((short)(10));
            this.ctrlTrafficLight3.RedColorWaitingTime = ((short)(10));
            this.ctrlTrafficLight3.Size = new System.Drawing.Size(88, 195);
            this.ctrlTrafficLight3.TabIndex = 2;
            this.ctrlTrafficLight3.Tag = "Third Traffic";
            // 
            // ctrlTrafficLight2
            // 
            this.ctrlTrafficLight2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlTrafficLight2.CurrentColor = TrafficLightProject.ctrlTrafficLight.enLightColor.Orange;
            this.ctrlTrafficLight2.GreenColorWaitingTime = ((short)(10));
            this.ctrlTrafficLight2.Location = new System.Drawing.Point(227, 24);
            this.ctrlTrafficLight2.Name = "ctrlTrafficLight2";
            this.ctrlTrafficLight2.OrangeColorWaitingTime = ((short)(10));
            this.ctrlTrafficLight2.RedColorWaitingTime = ((short)(10));
            this.ctrlTrafficLight2.Size = new System.Drawing.Size(88, 195);
            this.ctrlTrafficLight2.TabIndex = 1;
            this.ctrlTrafficLight2.Tag = "Second Traffic";
            // 
            // ctrlTrafficLight1
            // 
            this.ctrlTrafficLight1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ctrlTrafficLight1.CurrentColor = TrafficLightProject.ctrlTrafficLight.enLightColor.Red;
            this.ctrlTrafficLight1.GreenColorWaitingTime = ((short)(10));
            this.ctrlTrafficLight1.Location = new System.Drawing.Point(27, 24);
            this.ctrlTrafficLight1.Name = "ctrlTrafficLight1";
            this.ctrlTrafficLight1.OrangeColorWaitingTime = ((short)(10));
            this.ctrlTrafficLight1.RedColorWaitingTime = ((short)(10));
            this.ctrlTrafficLight1.Size = new System.Drawing.Size(88, 195);
            this.ctrlTrafficLight1.TabIndex = 0;
            this.ctrlTrafficLight1.Tag = "First Traffic";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(542, 243);
            this.Controls.Add(this.ctrlTrafficLight3);
            this.Controls.Add(this.ctrlTrafficLight2);
            this.Controls.Add(this.ctrlTrafficLight1);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.Name = "frmMain";
            this.Text = "frm";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlTrafficLight ctrlTrafficLight1;
        private ctrlTrafficLight ctrlTrafficLight2;
        private ctrlTrafficLight ctrlTrafficLight3;
    }
}