// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Endpoints.Inputs
{

    public sealed class ServiceEndpointGetArgs : Pulumi.ResourceArgs
    {
        [Input("address")]
        public Input<string>? Address { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        public ServiceEndpointGetArgs()
        {
        }
    }
}
