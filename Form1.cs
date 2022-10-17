using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PSI_FileExplorer
{
    public partial class Form1 : Form
    {
        DirectoryInfo dif = new DirectoryInfo(@"C:\");

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPath.Text= @"C:\";

            PreencherDetail();
        }

        private void rdbLarge_Click(object sender, EventArgs e)
        {
            lstvFiles.View = View.LargeIcon;
        }

        private void PreencherLarge()
        {
            lstvFiles.LargeImageList = img;

            DirectoryInfo[] difs = dif.GetDirectories();
            foreach (DirectoryInfo d in difs)
            {
                ListViewItem item = new ListViewItem(d.Name);

                lstvFiles.Items.Add(item);

            }
        }

        private void PreencherDetail()
        {
            DirectoryInfo[] difs = dif.GetDirectories();

            foreach (DirectoryInfo d in difs)
            {
                ListViewItem item = new ListViewItem(d.Name);

                item.SubItems.Add(d.LastWriteTime.ToString());
                item.SubItems.Add("Folder");

                lstvFiles.Items.Add(item);
            }

            FileInfo[] fifs = dif.GetFiles();

            foreach (FileInfo f in fifs)
            {
                ListViewItem item = new ListViewItem(f.Name);

                item.SubItems.Add(f.LastWriteTime.ToString());
                item.SubItems.Add("File");
                item.SubItems.Add(f.Length.ToString());
            }
        }
    }
}
