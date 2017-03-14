using System.Web.Routing;

namespace Nop.Web.Framework.Mvc.Routes
{
    /// <summary>
    /// Route publisher
    /// </summary>
    public interface IRoutePublisher
    {
        /// <summary>
        /// Register routes
        /// 路由发布者，以主动的试向系统添加路由 实体类：RoutePublisher
        /// </summary>
        /// <param name="routes">Routes</param>
        void RegisterRoutes(RouteCollection routes);
    }
}
