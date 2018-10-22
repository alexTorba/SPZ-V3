using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lb8
{
	static class FileProcessor
	{
		//---------------------------------------------------------------------

		public static string[] ReadFileContent( string _fileName )
		{
			List<string> fileContent = new List<string>();

			using ( StreamReader streamReader = new StreamReader( _fileName ) )
			{
				string currentLine;
				for ( int i = 0; ( currentLine = streamReader.ReadLine() ) != null; ++i )
					fileContent.Add( currentLine );
			}

			return fileContent.ToArray();
		}

		//---------------------------------------------------------------------

		public static void SaveInFile( string _fileName, string[] _data )
		{
			FileStream fileStream = new FileStream(
					_fileName
				,	FileMode.Create
				,	FileAccess.Write
			);
			StreamWriter streamWriter = new StreamWriter( fileStream );

			foreach ( string str in _data )
				streamWriter.WriteLine( str );

			streamWriter.Dispose();
			fileStream.Dispose();
		}

		//---------------------------------------------------------------------
	}
}
