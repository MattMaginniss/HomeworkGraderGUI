using System;
using System.Linq;
using System.Windows.Forms;

namespace GraderFormControl
{
    public partial class GraderFormControl : UserControl
    {
        #region Properties

        public int CurrentPoints => this.getCheckedButtonValue();

        public int MaxPoints => (int) this.btnOne.Tag;

        #endregion

        #region Constructors

        public GraderFormControl()
        {
            this.InitializeComponent();
            this.SetPointValue(3, 2, 1, 0);
        }

        #endregion

        #region Methods

        public class DataChangedEventArgs : EventArgs
        {
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

        public string GetCheckedComments()
        {
            var comments = "";

            foreach (DataGridViewRow row in this.dgvComments.Rows)
            {
                var cell = (DataGridViewCheckBoxCell) row.Cells[0];

                if (Convert.ToBoolean(cell.EditingCellFormattedValue))
                {
                    var textCell = (DataGridViewTextBoxCell) row.Cells[1];

                    if (textCell.Value != null)
                    {
                        comments += textCell.Value + Environment.NewLine;
                    }
                }
            }

            return comments;
        }

        private int getCheckedButtonValue()
        {
            var checkedButton = this.boxRadioButtons.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
            return (int) checkedButton.Tag;
        }

        public void ClearCheckBoxes()
        {
            foreach (DataGridViewRow row in this.dgvComments.Rows)
            {
                ((DataGridViewCheckBoxCell) row.Cells[0]).Value = false;
            }
        }

        private void btn_CheckedChanged(object sender, EventArgs e)
        {
            var args = new DataChangedEventArgs();
            this.onDataChanged(args);
        }

        private void dgvComments_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var args = new DataChangedEventArgs();
            this.onDataChanged(args);
        }

        //public delegate void MessageSentHandler(string message);

        public event EventHandler<DataChangedEventArgs> DataChanged;

        private void onDataChanged(DataChangedEventArgs args)
        {
            var handler = this.DataChanged;

            if (handler != null)
            {
                handler(this, args);
            }
        }
    }
}