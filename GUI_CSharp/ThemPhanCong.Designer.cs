﻿namespace GUI_CSharp
{
    partial class ThemPhanCong
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
            this.cardPhancong = new MaterialSkin.Controls.MaterialCard();
            this.btnThem = new MaterialSkin.Controls.MaterialButton();
            this.label1 = new System.Windows.Forms.Label();
            this.cbPhancongNamhoc = new MaterialSkin.Controls.MaterialComboBox();
            this.cbPhancongMalop = new MaterialSkin.Controls.MaterialComboBox();
            this.cbPhancongGV = new MaterialSkin.Controls.MaterialComboBox();
            this.cbPhancongMonhoc = new MaterialSkin.Controls.MaterialComboBox();
            this.txSttPhancong = new MaterialSkin.Controls.MaterialTextBox();
            this.cardPhancong.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardPhancong
            // 
            this.cardPhancong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cardPhancong.Controls.Add(this.btnThem);
            this.cardPhancong.Controls.Add(this.label1);
            this.cardPhancong.Controls.Add(this.cbPhancongNamhoc);
            this.cardPhancong.Controls.Add(this.cbPhancongMalop);
            this.cardPhancong.Controls.Add(this.cbPhancongGV);
            this.cardPhancong.Controls.Add(this.cbPhancongMonhoc);
            this.cardPhancong.Controls.Add(this.txSttPhancong);
            this.cardPhancong.Depth = 0;
            this.cardPhancong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cardPhancong.Location = new System.Drawing.Point(23, 96);
            this.cardPhancong.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.cardPhancong.MouseState = MaterialSkin.MouseState.HOVER;
            this.cardPhancong.Name = "cardPhancong";
            this.cardPhancong.Padding = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.cardPhancong.Size = new System.Drawing.Size(843, 853);
            this.cardPhancong.TabIndex = 16;
            // 
            // btnThem
            // 
            this.btnThem.AutoSize = false;
            this.btnThem.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnThem.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnThem.Depth = 0;
            this.btnThem.HighEmphasis = true;
            this.btnThem.Icon = global::GUI_CSharp.Properties.Resources.add;
            this.btnThem.Location = new System.Drawing.Point(232, 671);
            this.btnThem.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.btnThem.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnThem.Name = "btnThem";
            this.btnThem.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnThem.Size = new System.Drawing.Size(372, 52);
            this.btnThem.TabIndex = 17;
            this.btnThem.TabStop = false;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnThem.UseAccentColor = false;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 71);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(331, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "PHÂN CÔNG GIẢNG DẠY";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbPhancongNamhoc
            // 
            this.cbPhancongNamhoc.AutoResize = false;
            this.cbPhancongNamhoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbPhancongNamhoc.Depth = 0;
            this.cbPhancongNamhoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbPhancongNamhoc.DropDownHeight = 174;
            this.cbPhancongNamhoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhancongNamhoc.DropDownWidth = 121;
            this.cbPhancongNamhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbPhancongNamhoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbPhancongNamhoc.FormattingEnabled = true;
            this.cbPhancongNamhoc.Hint = "Năm học";
            this.cbPhancongNamhoc.IntegralHeight = false;
            this.cbPhancongNamhoc.ItemHeight = 43;
            this.cbPhancongNamhoc.Location = new System.Drawing.Point(105, 254);
            this.cbPhancongNamhoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPhancongNamhoc.MaxDropDownItems = 4;
            this.cbPhancongNamhoc.MouseState = MaterialSkin.MouseState.OUT;
            this.cbPhancongNamhoc.Name = "cbPhancongNamhoc";
            this.cbPhancongNamhoc.Size = new System.Drawing.Size(612, 49);
            this.cbPhancongNamhoc.StartIndex = 0;
            this.cbPhancongNamhoc.TabIndex = 12;
            // 
            // cbPhancongMalop
            // 
            this.cbPhancongMalop.AutoResize = false;
            this.cbPhancongMalop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbPhancongMalop.Depth = 0;
            this.cbPhancongMalop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbPhancongMalop.DropDownHeight = 174;
            this.cbPhancongMalop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhancongMalop.DropDownWidth = 121;
            this.cbPhancongMalop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbPhancongMalop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbPhancongMalop.FormattingEnabled = true;
            this.cbPhancongMalop.Hint = "Mã lớp";
            this.cbPhancongMalop.IntegralHeight = false;
            this.cbPhancongMalop.ItemHeight = 43;
            this.cbPhancongMalop.Location = new System.Drawing.Point(105, 353);
            this.cbPhancongMalop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPhancongMalop.MaxDropDownItems = 4;
            this.cbPhancongMalop.MouseState = MaterialSkin.MouseState.OUT;
            this.cbPhancongMalop.Name = "cbPhancongMalop";
            this.cbPhancongMalop.Size = new System.Drawing.Size(612, 49);
            this.cbPhancongMalop.StartIndex = 0;
            this.cbPhancongMalop.TabIndex = 13;
            // 
            // cbPhancongGV
            // 
            this.cbPhancongGV.AutoResize = false;
            this.cbPhancongGV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbPhancongGV.Depth = 0;
            this.cbPhancongGV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbPhancongGV.DropDownHeight = 174;
            this.cbPhancongGV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhancongGV.DropDownWidth = 121;
            this.cbPhancongGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbPhancongGV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbPhancongGV.FormattingEnabled = true;
            this.cbPhancongGV.Hint = "Giáo viên dạy";
            this.cbPhancongGV.IntegralHeight = false;
            this.cbPhancongGV.ItemHeight = 43;
            this.cbPhancongGV.Location = new System.Drawing.Point(105, 554);
            this.cbPhancongGV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPhancongGV.MaxDropDownItems = 4;
            this.cbPhancongGV.MouseState = MaterialSkin.MouseState.OUT;
            this.cbPhancongGV.Name = "cbPhancongGV";
            this.cbPhancongGV.Size = new System.Drawing.Size(612, 49);
            this.cbPhancongGV.StartIndex = 0;
            this.cbPhancongGV.TabIndex = 13;
            // 
            // cbPhancongMonhoc
            // 
            this.cbPhancongMonhoc.AutoResize = false;
            this.cbPhancongMonhoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbPhancongMonhoc.Depth = 0;
            this.cbPhancongMonhoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbPhancongMonhoc.DropDownHeight = 174;
            this.cbPhancongMonhoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPhancongMonhoc.DropDownWidth = 121;
            this.cbPhancongMonhoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbPhancongMonhoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbPhancongMonhoc.FormattingEnabled = true;
            this.cbPhancongMonhoc.Hint = "Môn học";
            this.cbPhancongMonhoc.IntegralHeight = false;
            this.cbPhancongMonhoc.ItemHeight = 43;
            this.cbPhancongMonhoc.Location = new System.Drawing.Point(105, 455);
            this.cbPhancongMonhoc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPhancongMonhoc.MaxDropDownItems = 4;
            this.cbPhancongMonhoc.MouseState = MaterialSkin.MouseState.OUT;
            this.cbPhancongMonhoc.Name = "cbPhancongMonhoc";
            this.cbPhancongMonhoc.Size = new System.Drawing.Size(612, 49);
            this.cbPhancongMonhoc.StartIndex = 0;
            this.cbPhancongMonhoc.TabIndex = 13;
            // 
            // txSttPhancong
            // 
            this.txSttPhancong.AnimateReadOnly = false;
            this.txSttPhancong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txSttPhancong.Depth = 0;
            this.txSttPhancong.Enabled = false;
            this.txSttPhancong.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txSttPhancong.Hint = "Số thứ tự";
            this.txSttPhancong.LeadingIcon = null;
            this.txSttPhancong.Location = new System.Drawing.Point(105, 154);
            this.txSttPhancong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txSttPhancong.MaxLength = 50;
            this.txSttPhancong.MouseState = MaterialSkin.MouseState.OUT;
            this.txSttPhancong.Multiline = false;
            this.txSttPhancong.Name = "txSttPhancong";
            this.txSttPhancong.Size = new System.Drawing.Size(613, 50);
            this.txSttPhancong.TabIndex = 7;
            this.txSttPhancong.Text = "";
            this.txSttPhancong.TrailingIcon = null;
            // 
            // ThemPhanCong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 970);
            this.Controls.Add(this.cardPhancong);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ThemPhanCong";
            this.Padding = new System.Windows.Forms.Padding(4, 79, 4, 4);
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemPhanCong";
            this.cardPhancong.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard cardPhancong;
        private MaterialSkin.Controls.MaterialComboBox cbPhancongNamhoc;
        private MaterialSkin.Controls.MaterialComboBox cbPhancongMalop;
        private MaterialSkin.Controls.MaterialComboBox cbPhancongGV;
        private MaterialSkin.Controls.MaterialComboBox cbPhancongMonhoc;
        private MaterialSkin.Controls.MaterialTextBox txSttPhancong;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialButton btnThem;
    }
}