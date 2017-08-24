using Dapper;
using OpenSource.Sample.Winservice.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Quartz;
using log4net;

namespace OpenSource.Sample.Winservice.Jobs
{
    public class SomethingJob : IJob
    {
        const string SPSQL = @"exec sp_action";
        protected ILog loger = LogManager.GetLogger(typeof(SomethingJob));

        public void Execute(IJobExecutionContext context)
        {
            loger.Info("begin");

            using (IDbConnection conn = Common.Helper.NewAIConnection())
            {
                conn.Execute(SPSQL);
            }

            loger.Info("end");
        }
    }
}
