using System.ComponentModel;
using Synapse.Config;


namespace OmegaWarHead
{
    public class Config : AbstractConfigSection
    { 
        [Description("Whether or not this plugin enabled")]
        public bool isEnabled { get; set; } = true;

        [Description("When omegawarhead detonated it will send broadcast message ")]
        public string messagekill { get; set; } = "OmegaWarHead has been detonated";

        [Description("OmegaWarHead broadcast time")]
        public int bdtime { get; set; } = 10;
         

    }
}
