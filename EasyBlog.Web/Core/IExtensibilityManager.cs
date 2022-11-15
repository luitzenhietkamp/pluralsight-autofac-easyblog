using EasyBlog.Common;
using System;

namespace EasyBlog.Web.Core
{
    public interface IExtensibilityManager
    {
        ModuleEvents ModuleEvents { get; }
        ModuleEvents GetModuleEvents();
        void InvokeModuleEvent<T>(Action<T> moduleEvent, T args);
        void InvokeCancelableModuleEvent<T>(Action<T> moduleEvent, T args);
    }
}
