using DialogParameterDemo.Data;
using Prism.Services.Dialogs;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Input;
using Prism.Commands;

namespace DialogParameterDemo
{
    public class MainWindowViewModel
    {
        public IList<Product> Products { get; }
        private IDialogService _dialogService;

        public DelegateCommand CreateProductCommand { get; }

        public MainWindowViewModel(IDialogService dialogService)
        {
            _dialogService = dialogService;

            CreateProductCommand = new DelegateCommand(
                //executeMethod 実行される内容
                () => { _dialogService.ShowDialog(nameof(CreateProductDialogView)); },
                //canExecuteMethod 実行できるか
                () => true);

            Products = new List<Product>();
            Products.Add(new Product("1", "梅干し", 300));
            Products.Add(new Product("2", "納豆", 400));
            Products.Add(new Product("3", "甘納豆", 500));
            Products.Add(new Product("4", "甘酒", 600));
            Products.Add(new Product("5", "煮干し", 700));
        }
    }
}