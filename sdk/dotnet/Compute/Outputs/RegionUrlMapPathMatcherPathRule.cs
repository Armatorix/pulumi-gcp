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
    public sealed class RegionUrlMapPathMatcherPathRule
    {
        public readonly ImmutableArray<string> Paths;
        public readonly Outputs.RegionUrlMapPathMatcherPathRuleRouteAction? RouteAction;
        public readonly string? Service;
        public readonly Outputs.RegionUrlMapPathMatcherPathRuleUrlRedirect? UrlRedirect;

        [OutputConstructor]
        private RegionUrlMapPathMatcherPathRule(
            ImmutableArray<string> paths,

            Outputs.RegionUrlMapPathMatcherPathRuleRouteAction? routeAction,

            string? service,

            Outputs.RegionUrlMapPathMatcherPathRuleUrlRedirect? urlRedirect)
        {
            Paths = paths;
            RouteAction = routeAction;
            Service = service;
            UrlRedirect = urlRedirect;
        }
    }
}
