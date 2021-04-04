using System;

namespace Sample
{
    public class ModuleLoad
    {
        // This method will be run whenever the script "sit" is run. In our example module, this happens when a player clicks a chair.
        // Script names must adhere to the NWN restrictions (alphanumeric with some special characters and no longer than 16 characters)
        // The method name is arbitrary and can be called whatever you want.
        // Methods must be public and static so that the framework can pick them up when the module loads.
        [NWNEventHandler("sit")]
        public static void SitOnAChair()
        {
            var player = NWScript.GetLastUsedBy();
            var chair = NWScript.OBJECT_SELF;

            AssignCommand(player, () => ActionSit(chair));
        }
    }
}
