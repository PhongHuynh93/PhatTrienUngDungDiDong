using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Text;

using System.Windows.Forms;

namespace ConsumeConvertWS
{

    public partial class Form1 : Form
    {

        private ConsumeConvertWS.convertWS.ConvertWSSoap ws;

        public Form1()
        {

            InitializeComponent();

            ws = new ConsumeConvertWS.convertWS.ConvertWSSoapClient();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnVND2USD_Click(object sender, EventArgs e)
        {
            double mon = Double.Parse(txtMoney.Text);

            double usd = ws.VND2USD(mon);

            txtKetQua.Text = usd.ToString();

        }

        private void btnVND2EUR_Click(object sender, EventArgs e)
        {
            double mon = Double.Parse(txtMoney.Text);

            double usd = ws.VND2EUR(mon);

            txtKetQua.Text = usd.ToString();

        }

        private void btnUSD2VND_Click(object sender, EventArgs e)
        {
            double mon = Double.Parse(txtMoney.Text);

            double usd = ws.USD2VND(mon);

            txtKetQua.Text = usd.ToString();
        }

        private void btnEUR2VND_Click(object sender, EventArgs e)
        {
            double mon = Double.Parse(txtMoney.Text);

            double usd = ws.EUR2VND(mon);

            txtKetQua.Text = usd.ToString();
        }

        

    }

}