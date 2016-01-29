using System.Windows.Forms;

namespace Homework_Grader_by_Matthew_Maginniss
{
    public partial class HomeworkGraderForm : Form
    {
        #region Constructors

        public HomeworkGraderForm()
        {
            this.InitializeComponent();
            this.initializeFunctionalityControl();
            this.initializeImplementationControl();
            this.initializeDocumentationControl();
        }

        #endregion

        private void initializeDocumentationControl()
        {
            this.controlDocumentation.SetPointValue(3, 2, 1, 0);
            this.controlDocumentation.AddComment("Missing several specification headers for public interface of class.");
        }

        private void initializeImplementationControl()
        {
            this.controlImplementation.SetPointValue(6, 4, 2, 0);
            this.controlImplementation.AddComment("Magic numbers are used within the code.");
            this.controlImplementation.AddComment("Overall class design not following best practices in class design.");
            this.controlImplementation.AddComment("Duplicated code needs to be refactored.");
        }

        private void initializeFunctionalityControl()
        {
            this.controlFunctionality.SetPointValue(11, 8, 3, 0);
            this.controlFunctionality.AddComment("Good Job!");
            this.controlFunctionality.AddComment("No issues were discovered");
        }
    }
}