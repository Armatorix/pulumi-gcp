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
    public sealed class RegionUrlMapPathMatcherPathRuleRouteActionWeightedBackendServiceHeaderAction
    {
        public readonly ImmutableArray<Outputs.RegionUrlMapPathMatcherPathRuleRouteActionWeightedBackendServiceHeaderActionRequestHeadersToAdd> RequestHeadersToAdds;
        public readonly ImmutableArray<string> RequestHeadersToRemoves;
        public readonly ImmutableArray<Outputs.RegionUrlMapPathMatcherPathRuleRouteActionWeightedBackendServiceHeaderActionResponseHeadersToAdd> ResponseHeadersToAdds;
        public readonly ImmutableArray<string> ResponseHeadersToRemoves;

        [OutputConstructor]
        private RegionUrlMapPathMatcherPathRuleRouteActionWeightedBackendServiceHeaderAction(
            ImmutableArray<Outputs.RegionUrlMapPathMatcherPathRuleRouteActionWeightedBackendServiceHeaderActionRequestHeadersToAdd> requestHeadersToAdds,

            ImmutableArray<string> requestHeadersToRemoves,

            ImmutableArray<Outputs.RegionUrlMapPathMatcherPathRuleRouteActionWeightedBackendServiceHeaderActionResponseHeadersToAdd> responseHeadersToAdds,

            ImmutableArray<string> responseHeadersToRemoves)
        {
            RequestHeadersToAdds = requestHeadersToAdds;
            RequestHeadersToRemoves = requestHeadersToRemoves;
            ResponseHeadersToAdds = responseHeadersToAdds;
            ResponseHeadersToRemoves = responseHeadersToRemoves;
        }
    }
}
