using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
namespace CleanerBL
{
    public class Cleaner
    {
        private string filePath;

        public Cleaner(string filePath)
        {
            this.filePath = filePath;
        }

        private XmlDocument openFile()
        {
            XmlDocument xml = new XmlDocument();
            try
            {
                xml.Load(this.filePath);
            }
            catch (Exception e)
            {
                throw e;
            }
            return xml;
        }
        public void run(ListBox listbox)
        {
            
            MessageBox.Show("in run");
            listbox.Items.Add("in run");


            XmlDocument xml = openFile();
            XmlNodeList songsList = xml.SelectNodes("MusicDatabase/Songs/Song");
            foreach (XmlNode song in songsList)
            {
                if (song["Title"].InnerText != "")
                {
                    string title = song["Title"].InnerText;
                    string album = song["ContainedInAlbum"].InnerText;
                    listbox.Items.Add(title);
                    //break;
                }
            }

        }

    }
}