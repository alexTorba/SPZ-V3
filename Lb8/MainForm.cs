using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lb8
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		private void ChooseFont_Clicked( object sender, EventArgs e )
		{
			FontDialog fontDialog = new FontDialog();
			fontDialog.ShowDialog();
		}

		private void OpenFile_Click( object sender, EventArgs e )
		{
			OpenFileDialog fileDialog = new OpenFileDialog();
			DialogResult result = fileDialog.ShowDialog();
			MessageBox.Show( fileDialog.FileName );
		}
	}
}
