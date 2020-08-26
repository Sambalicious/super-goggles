namespace Basics

{
    public class Installer
    {
        private readonly Logger _logger;

        public Installer(Logger logger)
        {
            _logger = logger;
        }

        public void Install()
        {
            System.Console.WriteLine("we are installing a new application");
        }
    }
 }