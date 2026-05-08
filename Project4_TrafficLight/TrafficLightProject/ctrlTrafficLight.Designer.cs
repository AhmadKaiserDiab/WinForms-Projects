namespace TrafficLightProject
{
    partial class ctrlTrafficLight
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
            this.components = new System.ComponentModel.Container();
            this.lblRemainigTime = new System.Windows.Forms.Label();
            this.pbTrafficLight = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrafficLight)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRemainigTime
            // 
            this.lblRemainigTime.AutoSize = true;
            this.lblRemainigTime.BackColor = System.Drawing.SystemColors.Control;
            this.lblRemainigTime.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemainigTime.ForeColor = System.Drawing.Color.Red;
            this.lblRemainigTime.Location = new System.Drawing.Point(9, 156);
            this.lblRemainigTime.MinimumSize = new System.Drawing.Size(71, 0);
            this.lblRemainigTime.Name = "lblRemainigTime";
            this.lblRemainigTime.Size = new System.Drawing.Size(71, 23);
            this.lblRemainigTime.TabIndex = 0;
            this.lblRemainigTime.Text = "0";
            this.lblRemainigTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbTrafficLight
            // 
            this.pbTrafficLight.Image = global::TrafficLightProject.Properties.Resources.Red;
            this.pbTrafficLight.Location = new System.Drawing.Point(9, 10);
            this.pbTrafficLight.Name = "pbTrafficLight";
            this.pbTrafficLight.Size = new System.Drawing.Size(71, 136);
            this.pbTrafficLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTrafficLight.TabIndex = 1;
            this.pbTrafficLight.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ctrlTrafficLight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pbTrafficLight);
            this.Controls.Add(this.lblRemainigTime);
            this.Name = "ctrlTrafficLight";
            this.Size = new System.Drawing.Size(88, 185);
            ((System.ComponentModel.ISupportInitialize)(this.pbTrafficLight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRemainigTime;
        private System.Windows.Forms.PictureBox pbTrafficLight;
        private System.Windows.Forms.Timer timer1;
    }
}
