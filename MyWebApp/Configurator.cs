using MyWebApp.Handlers;
using MyWebApp.Resources;
using OpenRasta.Configuration;
using OpenRasta.Configuration.Fluent;
using OpenRasta.Configuration.WebForms;

namespace MyWebApp
{
    public class Configurator : IConfigurationSource
    {
        public void Configure()
        {
            using (OpenRastaConfiguration.Manual)
            {
                ResourceSpace.Has.ResourcesOfType<Home>()
                    .AtUri("/home")
                    .HandledBy<HomeHandler>()
                    .RenderedByAspx("~/Views/HomeView.aspx");
            }
        }
    }
}