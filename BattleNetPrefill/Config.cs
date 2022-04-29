﻿using System;
using System.IO;
using BattleNetPrefill.Utils;

namespace BattleNetPrefill
{
    public static class Config
    {
        static Config()
        {
            if (!Directory.Exists(CacheDir))
            {
                Directory.CreateDirectory(CacheDir);
            }
        }

        public static readonly Uri BattleNetPatchUri = new Uri("http://us.patch.battle.net:1119");

        //TODO comment
        public static string CacheDir => "cache";

        public static DebugConfig DebugConfig = new DebugConfig()
        {

        };

        public static readonly string LogFileBasePath = @$"{DirectorySearch.TryGetRepoRoot()}\Logs";

        public static bool UseCdnDebugMode = false;
        public static bool ShowDebugStats = false;

        public static bool WriteOutputFiles = false;
    }

    // TODO comment
    public class DebugConfig
    {

    }
}
