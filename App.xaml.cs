using Microsoft.Extensions.DependencyInjection;
using ComplementarioEstela.Data;

namespace ComplementarioEstela
{
    public partial class App : Application
    {
        public static PersonRepository PersonRepo { get; private set; }

        public App(PersonRepository repo)
        {
            InitializeComponent();

            PersonRepo = repo;
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            return new Window(new AppShell());
        }
    }
}