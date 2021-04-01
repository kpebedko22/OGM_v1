﻿
namespace OGM
{
    partial class GroupEquipmentForm
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
			this.button_RemoveGroupEquipment = new System.Windows.Forms.Button();
			this.button_EditGroupEquipment = new System.Windows.Forms.Button();
			this.button_AddGroupEquipment = new System.Windows.Forms.Button();
			this.dataGridView_DataSearch = new System.Windows.Forms.DataGridView();
			this.groupBox_Search = new System.Windows.Forms.GroupBox();
			this.comboBox_Workshop = new System.Windows.Forms.ComboBox();
			this.label_Workshop = new System.Windows.Forms.Label();
			this.textBox_Сipher = new System.Windows.Forms.TextBox();
			this.button_Search = new System.Windows.Forms.Button();
			this.textBox_NameEquipment = new System.Windows.Forms.TextBox();
			this.label_Сipher = new System.Windows.Forms.Label();
			this.label_NameEquipment = new System.Windows.Forms.Label();
			this.button_ResetSearch = new System.Windows.Forms.Button();
			this.Column_NameEquipment = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_Сipher = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_Workshop = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_DataSearch)).BeginInit();
			this.groupBox_Search.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_RemoveGroupEquipment
			// 
			this.button_RemoveGroupEquipment.Location = new System.Drawing.Point(424, 190);
			this.button_RemoveGroupEquipment.Name = "button_RemoveGroupEquipment";
			this.button_RemoveGroupEquipment.Size = new System.Drawing.Size(200, 29);
			this.button_RemoveGroupEquipment.TabIndex = 8;
			this.button_RemoveGroupEquipment.Text = "Удалить";
			this.button_RemoveGroupEquipment.UseVisualStyleBackColor = true;
			// 
			// button_EditGroupEquipment
			// 
			this.button_EditGroupEquipment.Location = new System.Drawing.Point(218, 190);
			this.button_EditGroupEquipment.Name = "button_EditGroupEquipment";
			this.button_EditGroupEquipment.Size = new System.Drawing.Size(200, 29);
			this.button_EditGroupEquipment.TabIndex = 7;
			this.button_EditGroupEquipment.Text = "Редактировать";
			this.button_EditGroupEquipment.UseVisualStyleBackColor = true;
			// 
			// button_AddGroupEquipment
			// 
			this.button_AddGroupEquipment.Location = new System.Drawing.Point(12, 190);
			this.button_AddGroupEquipment.Name = "button_AddGroupEquipment";
			this.button_AddGroupEquipment.Size = new System.Drawing.Size(200, 29);
			this.button_AddGroupEquipment.TabIndex = 6;
			this.button_AddGroupEquipment.Text = "Добавить";
			this.button_AddGroupEquipment.UseVisualStyleBackColor = true;
			this.button_AddGroupEquipment.Click += new System.EventHandler(this.button_AddGroupEquipment_Click);
			// 
			// dataGridView_DataSearch
			// 
			this.dataGridView_DataSearch.BackgroundColor = System.Drawing.Color.FloralWhite;
			this.dataGridView_DataSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_DataSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_NameEquipment,
            this.Column_Сipher,
            this.Column_Workshop});
			this.dataGridView_DataSearch.Location = new System.Drawing.Point(12, 239);
			this.dataGridView_DataSearch.Name = "dataGridView_DataSearch";
			this.dataGridView_DataSearch.Size = new System.Drawing.Size(860, 310);
			this.dataGridView_DataSearch.TabIndex = 9;
			// 
			// groupBox_Search
			// 
			this.groupBox_Search.Controls.Add(this.button_ResetSearch);
			this.groupBox_Search.Controls.Add(this.comboBox_Workshop);
			this.groupBox_Search.Controls.Add(this.label_Workshop);
			this.groupBox_Search.Controls.Add(this.textBox_Сipher);
			this.groupBox_Search.Controls.Add(this.button_Search);
			this.groupBox_Search.Controls.Add(this.textBox_NameEquipment);
			this.groupBox_Search.Controls.Add(this.label_Сipher);
			this.groupBox_Search.Controls.Add(this.label_NameEquipment);
			this.groupBox_Search.Location = new System.Drawing.Point(12, 12);
			this.groupBox_Search.Name = "groupBox_Search";
			this.groupBox_Search.Size = new System.Drawing.Size(860, 162);
			this.groupBox_Search.TabIndex = 12;
			this.groupBox_Search.TabStop = false;
			this.groupBox_Search.Text = "Параметры поиска";
			// 
			// comboBox_Workshop
			// 
			this.comboBox_Workshop.FormattingEnabled = true;
			this.comboBox_Workshop.Location = new System.Drawing.Point(179, 116);
			this.comboBox_Workshop.Name = "comboBox_Workshop";
			this.comboBox_Workshop.Size = new System.Drawing.Size(200, 29);
			this.comboBox_Workshop.TabIndex = 3;
			// 
			// label_Workshop
			// 
			this.label_Workshop.AutoSize = true;
			this.label_Workshop.Location = new System.Drawing.Point(131, 118);
			this.label_Workshop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Workshop.Name = "label_Workshop";
			this.label_Workshop.Size = new System.Drawing.Size(40, 21);
			this.label_Workshop.TabIndex = 10;
			this.label_Workshop.Text = "Цех:";
			// 
			// textBox_Сipher
			// 
			this.textBox_Сipher.Location = new System.Drawing.Point(179, 76);
			this.textBox_Сipher.Name = "textBox_Сipher";
			this.textBox_Сipher.Size = new System.Drawing.Size(200, 29);
			this.textBox_Сipher.TabIndex = 2;
			// 
			// button_Search
			// 
			this.button_Search.Location = new System.Drawing.Point(520, 36);
			this.button_Search.Name = "button_Search";
			this.button_Search.Size = new System.Drawing.Size(300, 29);
			this.button_Search.TabIndex = 4;
			this.button_Search.Text = "Найти";
			this.button_Search.UseVisualStyleBackColor = true;
			// 
			// textBox_NameEquipment
			// 
			this.textBox_NameEquipment.Location = new System.Drawing.Point(179, 36);
			this.textBox_NameEquipment.Name = "textBox_NameEquipment";
			this.textBox_NameEquipment.Size = new System.Drawing.Size(200, 29);
			this.textBox_NameEquipment.TabIndex = 1;
			// 
			// label_Сipher
			// 
			this.label_Сipher.AutoSize = true;
			this.label_Сipher.Location = new System.Drawing.Point(114, 78);
			this.label_Сipher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_Сipher.Name = "label_Сipher";
			this.label_Сipher.Size = new System.Drawing.Size(57, 21);
			this.label_Сipher.TabIndex = 3;
			this.label_Сipher.Text = "Шифр:";
			// 
			// label_NameEquipment
			// 
			this.label_NameEquipment.AutoSize = true;
			this.label_NameEquipment.Location = new System.Drawing.Point(51, 38);
			this.label_NameEquipment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label_NameEquipment.Name = "label_NameEquipment";
			this.label_NameEquipment.Size = new System.Drawing.Size(120, 21);
			this.label_NameEquipment.TabIndex = 0;
			this.label_NameEquipment.Text = "Наименование:";
			// 
			// button_ResetSearch
			// 
			this.button_ResetSearch.Location = new System.Drawing.Point(520, 76);
			this.button_ResetSearch.Name = "button_ResetSearch";
			this.button_ResetSearch.Size = new System.Drawing.Size(300, 29);
			this.button_ResetSearch.TabIndex = 5;
			this.button_ResetSearch.Text = "Сбросить параметры поиска";
			this.button_ResetSearch.UseVisualStyleBackColor = true;
			// 
			// Column_NameEquipment
			// 
			this.Column_NameEquipment.HeaderText = "Наименование";
			this.Column_NameEquipment.Name = "Column_NameEquipment";
			this.Column_NameEquipment.ReadOnly = true;
			this.Column_NameEquipment.Width = 300;
			// 
			// Column_Сipher
			// 
			this.Column_Сipher.HeaderText = "Шифр";
			this.Column_Сipher.Name = "Column_Сipher";
			this.Column_Сipher.ReadOnly = true;
			this.Column_Сipher.Width = 150;
			// 
			// Column_Workshop
			// 
			this.Column_Workshop.HeaderText = "Цех";
			this.Column_Workshop.Name = "Column_Workshop";
			this.Column_Workshop.ReadOnly = true;
			this.Column_Workshop.Width = 200;
			// 
			// GroupEquipmentForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 561);
			this.Controls.Add(this.button_RemoveGroupEquipment);
			this.Controls.Add(this.button_EditGroupEquipment);
			this.Controls.Add(this.button_AddGroupEquipment);
			this.Controls.Add(this.dataGridView_DataSearch);
			this.Controls.Add(this.groupBox_Search);
			this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "GroupEquipmentForm";
			this.Text = "Справочник - Группа оборудования";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_DataSearch)).EndInit();
			this.groupBox_Search.ResumeLayout(false);
			this.groupBox_Search.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_RemoveGroupEquipment;
        private System.Windows.Forms.Button button_EditGroupEquipment;
        private System.Windows.Forms.Button button_AddGroupEquipment;
        private System.Windows.Forms.DataGridView dataGridView_DataSearch;
        private System.Windows.Forms.GroupBox groupBox_Search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_NameEquipment;
        private System.Windows.Forms.Label label_Сipher;
        private System.Windows.Forms.Label label_NameEquipment;
        private System.Windows.Forms.TextBox textBox_Сipher;
        private System.Windows.Forms.ComboBox comboBox_Workshop;
        private System.Windows.Forms.Label label_Workshop;
		private System.Windows.Forms.Button button_ResetSearch;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_NameEquipment;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_Сipher;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column_Workshop;
	}
}