/* http://www.zkea.net/ Copyright 2016 ZKEASOFT http://www.zkea.net/licenses */
using Easy.Models;
using Microsoft.AspNetCore.Hosting;
using System;

namespace Easy
{
    public interface IApplicationContext
    {
        IUser CurrentUser { get; }
        IUser CurrentCustomer { get; }
        IHostingEnvironment HostingEnvironment { get; }
        bool IsAuthenticated { get; }
    }
}
