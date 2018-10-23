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

		private void OpenFile_Click( object _sender, EventArgs _e )
		{
			if ( !SelectFile() )
				return;

			fileText.Lines = FileProcessor.ReadFileContent( FileName );
		}

		//---------------------------------------------------------------------

		private void SaveFile_Click( object _sender, EventArgs _e )
		{
			if( FileName == null )
				if ( !SelectFile() )
					return;

			FileProcessor.SaveInFile( FileName, fileText.Lines );
		}

		//---------------------------------------------------------------------

		private void ChooseFont_Clicked( object _sender, EventArgs _e )
		{
			FontDialog fontDialog = new FontDialog();
			DialogResult result = fontDialog.ShowDialog();

			if ( result != DialogResult.OK )
				return;

			fileText.Font = fontDialog.Font;
		}

		//---------------------------------------------------------------------

		private void SaveToRegister_Clicked( object _sender, EventArgs _e )
		{
			RegisterActions.SaveToRegister( fileText.Font );
		}

		//---------------------------------------------------------------------

		private void RemoveFromRegister_Clicked( object _sender, EventArgs _e )
		{
			RegisterActions.RemoveFromRegister();
		}

		//---------------------------------------------------------------------

		void Form_KeyDown( object _sender, KeyEventArgs _e )
		{
			if ( _e.Control && _e.KeyCode == Keys.S )
				SaveFile_Click( _sender, _e );

			else if ( _e.Control && _e.KeyCode == Keys.O )
				OpenFile_Click( _sender, _e );
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
