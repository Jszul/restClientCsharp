using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace restClientCsharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        { 
        RESTClient rClient = new RESTClient();
        rClient.endPoint = txtRequest.Text;
        debugOutput("RESTClient Object created.");

        string strJSON = string.Empty;

        strJSON = rClient.makeRequest();

        debugOutput(strJSON);
    }
        private void debugOutput(string strDebugText)
        {
            try
            {
                System.Diagnostics.Debug.Write(strDebugText + Environment.NewLine);
                txtresponse.Text = txtresponse.Text + strDebugText + Environment.NewLine;
                txtresponse.SelectionStart = txtresponse.TextLength;
                txtresponse.ScrollToCaret();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Write(ex.Message, ToString() + Environment.NewLine);
            }
        }    
    }
}
