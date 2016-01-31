﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HomeworkGrader
{
    public partial class HomeworkGraderForm : Form
    {
        #region Constructors

        /// <summary>
        ///     Initializes a new instance of the <see cref="HomeworkGraderForm" /> class.
        /// </summary>
        public HomeworkGraderForm()
        {
            this.InitializeComponent();
            this.initializeFunctionalityControl();
            this.initializeImplementationControl();
            this.initializeDocumentationControl();

            this.controlFunctionality.DataChanged += this.updateData;
            this.controlImplementation.DataChanged += this.updateData;
            this.controlDocumentation.DataChanged += this.updateData;
        }

        #endregion

        private void updateData(object sender, GraderFormControl.GraderFormControl.DataChangedEventArgs e)
        {
            var comments = new List<string> {this.getTotalHeader()};
            foreach (TabPage currentPage in this.tabControl.TabPages)
            {
                var control =
                    currentPage.Controls.Cast<GraderFormControl.GraderFormControl>()
                               .FirstOrDefault(x => x != null);

                if (control == null)
                {
                    continue;
                }
                var header = currentPage.Text + " " + control.CurrentPoints + "/" + control.MaxPoints +
                             Environment.NewLine;

                comments.Add(header);

                var tabComments = control.GetCheckedComments() + Environment.NewLine;
                comments.Add(tabComments);
            }

            this.clearTextBox();
            foreach (var line in comments)
            {
                this.txtOutput.Text += line;
            }
        }

        private string getTotalHeader()
        {
            var totalPoints = this.controlFunctionality.MaxPoints + this.controlImplementation.MaxPoints +
                              this.controlDocumentation.MaxPoints;
            var currentPoints = this.controlFunctionality.CurrentPoints + this.controlImplementation.CurrentPoints +
                                this.controlDocumentation.CurrentPoints;
            var totalHeader = "Total: " + currentPoints + "/" + totalPoints + Environment.NewLine + Environment.NewLine;
            return totalHeader;
        }

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

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.controlDocumentation.ClearCheckBoxes();
            this.controlImplementation.ClearCheckBoxes();
            this.controlFunctionality.ClearCheckBoxes();
            this.clearTextBox();
        }

        private void clearTextBox()
        {
            this.txtOutput.Text = "";
        }

        private void menuBtnSave_Click(object sender, EventArgs e)
        {
        }

        private void menuBtnLoad_Click(object sender, EventArgs e)
        {
        }
    }
}