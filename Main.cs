using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MergeFiles
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void buttonSouce_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                sourcePath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonConvert_Click(object sender, EventArgs e)
        {
            if (!IsValidPath())
            {
                return;
            }

            saveFileDialog.FileName = "report";
            saveFileDialog.DefaultExt = "html";
            saveFileDialog.Filter = "HTML files (*.html)|*.html";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }

            var files = Directory.GetFiles(sourcePath.Text, "*.html");
            var result = "<html><body>";
            for (var i = 0; i < files.Length; i++)
            {
                var html = File.ReadAllText(files[i], Encoding.GetEncoding("ISO-8859-1"));

                const RegexOptions options = RegexOptions.IgnoreCase | RegexOptions.Singleline;
                var regx = new Regex("<body>(?<theBody>.*)</body>", options);

                var match = regx.Match(html);

                if (match.Success)
                {
                    result += match.Groups["theBody"].Value;
                }
            }

            result += "</body></html>";

            File.WriteAllText(saveFileDialog.FileName, result, Encoding.GetEncoding("ISO-8859-1"));
            MessageBox.Show("Sucesso!");

            System.Diagnostics.Process.Start(saveFileDialog.FileName);
        }

        private bool IsValidPath()
        {
            if (string.IsNullOrEmpty(sourcePath.Text))
            {
                MessageBox.Show("Selecione uma pasta!");
                return false;
            }


            if (!Directory.Exists(sourcePath.Text))
            {
                MessageBox.Show("Essa pasta não existe!");
                return false;
            }

            if (!Directory.GetFiles(sourcePath.Text, "*.html").Any())
            {
                MessageBox.Show("Não existe nenhum arquivo HTML nessa pasta.");
                return false;
            }

            return true;
        }
    }
}
