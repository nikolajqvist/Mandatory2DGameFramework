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
        private XmlClass _xmlClass;
        private MyLogger()
        {
            _xmlClass = new XmlClass();
            _traceSource = new TraceSource(_xmlClass.GetXmlString("GameName"));
            _traceSource.Switch = new SourceSwitch(_xmlClass.GetXmlString("SwitchName"));
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
        }
        public void LogWarning(string message)
        {
            int logid = GenerateId();
            _traceSource.TraceEvent(TraceEventType.Warning, logid, message);
        }
        public void LogError(string message)
        {
            int logid = GenerateId();
            _traceSource.TraceEvent(TraceEventType.Error, logid, message);
        }
        public void LogCritical(string message)
        {
            int logid = GenerateId();
            _traceSource.TraceEvent(TraceEventType.Critical, logid, message);
        }
        private int GenerateId()
        {
            return _nextId++;
        }
    }
}
