using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lb7.Model;
using Lb7.View;

namespace Lb7.Presenter
{
    class MainFormPresenter
    {

        IMainForm mainForm;

        public MainFormPresenter(IMainForm mainForm)
        {
            this.mainForm = mainForm;

            this.mainForm.LoadForm += MainForm_LoadForm;
        }

        private void MainForm_LoadForm(object sender, EventArgs e)
        {
            mainForm.StudentGridDataSource = DataManager.GetStudents();
            mainForm.SubjectGridDataSource = DataManager.GetSubjects();
        }

    }
}
