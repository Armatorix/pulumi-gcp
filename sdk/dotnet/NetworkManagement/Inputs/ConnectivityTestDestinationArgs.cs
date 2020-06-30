// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.NetworkManagement.Inputs
{

    public sealed class ConnectivityTestDestinationArgs : Pulumi.ResourceArgs
    {
        [Input("instance")]
        public Input<string>? Instance { get; set; }

        [Input("ipAddress")]
        public Input<string>? IpAddress { get; set; }

        [Input("network")]
        public Input<string>? Network { get; set; }

        [Input("port")]
        public Input<int>? Port { get; set; }

        [Input("projectId")]
        public Input<string>? ProjectId { get; set; }

        public ConnectivityTestDestinationArgs()
        {
        }
    }
}