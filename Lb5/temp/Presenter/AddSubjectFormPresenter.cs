using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lb7.View;
using Lb7.Model;

namespace Lb7.Presenter
{
    class AddSubjectFormPresenter
    {
        readonly IAddSubjectForm addSubjectForm;

        public AddSubjectFormPresenter(IAddSubjectForm addSubjectForm)
        {
            this.addSubjectForm = addSubjectForm;

            addSubjectForm.SaveButton += AddSubjectForm_SaveButton;
        }

        private void AddSubjectForm_SaveButton(object sender, EventArgs e)
        {
            Subjects subjects = new Subjects { Name = addSubjectForm.subjectName };
            EFGenericRepository.Create(subjects);
        }
    }
}
