using System.Collections.Generic;

namespace Nop.Web.Framework.Themes
{
    /// <summary>
    /// 皮肤提供者
    /// </summary>
    public partial interface IThemeProvider
    {
        ThemeConfiguration GetThemeConfiguration(string themeName);

        IList<ThemeConfiguration> GetThemeConfigurations();

        bool ThemeConfigurationExists(string themeName);
    }
}
