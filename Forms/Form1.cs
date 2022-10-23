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

namespace Forms
{
    public partial class SaveUserData : Form
    {
        public SaveUserData()
        {
            InitializeComponent();
        }

        private void exitapplication_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void adddata_Click(object sender, EventArgs e)
        {
            if ((accountno.Text != null) && (customername.Text != null) && (customerid.Text != null) && (location != null))
            {


                using (StreamWriter streamWriter = new StreamWriter("customerdata.txt"))
                {
                    streamWriter.WriteLine(accountno.Text + " " + customername.Text + " " + customerid.Text + " " + location.Text);
                }
                this.Hide();
                HomePage homePage = new HomePage();
                homePage.Show();

                string path = @"C:\Users\akshata\source\repos\Forms\bin\Debug\customerdata.txt";
                using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
                {
                    using (StreamReader sr = new StreamReader(fs))
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }

                }
            }


            else
            {
                MessageBox.Show("Enter the valid Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                   



        }
    }
}
