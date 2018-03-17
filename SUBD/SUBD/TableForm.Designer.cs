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
            this.gridView2 = new SUBD.GridView();
            this.gridViewRelations = new SUBD.GridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRelations)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "База данных";
            // 
            // manage
            // 
            this.manage.AutoSize = true;
            this.manage.Location = new System.Drawing.Point(255, 40);
            this.manage.Name = "manage";
            this.manage.Size = new System.Drawing.Size(69, 13);
            this.manage.TabIndex = 9;
            this.manage.TabStop = true;
            this.manage.Text = "Управление";
            this.manage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.manage_LinkClicked);
            // 
            // dbComboEdit
            // 
            this.dbComboEdit.DataSource = null;
            this.dbComboEdit.ForeColor = System.Drawing.SystemColors.Control;
            this.dbComboEdit.Location = new System.Drawing.Point(25, 33);
            this.dbComboEdit.MaximumSize = new System.Drawing.Size(300, 23);
            this.dbComboEdit.MinimumSize = new System.Drawing.Size(0, 23);
            this.dbComboEdit.Name = "dbComboEdit";
            this.dbComboEdit.Size = new System.Drawing.Size(209, 23);
            this.dbComboEdit.TabIndex = 0;
            this.dbComboEdit.Value = null;
            this.dbComboEdit.ValueIndex = -1;
            // 
            // gridViewTables
            // 
            this.gridViewTables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewTables.Location = new System.Drawing.Point(25, 94);
            this.gridViewTables.Name = "gridViewTables";
            this.gridViewTables.Size = new System.Drawing.Size(145, 156);
            this.gridViewTables.TabIndex = 10;
            // 
            // gridView2
            // 
            this.gridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView2.Location = new System.Drawing.Point(268, 94);
            this.gridView2.Name = "gridView2";
            this.gridView2.Size = new System.Drawing.Size(310, 156);
            this.gridView2.TabIndex = 11;
            // 
            // gridViewRelations
            // 
            this.gridViewRelations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewRelations.Location = new System.Drawing.Point(25, 297);
            this.gridViewRelations.Name = "gridViewRelations";
            this.gridViewRelations.Size = new System.Drawing.Size(553, 171);
            this.gridViewRelations.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Таблицы";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Аттрибуты таблицы";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Отношения";
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.Location = new System.Drawing.Point(367, 78);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(30, 13);
            this.tableLabel.TabIndex = 16;
            this.tableLabel.Text = "table";
            // 
            // TableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 516);
            this.Controls.Add(this.tableLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridViewRelations);
            this.Controls.Add(this.gridView2);
            this.Controls.Add(this.gridViewTables);
            this.Controls.Add(this.manage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dbComboEdit);
            this.Name = "TableForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewRelations)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel manage;
        private Controls.ComboEdit dbComboEdit;
        private GridView gridViewTables;
        private GridView gridView2;
        private GridView gridViewRelations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tableLabel;
    }
}