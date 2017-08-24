using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace OpenSource.Sample.Winservice
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                //x.UseLog4Net();
                x.Service<ControlService>();

                x.SetServiceName("aWinServices");//服务名称
                x.SetDisplayName("OpenSource.Sample.Winservice");//服务的显示名称
                x.SetDescription("sample服务");//服务的描述

                x.RunAsLocalSystem();
                x.EnablePauseAndContinue();
            });
        }
    }
}
