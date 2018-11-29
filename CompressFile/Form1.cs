using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Libreria para comprimir archivos
/*using System.IO.Compression;
using System.IO;*/


namespace CompressFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class ObjetoArchivo
        {
            public string Name { get; set; }
            public string Size { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*string carpetaAComprimir = @"C:\Files\Start";
            string archivoDestioACrear = @"C:\Files\result.zip";
            string carpetaAExtraer = @"C:\Files\End\result.zip";*/

            /*ZipFile.CreateFromDirectory(carpetaAComprimir, archivoDestioACrear);
            //ZipFile.ExtractToDirectory(archivoDestioACrear, carpetaAExtraer);
            File.Move(archivoDestioACrear, carpetaAExtraer);*/

            
            /*using (ZipArchive zip = ZipFile.Open(@"C:\Files\End\result.zip", ZipArchiveMode.Create, Encoding.UTF8 ))
            {
                zip.CreateEntryFromFile(@"C:\Files\Start\Doc-Cargos.txt", "archivo.txt");
                
            }*/


            using (ZipFile zip = new ZipFile())
            {
                zip.Password = "password";
                zip.AddFile(@"C:\Files\Start\Doc-Cargos.txt", "/");
                zip.Save(@"C:\Files\End\result.zip");
            }

        }
    }
}
