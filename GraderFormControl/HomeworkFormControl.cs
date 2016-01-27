using System.Windows.Forms;

namespace GraderFormControl
{
    public partial class HomeworkFormControl : UserControl
    {
        #region Properties

        public int CurrentPoints { get; }

        public int MaxPoints { get; }

        #endregion

        #region Constructors

        public HomeworkFormControl()
        {
            this.InitializeComponent();
        }

        #endregion

        public void SetPointValue(int one, int two, int three, int four)
        {
            this.btnOne.Tag = one;
            this.btnTwo.Tag = two;
            this.btnThree.Tag = three;
            this.btnFour.Tag = four;
        }
    }
}