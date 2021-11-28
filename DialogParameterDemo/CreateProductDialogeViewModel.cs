using Prism.Services.Dialogs;
using System;

namespace DialogParameterDemo
{
    public class CreateProductDialogViewModel : IDialogAware
    {
        public string Title => "新規商品追加ダイアログ";

        public event Action<IDialogResult> RequestClose;

        public bool CanCloseDialog() => true;

        public void OnDialogClosed()
        {
        }

        public void OnDialogOpened(IDialogParameters parameters)
        {
        }
    }
}