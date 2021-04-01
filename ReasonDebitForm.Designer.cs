﻿
namespace OGM
{
    partial class ReasonDebitForm
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
			this.button_RemoveReasonDebit = new System.Windows.Forms.Button();
			this.button_EditReasonDebit = new System.Windows.Forms.Button();
			this.button_AddReasonDebit = new System.Windows.Forms.Button();
			this.dataGridView_DataSearch = new System.Windows.Forms.DataGridView();
			this.Column_NameReasonDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column_CipherReasonDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.groupBox_Search = new System.Windows.Forms.GroupBox();
			this.button_Search = new System.Windows.Forms.Button();
			this.textBox_CipherReasonDebit = new System.Windows.Forms.TextBox();
			this.textBox_NameReasonDebit = new System.Windows.Forms.TextBox();
			this.label_Cipher = new System.Windows.Forms.Label();
			this.label_Name = new System.Windows.Forms.Label();
			this.button_ResetSearch = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_DataSearch)).BeginInit();
			this.groupBox_Search.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_RemoveReasonDebit
			// 
			this.button_RemoveReasonDebit.Location = new System.Drawing.Point(424, 190);
			this.button_RemoveReasonDebit.Name = "button_RemoveReasonDebit";
			this.button_RemoveReasonDebit.Size = new System.Drawing.Size(200, 29);
			this.button_RemoveReasonDebit.TabIndex = 7;
			this.button_RemoveReasonDebit.Text = "Удалить";
			this.button_RemoveReasonDebit.UseVisualStyleBackColor = true;
			// 
			// button_EditReasonDebit
			// 
			this.button_EditReasonDebit.Location = new System.Drawing.Point(218, 190);
			this.button_EditReasonDebit.Name = "button_EditReasonDebit";
			this.button_EditReasonDebit.Size = new System.Drawing.Size(200, 29);
			this.button_EditReasonDebit.TabIndex = 6;
			this.button_EditReasonDebit.Text = "Редактировать";
			this.button_EditReasonDebit.UseVisualStyleBackColor = true;
			// 
			// button_AddReasonDebit
			// 
			this.button_AddReasonDebit.Location = new System.Drawing.Point(12, 190);
			this.button_AddReasonDebit.Name = "button_AddReasonDebit";
			this.button_AddReasonDebit.Size = new System.Drawing.Size(200, 29);
			this.button_AddReasonDebit.TabIndex = 5;
			this.button_AddReasonDebit.Text = "Добавить";
			this.button_AddReasonDebit.UseVisualStyleBackColor = true;
			this.button_AddReasonDebit.Click += new System.EventHandler(this.button_AddEquipment_Click);
			// 
			// dataGridView_DataSearch
			// 
			this.dataGridView_DataSearch.BackgroundColor = System.Drawing.Color.FloralWhite;
			this.dataGridView_DataSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView_DataSearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_NameReasonDebit,
            this.Column_CipherReasonDebit});
			this.dataGridView_DataSearch.Location = new System.Drawing.Point(12, 239);
			this.dataGridView_DataSearch.Name = "dataGridView_DataSearch";
			this.dataGridView_DataSearch.Size = new System.Drawing.Size(860, 310);
			this.dataGridView_DataSearch.TabIndex = 8;
			// 
			// Column_NameReasonDebit
			// 
			this.Column_NameReasonDebit.HeaderText = "Наименование";
			this.Column_NameReasonDebit.Name = "Column_NameReasonDebit";
			this.Column_NameReasonDebit.ReadOnly = true;
			this.Column_NameReasonDebit.Width = 430;
			// 
			// Column_CipherReasonDebit
			// 
			this.Column_CipherReasonDebit.HeaderText = "Шифр";
			this.Column_CipherReasonDebit.Name = "Column_CipherReasonDebit";
			this.Column_CipherReasonDebit.ReadOnly = true;
			this.Column_CipherReasonDebit.Width = 200;
			// 
			// groupBox_Search
			// 
			this.groupBox_Search.Controls.Add(this.button_ResetSearch);
			this.groupBox_Search.Controls.Add(this.button_Search);
			this.groupBox_Search.Controls.Add(this.textBox_CipherReasonDebit);
			this.groupBox_Search.Controls.Add(this.textBox_NameReasonDebit);
			this.groupBox_Search.Controls.Add(this.label_Cipher);
			this.groupBox_Search.Controls.Add(this.label_Name);
			this.groupBox_Search.Location = new System.Drawing.Point(12, 12);
			this.groupBox_Search.Name = "groupBox_Search";
			this.groupBox_Search.Size = new System.Drawing.Size(860, 162);
			this.groupBox_Search.TabIndex = 17;
			this.groupBox_Search.TabStop = false;
			this.groupBox_Search.Text = "Параметры поиска";
			// 
			// button_Search
			// 
			this.button_Search.Location = new System.Drawing.Point(520, 36);
			this.button_Search.Name = "button_Search";
			this.button_Search.Size = new System.Drawing.Size(300, 29);
			this.button_Search.TabIndex = 3;
			this.button_Search.Text = "Найти";
			this.button_Search.UseVisualStyleBackColor = true;
			// 
			// textBox_CipherReasonDebit
			// 
			this.textBox_CipherReasonDebit.Location = new System.Drawing.Point(179, 76);
			this.textBox_CipherReasonDebit.Name = "textBox_CipherReasonDebit";
			this.textBox_CipherReasonDebit.Size = new System.Drawing.Size(200, 29);
			this.textBox_CipherReasonDebit.TabIndex = 2;
			// 
			// textBox_NameReasonDebit
			// 
			this.textBox_NameReasonDebit.Location = new System.Drawing.Point(179, 36);
			this.textBox_NameReasonDebit.Name = "textBox_NameReasonDebit";
			this.textBox_NameReasonDebit.Size = new System.Drawing.Size(200, 29);
			this.textBox_NameReasonDebit.TabIndex = 1;
			// 
			// label_Cipher
			// 
			this.label_Cipher.AutoSize = true;
			this.label_Cipher.Location = new System.Drawing.Point(116, 80);
			this.label_Cipher.Name = "label_Cipher";
			this.label_Cipher.Size = new System.Drawing.Size(57, 21);
			this.label_Cipher.TabIndex = 2;
			this.label_Cipher.Text = "Шифр:";
			// 
			// label_Name
			// 
			this.label_Name.AutoSize = true;
			this.label_Name.Location = new System.Drawing.Point(53, 40);
			this.label_Name.Name = "label_Name";
			this.label_Name.Size = new System.Drawing.Size(120, 21);
			this.label_Name.TabIndex = 0;
			this.label_Name.Text = "Наименование:";
			// 
			// button_ResetSearch
			// 
			this.button_ResetSearch.Location = new System.Drawing.Point(520, 76);
			this.button_ResetSearch.Name = "button_ResetSearch";
			this.button_ResetSearch.Size = new System.Drawing.Size(300, 29);
			this.button_ResetSearch.TabIndex = 4;
			this.button_ResetSearch.Text = "Сбросить параметры поиска";
			this.button_ResetSearch.UseVisualStyleBackColor = true;
			// 
			// ReasonDebitForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(884, 561);
			this.Controls.Add(this.button_RemoveReasonDebit);
			this.Controls.Add(this.button_EditReasonDebit);
			this.Controls.Add(this.button_AddReasonDebit);
			this.Controls.Add(this.dataGridView_DataSearch);
			this.Controls.Add(this.groupBox_Search);
			this.Font = new System.Drawing.Font("Segoe WP", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "ReasonDebitForm";
			this.Text = "Справочник - Причина списания";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView_DataSearch)).EndInit();
			this.groupBox_Search.ResumeLayout(false);
			this.groupBox_Search.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_RemoveReasonDebit;
        private System.Windows.Forms.Button button_EditReasonDebit;
        private System.Windows.Forms.Button button_AddReasonDebit;
        private System.Windows.Forms.DataGridView dataGridView_DataSearch;
        private System.Windows.Forms.GroupBox groupBox_Search;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_CipherReasonDebit;
        private System.Windows.Forms.TextBox textBox_NameReasonDebit;
        private System.Windows.Forms.Label label_Cipher;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_NameReasonDebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_CipherReasonDebit;
		private System.Windows.Forms.Button button_ResetSearch;
	}
}