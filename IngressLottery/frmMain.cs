using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IngressLottery
{
	public partial class frmMain : Form
	{
		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
			{
				btnGenerate.PerformClick();
			}
		}

		private void btnGenerate_Click(object sender, EventArgs e)
		{
			lblItem.Text = ProfileItems.Items[new Random().Next(ProfileItems.Items.Length)];

			lblNumber.Text = new Random().Next(99).ToString("D2");
		}
	}
}
