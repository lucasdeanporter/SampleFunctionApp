using SampleFunctionApp.Fundamentals.Interfaces.IFramework;
using System;

namespace SampleFunctionApp.Fundamentals.Interfaces.IApp
{
    public interface IAppArchive : IArchive
    {
        public string AppName { get; }
    }
}
