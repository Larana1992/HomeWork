using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.Framework.Core
{
    public class Logger
    {
        private ILog logger;

        public Logger(ILog logger)
        {
            this.logger = logger;
        }

        public void Step(int number)
        {
            logger.Info("== Step " + number + " ==");
        }

        public void Info(String info)
        {
            logger.Info(info);
        }

        public void Fatal(String fatal)
        {
            logger.Fatal(fatal);
        }
    }
}
