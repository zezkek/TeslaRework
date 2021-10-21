using Exiled.API.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeslaRework
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        [Description("Are tesla gates enabled?")]
        public bool IsTeslaEnabled { get; set; } = true;
        [Description("Are cards diabling tesla")]
        public bool IsCardDisbaleEnabled { get; set; } = true;
        [Description("List of cards that disables tesla")]
        public List<ItemType> Cards { get; set; } = new List<ItemType> {
            ItemType.KeycardResearchCoordinator, ItemType.KeycardGuard,
            ItemType.KeycardNTFOfficer, ItemType.KeycardNTFLieutenant,
            ItemType.KeycardNTFCommander,ItemType.KeycardFacilityManager,
            ItemType.KeycardContainmentEngineer};
        [Description("Distance between tesla and player with card to prevent tesla from charging")]
        public float DistanceToDisable { get; set; } = 10;
    }
}
