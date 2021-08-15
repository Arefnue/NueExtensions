using UnityEngine;

namespace NueLogger
{
    public static class LoggerDefault
    {
        private static readonly Color NueTagColor = new Color(1f, 0.59f, 0f);

        private static readonly Color NueDefaultColor = new Color(0.99f, 0.95f, 1f);

        private static readonly Color NueMemberColor = new Color(0.67f, 0.65f, 0.67f);
        
        private const string NueTagName = "<<Nue>>";

        public static void NueLog(object str, string memberName)
        {
            if (!Application.isEditor)
                return;
            Debug.Log(string.Format("<color=#{0}> {2} </color> <color=#{3}>{1}</color>  <color=#{5}>--- {4} ---</color> ",
                ColorUtility.ToHtmlStringRGBA(NueTagColor),
                str,
                NueTagName,
                ColorUtility.ToHtmlStringRGBA(NueDefaultColor),
                memberName,
                ColorUtility.ToHtmlStringRGBA(NueMemberColor)
                ));
        }

        public static void NueLog(object str, Color color, string memberName)
        {
            if (!Application.isEditor)
                return;
            
            string targetColor = ColorUtility.ToHtmlStringRGBA(color);
            Debug.Log(string.Format("<color=#{0}> {2} </color> <color=#{3}>{1}</color>  <color=#{5}>--- {4} ---</color> ",
                ColorUtility.ToHtmlStringRGBA(NueTagColor), 
                str,
                NueTagName,
                targetColor,
                memberName,
                ColorUtility.ToHtmlStringRGBA(NueMemberColor)
                ));
        }
        
    }
}