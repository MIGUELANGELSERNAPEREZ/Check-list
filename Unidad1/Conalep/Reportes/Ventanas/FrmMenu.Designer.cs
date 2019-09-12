namespace Reportes.Ventanas
{
	partial class FrmMenu
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
			this.btnReporte = new System.Windows.Forms.Button();
			this.btnAsistencias = new System.Windows.Forms.Button();
			this.btnSalir = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnReporte
			// 
			this.btnReporte.BackColor = System.Drawing.Color.White;
			this.btnReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnReporte.Location = new System.Drawing.Point(12, 4);
			this.btnReporte.Name = "btnReporte";
			this.btnReporte.Size = new System.Drawing.Size(97, 59);
			this.btnReporte.TabIndex = 0;
			this.btnReporte.Text = "Reportes";
			this.btnReporte.UseVisualStyleBackColor = false;
			this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
			// 
			// btnAsistencias
			// 
			this.btnAsistencias.BackColor = System.Drawing.Color.White;
			this.btnAsistencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAsistencias.Location = new System.Drawing.Point(253, 4);
			this.btnAsistencias.Name = "btnAsistencias";
			this.btnAsistencias.Size = new System.Drawing.Size(109, 60);
			this.btnAsistencias.TabIndex = 1;
			this.btnAsistencias.Text = "Asistencias";
			this.btnAsistencias.UseVisualStyleBackColor = false;
			this.btnAsistencias.Click += new System.EventHandler(this.btnAsistencias_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.Color.White;
			this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSalir.Location = new System.Drawing.Point(1, 201);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(75, 35);
			this.btnSalir.TabIndex = 2;
			this.btnSalir.Text = "Salir";
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// FrmMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = global::Reportes.Properties.Resources.conalep;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(476, 235);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.btnAsistencias);
			this.Controls.Add(this.btnReporte);
			this.DoubleBuffered = true;
			this.Name = "FrmMenu";
			this.Text = "Menu";
			this.Load += new System.EventHandler(this.FrmMenu_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnReporte;
		private System.Windows.Forms.Button btnAsistencias;
		private System.Windows.Forms.Button btnSalir;
	}
}