﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace BrowserApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com");

            //test

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

            var el = webBrowser1.Document.GetElementById("lst-ib");
            el.SetAttribute("value", "test");

            el.Style.Insert(2, "");

            el.Style.Insert(2, "");
            el.Style.Insert(2, "");
            el.Style.Insert(2, "");



            el.Style.Insert(2, "");
            el.Style.Insert(2, "");
            el.Style.Insert(2, "");

        }
    }
}
