using Solution.Common.Misc;

using UnityEngine;

namespace Solution.Common.Assets {
    public class LoggingSettings : ScriptableObject, IUpdatedAsset {
        public ICommonLogger commonLogger = ICommonLogger.CreateDefaultLogger();
    }
}