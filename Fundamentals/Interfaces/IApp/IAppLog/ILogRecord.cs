﻿using SampleFunctionApp.Fundamentals.Classes.Examples;
using SampleFunctionApp.Fundamentals.Classes.IApp.IAppContext.IMethodContext;
using SampleFunctionApp.Fundamentals.Features;
using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using SampleFunctionApp.Fundamentals.Interfaces.ITime;
using System.Collections.Generic;

namespace SampleFunctionApp.Fundamentals.Interfaces.IApp.IAppLog
{
    public interface ILogRecord : ILogArchive, ISessionArchive, IDurationArchive, IRecord, IArchive
    {
        // TODO: Need to grab values from ILogLogicRecord
        string NamespaceName { get; set; }
        string ClassName { get; set; }
        string MethodName { get; set; }
        public object BeginningParameters { get; set; }
        public object EndingParameters { get; set; }
        bool IsCurrentMessageString { get; set; }
        public StringOrObject CurrentMessage { get; set; }
        List<StringOrObject> PreviousMessages { get; set; }
        public int EndIncrement { get; set; }
        public bool OnMethodEndCalled { get; set; }
        public bool IsMethodEnd { get; set; }
        public void SetCurrentMessage(string newMessage);
        public void SetCurrentMessage(object newMessage);
        public bool ExistsCurrentMessage();
        public void AddToPreviousMessages(StringOrObject lastCurrentMessage);
    }
}