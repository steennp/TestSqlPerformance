using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testsqlperformance
{
    using System.Data.SqlClient;
    using System.Diagnostics;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Stopwatch s = new Stopwatch();
            s.Start();

            DataSet dataset = new DataSet();
            
            tResult.AppendText("opening : "+ s.ElapsedMilliseconds + Environment.NewLine);

            try
            {
                using (SqlConnection con = new SqlConnection("Data Source=" + tServer.Text + ";Initial Catalog=" + tDB.Text + ";User ID=" + tUser.Text + ";Password=" + tPass.Text))
                {
                


                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = new SqlCommand(tQuery.Text, con);
                con.Open();
                tResult.AppendText("Filling : " + s.ElapsedMilliseconds + Environment.NewLine);
                adapter.Fill(dataset);
                tResult.AppendText("Filled : " + s.ElapsedMilliseconds + Environment.NewLine);

                tResult.AppendText(dataset.GetXml());

                }
            }
            catch (Exception ee)
            {
                
                tResult.AppendText(ee.ToString());
            }


            tTime.Text = s.ElapsedMilliseconds.ToString();
            s.Stop();
            




        }
    }
}
