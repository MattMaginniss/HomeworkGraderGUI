namespace Homework_Grader_by_Matthew_Maginniss
{
    partial class HomeworkGraderForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageFunctionality = new System.Windows.Forms.TabPage();
            this.tabPageImplementation = new System.Windows.Forms.TabPage();
            this.tabPageDocumentation = new System.Windows.Forms.TabPage();
            this.controlFunctionality = new GraderFormControl.HomeworkFormControl();
            this.controlImplementation = new GraderFormControl.HomeworkFormControl();
            this.controlDocumentation = new GraderFormControl.HomeworkFormControl();
            this.tabControl.SuspendLayout();
            this.tabPageFunctionality.SuspendLayout();
            this.tabPageImplementation.SuspendLayout();
            this.tabPageDocumentation.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(17, 430);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(544, 279);
            this.txtOutput.TabIndex = 1;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(252, 725);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageFunctionality);
            this.tabControl.Controls.Add(this.tabPageImplementation);
            this.tabControl.Controls.Add(this.tabPageDocumentation);
            this.tabControl.Location = new System.Drawing.Point(13, 26);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(552, 362);
            this.tabControl.TabIndex = 3;
            // 
            // tabPageFunctionality
            // 
            this.tabPageFunctionality.Controls.Add(this.controlFunctionality);
            this.tabPageFunctionality.Location = new System.Drawing.Point(4, 22);
            this.tabPageFunctionality.Name = "tabPageFunctionality";
            this.tabPageFunctionality.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFunctionality.Size = new System.Drawing.Size(544, 336);
            this.tabPageFunctionality.TabIndex = 0;
            this.tabPageFunctionality.Text = "Functionality";
            this.tabPageFunctionality.UseVisualStyleBackColor = true;
            // 
            // tabPageImplementation
            // 
            this.tabPageImplementation.Controls.Add(this.controlImplementation);
            this.tabPageImplementation.Location = new System.Drawing.Point(4, 22);
            this.tabPageImplementation.Name = "tabPageImplementation";
            this.tabPageImplementation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImplementation.Size = new System.Drawing.Size(544, 336);
            this.tabPageImplementation.TabIndex = 1;
            this.tabPageImplementation.Text = "Implementation";
            this.tabPageImplementation.UseVisualStyleBackColor = true;
            // 
            // tabPageDocumentation
            // 
            this.tabPageDocumentation.Controls.Add(this.controlDocumentation);
            this.tabPageDocumentation.Location = new System.Drawing.Point(4, 22);
            this.tabPageDocumentation.Name = "tabPageDocumentation";
            this.tabPageDocumentation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDocumentation.Size = new System.Drawing.Size(544, 336);
            this.tabPageDocumentation.TabIndex = 2;
            this.tabPageDocumentation.Text = "Documentation";
            this.tabPageDocumentation.UseVisualStyleBackColor = true;
            // 
            // controlFunctionality
            // 
            this.controlFunctionality.Location = new System.Drawing.Point(-3, -1);
            this.controlFunctionality.Name = "controlFunctionality";
            this.controlFunctionality.Size = new System.Drawing.Size(551, 338);
            this.controlFunctionality.TabIndex = 0;
            // 
            // controlImplementation
            // 
            this.controlImplementation.Location = new System.Drawing.Point(-3, -1);
            this.controlImplementation.Name = "controlImplementation";
            this.controlImplementation.Size = new System.Drawing.Size(551, 338);
            this.controlImplementation.TabIndex = 0;
            // 
            // controlDocumentation
            // 
            this.controlDocumentation.Location = new System.Drawing.Point(-3, -1);
            this.controlDocumentation.Name = "controlDocumentation";
            this.controlDocumentation.Size = new System.Drawing.Size(551, 338);
            this.controlDocumentation.TabIndex = 4;
            // 
            // HomeworkGraderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 775);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtOutput);
            this.Name = "HomeworkGraderForm";
            this.Text = "Homework Grader by Matthew Maginniss";
            this.tabControl.ResumeLayout(false);
            this.tabPageFunctionality.ResumeLayout(false);
            this.tabPageImplementation.ResumeLayout(false);
            this.tabPageDocumentation.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageFunctionality;
        private System.Windows.Forms.TabPage tabPageImplementation;
        private GraderFormControl.HomeworkFormControl homeworkFormControl1;
        private System.Windows.Forms.TabPage tabPageDocumentation;
        private GraderFormControl.HomeworkFormControl controlFunctionality;
        private GraderFormControl.HomeworkFormControl controlImplementation;
        private GraderFormControl.HomeworkFormControl controlDocumentation;
    }
}

