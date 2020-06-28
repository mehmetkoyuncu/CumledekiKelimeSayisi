using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CumledeKelimeBulma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            string[] wordList = txtText.Text.Split(new char[] {' ','.' });
            string searchedText = txtSearchedWord.Text.ToLower();
            int count=0;
            foreach (string item in wordList)
            {
                if(searchedText.ToLower()==item.ToLower())
                {
                    count++;
                }
            }
            lblWordCount.Text = count.ToString();

      
        }
    }
}
