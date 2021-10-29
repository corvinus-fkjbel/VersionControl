﻿using MNBSoap.Entities;
using MNBSoap.MnbServicereference;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MNBSoap
{
    public partial class Form1 : Form
    {
        BindingList<RateData> Rates = new BindingList<RateData>();
        public Form1()
        {
            InitializeComponent();
            Consume();
        }

        void Consume()
        {
            MNBArfolyamServiceSoapClient mnbService = new MNBArfolyamServiceSoapClient();
            GetExchangeRatesRequestBody request = new GetExchangeRatesRequestBody();
            request.currencyNames = "EUR";
            request.startDate = "2020-01-01";
            request.endDate = "2020-06-30";
            mnbService.GetExchangeRates(request);
            var response = mnbService.GetExchangeRates(request);
            var result = response.GetExchangeRatesResult;
            FileDialog.WriteAllText("export.xml", result);


        }
    }
}
