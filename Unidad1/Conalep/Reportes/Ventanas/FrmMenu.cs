using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reportes.Ventanas
{
	public partial class FrmMenu : Form
	{
		public FrmMenu()
		{
			InitializeComponent();
		}

		private void FrmMenu_Load(object sender, EventArgs e)
		{

		}

		private void btnReporte_Click(object sender, EventArgs e)
		{
			FrmReportes abrir = new FrmReportes();
			abrir.Show();
			this.Visible = false;
		}

		private void btnAsistencias_Click(object sender, EventArgs e)
		{
			FrmAsistencias abrir = new FrmAsistencias();
			abrir.Show();
			this.Visible = false;
		}

		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Visible = false;
		}
	}
}
