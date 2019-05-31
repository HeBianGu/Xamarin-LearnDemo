using System;

using HeBianGu.Product.XamarinDemo.Defaut.Models;

namespace HeBianGu.Product.XamarinDemo.Defaut.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
