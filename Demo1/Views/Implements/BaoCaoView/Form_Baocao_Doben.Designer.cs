﻿
namespace ProductVertificationDesktopApp.Views.Implements.BaoCaoView
{
    partial class Form_Baocao_Doben
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_ImportData = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerStop = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dataGridView_doben = new System.Windows.Forms.DataGridView();
            this.button_Insert = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTarget = new System.Windows.Forms.ComboBox();
            this.textBoxAdditional = new System.Windows.Forms.TextBox();
            this.textBoxNameProduct = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_doben)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ImportData
            // 
            this.btn_ImportData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(77)))));
            this.btn_ImportData.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_ImportData.FlatAppearance.BorderSize = 0;
            this.btn_ImportData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ImportData.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ImportData.ForeColor = System.Drawing.Color.White;
            this.btn_ImportData.Location = new System.Drawing.Point(1005, 49);
            this.btn_ImportData.Name = "btn_ImportData";
            this.btn_ImportData.Size = new System.Drawing.Size(229, 79);
            this.btn_ImportData.TabIndex = 49;
            this.btn_ImportData.Text = "Truy xuất";
            this.btn_ImportData.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 31);
            this.label2.TabIndex = 48;
            this.label2.Text = "Đến ngày";
            // 
            // dateTimePickerStop
            // 
            this.dateTimePickerStop.CalendarFont = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStop.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(55)))));
            this.dateTimePickerStop.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerStop.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStop.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStop.Location = new System.Drawing.Point(210, 87);
            this.dateTimePickerStop.Name = "dateTimePickerStop";
            this.dateTimePickerStop.Size = new System.Drawing.Size(229, 45);
            this.dateTimePickerStop.TabIndex = 47;
            this.dateTimePickerStop.Value = new System.DateTime(2021, 6, 15, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 31);
            this.label1.TabIndex = 46;
            this.label1.Text = "Từ ngày";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.CalendarFont = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStart.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(29)))), ((int)(((byte)(55)))));
            this.dateTimePickerStart.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerStart.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerStart.Location = new System.Drawing.Point(210, 26);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(229, 45);
            this.dateTimePickerStart.TabIndex = 45;
            this.dateTimePickerStart.Value = new System.DateTime(2021, 6, 15, 0, 0, 0, 0);
            // 
            // dataGridView_doben
            // 
            this.dataGridView_doben.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_doben.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_doben.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_doben.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_doben.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(54)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_doben.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_doben.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView_doben.Location = new System.Drawing.Point(189, 272);
            this.dataGridView_doben.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView_doben.Name = "dataGridView_doben";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_doben.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_doben.RowHeadersWidth = 55;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView_doben.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_doben.RowTemplate.Height = 50;
            this.dataGridView_doben.Size = new System.Drawing.Size(1279, 584);
            this.dataGridView_doben.TabIndex = 50;
            // 
            // button_Insert
            // 
            this.button_Insert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(41)))), ((int)(((byte)(77)))));
            this.button_Insert.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button_Insert.FlatAppearance.BorderSize = 0;
            this.button_Insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Insert.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Insert.ForeColor = System.Drawing.Color.White;
            this.button_Insert.Location = new System.Drawing.Point(1289, 49);
            this.button_Insert.Name = "button_Insert";
            this.button_Insert.Size = new System.Drawing.Size(229, 79);
            this.button_Insert.TabIndex = 58;
            this.button_Insert.Text = "Xuất Excel";
            this.button_Insert.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(487, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 31);
            this.label3.TabIndex = 59;
            this.label3.Text = "Mục đích kiểm tra";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(487, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 31);
            this.label4.TabIndex = 60;
            this.label4.Text = "Chú thích";
            // 
            // comboBoxTarget
            // 
            this.comboBoxTarget.FormattingEnabled = true;
            this.comboBoxTarget.Location = new System.Drawing.Point(742, 24);
            this.comboBoxTarget.Name = "comboBoxTarget";
            this.comboBoxTarget.Size = new System.Drawing.Size(176, 40);
            this.comboBoxTarget.TabIndex = 61;
            // 
            // textBoxAdditional
            // 
            this.textBoxAdditional.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold);
            this.textBoxAdditional.Location = new System.Drawing.Point(742, 87);
            this.textBoxAdditional.Multiline = true;
            this.textBoxAdditional.Name = "textBoxAdditional";
            this.textBoxAdditional.Size = new System.Drawing.Size(176, 45);
            this.textBoxAdditional.TabIndex = 62;
            // 
            // textBoxNameProduct
            // 
            this.textBoxNameProduct.Font = new System.Drawing.Font("Arial", 19.8F, System.Drawing.FontStyle.Bold);
            this.textBoxNameProduct.Location = new System.Drawing.Point(493, 186);
            this.textBoxNameProduct.Multiline = true;
            this.textBoxNameProduct.Name = "textBoxNameProduct";
            this.textBoxNameProduct.Size = new System.Drawing.Size(718, 77);
            this.textBoxNameProduct.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(204, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(203, 31);
            this.label5.TabIndex = 64;
            this.label5.Text = "Tên Sản Phẩm";
            // 
            // Form_Baocao_Doben
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxNameProduct);
            this.Controls.Add(this.textBoxAdditional);
            this.Controls.Add(this.comboBoxTarget);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_Insert);
            this.Controls.Add(this.dataGridView_doben);
            this.Controls.Add(this.btn_ImportData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePickerStop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerStart);
            this.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form_Baocao_Doben";
            this.Size = new System.Drawing.Size(1607, 902);
            this.Load += new System.EventHandler(this.Form_Baocao_Doben_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_doben)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ImportData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DataGridView dataGridView_doben;
        private System.Windows.Forms.Button button_Insert;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTarget;
        private System.Windows.Forms.TextBox textBoxAdditional;
        private System.Windows.Forms.TextBox textBoxNameProduct;
        private System.Windows.Forms.Label label5;
    }
}