using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ferramentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void informaçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string info = $"Sistema Operacinal:{Environment.OSVersion}\n" +
                          $"Arquitetura: {(Environment.Is64BitOperatingSystem ? "64 Bits" : "32")}" +
                          $"Processador: {System.Environment.GetEnvironmentVariable("PROCESSOR_IDENTIFIER")}";

            MessageBox.Show(info);
        }

        private void apagarArquivosTemporariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exibe uma mensagem de confirmação
            var result = MessageBox.Show("Certeza? ",
                         "Confirmação",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // captura o caminho para pasta temporaria do windows
                string tempPatch = Path.GetTempPath();
                // Rodar metodo para apagar os arquivos que vamos criar
                DeletarArquivosTemporarios(tempPatch);
            }

        }

        private void DeletarArquivosTemporarios(string tempPatch)
        {
            try
            {
                if (Directory.Exists(tempPatch))
                {
                    DirectoryInfo di = new DirectoryInfo(tempPatch);

                    // Deletar todos os arwuivos encontrados
                    foreach (FileInfo file in di.GetFiles())
                    {
                        file.Delete();
                    }

                    // Deleta todas as pastas
                    foreach (DirectoryInfo dir in di.GetDirectories())
                    {
                        dir.Delete();
                    }

                }
                else
                {
                    MessageBox.Show("A pasta não existe!",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void desligarComputadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Conexão com form2
            desligaPc desliga = new desligaPc();
            desliga.ShowDialog();

        }
    }
}
