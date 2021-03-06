﻿namespace SUBD
{
    partial class TableForm
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
            this.manage = new System.Windows.Forms.LinkLabel();
            this.dbComboEdit = new Controls.ComboEdit();
            this.gridViewTables = new SUBD.GridView();
            this.gridViewColumns = new SUBD.GridView();
            this.gridViewRelations = new SUBD.GridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLabel = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.maskManage = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewColumns)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRelations)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "База данных";
            // 
            // manage
            // 
            this.manage.AutoSize = true;
            this.manage.Location = new System.Drawing.Point(340, 49);
            this.manage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.manage.Name = "manage";
            this.manage.Size = new System.Drawing.Size(88, 17);
            this.manage.TabIndex = 9;
            this.manage.TabStop = true;
            this.manage.Text = "Управление";
            this.manage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.manage_LinkClicked);
            // 
            // dbComboEdit
            // 
            this.dbComboEdit.CanWrite = false;
            this.dbComboEdit.DataSource = null;
            this.dbComboEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.dbComboEdit.Location = new System.Drawing.Point(33, 41);
            this.dbComboEdit.Margin = new System.Windows.Forms.Padding(5);
            this.dbComboEdit.MaximumSize = new System.Drawing.Size(400, 28);
            this.dbComboEdit.MinimumSize = new System.Drawing.Size(0, 28);
            this.dbComboEdit.Name = "dbComboEdit";
            this.dbComboEdit.Size = new System.Drawing.Size(279, 28);
            this.dbComboEdit.TabIndex = 0;
            this.dbComboEdit.Value = null;
            this.dbComboEdit.ValueIndex = -1;
            // 
            // gridViewTables
            // 
            this.gridViewTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTables.Location = new System.Drawing.Point(33, 116);
            this.gridViewTables.Margin = new System.Windows.Forms.Padding(4);
            this.gridViewTables.Name = "gridViewTables";
            this.gridViewTables.Size = new System.Drawing.Size(193, 192);
            this.gridViewTables.TabIndex = 10;
            this.gridViewTables.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewTables_RowEnter);
            this.gridViewTables.RowLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewTables_RowLeave);
            // 
            // gridViewColumns
            // 
            this.gridViewColumns.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewColumns.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridViewColumns.Location = new System.Drawing.Point(0, 395);
            this.gridViewColumns.Margin = new System.Windows.Forms.Padding(4);
            this.gridViewColumns.Name = "gridViewColumns";
            this.gridViewColumns.Size = new System.Drawing.Size(1080, 240);
            this.gridViewColumns.TabIndex = 11;
            this.gridViewColumns.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewColumns_CellDoubleClick);
            // 
            // gridViewRelations
            // 
            this.gridViewRelations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewRelations.Location = new System.Drawing.Point(327, 116);
            this.gridViewRelations.Margin = new System.Windows.Forms.Padding(4);
            this.gridViewRelations.Name = "gridViewRelations";
            this.gridViewRelations.Size = new System.Drawing.Size(444, 192);
            this.gridViewRelations.TabIndex = 12;
            this.gridViewRelations.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewRelations_CellDoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Таблицы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 347);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Аттрибуты таблицы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(323, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Отношения";
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.Location = new System.Drawing.Point(167, 347);
            this.tableLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(39, 17);
            this.tableLabel.TabIndex = 16;
            this.tableLabel.Text = "table";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(671, 592);
            this.save.Margin = new System.Windows.Forms.Padding(4);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(100, 28);
            this.save.TabIndex = 17;
            this.save.Text = "Сохранить";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // maskManage
            // 
            this.maskManage.AutoSize = true;
            this.maskManage.Location = new System.Drawing.Point(477, 49);
            this.maskManage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maskManage.Name = "maskManage";
            this.maskManage.Size = new System.Drawing.Size(148, 17);
            this.maskManage.TabIndex = 18;
            this.maskManage.TabStop = true;
            this.maskManage.Text = "Управление масками";
            this.maskManage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.maskManage_LinkClicked);
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 635);
            this.Controls.Add(this.maskManage);
            this.Controls.Add(this.save);
            this.Controls.Add(this.tableLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridViewRelations);
            this.Controls.Add(this.gridViewColumns);
            this.Controls.Add(this.gridViewTables);
            this.Controls.Add(this.manage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbComboEdit);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TableForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewColumns)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRelations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel manage;
        private Controls.ComboEdit dbComboEdit;
        private GridView gridViewTables;
        private GridView gridViewColumns;
        private GridView gridViewRelations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tableLabel;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.LinkLabel maskManage;
    }
}