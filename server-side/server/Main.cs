using GTANetworkAPI;
namespace server
{
    public class Main : Script
    {

        [ServerEvent(Event.ResourceStart)]
        public void OnResourceStart()
        {
            Console.WriteLine("Ariseu just started!");
        }
    }
}
