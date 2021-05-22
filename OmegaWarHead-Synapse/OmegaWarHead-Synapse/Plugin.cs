using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Synapse.Api;
using Synapse;
using Synapse.Api.Plugin;

namespace OmegaWarHead
{
    [PluginInformation(
            Author = "Space",
            Name = "OmegaWarHead",
            Description = "With that plugin warhead will detonate everyone with custom broadcast",
            SynapseMajor = 2,
            SynapseMinor = 5,
            SynapsePatch = 3,
            Version = "v.1.0.0",
            LoadPriority = 1

           )]
    public class Plugin : AbstractPlugin
    {
        [Synapse.Api.Plugin.Config(section = "OmegaWarHead")]
        public static Config Config; 

        public override void Load()
        {
            new EventHandlers(); 
            base.Load();
        }
    }
}
