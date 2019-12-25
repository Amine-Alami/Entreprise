namespace Entreprise
{
	partial class NewForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewForm));
			this.cbStage = new System.Windows.Forms.ComboBox();
			this.cbEmp = new System.Windows.Forms.ComboBox();
			this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.btnNouveau = new Bunifu.Framework.UI.BunifuFlatButton();
			this.SuspendLayout();
			// 
			// cbStage
			// 
			this.cbStage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbStage.FormattingEnabled = true;
			this.cbStage.Location = new System.Drawing.Point(245, 121);
			this.cbStage.Name = "cbStage";
			this.cbStage.Size = new System.Drawing.Size(187, 28);
			this.cbStage.TabIndex = 42;
			// 
			// cbEmp
			// 
			this.cbEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbEmp.FormattingEnabled = true;
			this.cbEmp.Location = new System.Drawing.Point(245, 45);
			this.cbEmp.Name = "cbEmp";
			this.cbEmp.Size = new System.Drawing.Size(187, 28);
			this.cbEmp.TabIndex = 43;
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.AutoSize = true;
			this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(50, 120);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(105, 29);
			this.bunifuCustomLabel1.TabIndex = 40;
			this.bunifuCustomLabel1.Text = "ID Stage";
			// 
			// bunifuCustomLabel2
			// 
			this.bunifuCustomLabel2.AutoSize = true;
			this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel2.Location = new System.Drawing.Point(50, 44);
			this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
			this.bunifuCustomLabel2.Size = new System.Drawing.Size(131, 29);
			this.bunifuCustomLabel2.TabIndex = 41;
			this.bunifuCustomLabel2.Text = "ID Eployée";
			// 
			// btnNouveau
			// 
			this.btnNouveau.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
			this.btnNouveau.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
			this.btnNouveau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnNouveau.BorderRadius = 7;
			this.btnNouveau.ButtonText = "Confirmer";
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
			this.btnNouveau.Location = new System.Drawing.Point(149, 193);
			this.btnNouveau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnNouveau.Name = "btnNouveau";
			this.btnNouveau.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(148)))), ((int)(((byte)(50)))));
			this.btnNouveau.OnHovercolor = System.Drawing.Color.MediumSeaGreen;
			this.btnNouveau.OnHoverTextColor = System.Drawing.Color.Black;
			this.btnNouveau.selected = false;
			this.btnNouveau.Size = new System.Drawing.Size(163, 49);
			this.btnNouveau.TabIndex = 44;
			this.btnNouveau.Text = "Confirmer";
			this.btnNouveau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnNouveau.Textcolor = System.Drawing.Color.White;
			this.btnNouveau.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
			// 
			// NewForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(493, 272);
			this.Controls.Add(this.btnNouveau);
			this.Controls.Add(this.cbStage);
			this.Controls.Add(this.cbEmp);
			this.Controls.Add(this.bunifuCustomLabel1);
			this.Controls.Add(this.bunifuCustomLabel2);
			this.Name = "NewForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "NewForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cbStage;
		private System.Windows.Forms.ComboBox cbEmp;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
		private Bunifu.Framework.UI.BunifuFlatButton btnNouveau;
	}
}