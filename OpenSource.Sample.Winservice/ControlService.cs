using log4net;
using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Timers;
using Topshelf;

namespace OpenSource.Sample.Winservice
{
    public class ControlService : ServiceControl, ServiceSuspend
    {
        protected ILog loger = LogManager.GetLogger(typeof(ControlService));
        private readonly IScheduler scheduler;

        public ControlService()
        {
            scheduler = StdSchedulerFactory.GetDefaultScheduler();
        }
        
        public bool Start(HostControl hostControl)
        {
            scheduler.Start();
            return true;
        }

        public bool Stop(HostControl hostControl)
        {
            scheduler.Shutdown(false);
            return true;
        }

        public bool Continue(HostControl hostControl)
        {
            scheduler.ResumeAll();
            return true;
        }

        public bool Pause(HostControl hostControl)
        {
            scheduler.PauseAll();
            return true;
        }
    }
}
