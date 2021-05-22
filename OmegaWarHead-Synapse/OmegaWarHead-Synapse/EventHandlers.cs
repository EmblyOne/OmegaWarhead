using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Synapse;
using Synapse.Api;
using Synapse.Api.Plugin;

namespace OmegaWarHead
{ 
    
    public class EventHandlers
    {
        
     

        public EventHandlers()
        {
            Server.Get.Events.Map.WarheadDetonationEvent += OnDetonation;
        } 
         
        public void OnDetonation()   
        {


            foreach (var player in Server.Get.Players)
            {
                player.Kill(DamageTypes.Nuke);  
                player.SendBroadcast((ushort)OmegaWarHead.Plugin.Config.bdtime, OmegaWarHead.Plugin.Config.messagekill);
                
            } 
           
        }
    }
}
