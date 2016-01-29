using System.Linq;
using System.Windows.Forms;

namespace GraderFormControl
{
    public partial class GraderFormControl : UserControl
    {
        #region Properties

        public int CurrentPoints => this.getCheckedButtonValue();

        public int MaxPoints { get; }

        #endregion

        #region Constructors

        public GraderFormControl()
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

        public void AddComment(string comment)
        {
            if (this.dgvComments.RowCount == 0)
            {
                this.dgvComments.Rows[0].Cells[1].Value = comment;
            }
            else
            {
                var rowIndex = this.dgvComments.Rows.Add();
                this.dgvComments.Rows[rowIndex].Cells[1].Value = comment;
            }
        }

        private int getCheckedButtonValue()
        {
            var checkedButton = this.boxRadioButtons.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            return (int) checkedButton.Tag;
        }
    }
}