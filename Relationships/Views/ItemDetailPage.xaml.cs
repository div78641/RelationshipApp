using System.ComponentModel;
using Xamarin.Forms;
using Relationships.ViewModels;

namespace Relationships.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
