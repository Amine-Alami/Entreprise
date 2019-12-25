namespace Entreprise
{
	partial class Dashboard
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
			this.panel1 = new System.Windows.Forms.Panel();
			this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
			this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.btnParticipant = new Bunifu.Framework.UI.BunifuTileButton();
			this.btnStage = new Bunifu.Framework.UI.BunifuTileButton();
			this.btnEmploye = new Bunifu.Framework.UI.BunifuTileButton();
			this.btnDepartement = new Bunifu.Framework.UI.BunifuTileButton();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.departementUserControl1 = new Entreprise.DepartementUserControl();
			this.employeUserControl1 = new Entreprise.EmployeUserControl();
			this.stageUserControl1 = new Entreprise.StageUserControl();
			this.participantUserControl2 = new Entreprise.ParticipantUserControl();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
			this.panel1.Controls.Add(this.bunifuImageButton1);
			this.panel1.Controls.Add(this.bunifuCustomLabel1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(138, 685);
			this.panel1.TabIndex = 0;
			// 
			// bunifuImageButton1
			// 
			this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
			this.bunifuImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
			this.bunifuImageButton1.ImageActive = null;
			this.bunifuImageButton1.Location = new System.Drawing.Point(12, 19);
			this.bunifuImageButton1.Name = "bunifuImageButton1";
			this.bunifuImageButton1.Size = new System.Drawing.Size(110, 90);
			this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.bunifuImageButton1.TabIndex = 2;
			this.bunifuImageButton1.TabStop = false;
			this.bunifuImageButton1.Zoom = 10;
			this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
			// 
			// bunifuCustomLabel1
			// 
			this.bunifuCustomLabel1.AutoSize = true;
			this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
			this.bunifuCustomLabel1.Location = new System.Drawing.Point(32, 115);
			this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
			this.bunifuCustomLabel1.Size = new System.Drawing.Size(72, 25);
			this.bunifuCustomLabel1.TabIndex = 1;
			this.bunifuCustomLabel1.Text = "Admin";
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(212)))), ((int)(((byte)(233)))));
			this.panel2.Controls.Add(this.btnParticipant);
			this.panel2.Controls.Add(this.btnStage);
			this.panel2.Controls.Add(this.btnEmploye);
			this.panel2.Controls.Add(this.btnDepartement);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(138, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1067, 149);
			this.panel2.TabIndex = 1;
			// 
			// btnParticipant
			// 
			this.btnParticipant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(220)))), ((int)(((byte)(88)))));
			this.btnParticipant.color = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(220)))), ((int)(((byte)(88)))));
			this.btnParticipant.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
			this.btnParticipant.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnParticipant.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			this.btnParticipant.ForeColor = System.Drawing.Color.White;
			this.btnParticipant.Image = ((System.Drawing.Image)(resources.GetObject("btnParticipant.Image")));
			this.btnParticipant.ImagePosition = 5;
			this.btnParticipant.ImageZoom = 25;
			this.btnParticipant.LabelPosition = 41;
			this.btnParticipant.LabelText = "Participants";
			this.btnParticipant.Location = new System.Drawing.Point(813, 19);
			this.btnParticipant.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
			this.btnParticipant.Name = "btnParticipant";
			this.btnParticipant.Size = new System.Drawing.Size(212, 100);
			this.btnParticipant.TabIndex = 0;
			this.btnParticipant.Click += new System.EventHandler(this.btnParticipant_Click);
			// 
			// btnStage
			// 
			this.btnStage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
			this.btnStage.color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
			this.btnStage.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
			this.btnStage.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnStage.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			this.btnStage.ForeColor = System.Drawing.Color.White;
			this.btnStage.Image = ((System.Drawing.Image)(resources.GetObject("btnStage.Image")));
			this.btnStage.ImagePosition = 5;
			this.btnStage.ImageZoom = 25;
			this.btnStage.LabelPosition = 41;
			this.btnStage.LabelText = "Stages";
			this.btnStage.Location = new System.Drawing.Point(556, 22);
			this.btnStage.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
			this.btnStage.Name = "btnStage";
			this.btnStage.Size = new System.Drawing.Size(212, 100);
			this.btnStage.TabIndex = 0;
			this.btnStage.Click += new System.EventHandler(this.btnStage_Click);
			// 
			// btnEmploye
			// 
			this.btnEmploye.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
			this.btnEmploye.color = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(153)))), ((int)(((byte)(146)))));
			this.btnEmploye.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(103)))), ((int)(((byte)(106)))));
			this.btnEmploye.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnEmploye.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			this.btnEmploye.ForeColor = System.Drawing.Color.White;
			this.btnEmploye.Image = ((System.Drawing.Image)(resources.GetObject("btnEmploye.Image")));
			this.btnEmploye.ImagePosition = 5;
			this.btnEmploye.ImageZoom = 25;
			this.btnEmploye.LabelPosition = 41;
			this.btnEmploye.LabelText = "Employées";
			this.btnEmploye.Location = new System.Drawing.Point(286, 22);
			this.btnEmploye.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
			this.btnEmploye.Name = "btnEmploye";
			this.btnEmploye.Size = new System.Drawing.Size(212, 100);
			this.btnEmploye.TabIndex = 0;
			this.btnEmploye.Click += new System.EventHandler(this.btnEmploye_Click);
			// 
			// btnDepartement
			// 
			this.btnDepartement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
			this.btnDepartement.color = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
			this.btnDepartement.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(101)))), ((int)(((byte)(130)))));
			this.btnDepartement.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnDepartement.Font = new System.Drawing.Font("Century Gothic", 15.75F);
			this.btnDepartement.ForeColor = System.Drawing.Color.White;
			this.btnDepartement.Image = ((System.Drawing.Image)(resources.GetObject("btnDepartement.Image")));
			this.btnDepartement.ImagePosition = 5;
			this.btnDepartement.ImageZoom = 25;
			this.btnDepartement.LabelPosition = 41;
			this.btnDepartement.LabelText = "Départements";
			this.btnDepartement.Location = new System.Drawing.Point(23, 23);
			this.btnDepartement.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
			this.btnDepartement.Name = "btnDepartement";
			this.btnDepartement.Size = new System.Drawing.Size(212, 100);
			this.btnDepartement.TabIndex = 0;
			this.btnDepartement.Click += new System.EventHandler(this.btnDepartement_Click);
			// 
			// pictureBox6
			// 
			this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pictureBox6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.BackgroundImage")));
			this.pictureBox6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.pictureBox6.Location = new System.Drawing.Point(138, 147);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(1067, 538);
			this.pictureBox6.TabIndex = 4;
			this.pictureBox6.TabStop = false;
			// 
			// departementUserControl1
			// 
			this.departementUserControl1.Location = new System.Drawing.Point(138, 147);
			this.departementUserControl1.Name = "departementUserControl1";
			this.departementUserControl1.Size = new System.Drawing.Size(1067, 538);
			this.departementUserControl1.TabIndex = 3;
			// 
			// employeUserControl1
			// 
			this.employeUserControl1.AutoScroll = true;
			this.employeUserControl1.Location = new System.Drawing.Point(138, 147);
			this.employeUserControl1.Name = "employeUserControl1";
			this.employeUserControl1.Size = new System.Drawing.Size(1067, 538);
			this.employeUserControl1.TabIndex = 2;
			// 
			// stageUserControl1
			// 
			this.stageUserControl1.Location = new System.Drawing.Point(138, 147);
			this.stageUserControl1.Name = "stageUserControl1";
			this.stageUserControl1.Size = new System.Drawing.Size(1067, 538);
			this.stageUserControl1.TabIndex = 5;
			// 
			// participantUserControl2
			// 
			this.participantUserControl2.Location = new System.Drawing.Point(138, 147);
			this.participantUserControl2.Name = "participantUserControl2";
			this.participantUserControl2.Size = new System.Drawing.Size(1067, 538);
			this.participantUserControl2.TabIndex = 6;
			// 
			// Dashboard
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1205, 685);
			this.Controls.Add(this.participantUserControl2);
			this.Controls.Add(this.stageUserControl1);
			this.Controls.Add(this.pictureBox6);
			this.Controls.Add(this.departementUserControl1);
			this.Controls.Add(this.employeUserControl1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "Dashboard";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dashboard";
			this.Load += new System.EventHandler(this.Dashboard_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
		private EmployeUserControl employeUserControl1;
		private DepartementUserControl departementUserControl1;
		private System.Windows.Forms.PictureBox pictureBox6;
		private Bunifu.Framework.UI.BunifuTileButton btnDepartement;
		private Bunifu.Framework.UI.BunifuTileButton btnParticipant;
		private Bunifu.Framework.UI.BunifuTileButton btnStage;
		private Bunifu.Framework.UI.BunifuTileButton btnEmploye;
		private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
		private StageUserControl stageUserControl1;
		private ParticipantUserControl participantUserControl2;
	}
}

