namespace Reportes.Ventanas
{
	partial class FrmAsistencias
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
			this.components = new System.ComponentModel.Container();
			this.btnRegresar = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btnCargar = new System.Windows.Forms.Button();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.button1 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnRegresar
			// 
			this.btnRegresar.BackColor = System.Drawing.Color.White;
			this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnRegresar.Location = new System.Drawing.Point(697, 360);
			this.btnRegresar.Name = "btnRegresar";
			this.btnRegresar.Size = new System.Drawing.Size(102, 33);
			this.btnRegresar.TabIndex = 0;
			this.btnRegresar.Text = "Regresar";
			this.btnRegresar.UseVisualStyleBackColor = false;
			this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(-1, -3);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(800, 133);
			this.dataGridView1.TabIndex = 1;
			// 
			// btnCargar
			// 
			this.btnCargar.BackColor = System.Drawing.Color.White;
			this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnCargar.Location = new System.Drawing.Point(-1, 136);
			this.btnCargar.Name = "btnCargar";
			this.btnCargar.Size = new System.Drawing.Size(79, 42);
			this.btnCargar.TabIndex = 2;
			this.btnCargar.Text = "Cargar";
			this.btnCargar.UseVisualStyleBackColor = false;
			this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.White;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(-1, 184);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(79, 42);
			this.button1.TabIndex = 4;
			this.button1.Text = "Buscar";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// FrmAsistencias
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.BackgroundImage = global::Reportes.Properties.Resources.conalep;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(800, 396);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnCargar);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnRegresar);
			this.DoubleBuffered = true;
			this.Name = "FrmAsistencias";
			this.Text = "FrmAsistencias";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnRegresar;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button btnCargar;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.Button button1;
	}
}