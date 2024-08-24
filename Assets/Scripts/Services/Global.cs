using Services.MessageHub;
using Services.ServiceLocator;

namespace Services
{
    public static class Global
    {
        public static readonly ILocator Locator = new Locator();
        
        public static void BindServices()
        {
            Locator.Bind<IMessageHub>(new MessageHub.MessageHub());
        }
    }
    
  
}