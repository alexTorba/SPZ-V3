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
		//---------------------------------------------------------------------

		public MainForm()
		{
			InitializeComponent();

			fileText.Font = RegisterActions.RetrieveFromRegister();
		}

		//---------------------------------------------------------------------

		private void OpenFile_Click( object sender, EventArgs e )
		{
			if ( !SelectFile() )
				return;

			fileText.Lines = FileProcessor.ReadFileContent( FileName );
		}

		//---------------------------------------------------------------------

		private void SaveFile_Click( object sender, EventArgs e )
		{
			if( FileName == null )
				if ( !SelectFile() )
					return;

			FileProcessor.SaveInFile( FileName, fileText.Lines );
		}

		//---------------------------------------------------------------------

		private void ChooseFont_Clicked( object sender, EventArgs e )
		{
			FontDialog fontDialog = new FontDialog();
			DialogResult result = fontDialog.ShowDialog();

			if ( result != DialogResult.OK )
				return;

			fileText.Font = fontDialog.Font;
		}

		//---------------------------------------------------------------------

		private void SaveToRegister_Clicked( object sender, EventArgs e )
		{
			RegisterActions.SaveToRegister( fileText.Font );
		}

		//---------------------------------------------------------------------

		private void RemoveFromRegister_Clicked( object sender, EventArgs e )
		{
			RegisterActions.RemoveFromRegister();
		}

		//---------------------------------------------------------------------

		private bool SelectFile()
		{
			OpenFileDialog fileDialog = new OpenFileDialog();
			DialogResult result = fileDialog.ShowDialog();

			if ( result != DialogResult.OK )
				return false;

			FileName = fileDialog.FileName;
			return true;
		}

		//---------------------------------------------------------------------

		private string FileName { get; set; }

		//---------------------------------------------------------------------
	}
}
