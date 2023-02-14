using dosymep.Bim4Everyone;
using dosymep.Bim4Everyone.ProjectConfigs;
using dosymep.Serializers;

using pyRevitLabs.Json;

namespace RevitPluginTemplate.Models {
    internal class RevitPluginTemplateConfig :ProjectConfig<RevitPluginTemplateSettings> {
        [JsonIgnore] public override string ProjectConfigPath { get; set; }

        [JsonIgnore] public override IConfigSerializer Serializer { get; set; }

        public static RevitPluginTemplateConfig GetCheckingLevelConfig() {
            return new ProjectConfigBuilder()
                .SetSerializer(new ConfigSerializer())
                .SetPluginName(nameof(RevitPluginTemplate))
                .SetRevitVersion(ModuleEnvironment.RevitVersion)
                .SetProjectConfigName(nameof(RevitPluginTemplateConfig) + ".json")
                .Build<RevitPluginTemplateConfig>();
        }
    }

    internal class RevitPluginTemplateSettings : ProjectSettings {
        public override string ProjectName { get; set; }
    }
}