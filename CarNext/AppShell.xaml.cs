namespace CarNext
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Shell.SetTabBarIsVisible(this, false);
        }
    }
}
