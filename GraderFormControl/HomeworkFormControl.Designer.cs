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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOne
            // 
            this.btnOne.AutoSize = true;
            this.btnOne.Location = new System.Drawing.Point(32, 60);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(31, 17);
            this.btnOne.TabIndex = 0;
            this.btnOne.TabStop = true;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = true;
            // 
            // btnTwo
            // 
            this.btnTwo.AutoSize = true;
            this.btnTwo.Location = new System.Drawing.Point(32, 83);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(85, 17);
            this.btnTwo.TabIndex = 1;
            this.btnTwo.TabStop = true;
            this.btnTwo.Text = "radioButton2";
            this.btnTwo.UseVisualStyleBackColor = true;
            // 
            // btnThree
            // 
            this.btnThree.AutoSize = true;
            this.btnThree.Location = new System.Drawing.Point(32, 106);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(85, 17);
            this.btnThree.TabIndex = 2;
            this.btnThree.TabStop = true;
            this.btnThree.Text = "radioButton3";
            this.btnThree.UseVisualStyleBackColor = true;
            // 
            // btnFour
            // 
            this.btnFour.AutoSize = true;
            this.btnFour.Location = new System.Drawing.Point(32, 129);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(85, 17);
            this.btnFour.TabIndex = 3;
            this.btnFour.TabStop = true;
            this.btnFour.Text = "radioButton4";
            this.btnFour.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(167, 35);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // HomeworkFormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnOne);
            this.Name = "HomeworkFormControl";
            this.Size = new System.Drawing.Size(438, 221);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton btnOne;
        private System.Windows.Forms.RadioButton btnTwo;
        private System.Windows.Forms.RadioButton btnThree;
        private System.Windows.Forms.RadioButton btnFour;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
