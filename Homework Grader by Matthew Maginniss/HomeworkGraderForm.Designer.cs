namespace HomeworkGrader
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.btnClear = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.commentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBtnLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.controlFunctionality = new GraderFormControl.GraderFormControl();
            this.controlImplementation = new GraderFormControl.GraderFormControl();
            this.controlDocumentation = new GraderFormControl.GraderFormControl();
            this.tabControl.SuspendLayout();
            this.tabPageFunctionality.SuspendLayout();
            this.tabPageImplementation.SuspendLayout();
            this.tabPageDocumentation.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.btnCopy.Location = new System.Drawing.Point(200, 724);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 2;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
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
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(304, 724);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.commentsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(579, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // commentsToolStripMenuItem
            // 
            this.commentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBtnSave,
            this.menuBtnLoad});
            this.commentsToolStripMenuItem.Name = "commentsToolStripMenuItem";
            this.commentsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.commentsToolStripMenuItem.Text = "&Comments";
            // 
            // menuBtnSave
            // 
            this.menuBtnSave.Name = "menuBtnSave";
            this.menuBtnSave.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuBtnSave.Size = new System.Drawing.Size(152, 22);
            this.menuBtnSave.Text = "Save";
            this.menuBtnSave.Click += new System.EventHandler(this.menuBtnSave_Click);
            // 
            // menuBtnLoad
            // 
            this.menuBtnLoad.Name = "menuBtnLoad";
            this.menuBtnLoad.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.menuBtnLoad.Size = new System.Drawing.Size(152, 22);
            this.menuBtnLoad.Text = "Load";
            this.menuBtnLoad.Click += new System.EventHandler(this.menuBtnLoad_Click);
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
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeworkGraderForm";
            this.Text = "Homework Grader by Matthew Maginniss";
            this.tabControl.ResumeLayout(false);
            this.tabPageFunctionality.ResumeLayout(false);
            this.tabPageImplementation.ResumeLayout(false);
            this.tabPageDocumentation.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageFunctionality;
        private System.Windows.Forms.TabPage tabPageImplementation;
        private GraderFormControl.GraderFormControl homeworkFormControl1;
        private System.Windows.Forms.TabPage tabPageDocumentation;
        private GraderFormControl.GraderFormControl controlFunctionality;
        private GraderFormControl.GraderFormControl controlImplementation;
        private GraderFormControl.GraderFormControl controlDocumentation;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem commentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuBtnSave;
        private System.Windows.Forms.ToolStripMenuItem menuBtnLoad;
    }
}

