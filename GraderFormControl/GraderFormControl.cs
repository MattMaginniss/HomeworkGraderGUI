using System;
using System.Linq;
using System.Windows.Forms;

namespace GraderFormControl
{
    /// <summary>
    ///     Grading Form Control for a that has radio buttons for points and comment selections
    /// </summary>
    public partial class GraderFormControl : UserControl
    {
        #region Properties

        /// <summary>
        ///     Gets the current points.
        /// </summary>
        /// <value>
        ///     The current points.
        /// </value>
        public int CurrentPoints => this.getCheckedButtonValue();

        /// <summary>
        ///     Gets the maximum points.
        /// </summary>
        /// <value>
        ///     The maximum points.
        /// </value>
        public int MaxPoints => (int) this.btnOne.Tag;

        #endregion

        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="GraderFormControl" /> class.
        /// </summary>
        public GraderFormControl()
        {
            this.InitializeComponent();
            this.SetPointValue(3, 2, 1, 0);
            this.btnOne.Checked = true;
        }

        #endregion

        #region Methods

        /// <summary>
        ///     Custom EventArgs child class that is invoked when any data is changed.
        /// </summary>
        public class DataChangedEventArgs : EventArgs
        {
        }

        #endregion

        /// <summary>
        ///     Sets the point value.
        /// </summary>
        /// <param name="exceptional">The exceptional value.</param>
        /// <param name="acceptable">The acceptable value.</param>
        /// <param name="amateur">The amateur value.</param>
        /// <param name="unsatisfactory">The unsatisfactory value.</param>
        public void SetPointValue(int exceptional, int acceptable, int amateur, int unsatisfactory)
        {
            this.btnOne.Tag = exceptional;
            this.btnTwo.Tag = acceptable;
            this.btnThree.Tag = amateur;
            this.btnFour.Tag = unsatisfactory;
            this.setButtonLabels();
        }

        private void setButtonLabels()
        {
            this.btnOne.Text = ("Exceptional (" + this.btnOne.Tag + ")");
            this.btnTwo.Text = ("Acceptable (" + this.btnTwo.Tag + ")");
            this.btnThree.Text = ("Amateur (" + this.btnThree.Tag + ")");
            this.btnFour.Text = ("Unsatisfactory (" + this.btnFour.Tag + ")");
        }

        /// <summary>
        ///     Adds a comment to the comment list.
        /// </summary>
        /// <param name="comment">The comment to be added.</param>
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

        /// <summary>
        ///     Gets the checked comments from the data grid of comments.
        /// </summary>
        /// <returns>A string of all the comments that have been selected.</returns>
        public string GetCheckedComments()
        {
            var comments = "";

            foreach (DataGridViewRow row in this.dgvComments.Rows)
            {
                var cell = (DataGridViewCheckBoxCell) row.Cells[0];

                if (!Convert.ToBoolean(cell.EditingCellFormattedValue))
                {
                    continue;
                }
                var textCell = (DataGridViewTextBoxCell) row.Cells[1];

                if (textCell.Value != null)
                {
                    comments += textCell.Value + Environment.NewLine;
                }
            }

            return comments;
        }

        /// <summary>
        ///     Gets all comments from the data grid view
        /// </summary>
        /// <returns>All comments</returns>
        public string GetAllComments()
        {
            var comments = "";

            foreach (DataGridViewRow row in this.dgvComments.Rows)
            {
                var textCell = (DataGridViewTextBoxCell) row.Cells[1];

                if (textCell.Value != null)
                {
                    comments += textCell.Value + Environment.NewLine;
                }
            }
            return comments;
        }

        /// <summary>
        ///     Clears the comments from the data grid view.
        /// </summary>
        public void ClearComments()
        {
            this.dgvComments.Rows.Clear();
        }

        private int getCheckedButtonValue()
        {
            var checkedButton = this.boxRadioButtons.Controls.OfType<RadioButton>().First(r => r.Checked);
            return (int) checkedButton.Tag;
        }

        /// <summary>
        ///     Clears all the check boxes in the data grid.
        /// </summary>
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

        /// <summary>
        ///     Event that occurs when [data changed].
        /// </summary>
        public event EventHandler<DataChangedEventArgs> DataChanged;

        private void onDataChanged(DataChangedEventArgs args)
        {
            var handler = this.DataChanged;

            handler?.Invoke(this, args);
        }
    }
}