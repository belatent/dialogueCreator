namespace dialoguecraetor
{
    partial class SetButtonName
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
            this.note = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.ok = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // note
            // 
            this.note.AutoSize = true;
            this.note.Location = new System.Drawing.Point(12, 10);
            this.note.Name = "note";
            this.note.Size = new System.Drawing.Size(120, 15);
            this.note.TabIndex = 0;
            this.note.Text = "正在修改-号按钮";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(114, 43);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(227, 25);
            this.nameText.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(26, 46);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(82, 15);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "新角色名：";
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(12, 77);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(170, 37);
            this.ok.TabIndex = 3;
            this.ok.Text = "挺好~";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancel
            // 
            this.cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel.Location = new System.Drawing.Point(188, 77);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(170, 37);
            this.cancel.TabIndex = 4;
            this.cancel.Text = "算了";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // SetButtonName
            // 
            this.AcceptButton = this.ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.CancelButton = this.cancel;
            this.ClientSize = new System.Drawing.Size(371, 119);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.note);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetButtonName";
            this.ShowInTaskbar = false;
            this.Text = "修改角色名";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label note;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.Button cancel;
    }
}