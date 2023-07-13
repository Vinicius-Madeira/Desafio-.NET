namespace TestesWPF
{
    partial class FrmNotas
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
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.labelStudentName = new System.Windows.Forms.Label();
            this.txtFirstSemester = new System.Windows.Forms.TextBox();
            this.txtSecondSemester = new System.Windows.Forms.TextBox();
            this.labelFirstSemester = new System.Windows.Forms.Label();
            this.labelSecondSemester = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.buttonClearFields = new System.Windows.Forms.Button();
            this.labelStudentNameError = new System.Windows.Forms.Label();
            this.labelFirstSemesterError = new System.Windows.Forms.Label();
            this.labelSecondSemesterError = new System.Windows.Forms.Label();
            this.labelStudentStatus = new System.Windows.Forms.Label();
            this.labelGradeStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(40, 150);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(400, 23);
            this.txtStudentName.TabIndex = 0;
            // 
            // labelStudentName
            // 
            this.labelStudentName.AutoSize = true;
            this.labelStudentName.Location = new System.Drawing.Point(40, 132);
            this.labelStudentName.Name = "labelStudentName";
            this.labelStudentName.Size = new System.Drawing.Size(95, 15);
            this.labelStudentName.TabIndex = 1;
            this.labelStudentName.Text = "Nome do Aluno:";
            // 
            // txtFirstSemester
            // 
            this.txtFirstSemester.Location = new System.Drawing.Point(40, 250);
            this.txtFirstSemester.Name = "txtFirstSemester";
            this.txtFirstSemester.Size = new System.Drawing.Size(150, 23);
            this.txtFirstSemester.TabIndex = 2;
            // 
            // txtSecondSemester
            // 
            this.txtSecondSemester.Location = new System.Drawing.Point(290, 250);
            this.txtSecondSemester.Name = "txtSecondSemester";
            this.txtSecondSemester.Size = new System.Drawing.Size(150, 23);
            this.txtSecondSemester.TabIndex = 3;
            // 
            // labelFirstSemester
            // 
            this.labelFirstSemester.AutoSize = true;
            this.labelFirstSemester.Location = new System.Drawing.Point(40, 232);
            this.labelFirstSemester.Name = "labelFirstSemester";
            this.labelFirstSemester.Size = new System.Drawing.Size(118, 15);
            this.labelFirstSemester.TabIndex = 4;
            this.labelFirstSemester.Text = "Nota do 1º Semestre:";
            // 
            // labelSecondSemester
            // 
            this.labelSecondSemester.AutoSize = true;
            this.labelSecondSemester.Location = new System.Drawing.Point(290, 232);
            this.labelSecondSemester.Name = "labelSecondSemester";
            this.labelSecondSemester.Size = new System.Drawing.Size(118, 15);
            this.labelSecondSemester.TabIndex = 5;
            this.labelSecondSemester.Text = "Nota do 2º Semestre:";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Location = new System.Drawing.Point(40, 320);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(250, 23);
            this.buttonSubmit.TabIndex = 6;
            this.buttonSubmit.Text = "Enviar";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // buttonClearFields
            // 
            this.buttonClearFields.Location = new System.Drawing.Point(296, 320);
            this.buttonClearFields.Name = "buttonClearFields";
            this.buttonClearFields.Size = new System.Drawing.Size(144, 23);
            this.buttonClearFields.TabIndex = 7;
            this.buttonClearFields.Text = "Limpar Campos";
            this.buttonClearFields.UseVisualStyleBackColor = true;
            this.buttonClearFields.Click += new System.EventHandler(this.buttonClearFields_Click);
            // 
            // labelStudentNameError
            // 
            this.labelStudentNameError.AutoSize = true;
            this.labelStudentNameError.ForeColor = System.Drawing.Color.Red;
            this.labelStudentNameError.Location = new System.Drawing.Point(40, 176);
            this.labelStudentNameError.Name = "labelStudentNameError";
            this.labelStudentNameError.Size = new System.Drawing.Size(126, 15);
            this.labelStudentNameError.TabIndex = 8;
            this.labelStudentNameError.Text = "O Nome é obrigatório.";
            this.labelStudentNameError.Visible = false;
            // 
            // labelFirstSemesterError
            // 
            this.labelFirstSemesterError.AutoSize = true;
            this.labelFirstSemesterError.ForeColor = System.Drawing.Color.Red;
            this.labelFirstSemesterError.Location = new System.Drawing.Point(40, 276);
            this.labelFirstSemesterError.Name = "labelFirstSemesterError";
            this.labelFirstSemesterError.Size = new System.Drawing.Size(117, 15);
            this.labelFirstSemesterError.TabIndex = 9;
            this.labelFirstSemesterError.Text = "A Nota é obrigatória.";
            this.labelFirstSemesterError.Visible = false;
            // 
            // labelSecondSemesterError
            // 
            this.labelSecondSemesterError.AutoSize = true;
            this.labelSecondSemesterError.ForeColor = System.Drawing.Color.Red;
            this.labelSecondSemesterError.Location = new System.Drawing.Point(290, 276);
            this.labelSecondSemesterError.Name = "labelSecondSemesterError";
            this.labelSecondSemesterError.Size = new System.Drawing.Size(117, 15);
            this.labelSecondSemesterError.TabIndex = 10;
            this.labelSecondSemesterError.Text = "A Nota é obrigatória.";
            this.labelSecondSemesterError.Visible = false;
            // 
            // labelStudentStatus
            // 
            this.labelStudentStatus.AutoSize = true;
            this.labelStudentStatus.Location = new System.Drawing.Point(40, 450);
            this.labelStudentStatus.Name = "labelStudentStatus";
            this.labelStudentStatus.Size = new System.Drawing.Size(94, 15);
            this.labelStudentStatus.TabIndex = 11;
            this.labelStudentStatus.Text = "Status do Aluno:";
            // 
            // labelGradeStatus
            // 
            this.labelGradeStatus.AutoSize = true;
            this.labelGradeStatus.ForeColor = System.Drawing.Color.Gray;
            this.labelGradeStatus.Location = new System.Drawing.Point(140, 450);
            this.labelGradeStatus.Name = "labelGradeStatus";
            this.labelGradeStatus.Size = new System.Drawing.Size(103, 15);
            this.labelGradeStatus.TabIndex = 12;
            this.labelGradeStatus.Text = "Nota não enviada.";
            // 
            // FrmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 611);
            this.Controls.Add(this.labelGradeStatus);
            this.Controls.Add(this.labelStudentStatus);
            this.Controls.Add(this.labelSecondSemesterError);
            this.Controls.Add(this.labelFirstSemesterError);
            this.Controls.Add(this.labelStudentNameError);
            this.Controls.Add(this.buttonClearFields);
            this.Controls.Add(this.buttonSubmit);
            this.Controls.Add(this.labelSecondSemester);
            this.Controls.Add(this.labelFirstSemester);
            this.Controls.Add(this.txtSecondSemester);
            this.Controls.Add(this.txtFirstSemester);
            this.Controls.Add(this.labelStudentName);
            this.Controls.Add(this.txtStudentName);
            this.Name = "FrmNotas";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtStudentName;
        private Label labelStudentName;
        private TextBox txtFirstSemester;
        private TextBox txtSecondSemester;
        private Label labelFirstSemester;
        private Label labelSecondSemester;
        private Button buttonSubmit;
        private Button buttonClearFields;
        private Label labelStudentNameError;
        private Label labelFirstSemesterError;
        private Label labelSecondSemesterError;
        private Label labelStudentStatus;
        private Label labelGradeStatus;
    }
}