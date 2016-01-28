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
            this.SetPointValue(3, 2, 1, 0);

            this.MaxPoints = (int) this.btnOne.Tag;
        }

        #endregion

        public void SetPointValue(int one, int two, int three, int four)
        {
            this.btnOne.Tag = one;
            this.btnTwo.Tag = two;
            this.btnThree.Tag = three;
            this.btnFour.Tag = four;
            this.setButtonLabels();
        }

        private void setButtonLabels()
        {
            this.btnOne.Text = ("Exceptional (" + this.btnOne.Tag + ")");
            this.btnTwo.Text = ("Acceptable (" + this.btnTwo.Tag + ")");
            this.btnThree.Text = ("Amateur (" + this.btnThree.Tag + ")");
            this.btnFour.Text = ("Unsatisfactory (" + this.btnFour.Tag + ")");
        }
    }
}