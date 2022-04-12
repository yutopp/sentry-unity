using UnityEditor;
using UnityEditor.Build;
using UnityEditor.Build.Reporting;
using UnityEngine;

namespace Sentry.Unity.Editor
{
    class Il2CppOption : IPreprocessBuildWithReport
    {
        public int callbackOrder => 0;

        public void OnPreprocessBuild(BuildReport report)
        {
            if (!Application.unityVersion.StartsWith("2022.1"))
            {
                return;
            }

            var arguments = "--emit-source-mapping";
            Debug.Log($"Setting additional IL2CPP arguments = '{arguments}' for platform {report.summary.platform}");
            PlayerSettings.SetAdditionalIl2CppArgs(arguments);
        }
    }
}
