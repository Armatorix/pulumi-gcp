// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class RegionHealthCheckHttpsHealthCheckArgs : Pulumi.ResourceArgs
    {
        [Input("host")]
        public Input<string>? Host { get; set; }

        [Input("port")]
        public Input<int>? Port { get; set; }

        [Input("portName")]
        public Input<string>? PortName { get; set; }

        [Input("portSpecification")]
        public Input<string>? PortSpecification { get; set; }

        [Input("proxyHeader")]
        public Input<string>? ProxyHeader { get; set; }

        [Input("requestPath")]
        public Input<string>? RequestPath { get; set; }

        [Input("response")]
        public Input<string>? Response { get; set; }

        public RegionHealthCheckHttpsHealthCheckArgs()
        {
        }
    }
}
