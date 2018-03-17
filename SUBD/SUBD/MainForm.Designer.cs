namespace SUBD
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.connect = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.serverComboEdit = new Controls.ComboEdit();
            this.passwordTextEdit = new Controls.TextEdit();
            this.loginTextEdit = new Controls.TextEdit();
            this.SuspendLayout();
            // 
            // connect
            // 
            this.connect.Location = new System.Drawing.Point(64, 199);
            this.connect.Name = "connect";
            this.connect.Size = new System.Drawing.Size(101, 23);
            this.connect.TabIndex = 1;
            this.connect.Text = "Подключиться";
            this.connect.UseVisualStyleBackColor = true;
            this.connect.Click += new System.EventHandler(this.connect_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(185, 199);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(104, 23);
            this.add.TabIndex = 5;
            this.add.Text = "Добавить сервер";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Checked = true;
            this.checkBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox.Location = new System.Drawing.Point(64, 79);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(185, 17);
            this.checkBox.TabIndex = 6;
            this.checkBox.Text = "использовать аутентификацию";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Сервер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Логин";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Пароль";
            // 
            // serverComboEdit
            // 
            this.serverComboEdit.DataSource = null;
            this.serverComboEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.serverComboEdit.Location = new System.Drawing.Point(64, 40);
            this.serverComboEdit.MaximumSize = new System.Drawing.Size(300, 23);
            this.serverComboEdit.MinimumSize = new System.Drawing.Size(0, 23);
            this.serverComboEdit.Name = "serverComboEdit";
            this.serverComboEdit.Size = new System.Drawing.Size(225, 23);
            this.serverComboEdit.TabIndex = 10;
            this.serverComboEdit.Value = null;
            this.serverComboEdit.ValueIndex = -1;
            // 
            // passwordTextEdit
            // 
            this.passwordTextEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.passwordTextEdit.Location = new System.Drawing.Point(64, 155);
            this.passwordTextEdit.MaximumSize = new System.Drawing.Size(300, 22);
            this.passwordTextEdit.MinimumSize = new System.Drawing.Size(0, 22);
            this.passwordTextEdit.Name = "passwordTextEdit";
            this.passwordTextEdit.Size = new System.Drawing.Size(225, 22);
            this.passwordTextEdit.TabIndex = 4;
            // 
            // loginTextEdit
            // 
            this.loginTextEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.loginTextEdit.Location = new System.Drawing.Point(64, 115);
            this.loginTextEdit.MaximumSize = new System.Drawing.Size(300, 22);
            this.loginTextEdit.MinimumSize = new System.Drawing.Size(0, 22);
            this.loginTextEdit.Name = "loginTextEdit";
            this.loginTextEdit.Size = new System.Drawing.Size(225, 22);
            this.loginTextEdit.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 319);
            this.Controls.Add(this.serverComboEdit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.add);
            this.Controls.Add(this.passwordTextEdit);
            this.Controls.Add(this.loginTextEdit);
            this.Controls.Add(this.connect);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(405, 358);
            this.MinimumSize = new System.Drawing.Size(405, 358);
            this.Name = "MainForm";
            this.Text = "Подключение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button connect;
        private Controls.TextEdit loginTextEdit;
        private Controls.TextEdit passwordTextEdit;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Controls.ComboEdit serverComboEdit;
    }
}

