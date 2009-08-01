using MyWebApp.Resources;

namespace MyWebApp.Handlers
{
    public class HomeHandler
    {
        public object Get()
        {
            return new Home {Title = "Welcome home."};
        }
    }
}