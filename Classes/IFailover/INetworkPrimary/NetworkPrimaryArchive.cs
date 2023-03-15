using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Classes.IFailover.INetworkPrimary
{
    internal class NetworkPrimaryArchive
    {
        public bool isPublicIPAddress { get; set; }
        // innovative primary backup, using public IP failover with a possible third party involvement to facilitate the communication temporarily, likely a CDN. A combination of the two.
    }
}
