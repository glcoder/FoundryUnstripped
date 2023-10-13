#if UNITY_EDITOR
using System;
using UnityEngine;
using UnityEditor;
using UnityEditor.Build.Reporting;
#endif

public class Builder
{
    public static void Build()
    {
#if UNITY_EDITOR
        PlayerSettings.SetManagedStrippingLevel(BuildTargetGroup.Standalone, ManagedStrippingLevel.High);
        BuildPipeline.BuildPlayer(new BuildPlayerOptions
        {
            scenes = new[] { "Assets/Scene.unity" },
            locationPathName = "Build/FoundryUnstripped.exe",
            options = BuildOptions.None,
            target = BuildTarget.StandaloneWindows64,
        });
#endif
    }
}
