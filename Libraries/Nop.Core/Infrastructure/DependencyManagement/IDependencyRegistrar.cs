using Autofac;
using Nop.Core.Configuration;

namespace Nop.Core.Infrastructure.DependencyManagement
{
    /// <summary>
    /// Dependency registrar interface
    /// 系统注册接口
    /// 并通过ITypeFinder类搜寻程序集里实现接口IDependencyRegistrar的类
    /// </summary>
    public interface IDependencyRegistrar
    {
        /// <summary>
        /// Register services and interfaces
        /// </summary>
        /// <param name="builder">Container builder 窗口生成器</param>
        /// <param name="typeFinder">Type finder 类型查找者接口</param>
        /// <param name="config">Config</param>
        void Register(ContainerBuilder builder, ITypeFinder typeFinder, NopConfig config);

        /// <summary>
        /// Order of this dependency registrar implementation
        /// 注册排序序号
        /// </summary>
        int Order { get; }
    }
}
