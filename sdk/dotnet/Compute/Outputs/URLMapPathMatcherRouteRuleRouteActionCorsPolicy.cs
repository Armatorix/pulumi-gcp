// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Outputs
{

    [OutputType]
    public sealed class URLMapPathMatcherRouteRuleRouteActionCorsPolicy
    {
        public readonly bool? AllowCredentials;
        public readonly ImmutableArray<string> AllowHeaders;
        public readonly ImmutableArray<string> AllowMethods;
        public readonly ImmutableArray<string> AllowOriginRegexes;
        public readonly ImmutableArray<string> AllowOrigins;
        public readonly bool? Disabled;
        public readonly ImmutableArray<string> ExposeHeaders;
        public readonly int? MaxAge;

        [OutputConstructor]
        private URLMapPathMatcherRouteRuleRouteActionCorsPolicy(
            bool? allowCredentials,

            ImmutableArray<string> allowHeaders,

            ImmutableArray<string> allowMethods,

            ImmutableArray<string> allowOriginRegexes,

            ImmutableArray<string> allowOrigins,

            bool? disabled,

            ImmutableArray<string> exposeHeaders,

            int? maxAge)
        {
            AllowCredentials = allowCredentials;
            AllowHeaders = allowHeaders;
            AllowMethods = allowMethods;
            AllowOriginRegexes = allowOriginRegexes;
            AllowOrigins = allowOrigins;
            Disabled = disabled;
            ExposeHeaders = exposeHeaders;
            MaxAge = maxAge;
        }
    }
}
