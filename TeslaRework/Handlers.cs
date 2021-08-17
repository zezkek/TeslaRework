using Exiled.API.Features;
using Exiled.Events.EventArgs;
using Exiled.API.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace MoreToolsExiled
{
    public class Handlers
    {
        public void OnTriggeringTesla(TriggeringTeslaEventArgs ev)
        {
            if (!Plugin.PluginItem.Config.IsCardDisbaleEnabled)
            {
                ev.IsTriggerable = true;
            }
            else
            {
                foreach (ItemType iscard in Plugin.PluginItem.Config.Cards)
                    if (ev.Player.HasItem(iscard))
                        ev.IsTriggerable = false;
                List<Player> players = Player.List.ToList();
                foreach (Player has_card in players.Where(x=>Vector3.Distance(x.Position,ev.Player.Position)<=Plugin.PluginItem.Config.DistanceToDisable))
                {
                    foreach (ItemType iscard in Plugin.PluginItem.Config.Cards)
                        if (has_card.HasItem(iscard))
                            ev.IsTriggerable = false;
                }
            }
        }
        public void 
    }
}
