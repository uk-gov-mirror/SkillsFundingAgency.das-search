﻿namespace Sfa.Infrastructure.Services
{
    using System;
    using Microsoft.ApplicationInsights.NLogTarget;
    using NLog;
    using NLog.Targets.ElasticSearch;
    using Sfa.Eds.Das.Indexer.ApplicationServices.Infrastructure;

    public class NLogService : ILog
    {
        private ElasticSearchTarget dummy; // Reference so assembly is copied to Primary output.
        private ApplicationInsightsTarget dummy2; // Reference so assembly is copied to Primary output.

        private Logger logger;
        public NLogService(Type loggerType)
        {
            logger = LogManager.GetLogger(loggerType?.ToString() ?? "NullIndexLogger");
        }

        public void Debug(object message)
        {
            logger.Debug(message);
        }

        public void Debug(object message, Exception exception)
        {
            logger.Debug(exception, message.ToString());
        }

        public void DebugFormat(string format, params object[] args)
        {
            logger.Debug(format, args);
        }

        public void Info(object message)
        {
            logger.Info(message);
        }

        public void Info(object message, Exception exception)
        {
            logger.Info(exception, message.ToString());
        }

        public void InfoFormat(string format, params object[] args)
        {
            logger.Info(format, args);
        }

        public void Warn(object message)
        {
            logger.Warn(message);
        }

        public void Warn(object message, Exception exception)
        {
            logger.Warn(exception, message.ToString());
        }

        public void WarnFormat(string format, params object[] args)
        {
            logger.Warn(format, args);
        }

        public void Error(object message)
        {
            logger.Error(message);
        }

        public void Error(object message, Exception exception)
        {
            logger.Error(exception, message.ToString());
        }

        public void ErrorFormat(string format, params object[] args)
        {
            logger.Error(format, args);
        }

        public void Fatal(object message)
        {
            logger.Fatal(message);
        }

        public void Fatal(object message, Exception exception)
        {
            logger.Fatal(exception, message.ToString());
        }

        public void FatalFormat(string format, params object[] args)
        {
            logger.Fatal(format, args);
        }
    }
}