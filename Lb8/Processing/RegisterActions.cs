using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lb8
{
	static class RegisterActions
	{
		//---------------------------------------------------------------------

		public static Font RetrieveFromRegister()
		{
			RegistryKey hkSoftware = Registry.CurrentUser.OpenSubKey( "Software" );
			RegistryKey hkLab = hkSoftware.OpenSubKey( "Lab_SPZ" );

			if ( !( hkLab?.GetValue( "Font" ) is string fontAsString ) )
				return new Font( "Times New Roman", 13.0f );
			else
			{
				FontConverter fontConverter = new FontConverter();
				return fontConverter.ConvertFromString( fontAsString ) as Font;
			}
		}

		//---------------------------------------------------------------------

		public static void RemoveFromRegister()
		{
			RegistryKey hkSoftware = Registry.CurrentUser.OpenSubKey( "Software", true );
			RegistryKey hkLab = hkSoftware.OpenSubKey( "Lab_SPZ", true );

			if ( hkLab != null )
				hkSoftware.DeleteSubKey( "Lab_SPZ" );
		}

		//---------------------------------------------------------------------

		public static void SaveToRegister( Font _font )
		{
			RegistryKey hkSoftware = Registry.CurrentUser.OpenSubKey( "Software", true );
			RegistryKey hkLab = hkSoftware.CreateSubKey( "Lab_SPZ", true );

			FontConverter fontConverter = new FontConverter();
			string converted = fontConverter.ConvertToString( _font );

			hkLab.SetValue( "Font", converted );
		}

		//---------------------------------------------------------------------
	}
}
