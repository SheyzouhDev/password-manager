using Proton_Manager.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace Proton_Manager.Helper
{
    public static class ConfigurationHelper
    {
        private static readonly string configDirPath = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "ProtonManager");

        private static readonly string configFileName = "ProtonManager.config.json";
        private static readonly string configFilePath = Path.Combine(configDirPath, configFileName);

        public static void SaveConfiguration(Configuration configuration)
        {
            var json = JsonSerializer.Serialize(configuration, new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.All)
            });

            if (!Directory.Exists(configDirPath))
                Directory.CreateDirectory(configDirPath);

            File.WriteAllText(configFilePath, json);
        }

        public static Configuration LoadConfiguration()
        {
            Configuration configuration = new();

            if (!Directory.Exists(configDirPath))
            {
                Directory.CreateDirectory(configDirPath);

                SaveConfiguration(configuration);

                return configuration;
            }

            var json = File.ReadAllText(configFilePath);

            return JsonSerializer.Deserialize<Configuration>(json);
        }
    }
}