﻿using OrderBook.Data.Services;
using OrderBook.UI.ViewModels;

namespace OrderBook.UI
{
    public partial class XMainForm : DevExpress.XtraEditors.XtraForm
    {
        private readonly MainViewModel _mainViewModel;

        public XMainForm()
        {
            InitializeComponent();
            _mainViewModel = new MainViewModel(new OrderBookApiService());
        }

        private async void btnOpenOrderBookForm_Click(object sender, EventArgs e)
        {
            await _mainViewModel.OpenOrderBookWindow();
        }

        private async void XMainForm_Load(object sender, EventArgs e)
        {
            await _mainViewModel.Load();
            orderBookBindingSource.DataSource = _mainViewModel.OrderBooks;
        }
    }
}