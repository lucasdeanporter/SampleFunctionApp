using SampleFunctionApp.Interfaces.IDownload;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Interfaces.IAutoUpdate
{
    internal class IAutoUpdateRecord
    {
        IAutoUpdateArchive updateArchive;
        public IDownloadRecord Downloader;
    }
}
