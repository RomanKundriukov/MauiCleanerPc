using MauiCleanerPc.View;

namespace MauiCleanerPc
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(StartPageView), typeof(StartPageView));
        }
    }
}
