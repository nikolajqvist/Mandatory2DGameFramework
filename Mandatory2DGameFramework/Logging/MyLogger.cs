using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mandatory2DGameFramework.Xml;

namespace Mandatory2DGameFramework.Logging
{
    public class MyLogger
    {
        private static int _nextId;
        private static MyLogger _instance = null;
        private TraceSource _traceSource;
        private MyLogger()
        {
            _traceSource = new TraceSource("Peter's spil");
            _traceSource.Switch = new SourceSwitch("Peter's switch");
        }
        public static MyLogger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MyLogger();
            }
            return _instance;
        }
        public void AddSource(TraceListener listener)
        {
            if (listener != null)
            {
                _traceSource.Listeners.Add(listener);
            }
        }
        public void RemoveSource(TraceListener listener)
        {
            if (listener != null)
            {
                _traceSource.Listeners.Remove(listener);
            }
        }
        public void LogInfo(string message)
        {
            int logid = GenerateId();
            _traceSource.TraceEvent(TraceEventType.Information, logid, message);
            Flushing();
        }
        public void LogWarning(string message)
        {
            int logid = GenerateId();
            _traceSource.TraceEvent(TraceEventType.Warning, logid, message);
            Flushing();
        }
        public void LogError(string message)
        {
            int logid = GenerateId();
            _traceSource.TraceEvent(TraceEventType.Error, logid, message);
            Flushing();
        }
        public void LogCritical(string message)
        {
            int logid = GenerateId();
            _traceSource.TraceEvent(TraceEventType.Critical, logid, message);
            Flushing();
        }
        private int GenerateId()
        {
            return _nextId++;
        }
        private void Flushing()
        {
            _traceSource.Flush();
        }
    }
}
