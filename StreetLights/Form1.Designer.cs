namespace StreetLights
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lamp1NameLbl = new System.Windows.Forms.Label();
            this.lamp2NameLbl = new System.Windows.Forms.Label();
            this.lamp3NameLbl = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1340, 716);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lamp3NameLbl);
            this.tabPage1.Controls.Add(this.lamp2NameLbl);
            this.tabPage1.Controls.Add(this.lamp1NameLbl);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1332, 690);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lamp1NameLbl
            // 
            this.lamp1NameLbl.AutoSize = true;
            this.lamp1NameLbl.Location = new System.Drawing.Point(330, 283);
            this.lamp1NameLbl.Name = "lamp1NameLbl";
            this.lamp1NameLbl.Size = new System.Drawing.Size(35, 13);
            this.lamp1NameLbl.TabIndex = 0;
            this.lamp1NameLbl.Text = "label1";
            // 
            // lamp2NameLbl
            // 
            this.lamp2NameLbl.AutoSize = true;
            this.lamp2NameLbl.Location = new System.Drawing.Point(507, 283);
            this.lamp2NameLbl.Name = "lamp2NameLbl";
            this.lamp2NameLbl.Size = new System.Drawing.Size(35, 13);
            this.lamp2NameLbl.TabIndex = 1;
            this.lamp2NameLbl.Text = "label2";
            // 
            // lamp3NameLbl
            // 
            this.lamp3NameLbl.AutoSize = true;
            this.lamp3NameLbl.Location = new System.Drawing.Point(685, 283);
            this.lamp3NameLbl.Name = "lamp3NameLbl";
            this.lamp3NameLbl.Size = new System.Drawing.Size(35, 13);
            this.lamp3NameLbl.TabIndex = 2;
            this.lamp3NameLbl.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 716);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lamp3NameLbl;
        private System.Windows.Forms.Label lamp2NameLbl;
        private System.Windows.Forms.Label lamp1NameLbl;
    }
}

