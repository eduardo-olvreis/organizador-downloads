using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrganizadorDownloads
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            string[] arquivos = Directory.GetFiles(@"C:\Users\eduar\Downloads");
            foreach (string arquivo in arquivos)
            {
                listBox1.Items.Add(Path.GetFileName(arquivo));
                listBox2.Items.Add(Path.GetExtension(arquivo).Trim());
                string extensao = Path.GetExtension(arquivo).Trim();
                string pastaDestino = "";
                switch (extensao)
                {
                    // Documentos
                    case ".pdf":
                    case ".docx":
                    case ".doc":
                    case ".xlsx":
                    case ".pptx":
                    case ".txt":
                    case ".epub":
                        pastaDestino = "Documentos";
                        break;

                    // Imagens
                    case ".jpg":
                    case ".jpeg":
                    case ".png":
                    case ".gif":
                    case ".svg":
                    case ".webp":
                    case ".bmp":
                        pastaDestino = "Imagens";
                        break;

                    // Videos
                    case ".mp4":
                    case ".mkv":
                    case ".avi":
                    case ".mov":
                    case ".webm":
                        pastaDestino = "Videos";
                        break;

                    // Audios
                    case ".mp3":
                    case ".wav":
                    case ".flac":
                    case ".ogg":
                        pastaDestino = "Musicas";
                        break;

                    // Compactados
                    case ".zip":
                    case ".rar":
                    case ".7z":
                    case ".tar":
                    case ".gz":
                        pastaDestino = "Compactados";
                        break;

                    // Executaveis
                    case ".exe":
                    case ".msi":
                    case ".bat":
                    case ".apk":
                        pastaDestino = "Executaveis";
                        break;

                    // Outros
                    default:
                        pastaDestino = "Outros";
                        break;
                }
            }
        }
    }
}
