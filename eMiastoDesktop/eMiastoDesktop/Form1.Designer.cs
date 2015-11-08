namespace eMiastoDesktop {
	partial class Form1 {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.lblMiasto = new System.Windows.Forms.Label();
			this.txtMiasto = new System.Windows.Forms.TextBox();
			this.webBrowser = new System.Windows.Forms.WebBrowser();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnSzukaj = new System.Windows.Forms.Button();
			this.btnDodaj = new System.Windows.Forms.Button();
			this.gridLista = new System.Windows.Forms.DataGridView();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridLista)).BeginInit();
			this.SuspendLayout();
			// 
			// lblMiasto
			// 
			this.lblMiasto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblMiasto.AutoSize = true;
			this.lblMiasto.Location = new System.Drawing.Point(19, 0);
			this.lblMiasto.Name = "lblMiasto";
			this.lblMiasto.Size = new System.Drawing.Size(38, 33);
			this.lblMiasto.TabIndex = 0;
			this.lblMiasto.Text = "Miasto";
			this.lblMiasto.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// txtMiasto
			// 
			this.txtMiasto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtMiasto.Location = new System.Drawing.Point(63, 3);
			this.txtMiasto.Name = "txtMiasto";
			this.txtMiasto.Size = new System.Drawing.Size(908, 20);
			this.txtMiasto.TabIndex = 3;
			// 
			// webBrowser
			// 
			this.webBrowser.Location = new System.Drawing.Point(12, 51);
			this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
			this.webBrowser.Name = "webBrowser";
			this.webBrowser.Size = new System.Drawing.Size(1034, 340);
			this.webBrowser.TabIndex = 6;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.txtMiasto, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.lblMiasto, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnSzukaj, 2, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1034, 33);
			this.tableLayoutPanel1.TabIndex = 7;
			// 
			// btnSzukaj
			// 
			this.btnSzukaj.Location = new System.Drawing.Point(977, 3);
			this.btnSzukaj.Name = "btnSzukaj";
			this.btnSzukaj.Size = new System.Drawing.Size(54, 23);
			this.btnSzukaj.TabIndex = 6;
			this.btnSzukaj.Text = "Szukaj";
			this.btnSzukaj.UseVisualStyleBackColor = true;
			this.btnSzukaj.Click += new System.EventHandler(this.btnSzukaj_Click);
			// 
			// btnDodaj
			// 
			this.btnDodaj.Location = new System.Drawing.Point(12, 397);
			this.btnDodaj.Name = "btnDodaj";
			this.btnDodaj.Size = new System.Drawing.Size(75, 23);
			this.btnDodaj.TabIndex = 8;
			this.btnDodaj.Text = "Dodaj";
			this.btnDodaj.UseVisualStyleBackColor = true;
			this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
			// 
			// gridLista
			// 
			this.gridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridLista.Location = new System.Drawing.Point(12, 426);
			this.gridLista.Name = "gridLista";
			this.gridLista.Size = new System.Drawing.Size(1034, 150);
			this.gridLista.TabIndex = 9;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1058, 588);
			this.Controls.Add(this.gridLista);
			this.Controls.Add(this.btnDodaj);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.webBrowser);
			this.Name = "Form1";
			this.Text = "eMiasto";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.gridLista)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lblMiasto;
		private System.Windows.Forms.TextBox txtMiasto;
		private System.Windows.Forms.WebBrowser webBrowser;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnSzukaj;
		private System.Windows.Forms.Button btnDodaj;
		private System.Windows.Forms.DataGridView gridLista;
	}
}

