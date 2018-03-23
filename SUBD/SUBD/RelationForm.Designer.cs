namespace SUBD
{
    partial class RelationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.textEditName = new Controls.TextEdit();
            this.comboEditTable1 = new Controls.ComboEdit();
            this.comboEditColumn1 = new Controls.ComboEdit();
            this.comboEditTable2 = new Controls.ComboEdit();
            this.comboEditColumn2 = new Controls.ComboEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Название";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(225, 181);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 10;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // textEditName
            // 
            this.textEditName.ForeColor = System.Drawing.SystemColors.Control;
            this.textEditName.Location = new System.Drawing.Point(15, 26);
            this.textEditName.MaximumSize = new System.Drawing.Size(300, 22);
            this.textEditName.MinimumSize = new System.Drawing.Size(0, 22);
            this.textEditName.Name = "textEditName";
            this.textEditName.Size = new System.Drawing.Size(209, 22);
            this.textEditName.TabIndex = 11;
            // 
            // comboEditTable1
            // 
            this.comboEditTable1.CanWrite = false;
            this.comboEditTable1.DataSource = null;
            this.comboEditTable1.ForeColor = System.Drawing.SystemColors.Control;
            this.comboEditTable1.Location = new System.Drawing.Point(15, 79);
            this.comboEditTable1.MaximumSize = new System.Drawing.Size(300, 23);
            this.comboEditTable1.MinimumSize = new System.Drawing.Size(0, 23);
            this.comboEditTable1.Name = "comboEditTable1";
            this.comboEditTable1.Size = new System.Drawing.Size(209, 23);
            this.comboEditTable1.TabIndex = 12;
            this.comboEditTable1.Value = null;
            this.comboEditTable1.ValueIndex = -1;
            this.comboEditTable1.SelectedIndexChanged += new System.EventHandler<System.EventArgs>(this.comboEditTable1_SelectedIndexChanged);
            // 
            // comboEditColumn1
            // 
            this.comboEditColumn1.CanWrite = false;
            this.comboEditColumn1.DataSource = null;
            this.comboEditColumn1.ForeColor = System.Drawing.SystemColors.Control;
            this.comboEditColumn1.Location = new System.Drawing.Point(15, 126);
            this.comboEditColumn1.MaximumSize = new System.Drawing.Size(300, 23);
            this.comboEditColumn1.MinimumSize = new System.Drawing.Size(0, 23);
            this.comboEditColumn1.Name = "comboEditColumn1";
            this.comboEditColumn1.Size = new System.Drawing.Size(209, 23);
            this.comboEditColumn1.TabIndex = 13;
            this.comboEditColumn1.Value = null;
            this.comboEditColumn1.ValueIndex = -1;
            // 
            // comboEditTable2
            // 
            this.comboEditTable2.CanWrite = false;
            this.comboEditTable2.DataSource = null;
            this.comboEditTable2.ForeColor = System.Drawing.SystemColors.Control;
            this.comboEditTable2.Location = new System.Drawing.Point(284, 79);
            this.comboEditTable2.MaximumSize = new System.Drawing.Size(300, 23);
            this.comboEditTable2.MinimumSize = new System.Drawing.Size(0, 23);
            this.comboEditTable2.Name = "comboEditTable2";
            this.comboEditTable2.Size = new System.Drawing.Size(209, 23);
            this.comboEditTable2.TabIndex = 14;
            this.comboEditTable2.Value = null;
            this.comboEditTable2.ValueIndex = -1;
            this.comboEditTable2.SelectedIndexChanged += new System.EventHandler<System.EventArgs>(this.comboEditTable2_SelectedIndexChanged);
            // 
            // comboEditColumn2
            // 
            this.comboEditColumn2.CanWrite = false;
            this.comboEditColumn2.DataSource = null;
            this.comboEditColumn2.ForeColor = System.Drawing.SystemColors.Control;
            this.comboEditColumn2.Location = new System.Drawing.Point(284, 126);
            this.comboEditColumn2.MaximumSize = new System.Drawing.Size(300, 23);
            this.comboEditColumn2.MinimumSize = new System.Drawing.Size(0, 23);
            this.comboEditColumn2.Name = "comboEditColumn2";
            this.comboEditColumn2.Size = new System.Drawing.Size(209, 23);
            this.comboEditColumn2.TabIndex = 15;
            this.comboEditColumn2.Value = null;
            this.comboEditColumn2.ValueIndex = -1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Таблица 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Атрибут 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Таблица 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Атрибут 2";
            // 
            // RelationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 215);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboEditColumn2);
            this.Controls.Add(this.comboEditTable2);
            this.Controls.Add(this.comboEditColumn1);
            this.Controls.Add(this.comboEditTable1);
            this.Controls.Add(this.textEditName);
            this.Controls.Add(this.save);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(541, 254);
            this.MinimumSize = new System.Drawing.Size(541, 254);
            this.Name = "RelationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button save;
        private Controls.TextEdit textEditName;
        private Controls.ComboEdit comboEditTable1;
        private Controls.ComboEdit comboEditColumn1;
        private Controls.ComboEdit comboEditTable2;
        private Controls.ComboEdit comboEditColumn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}