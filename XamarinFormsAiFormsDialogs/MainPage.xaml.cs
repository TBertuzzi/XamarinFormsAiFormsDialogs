using AiForms.Dialogs;
using AiForms.Dialogs.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinFormsAiFormsDialogs
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async Task Loading()
        {
            // Loading settings
            Configurations.LoadingConfig = new LoadingConfig
            {
                IndicatorColor = Color.White,
                OverlayColor = Color.Black,
                Opacity = 0.4,
                DefaultMessage = "Carregando (Uma hora acaba)...",
            };

            await AiForms.Dialogs.Loading.Instance.StartAsync(async progress => {
                for (var i = 0; i < 100; i++)
                {
                    await Task.Delay(50);
                    
                    progress.Report((i + 1) * 0.01d);
                }
            });
        }

        private async void btnLoading_Clicked(object sender, EventArgs e)
        {
            await Loading();
        }

        private void btnToast_Clicked(object sender, EventArgs e)
        {

            Toast.Instance.Show<MinhaToastView>();
        }

        private async void btnDialog_Clicked(object sender, EventArgs e)
        {
            var dialog = await Dialog.Instance.ShowAsync<MinhaDialogView>();
        }

        

    }
}
