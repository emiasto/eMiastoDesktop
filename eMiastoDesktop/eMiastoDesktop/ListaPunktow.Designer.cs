namespace eMiastoDesktop {
	partial class ListaPunktow {
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
			this.gridLista = new System.Windows.Forms.DataGridView();
			this.btnDodaj = new System.Windows.Forms.Button();
			this.btnPrzelicz = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridLista)).BeginInit();
			this.SuspendLayout();
			// 
			// gridLista
			// 
			this.gridLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.gridLista.Location = new System.Drawing.Point(12, 12);
			this.gridLista.Name = "gridLista";
			this.gridLista.Size = new System.Drawing.Size(719, 379);
			this.gridLista.TabIndex = 0;
			// 
			// btnDodaj
			// 
			this.btnDodaj.Location = new System.Drawing.Point(12, 397);
			this.btnDodaj.Name = "btnDodaj";
			this.btnDodaj.Size = new System.Drawing.Size(75, 23);
			this.btnDodaj.TabIndex = 1;
			this.btnDodaj.Text = "Dodaj";
			this.btnDodaj.UseVisualStyleBackColor = true;
			this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
			// 
			// btnPrzelicz
			// 
			this.btnPrzelicz.Location = new System.Drawing.Point(93, 397);
			this.btnPrzelicz.Name = "btnPrzelicz";
			this.btnPrzelicz.Size = new System.Drawing.Size(109, 23);
			this.btnPrzelicz.TabIndex = 2;
			this.btnPrzelicz.Text = "Przelicz wysokość";
			this.btnPrzelicz.UseVisualStyleBackColor = true;
			this.btnPrzelicz.Click += new System.EventHandler(this.btnPrzelicz_Click);
			// 
			// ListaPunktow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(743, 430);
			this.Controls.Add(this.btnPrzelicz);
			this.Controls.Add(this.btnDodaj);
			this.Controls.Add(this.gridLista);
			this.Name = "ListaPunktow";
			this.Text = "Lista punktów";
			((System.ComponentModel.ISupportInitialize)(this.gridLista)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView gridLista;
		private System.Windows.Forms.Button btnDodaj;
		private System.Windows.Forms.Button btnPrzelicz;
	}
}