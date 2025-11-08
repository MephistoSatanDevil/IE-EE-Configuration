using EEConfig.Components;

namespace EEConfig.UI
{
    public partial class AdditionalOptions : BaseWindow
    {
        private BaldurPropertyManager BaldurPropertyManager;

        public AdditionalOptions(BaldurPropertyManager baldurPropertyManager)
        {
            InitializeComponent();
            this.BaldurPropertyManager = baldurPropertyManager;
        }

        private void AdditionalOptions_Load(object sender, EventArgs e)
        {

        }
    }
}
