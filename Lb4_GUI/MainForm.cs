using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace Lb4_GUI
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}

		public enum SequenceSign
		{
				Growing
			,	Falling
			,	NonDefined
		}

		private void OpenMenuItem_Click( object sender, EventArgs e )
		{
			OpenFileDialog dialog = new OpenFileDialog();
			DialogResult result = dialog.ShowDialog();

			if ( result != DialogResult.OK )
				return;

			FileName = dialog.FileName;
			string fileContent;

			using ( FileStream fileStream = new FileStream( FileName, FileMode.Open, FileAccess.Read ) )
				using ( StreamReader streamReader = new StreamReader( fileStream ) )
					fileContent = streamReader.ReadLine();

			InputFileContentTB.Text = fileContent;
		}

		private void SaveResultMenuItem_Click( object sender, EventArgs e )
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "out files (*.out)|*.out";
			saveFileDialog.RestoreDirectory = true;

			saveFileDialog.ShowDialog();

			if ( string.IsNullOrEmpty( saveFileDialog.FileName ) )
				return;

			using ( FileStream fileStream = new FileStream( saveFileDialog.FileName, FileMode.OpenOrCreate ) )
				using ( StreamWriter streamWriter = new StreamWriter( fileStream ) )
					streamWriter.WriteLine( ResultTB.Text );
		}

		private void GenerateNumbersB_Click( object sender, EventArgs e )
		{
			string result = "";
			Random random = new Random();

			for ( int i = 0; i < NumbersToGenerateNUD.Value; ++i )
			{
				result += (double)random.Next( 100, 2000 ) / 100;

				if ( i != NumbersToGenerateNUD.Value - 1 )
					result += ' ';
			}

			InputFileContentTB.Text = result;
		}

		private void RunB_Click( object sender, EventArgs e )
		{
			string[] numbers = InputFileContentTB.Text.Trim().Split( ' ' );
			List< int > sequnceLenght = new List< int >();

			SequenceSign sign = SequenceSign.NonDefined;
			int currentSequenceLenght = 0;
			double previous = -1;

			foreach ( var strNumber in numbers )
			{
				var num = ParseNumber( strNumber );
				if ( num == null )
					return;

				double current = num.Value;

				if ( previous < 0 )
				{
					previous = current;
					continue;
				}

				switch ( sign )
				{
					case SequenceSign.Growing:
					{
						if ( previous < current )
							++currentSequenceLenght;
						else
						{
							sequnceLenght.Add( currentSequenceLenght );
							sign = SequenceSign.Falling;
							currentSequenceLenght = 2;
						}
					}
					break;

					case SequenceSign.Falling:
					{
						if ( previous > current )
							++currentSequenceLenght;
						else
						{
							sequnceLenght.Add( currentSequenceLenght );
							sign = SequenceSign.Growing;
							currentSequenceLenght = 2;
						}
					}
					break;

					case SequenceSign.NonDefined:
					{
						if ( previous < current )
							sign = SequenceSign.Growing;
						else
							sign = SequenceSign.Falling;

						currentSequenceLenght = 2;
					}
					break;

					default:
						break;
				}

				previous = current;
			}

			sequnceLenght.Add( currentSequenceLenght );
			ResultTB.Text = string.Join( " ", sequnceLenght );
		}

		private double? ParseNumber( string _str )
		{
			CultureInfo culture = new CultureInfo( "en-US" );

			try
			{
				return double.Parse( _str, culture );
			}
			catch ( FormatException )
			{
				MessageBox.Show( "Invalid input!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
				return null;
			}
		}

		private string FileName { get; set; }
	}
}
