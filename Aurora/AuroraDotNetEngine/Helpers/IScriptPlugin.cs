using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenSim.Framework;
using Aurora.Framework;
using OpenSim.Region.Framework.Scenes;
using OpenMetaverse;
using OpenMetaverse.StructuredData;

namespace Aurora.ScriptEngine.AuroraDotNetEngine
{
    public interface IScriptPlugin
    {
        /// <summary>
        /// Returns the plugin name
        /// </summary>
        /// <returns></returns>
        string Name { get; }

        void Initialize (ScriptEngine engine);
        void AddRegion (Scene scene);
        bool Check();
        OSD GetSerializationData (UUID itemID, UUID primID);
        void CreateFromData (UUID itemID, UUID objectID, OSD data);
        void RemoveScript(UUID primID, UUID itemID);
    }
}
