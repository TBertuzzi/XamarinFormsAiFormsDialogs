using AiForms.Dialogs.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinFormsAiFormsDialogs
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MinhaDialogView : DialogView
    {
        public MinhaDialogView()
        {
            InitializeComponent();
        }

        public override void SetUp()
        {
           
        }
        public override void RunPresentationAnimation()
        {
            
        }

        public override void RunDismissalAnimation()
        {
            
        }

        public override void Destroy()
        {
            
        }

        void btnOK_Clicked(object sender, System.EventArgs e)
        {
            DialogNotifier.Complete();
        }

        void btnCancel_Clicked(object sender, System.EventArgs e)
        {
            DialogNotifier.Cancel();
        }
    }
}