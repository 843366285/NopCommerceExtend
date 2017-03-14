using System.Web.Routing;

namespace Nop.Web.Framework.Mvc.Routes
{
    /// <summary>
    /// 路由提供者，每个插件都有一个路由提供者，向系统中注册路由
    /// </summary>
    public interface IRouteProvider
    {
        void RegisterRoutes(RouteCollection routes);

        int Priority { get; }
    }
}
