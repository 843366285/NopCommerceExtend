namespace Nop.Web.Framework.Themes
{
    /// <summary>
    /// Work context
    /// </summary>
    public interface IThemeContext
    {
        /// <summary>
        /// Get or set current theme system name
        /// 皮肤上下文，支持桌面皮肤和移动段皮肤。其实体类为:ThemeContext
        /// </summary>
        string WorkingThemeName { get; set; }
    }
}
