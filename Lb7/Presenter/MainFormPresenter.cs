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
            this.mainForm.ClosingForm += MainForm_ClosingForm;
            this.mainForm.DeleteStudent += MainForm_DeleteEntity;
            this.mainForm.DeleteSubject += MainForm_DeleteSubject;
        }

        private void MainForm_DeleteSubject(object sender, EventArgs e)
        {
             if (mainForm.CurrentSubjectRow is Subjects subject)
                EFGenericRepository.Delete(subject);
        }

        private void MainForm_DeleteEntity(object sender, EventArgs e)
        {
            if (mainForm.CurrentStudentRow is Students student)
                EFGenericRepository.Delete(student);
        }

        private void MainForm_ClosingForm(object sender, EventArgs e)
        {
            EFGenericRepository.SaveChanges();
        }

        private void MainForm_LoadForm(object sender, EventArgs e)
        {
            mainForm.StudentGridDataSource = EFGenericRepository.Get<Students>().ToList();
            mainForm.SubjectGridDataSource = EFGenericRepository.Get<Subjects>().ToList();
        }

    }
}
