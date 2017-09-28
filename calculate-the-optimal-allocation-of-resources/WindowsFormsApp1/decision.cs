using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class decision : Form
	{
		public decision()
		{
			InitializeComponent();
		}

		//закрытие формы
		private void decision_FormClosed(object sender, FormClosedEventArgs e)
		{
			Application.Exit();
		}
	}
}
