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
    public sealed class URLMapPathMatcherRouteRuleMatchRuleQueryParameterMatch
    {
        public readonly string? ExactMatch;
        public readonly string Name;
        public readonly bool? PresentMatch;
        public readonly string? RegexMatch;

        [OutputConstructor]
        private URLMapPathMatcherRouteRuleMatchRuleQueryParameterMatch(
            string? exactMatch,

            string name,

            bool? presentMatch,

            string? regexMatch)
        {
            ExactMatch = exactMatch;
            Name = name;
            PresentMatch = presentMatch;
            RegexMatch = regexMatch;
        }
    }
}
