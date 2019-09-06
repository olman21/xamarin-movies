using AiForms.Dialogs.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin.Movies.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadingOverlay : LoadingView
    {
        public LoadingOverlay()
        {
            InitializeComponent();
        }
    }
}