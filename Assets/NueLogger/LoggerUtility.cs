
using System.Runtime.CompilerServices;
using UnityEngine;

namespace NueLogger
{
    public static class LoggerUtility
    {
        public static void NueLog(this object str, [CallerMemberName] string memberName = "") =>
            LoggerDefault.NueLog(str, memberName);

        public static void NueLog(this object str, Color color, [CallerMemberName] string memberName = "") =>
            LoggerDefault.NueLog(str, color, memberName);
        
    }
}