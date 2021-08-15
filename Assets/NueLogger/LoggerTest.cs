using System;
using UnityEngine;

namespace NueLogger
{
    public class LoggerTest: MonoBehaviour
    {
        private void Start()
        {
            "Test Default".NueLog();
            
        }

        private void Update()
        {
            "Test Default".NueLog();
            "Test Colored".NueLog(Color.green);
        }

        private void LateUpdate()
        {
            "Test Default".NueLog();
            "Test Colored".NueLog(Color.red);
        }
    }
}