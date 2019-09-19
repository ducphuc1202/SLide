using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slide
{
    public partial class Form1 : Form
    {
        Image img;
        string pathDirectoryImg;
        string pathAvatarImg;
        private string openFileName;
        List<string> imageFiles = new List<string>();
        int thutu = 1;
        public Form1()
        {
            InitializeComponent();
            slideContainer.AllowDrop = true;
            pathDirectoryImg = Application.StartupPath + "/img";
            if (Directory.Exists(Application.StartupPath + "/img"))
            {
                var files = Directory.GetFiles(Application.StartupPath + "/img", "*.*", SearchOption.AllDirectories);
                if(files.Length > 0)
                {
                    foreach (string filename in files)
                    {
                        if (Regex.IsMatch(filename, @".jpg|.png|.gif$"))
                        {
                            imageFiles.Add(filename);
                        }
                    }
                    FileStream fileStream = new FileStream(imageFiles[0], FileMode.Open, FileAccess.Read);
                    slideContainer.Image = Image.FromStream(fileStream);
                    fileStream.Close();
                }

            }
            else
            {
                slideContainer.Image = Properties.Resources.design_form_SV;
            }

        }

        private void BtnImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();
            OpenFileDialog openfileDialog = new OpenFileDialog();
            openfileDialog.Title = "Chon anh dai dien";
            openfileDialog.Filter = "File anh(*.png; *.jpg)|*.png; *.jpg";
            if (folderDialog.ShowDialog() == DialogResult.OK)
            {
                openFileName = openfileDialog.FileName;
                try
                {
                    var files = Directory.GetFiles(folderDialog.SelectedPath, "*.*", SearchOption.AllDirectories);

                    imageFiles = new List<string>();
                    int count = 1;
                    
                    foreach (string filename in files)
                    {
                        if (Regex.IsMatch(filename, @".jpg|.png|.gif$"))
                        {
                            imageFiles.Add(filename);
                            
                        }
                            

                    }
                    if (imageFiles.Count > 0) {
                        timer1.Stop();
                        if (Directory.Exists(Application.StartupPath + "/img"))
                        {
                            var old_files = Directory.GetFiles(Application.StartupPath + "/img", "*.*", SearchOption.AllDirectories);
                            if (old_files.Length > 0)
                            {
                                foreach (string filename in old_files)
                                {
                                    if (Regex.IsMatch(filename, @".jpg|.png|.gif$"))
                                    {
                                        
                                        File.Delete(filename);
                                    }
                                }
                            }
                              
    
                            
                        }
                            
                        foreach (string filename in imageFiles)
                        {
                            img = Image.FromFile(filename);
                            if (img != null)
                            {
                                if (!Directory.Exists(pathDirectoryImg))
                                {
                                    Directory.CreateDirectory(pathDirectoryImg);
                                }
                                
                                string a = String.Format("/slide_{0}.png", count);
                                img.Save(pathDirectoryImg + a);
                                count++;

                            }
                        }
                            
                    }

                    MessageBox.Show("Upload thanh cong. Anh moi se duoc load sau 3s",
                                "Thong bao",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                    thutu = 0;
                    timer1.Start();
                }
                catch (Exception exp)
                {
                    MessageBox.Show("An error occurred while attempting to load the file. The error is:"
                                    + System.Environment.NewLine + exp.ToString() + System.Environment.NewLine);
                    
                }
                Invalidate();
            }
        }

        

  

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
            if(imageFiles.Count > 0)
            {
                //slideContainer.Image = Image.FromFile(imageFiles[thutu]);
                FileStream fileStream = new FileStream(imageFiles[thutu], FileMode.Open, FileAccess.Read);
                slideContainer.Image = Image.FromStream(fileStream);
                fileStream.Close();
                if (thutu == imageFiles.Count - 1)
                    thutu = 0;
                else
                    thutu++;
            }
            
            
        }
    }
}
