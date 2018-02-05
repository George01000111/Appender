using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        private static readonly ILog log = LogManager.GetLogger(typeof(Program));

        static void Main(string[] args)
        {
            log4net.Config.XmlConfigurator.Configure();
            log.Info("Estoy registrando este evento");
            log.Error("ERROR!");
            log.Debug("Se ha iniciado el servicio de base de datos");
            Console.ReadKey();

        }
    }
}
