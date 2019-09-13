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
	public partial class FrmAsistencias : Form
	{
		public FrmAsistencias()
		{
			InitializeComponent();
		}

		private void btnRegresar_Click(object sender, EventArgs e)
		{
			FrmMenu abrir = new FrmMenu();
			abrir.Show();
			this.Visible = false;
		}

		public void actualizar()
		{

		}
		private void btnCargar_Click(object sender, EventArgs e)
		{

		}
	}
}
