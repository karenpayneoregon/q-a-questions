using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoApp.Classes;
using DemoApp.Models;
using Newtonsoft.Json;

namespace DemoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ReadJsonButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var wc = new WebClient())
                {
                    var json = wc.DownloadString("https://crmscf.vidyasystems.com/api/gen/items.php");
                    Container container = JsonConvert.DeserializeObject<Container>(json);
                    if (container != null && container.success == 1)
                    {
                        var dt = container.items.ToList().ToDataTable();
                        dataGridView1.DataSource = dt;
                    }
                    else
                    {
                        // deal with it
                    }
                }
            }
            catch (Exception ex)
            {
                // deal with error
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DownloadInformation("https://crmscf.vidyasystems.com/api/gen/items.php");
        }

        private void DownloadInformation(string sender)
        {
            try
            {
                using (var wc = new WebClient())
                {
                    wc.DownloadStringCompleted += DetailOnDownloadStringCompleted;
                    wc.DownloadStringAsync(new Uri(sender));
                }
            }
            catch (Exception)
            {
                // ignored - deal with it
            }
        }

        private void DetailOnDownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
        {
            if (e.Cancelled == false)
            {
                Console.WriteLine(e.Result);
            }
            
        }

    }
}
