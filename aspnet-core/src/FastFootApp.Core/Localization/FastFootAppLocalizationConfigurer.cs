using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace FastFootApp.Localization
{
    public static class FastFootAppLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(FastFootAppConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(FastFootAppLocalizationConfigurer).GetAssembly(),
                        "FastFootApp.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
