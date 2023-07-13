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
using static System.Windows.Forms.Design.AxImporter;
using System.Xml;
using System.Text.Json;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;
using System.Text.Json.Serialization;
using JsonSerializer = System.Text.Json.JsonSerializer;

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
                string nome = txtStudentName.Text;

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

                var aluno = new AlunoDTO(nome, nota1, nota2, media, labelGradeStatus.Text);
                var output = "../../../../output.json"; 
                JsonFileUtils.WriteJSON(aluno, output);
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

    // Simples AlunoDTO para ser convertido em JSON e/ou inserido em um banco de dados.
    public record class AlunoDTO(
        string Nome,
        float Nota1,
        float Nota2,
        float Media,
        string Status);
   
                
    // Classe auxiliar para parsear Objetos em JSON
    public static class JsonFileUtils
    {
        private static readonly JsonSerializerOptions _options =
            new() { DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull };

        public static void WriteJSON(object obj, string fileName)
        {
            var options = new JsonSerializerOptions(_options)
            {
                WriteIndented = true
            };
            var jsonString = JsonSerializer.Serialize(obj, options);
            File.AppendAllText(fileName, jsonString+"\n");
        }
    }
}
