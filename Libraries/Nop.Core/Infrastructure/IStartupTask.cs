namespace Nop.Core.Infrastructure
{
    /// <summary>
    /// Interface which should be implemented by tasks run on startup
    /// </summary>
    public interface IStartupTask 
    {
        /// <summary>
        /// Executes a task
        /// 系统启动时执行任务
        /// 启动时执行的任务主要是数据库的初始化和加载
        /// </summary>
        void Execute();

        /// <summary>
        /// Order
        /// </summary>
        int Order { get; }
    }
}
