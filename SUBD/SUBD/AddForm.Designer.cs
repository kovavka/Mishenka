namespace SUBD
{
    partial class AddForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.add = new System.Windows.Forms.Button();
            this.password = new Controls.TextEdit();
            this.login = new Controls.TextEdit();
            this.server = new Controls.TextEdit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Адрес";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Checked = true;
            this.checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox.Location = new System.Drawing.Point(27, 73);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(185, 17);
            this.checkBox.TabIndex = 15;
            this.checkBox.Text = "использовать аутентификацию";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox_CheckedChanged);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(93, 210);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(104, 23);
            this.add.TabIndex = 14;
            this.add.Text = "Добавить сервер";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // password
            // 
            this.password.ForeColor = System.Drawing.SystemColors.Control;
            this.password.Location = new System.Drawing.Point(27, 149);
            this.password.MaximumSize = new System.Drawing.Size(300, 22);
            this.password.MinimumSize = new System.Drawing.Size(0, 22);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(225, 22);
            this.password.TabIndex = 13;
            // 
            // login
            // 
            this.login.ForeColor = System.Drawing.SystemColors.Control;
            this.login.Location = new System.Drawing.Point(27, 109);
            this.login.MaximumSize = new System.Drawing.Size(300, 22);
            this.login.MinimumSize = new System.Drawing.Size(0, 22);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(225, 22);
            this.login.TabIndex = 12;
            // 
            // server
            // 
            this.server.ForeColor = System.Drawing.SystemColors.Control;
            this.server.Location = new System.Drawing.Point(27, 34);
            this.server.MaximumSize = new System.Drawing.Size(300, 22);
            this.server.MinimumSize = new System.Drawing.Size(0, 22);
            this.server.Name = "server";
            this.server.Size = new System.Drawing.Size(225, 22);
            this.server.TabIndex = 19;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(302, 278);
            this.Controls.Add(this.server);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.add);
            this.Controls.Add(this.password);
            this.Controls.Add(this.login);
            this.MaximumSize = new System.Drawing.Size(318, 317);
            this.MinimumSize = new System.Drawing.Size(318, 317);
            this.Name = "AddForm";
            this.Text = "Добавить сервер";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Button add;
        private Controls.TextEdit password;
        private Controls.TextEdit login;
        private Controls.TextEdit server;
    }
}