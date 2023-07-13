using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestesWPF
{
    public partial class FrmNotas : Form
    {
        public FrmNotas()
        {
            InitializeComponent();
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            txtStudentName.Clear();
            labelStudentNameError.Visible = false;

            txtFirstSemester.Clear();
            labelFirstSemesterError.Visible = false;

            txtSecondSemester.Clear();
            labelSecondSemesterError.Visible = false;

            labelGradeStatus.Text = "Nota não enviada.";
            labelGradeStatus.ForeColor = Color.Gray;
            
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            bool studentNameIsEmpty = txtStudentName.Text.Length == 0 ? true : false;
            bool firstSemesterIsEmpty = txtFirstSemester.Text.Length == 0 ? true : false;
            bool secondSemesterIsEmpty = txtSecondSemester.Text.Length == 0 ? true : false;

            if (!studentNameIsEmpty && !firstSemesterIsEmpty && !secondSemesterIsEmpty)
            {
                float nota1 = float.Parse(txtFirstSemester.Text);
                float nota2 = float.Parse(txtSecondSemester.Text);
                float media = (nota1 + nota2) / 2;

                if (media >= 6.5)
                {
                    labelGradeStatus.Text = "Aprovado";
                    labelGradeStatus.ForeColor = Color.Green;
                }
                else
                {
                    labelGradeStatus.Text = "Reprovado";
                    labelGradeStatus.ForeColor = Color.Red;
                }
            }
            else
            {
                if (studentNameIsEmpty)
                {
                    labelStudentNameError.Visible = true;
                }
                if (firstSemesterIsEmpty)
                {
                    labelFirstSemesterError.Visible = true;
                }
                if (secondSemesterIsEmpty)
                {
                    labelSecondSemesterError.Visible = true;
                }
            }
        }
    }
}
