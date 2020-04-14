// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class URLMapPathMatcherRouteRuleHeaderActionGetArgs : Pulumi.ResourceArgs
    {
        [Input("requestHeadersToAdds")]
        private InputList<Inputs.URLMapPathMatcherRouteRuleHeaderActionRequestHeadersToAddGetArgs>? _requestHeadersToAdds;
        public InputList<Inputs.URLMapPathMatcherRouteRuleHeaderActionRequestHeadersToAddGetArgs> RequestHeadersToAdds
        {
            get => _requestHeadersToAdds ?? (_requestHeadersToAdds = new InputList<Inputs.URLMapPathMatcherRouteRuleHeaderActionRequestHeadersToAddGetArgs>());
            set => _requestHeadersToAdds = value;
        }

        [Input("requestHeadersToRemoves")]
        private InputList<string>? _requestHeadersToRemoves;
        public InputList<string> RequestHeadersToRemoves
        {
            get => _requestHeadersToRemoves ?? (_requestHeadersToRemoves = new InputList<string>());
            set => _requestHeadersToRemoves = value;
        }

        [Input("responseHeadersToAdds")]
        private InputList<Inputs.URLMapPathMatcherRouteRuleHeaderActionResponseHeadersToAddGetArgs>? _responseHeadersToAdds;
        public InputList<Inputs.URLMapPathMatcherRouteRuleHeaderActionResponseHeadersToAddGetArgs> ResponseHeadersToAdds
        {
            get => _responseHeadersToAdds ?? (_responseHeadersToAdds = new InputList<Inputs.URLMapPathMatcherRouteRuleHeaderActionResponseHeadersToAddGetArgs>());
            set => _responseHeadersToAdds = value;
        }

        [Input("responseHeadersToRemoves")]
        private InputList<string>? _responseHeadersToRemoves;
        public InputList<string> ResponseHeadersToRemoves
        {
            get => _responseHeadersToRemoves ?? (_responseHeadersToRemoves = new InputList<string>());
            set => _responseHeadersToRemoves = value;
        }

        public URLMapPathMatcherRouteRuleHeaderActionGetArgs()
        {
        }
    }
}
