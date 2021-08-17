using Exiled.API.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayerEv = Exiled.Events.Handlers.Player;

namespace MoreToolsExiled
{
    public class Plugin:Plugin<Config>
    {
        public override string Name { get; } = "MoreTools";
        public override string Author { get; } = ".fkn_goose";
        public override Version Version => new Version(0, 0, 1);
        public static readonly Lazy<Plugin> LazyInstance = new Lazy<Plugin>(valueFactory: () => new Plugin());
        public static Plugin PluginItem => LazyInstance.Value;
        private Handlers handlers;
        public override void OnEnabled()
        {
            handlers = new Handlers();
            PlayerEv.TriggeringTesla += handlers.OnTriggeringTesla;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            PlayerEv.TriggeringTesla -= handlers.OnTriggeringTesla;
            handlers = null;
            base.OnDisabled();
        }
    }
}
