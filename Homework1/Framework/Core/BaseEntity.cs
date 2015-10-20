using log4net;
using log4net.Config;

namespace Homework.Framework.Core
{
    public class BaseEntity
    {
        public static Logger Log;

        protected BaseEntity()
        {
            XmlConfigurator.Configure();
            Log = new Logger(LogManager.GetLogger(typeof(BaseEntity)));
        }
    }
}
