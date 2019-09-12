using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reportes.Ventanas;

namespace Reportes
{
	public partial class login : Form
	{
		public login()
		{
			InitializeComponent();
		}
		FrmMenu abrir = new FrmMenu();


		private void btnIniciar_Click(object sender, EventArgs e)
		{
			abrir.Show();
			this.Visible = false;
		}
	}
}
