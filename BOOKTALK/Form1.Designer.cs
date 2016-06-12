namespace BOOKTALK
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblBooktalk = new System.Windows.Forms.Label();
            this.btnFile = new System.Windows.Forms.Button();
            this.btnText = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.Location = new System.Drawing.Point(18, 41);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(454, 73);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "WELCOME TO";
            // 
            // lblBooktalk
            // 
            this.lblBooktalk.AutoSize = true;
            this.lblBooktalk.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooktalk.Location = new System.Drawing.Point(61, 114);
            this.lblBooktalk.Name = "lblBooktalk";
            this.lblBooktalk.Size = new System.Drawing.Size(376, 73);
            this.lblBooktalk.TabIndex = 1;
            this.lblBooktalk.Text = "BOOKTALK";
            // 
            // btnFile
            // 
            this.btnFile.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.Location = new System.Drawing.Point(85, 237);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(105, 30);
            this.btnFile.TabIndex = 2;
            this.btnFile.Text = "READ FILE";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnText
            // 
            this.btnText.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnText.Location = new System.Drawing.Point(286, 237);
            this.btnText.Name = "btnText";
            this.btnText.Size = new System.Drawing.Size(105, 30);
            this.btnText.TabIndex = 3;
            this.btnText.Text = "READ TEXT";
            this.btnText.UseVisualStyleBackColor = true;
            this.btnText.Click += new System.EventHandler(this.btnText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 311);
            this.Controls.Add(this.btnText);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.lblBooktalk);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Form1";
            this.Text = "BOOKTALK";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblBooktalk;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnText;
    }
}

