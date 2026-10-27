using UnityEditor;
using UnityEngine;
using System.Linq;

/// <summary>
/// Headless build script invoked by GitHub Actions CI to produce an Android APK.
/// </summary>
public static class BuildScript
{
    private static readonly string[] Scenes = GetEnabledScenes();

    /// <summary>
    /// Entry point called by Unity in batch mode:
    /// -executeMethod BuildScript.BuildAndroid
    /// </summary>
    public static void BuildAndroid()
    {
        string outputPath = GetArgument("-outputPath", "Builds/ArrowBlitz.apk");

        Debug.Log($"[BuildScript] Starting Android build → {outputPath}");
        Debug.Log($"[BuildScript] Scenes: {string.Join(", ", Scenes)}");

        // ── Android-specific settings ──────────────────────────────────────
        PlayerSettings.applicationIdentifier = "com.dipanjan.arrowblitz";
        PlayerSettings.productName           = "ArrowBlitz";
        PlayerSettings.bundleVersion         = "1.0.0";
        PlayerSettings.Android.bundleVersionCode = 1;

        // Target SDK / minimum SDK
        PlayerSettings.Android.targetSdkVersion  = AndroidSdkVersions.AndroidApiLevel33;
        PlayerSettings.Android.minSdkVersion      = AndroidSdkVersions.AndroidApiLevel22;

        // Use the IL2CPP scripting backend for release builds
        PlayerSettings.SetScriptingBackend(BuildTargetGroup.Android, ScriptingImplementation.IL2CPP);
        PlayerSettings.Android.targetArchitectures = AndroidArchitecture.ARM64 | AndroidArchitecture.ARMv7;

        // Build an APK (not AAB) so it can be sideloaded directly
        EditorUserBuildSettings.buildAppBundle = false;

        // ── Execute build ──────────────────────────────────────────────────
        BuildPlayerOptions opts = new BuildPlayerOptions
        {
            scenes            = Scenes,
            locationPathName  = outputPath,
            target            = BuildTarget.Android,
            options           = BuildOptions.None
        };

        var report = BuildPipeline.BuildPlayer(opts);
        var summary = report.summary;

        if (summary.result == UnityEditor.Build.Reporting.BuildResult.Succeeded)
        {
            Debug.Log($"[BuildScript] Build succeeded! Size: {summary.totalSize / 1024 / 1024} MB");
        }
        else
        {
            Debug.LogError($"[BuildScript] Build FAILED: {summary.result}");
            EditorApplication.Exit(1);
        }
    }

    // ── Helpers ─────────────────────────────────────────────────────────────

    private static string[] GetEnabledScenes()
    {
        return EditorBuildSettings.scenes
            .Where(s => s.enabled)
            .Select(s => s.path)
            .ToArray();
    }

    private static string GetArgument(string name, string defaultValue = "")
    {
        string[] args = System.Environment.GetCommandLineArgs();
        for (int i = 0; i < args.Length - 1; i++)
        {
            if (args[i] == name)
                return args[i + 1];
        }
        return defaultValue;
    }
}
