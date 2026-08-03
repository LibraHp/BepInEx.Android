using System;
using System.IO;

namespace BepInEx.Preloader.Core;

/// <summary>
///     NextCore environment variables, passed into the BepInEx preloader.
///     <para>https://github.com/All-Of-Us-Mods/FusionCore</para>
/// </summary>
public static class EnvVars
{
    /// <summary>
    ///     Path to the BepInEx folder, passed in by NextCore.
    /// </summary>
    public static string NEXT_BEPINEX_PATH { get; private set; }

    /// <summary>
    ///     Path to the game binary (libil2cpp.so)
    /// </summary>
    public static string NEXT_GAME_BINARY { get; private set; }

    /// <summary>
    ///     Path to the app's data directory, not safe to write.
    /// </summary>
    public static string NEXT_GAME_DATA_DIR { get; private set; }

    /// <summary>
    ///     Path to NextCore's data directory, safe to write.
    /// </summary>
    public static string NEXT_APP_DATA_DIR { get; private set; }


    /// <summary>
    ///     Unity version override passed in by NextCore.
    /// </summary>
    public static string NEXT_UNITY_VERSION { get; private set; }

    internal static void LoadVars()
    {
        NEXT_BEPINEX_PATH = Environment.GetEnvironmentVariable("NEXT_BEPINEX_PATH");
        NEXT_GAME_BINARY = Environment.GetEnvironmentVariable("NEXT_GAME_BINARY");
        NEXT_GAME_DATA_DIR = Environment.GetEnvironmentVariable("NEXT_GAME_DATA_DIR");
        NEXT_APP_DATA_DIR = Environment.GetEnvironmentVariable("NEXT_APP_DATA_DIR");
        NEXT_UNITY_VERSION = Environment.GetEnvironmentVariable("NEXT_UNITY_VERSION");
    }
}
