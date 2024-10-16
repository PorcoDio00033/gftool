﻿using Tomlyn.Model;
using System.Text.Json.Serialization;
using System.ComponentModel;

namespace TrinityModLoader
{
    [JsonDerivedType(typeof(PackedModEntry), "PackedModEntry")]
    [JsonDerivedType(typeof(FolderModEntry), "FolderModEntry")]
    public interface IModEntry
    {
        public string ModPath { get; set; }
        public string URL { get; set; }
        public bool IsEnabled { get; set; }

        public string[] FetchFiles();
        public ModData FetchToml();

        public void Extract(string path);
        public bool Exists();
    }

    public class ModData
    {
        [Category("Mod Data")]
        [DisplayName("Name")]
        public string display_name { get; set; }
        public string description { get; set; }
        public string version { get; set; }
    }
}
