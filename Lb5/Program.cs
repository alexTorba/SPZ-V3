using System;
using System.Windows.Forms;

namespace Lb5
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault( false );

			View.MainForm mainForm = new View.MainForm();
			Model.Model model = new Model.Model();
			model.LoadData();
			Presenter.MainFormPresenter mainFormPresenter =
				new Presenter.MainFormPresenter( model, mainForm );

			Application.Run( mainForm );
		}
	}
}
