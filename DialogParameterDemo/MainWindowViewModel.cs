using DialogParameterDemo.Data;
using Prism.Services.Dialogs;
using System.Collections.Generic;

namespace DialogParameterDemo
{
    public class MainWindowViewModel
    {
        public IList<Product> Products { get; }
        private IDialogService _dialogService;

        public MainWindowViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;
            _dialogService.ShowDialog(nameof(CreateProductDialogView));

            Products = new List<Product>();
            Products.Add(new Product("1", "梅干し", 300));
            Products.Add(new Product("2", "納豆", 400));
            Products.Add(new Product("3", "甘納豆", 500));
            Products.Add(new Product("4", "甘酒", 600));
            Products.Add(new Product("5", "煮干し", 700));
        }
    }
}