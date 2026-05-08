namespace PoolClubProject
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
            this.ctrlPoolTable4 = new PoolClubProject.ctrlPoolTable();
            this.ctrlPoolTable3 = new PoolClubProject.ctrlPoolTable();
            this.ctrlPoolTable2 = new PoolClubProject.ctrlPoolTable();
            this.ctrlPoolTable1 = new PoolClubProject.ctrlPoolTable();
            this.SuspendLayout();
            // 
            // ctrlPoolTable4
            // 
            this.ctrlPoolTable4.BackColor = System.Drawing.Color.Black;
            this.ctrlPoolTable4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ctrlPoolTable4.HourlyRate = 40D;
            this.ctrlPoolTable4.Location = new System.Drawing.Point(405, 288);
            this.ctrlPoolTable4.Name = "ctrlPoolTable4";
            this.ctrlPoolTable4.PlayerName = "P4";
            this.ctrlPoolTable4.Size = new System.Drawing.Size(390, 276);
            this.ctrlPoolTable4.TabIndex = 3;
            this.ctrlPoolTable4.TableName = "T4";
            // 
            // ctrlPoolTable3
            // 
            this.ctrlPoolTable3.BackColor = System.Drawing.Color.Black;
            this.ctrlPoolTable3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ctrlPoolTable3.HourlyRate = 30D;
            this.ctrlPoolTable3.Location = new System.Drawing.Point(12, 288);
            this.ctrlPoolTable3.Name = "ctrlPoolTable3";
            this.ctrlPoolTable3.PlayerName = "P3";
            this.ctrlPoolTable3.Size = new System.Drawing.Size(390, 276);
            this.ctrlPoolTable3.TabIndex = 2;
            this.ctrlPoolTable3.TableName = "T3";
            // 
            // ctrlPoolTable2
            // 
            this.ctrlPoolTable2.BackColor = System.Drawing.Color.Black;
            this.ctrlPoolTable2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ctrlPoolTable2.HourlyRate = 20D;
            this.ctrlPoolTable2.Location = new System.Drawing.Point(405, 12);
            this.ctrlPoolTable2.Name = "ctrlPoolTable2";
            this.ctrlPoolTable2.PlayerName = "P2";
            this.ctrlPoolTable2.Size = new System.Drawing.Size(390, 276);
            this.ctrlPoolTable2.TabIndex = 1;
            this.ctrlPoolTable2.TableName = "T2";
            // 
            // ctrlPoolTable1
            // 
            this.ctrlPoolTable1.BackColor = System.Drawing.Color.Black;
            this.ctrlPoolTable1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ctrlPoolTable1.HourlyRate = 10D;
            this.ctrlPoolTable1.Location = new System.Drawing.Point(12, 12);
            this.ctrlPoolTable1.Name = "ctrlPoolTable1";
            this.ctrlPoolTable1.PlayerName = "P1";
            this.ctrlPoolTable1.Size = new System.Drawing.Size(390, 276);
            this.ctrlPoolTable1.TabIndex = 0;
            this.ctrlPoolTable1.TableName = "T1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(807, 576);
            this.Controls.Add(this.ctrlPoolTable4);
            this.Controls.Add(this.ctrlPoolTable3);
            this.Controls.Add(this.ctrlPoolTable2);
            this.Controls.Add(this.ctrlPoolTable1);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlPoolTable ctrlPoolTable1;
        private ctrlPoolTable ctrlPoolTable2;
        private ctrlPoolTable ctrlPoolTable3;
        private ctrlPoolTable ctrlPoolTable4;
    }
}

