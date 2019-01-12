﻿using System;
using DotNetCore.CAP;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Util.Events.Cap {
    /// <summary>
    /// 事件总线扩展
    /// </summary>
    public static class Extensions {
        /// <summary>
        /// 注册事件总线服务
        /// </summary>
        /// <param name="services">服务集合</param>
        /// <param name="action">配置操作</param>
        public static IServiceCollection AddEventBus( this IServiceCollection services, Action<CapOptions> action ) {
            services.TryAddSingleton<IEventBus, EventBus>();
            services.AddCap( action );
            return services;
        }
    }
}
