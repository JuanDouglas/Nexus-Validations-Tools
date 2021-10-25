﻿using System;

namespace Nexus.Tools.Validations.Middlewares.Authentication.Attributes
{
    /// <summary>
    /// Informs Middleware of authentication that this class or method accepts anonymous requests.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = false)]
    public class AllowAnonymousAttribute : Attribute
    {
    }
}
