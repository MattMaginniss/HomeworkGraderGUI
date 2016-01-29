namespace GraderFormControl
{
    partial class HomeworkFormControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOne = new System.Windows.Forms.RadioButton();
            this.btnTwo = new System.Windows.Forms.RadioButton();
            this.btnThree = new System.Windows.Forms.RadioButton();
            this.btnFour = new System.Windows.Forms.RadioButton();
            this.dgvComments = new System.Windows.Forms.DataGridView();
            this.boxRadioButtons = new System.Windows.Forms.GroupBox();
            this.clmnCheckBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.clmnCommentArea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).BeginInit();
            this.boxRadioButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOne
            // 
            this.btnOne.AutoSize = true;
            this.btnOne.Checked = true;
            this.btnOne.Location = new System.Drawing.Point(6, 16);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(80, 17);
            this.btnOne.TabIndex = 0;
            this.btnOne.TabStop = true;
            this.btnOne.Text = "Exceptional";
            this.btnOne.UseVisualStyleBackColor = true;
            // 
            // btnTwo
            // 
            this.btnTwo.AutoSize = true;
            this.btnTwo.Location = new System.Drawing.Point(6, 39);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(79, 17);
            this.btnTwo.TabIndex = 1;
            this.btnTwo.Text = "Acceptable";
            this.btnTwo.UseVisualStyleBackColor = true;
            // 
            // btnThree
            // 
            this.btnThree.AutoSize = true;
            this.btnThree.Location = new System.Drawing.Point(6, 62);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(64, 17);
            this.btnThree.TabIndex = 2;
            this.btnThree.Text = "Amateur";
            this.btnThree.UseVisualStyleBackColor = true;
            // 
            // btnFour
            // 
            this.btnFour.AutoSize = true;
            this.btnFour.Location = new System.Drawing.Point(6, 85);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(92, 17);
            this.btnFour.TabIndex = 3;
            this.btnFour.Text = "Unsatisfactory";
            this.btnFour.UseVisualStyleBackColor = true;
            // 
            // dgvComments
            // 
            this.dgvComments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComments.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnCheckBox,
            this.clmnCommentArea});
            this.dgvComments.Location = new System.Drawing.Point(163, 24);
            this.dgvComments.Name = "dgvComments";
            this.dgvComments.RowHeadersVisible = false;
            this.dgvComments.Size = new System.Drawing.Size(360, 290);
            this.dgvComments.TabIndex = 4;
            // 
            // boxRadioButtons
            // 
            this.boxRadioButtons.Controls.Add(this.btnTwo);
            this.boxRadioButtons.Controls.Add(this.btnOne);
            this.boxRadioButtons.Controls.Add(this.btnFour);
            this.boxRadioButtons.Controls.Add(this.btnThree);
            this.boxRadioButtons.Location = new System.Drawing.Point(24, 47);
            this.boxRadioButtons.Name = "boxRadioButtons";
            this.boxRadioButtons.Size = new System.Drawing.Size(118, 108);
            this.boxRadioButtons.TabIndex = 5;
            this.boxRadioButtons.TabStop = false;
            this.boxRadioButtons.Text = "Grade";
            // 
            // clmnCheckBox
            // 
            this.clmnCheckBox.HeaderText = "Add";
            this.clmnCheckBox.Name = "clmnCheckBox";
            this.clmnCheckBox.Width = 35;
            // 
            // clmnCommentArea
            // 
            this.clmnCommentArea.HeaderText = "Comments";
            this.clmnCommentArea.Name = "clmnCommentArea";
            this.clmnCommentArea.Width = 322;
            // 
            // HomeworkFormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.boxRadioButtons);
            this.Controls.Add(this.dgvComments);
            this.Name = "HomeworkFormControl";
            this.Size = new System.Drawing.Size(551, 338);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComments)).EndInit();
            this.boxRadioButtons.ResumeLayout(false);
            this.boxRadioButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton btnOne;
        private System.Windows.Forms.RadioButton btnTwo;
        private System.Windows.Forms.RadioButton btnThree;
        private System.Windows.Forms.RadioButton btnFour;
        private System.Windows.Forms.DataGridView dgvComments;
        private System.Windows.Forms.GroupBox boxRadioButtons;
        private System.Windows.Forms.DataGridViewCheckBoxColumn clmnCheckBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnCommentArea;
    }
}
