﻿namespace Entreprise
{
	partial class ParticipantUserControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParticipantUserControl));
			this.cbEmp = new System.Windows.Forms.ComboBox();
			this.bunifuCustomDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
			this.btnLast = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnNext = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnPrevious = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnFirst = new Bunifu.Framework.UI.BunifuImageButton();
			this.btnNouveau = new Bunifu.Framework.UI.BunifuFlatButton();
			this.btnSupprimer = new Bunifu.Framework.UI.BunifuFlatButton();
			this.btnModifier = new Bunifu.Framework.UI.BunifuFlatButton();
			this.btnAjouter = new Bunifu.Framework.UI.BunifuFlatButton();
			this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.cbStage = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnLast)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnNext)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.btnFirst)).BeginInit();
			this.SuspendLayout();
			// 
			// cbEmp
			// 
			this.cbEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbEmp.FormattingEnabled = true;
			this.cbEmp.Location = new System.Drawing.Point(542, 43);
			this.cbEmp.Name = "cbEmp";
			this.cbEmp.Size = new System.Drawing.Size(187, 28);
			this.cbEmp.TabIndex = 39;
			// 
			// bunifuCustomDataGrid1
			// 
			this.bunifuCustomDataGrid1.AllowUserToAddRows = false;
			this.bunifuCustomDataGrid1.AllowUserToDeleteRows = false;
			this.bunifuCustomDataGrid1.AllowUserToOrderColumns = true;
			this.bunifuCustomDataGrid1.AllowUserToResizeRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.bunifuCustomDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.bunifuCustomDataGrid1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
			this.bunifuCustomDataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro;
			this.bunifuCustomDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.bunifuCustomDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.DimGray;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.bunifuCustomDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.bunifuCustomDataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.bunifuCustomDataGrid1.DefaultCellStyle = dataGridViewCellStyle3;
			this.bunifuCustomDataGrid1.DoubleBuffered = false;
			this.bunifuCustomDataGrid1.EnableHeadersVisualStyles = false;
			this.bunifuCustomDataGrid1.HeaderBgColor = System.Drawing.Color.DimGray;
			this.bunifuCustomDataGrid1.HeaderForeColor = System.Drawing.Color.Black;
			this.bunifuCustomDataGrid1.Location = new System.Drawing.Point(169, 330);
			this.bunifuCustomDataGrid1.MultiSelect = false;
			this.bunifuCustomDataGrid1.Name = "bunifuCustomDataGrid1";
			this.bunifuCustomDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.bunifuCustomDataGrid1.Size = new System.Drawing.Size(725, 205);
			this.bunifuCustomDataGrid1.TabIndex = 38;
			this.bunifuCustomDataGrid1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellClick);
			// 
			// btnLast
			// 
			this.btnLast.BackColor = System.Drawing.Color.Transparent;
			this.btnLast.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnLast.Image = ((System.Drawing.Image)(resources.GetObject("btnLast.Image")));
			this.btnLast.ImageActive = null;
			this.btnLast.Location = new System.Drawing.Point(782, 185);
			this.btnLast.Name = "btnLast";
			this.btnLast.Size = new System.Drawing.Size(55, 43);
			this.btnLast.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnLast.TabIndex = 34;
			this.btnLast.TabStop = false;
			this.btnLast.Zoom = 10;
			this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
			// 
			// btnNext
			// 
			this.btnNext.BackColor = System.Drawing.Color.Transparent;
			this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
			this.btnNext.ImageActive = null;
			this.btnNext.Location = new System.Drawing.Point(610, 185);
			this.btnNext.Name = "btnNext";
			this.btnNext.Size = new System.Drawing.Size(55, 43);
			this.btnNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnNext.TabIndex = 35;
			this.btnNext.TabStop = false;
			this.btnNext.Zoom = 10;
			this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
			// 
			// btnPrevious
			// 
			this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
			this.btnPrevious.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
			this.btnPrevious.ImageActive = null;
			this.btnPrevious.Location = new System.Drawing.Point(420, 185);
			this.btnPrevious.Name = "btnPrevious";
			this.btnPrevious.Size = new System.Drawing.Size(55, 43);
			this.btnPrevious.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnPrevious.TabIndex = 36;
			this.btnPrevious.TabStop = false;
			this.btnPrevious.Zoom = 10;
			this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
			// 
			// btnFirst
			// 
			this.btnFirst.BackColor = System.Drawing.Color.Transparent;
			this.btnFirst.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnFirst.Image = ((System.Drawing.Image)(resources.GetObject("btnFirst.Image")));
			this.btnFirst.ImageActive = null;
			this.btnFirst.Location = new System.Drawing.Point(227, 185);
			this.btnFirst.Name = "btnFirst";
			this.btnFirst.Size = new System.Drawing.Size(55, 43);
			this.btnFirst.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.btnFirst.TabIndex = 37;
			this.btnFirst.TabStop = false;
			this.btnFirst.Zoom = 10;
			this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
			// 
			// btnNouveau
			// 
			this.btnNouveau.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
			this.btnNouveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
			this.btnNouveau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnNouveau.BorderRadius = 7;
			this.btnNouveau.ButtonText = "Nouveau";
			this.btnNouveau.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnNouveau.DisabledColor = System.Drawing.Color.Gray;
			this.btnNouveau.Iconcolor = System.Drawing.Color.Transparent;
			this.btnNouveau.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnNouveau.Iconimage")));
			this.btnNouveau.Iconimage_right = null;
			this.btnNouveau.Iconimage_right_Selected = null;
			this.btnNouveau.Iconimage_Selected = null;
			this.btnNouveau.IconMarginLeft = 0;
			this.btnNouveau.IconMarginRight = 0;
			this.btnNouveau.IconRightVisible = true;
			this.btnNouveau.IconRightZoom = 0D;
			this.btnNouveau.IconVisible = true;
			this.btnNouveau.IconZoom = 60D;
			this.btnNouveau.IsTab = false;
			this.btnNouveau.Location = new System.Drawing.Point(731, 273);
			this.btnNouveau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnNouveau.Name = "btnNouveau";
			this.btnNouveau.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
			this.btnNouveau.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
			this.btnNouveau.OnHoverTextColor = System.Drawing.Color.Black;
			this.btnNouveau.selected = false;
			this.btnNouveau.Size = new System.Drawing.Size(163, 49);
			this.btnNouveau.TabIndex = 30;
			this.btnNouveau.Text = "Nouveau";
			this.btnNouveau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNouveau.Textcolor = System.Drawing.Color.White;
			this.btnNouveau.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
			// 
			// btnSupprimer
			// 
			this.btnSupprimer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
			this.btnSupprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
			this.btnSupprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSupprimer.BorderRadius = 7;
			this.btnSupprimer.ButtonText = "Supprimer";
			this.btnSupprimer.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSupprimer.DisabledColor = System.Drawing.Color.Gray;
			this.btnSupprimer.Iconcolor = System.Drawing.Color.Transparent;
			this.btnSupprimer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSupprimer.Iconimage")));
			this.btnSupprimer.Iconimage_right = null;
			this.btnSupprimer.Iconimage_right_Selected = null;
			this.btnSupprimer.Iconimage_Selected = null;
			this.btnSupprimer.IconMarginLeft = 0;
			this.btnSupprimer.IconMarginRight = 0;
			this.btnSupprimer.IconRightVisible = true;
			this.btnSupprimer.IconRightZoom = 0D;
			this.btnSupprimer.IconVisible = true;
			this.btnSupprimer.IconZoom = 50D;
			this.btnSupprimer.IsTab = false;
			this.btnSupprimer.Location = new System.Drawing.Point(542, 273);
			this.btnSupprimer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSupprimer.Name = "btnSupprimer";
			this.btnSupprimer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
			this.btnSupprimer.OnHovercolor = System.Drawing.Color.IndianRed;
			this.btnSupprimer.OnHoverTextColor = System.Drawing.Color.Black;
			this.btnSupprimer.selected = false;
			this.btnSupprimer.Size = new System.Drawing.Size(163, 49);
			this.btnSupprimer.TabIndex = 31;
			this.btnSupprimer.Text = "Supprimer";
			this.btnSupprimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSupprimer.Textcolor = System.Drawing.Color.White;
			this.btnSupprimer.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
			// 
			// btnModifier
			// 
			this.btnModifier.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
			this.btnModifier.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
			this.btnModifier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnModifier.BorderRadius = 7;
			this.btnModifier.ButtonText = "Modifier";
			this.btnModifier.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnModifier.DisabledColor = System.Drawing.Color.Gray;
			this.btnModifier.Iconcolor = System.Drawing.Color.Transparent;
			this.btnModifier.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnModifier.Iconimage")));
			this.btnModifier.Iconimage_right = null;
			this.btnModifier.Iconimage_right_Selected = null;
			this.btnModifier.Iconimage_Selected = null;
			this.btnModifier.IconMarginLeft = 0;
			this.btnModifier.IconMarginRight = 0;
			this.btnModifier.IconRightVisible = true;
			this.btnModifier.IconRightZoom = 0D;
			this.btnModifier.IconVisible = true;
			this.btnModifier.IconZoom = 50D;
			this.btnModifier.IsTab = false;
			this.btnModifier.Location = new System.Drawing.Point(352, 273);
			this.btnModifier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnModifier.Name = "btnModifier";
			this.btnModifier.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(137)))), ((int)(((byte)(167)))));
			this.btnModifier.OnHovercolor = System.Drawing.Color.CadetBlue;
			this.btnModifier.OnHoverTextColor = System.Drawing.Color.Black;
			this.btnModifier.selected = false;
			this.btnModifier.Size = new System.Drawing.Size(163, 49);
			this.btnModifier.TabIndex = 32;
			this.btnModifier.Text = "Modifier";
			this.btnModifier.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnModifier.Textcolor = System.Drawing.Color.White;
			this.btnModifier.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
			// 
			// btnAjouter
			// 
			this.btnAjouter.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
			this.btnAjouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
			this.btnAjouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnAjouter.BorderRadius = 7;
			this.btnAjouter.ButtonText = "Ajouter";
			this.btnAjouter.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnAjouter.DisabledColor = System.Drawing.Color.Gray;
			this.btnAjouter.Iconcolor = System.Drawing.Color.Transparent;
			this.btnAjouter.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAjouter.Iconimage")));
			this.btnAjouter.Iconimage_right = null;
			this.btnAjouter.Iconimage_right_Selected = null;
			this.btnAjouter.Iconimage_Selected = null;
			this.btnAjouter.IconMarginLeft = 0;
			this.btnAjouter.IconMarginRight = 0;
			this.btnAjouter.IconRightVisible = true;
			this.btnAjouter.IconRightZoom = 0D;
			this.btnAjouter.IconVisible = true;
			this.btnAjouter.IconZoom = 60D;
			this.btnAjouter.IsTab = false;
			this.btnAjouter.Location = new System.Drawing.Point(169, 273);
			this.btnAjouter.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnAjouter.Name = "btnAjouter";
			this.btnAjouter.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(90)))), ((int)(((byte)(36)))));
			this.btnAjouter.OnHovercolor = System.Drawing.Color.DarkSalmon;
			this.btnAjouter.OnHoverTextColor = System.Drawing.Color.Black;
			this.btnAjouter.selected = false;
			this.btnAjouter.Size = new System.Drawing.Size(163, 49);
			this.btnAjouter.TabIndex = 33;
			this.btnAjouter.Text = "Ajouter";
			this.btnAjouter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnAjouter.Textcolor = System.Drawing.Color.White;
			this.btnAjouter.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
			// 
			// bunifuCustomLabel2
			// 
			this.bunifuCustomLabel2.AutoSize = true;
			this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.bunifuCustomLabel2.Location = new System.Drawing.Point(347, 45);
			this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
			this.bunifuCustomLabel2.Size = new System.Drawing.Size(83, 21);
			this.bunifuCustomLabel2.TabIndex = 24;
			this.bunifuCustomLabel2.Text = "ID Eployée";
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.AutoSize = true;
			this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(348, 121);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(67, 21);
			this.bunifuCustomLabel1.TabIndex = 24;
			this.bunifuCustomLabel1.Text = "ID Stage";
			// 
			// cbStage
			// 
			this.cbStage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbStage.FormattingEnabled = true;
			this.cbStage.Location = new System.Drawing.Point(542, 119);
			this.cbStage.Name = "cbStage";
			this.cbStage.Size = new System.Drawing.Size(187, 28);
			this.cbStage.TabIndex = 39;
			// 
			// ParticipantUserControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.Controls.Add(this.cbStage);
			this.Controls.Add(this.cbEmp);
			this.Controls.Add(this.bunifuCustomDataGrid1);
			this.Controls.Add(this.btnLast);
			this.Controls.Add(this.btnNext);
			this.Controls.Add(this.btnPrevious);
			this.Controls.Add(this.btnFirst);
			this.Controls.Add(this.btnNouveau);
			this.Controls.Add(this.btnSupprimer);
			this.Controls.Add(this.btnModifier);
			this.Controls.Add(this.bunifuCustomLabel1);
			this.Controls.Add(this.btnAjouter);
			this.Controls.Add(this.bunifuCustomLabel2);
			this.Name = "ParticipantUserControl";
			this.Size = new System.Drawing.Size(1067, 538);
			((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnLast)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnNext)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnPrevious)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.btnFirst)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ComboBox cbEmp;
		private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid1;
		private Bunifu.Framework.UI.BunifuImageButton btnLast;
		private Bunifu.Framework.UI.BunifuImageButton btnNext;
		private Bunifu.Framework.UI.BunifuImageButton btnPrevious;
		private Bunifu.Framework.UI.BunifuImageButton btnFirst;
		private Bunifu.Framework.UI.BunifuFlatButton btnNouveau;
		private Bunifu.Framework.UI.BunifuFlatButton btnSupprimer;
		private Bunifu.Framework.UI.BunifuFlatButton btnModifier;
		private Bunifu.Framework.UI.BunifuFlatButton btnAjouter;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
		private System.Windows.Forms.ComboBox cbStage;
	}
}
