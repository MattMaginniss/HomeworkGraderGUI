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

            this.btnOne.Tag = 3;
            this.btnTwo.Tag = 2;
            this.btnThree.Tag = 1;
            this.btnFour.Tag = 0;
            this.MaxPoints = (int)this.btnOne.Tag;
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