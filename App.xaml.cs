namespace LoginSimple
{
    public partial class App : Application
    {

        public static List<string> usuarios = new List<string>();
        public static List<string> claves = new List<string>();
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new NavigationPage(new Views.vOne()));
        }
    }
}