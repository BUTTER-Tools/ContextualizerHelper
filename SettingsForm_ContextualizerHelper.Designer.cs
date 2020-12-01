namespace ContextualizerHelper
{
    partial class SettingsForm_ContextualizerHelper
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm_ContextualizerHelper));
            this.OKButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.KeepLeftCheckbox = new System.Windows.Forms.CheckBox();
            this.KeepWordsCheckbox = new System.Windows.Forms.CheckBox();
            this.KeepRightCheckbox = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OKButton
            // 
            this.OKButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OKButton.Location = new System.Drawing.Point(55, 183);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(118, 40);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.KeepRightCheckbox);
            this.groupBox1.Controls.Add(this.KeepWordsCheckbox);
            this.groupBox1.Controls.Add(this.KeepLeftCheckbox);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 165);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Token Retention";
            // 
            // KeepLeftCheckbox
            // 
            this.KeepLeftCheckbox.AutoSize = true;
            this.KeepLeftCheckbox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeepLeftCheckbox.Location = new System.Drawing.Point(6, 41);
            this.KeepLeftCheckbox.Name = "KeepLeftCheckbox";
            this.KeepLeftCheckbox.Size = new System.Drawing.Size(156, 20);
            this.KeepLeftCheckbox.TabIndex = 0;
            this.KeepLeftCheckbox.Text = "Retain Left Context";
            this.KeepLeftCheckbox.UseVisualStyleBackColor = true;
            // 
            // KeepWordsCheckbox
            // 
            this.KeepWordsCheckbox.AutoSize = true;
            this.KeepWordsCheckbox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeepWordsCheckbox.Location = new System.Drawing.Point(6, 78);
            this.KeepWordsCheckbox.Name = "KeepWordsCheckbox";
            this.KeepWordsCheckbox.Size = new System.Drawing.Size(191, 20);
            this.KeepWordsCheckbox.TabIndex = 1;
            this.KeepWordsCheckbox.Text = "Retain Captured Word(s)";
            this.KeepWordsCheckbox.UseVisualStyleBackColor = true;
            // 
            // KeepRightCheckbox
            // 
            this.KeepRightCheckbox.AutoSize = true;
            this.KeepRightCheckbox.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeepRightCheckbox.Location = new System.Drawing.Point(6, 114);
            this.KeepRightCheckbox.Name = "KeepRightCheckbox";
            this.KeepRightCheckbox.Size = new System.Drawing.Size(163, 20);
            this.KeepRightCheckbox.TabIndex = 2;
            this.KeepRightCheckbox.Text = "Retain Right Context";
            this.KeepRightCheckbox.UseVisualStyleBackColor = true;
            // 
            // SettingsForm_ContextualizerHelper
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 231);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.OKButton);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SettingsForm_ContextualizerHelper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plugin Name";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox KeepRightCheckbox;
        private System.Windows.Forms.CheckBox KeepWordsCheckbox;
        private System.Windows.Forms.CheckBox KeepLeftCheckbox;
    }
}