// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class InstanceGroupManagerNamedPortGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// - Version name.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The port number.
        /// - - -
        /// </summary>
        [Input("port", required: true)]
        public Input<int> Port { get; set; } = null!;

        public InstanceGroupManagerNamedPortGetArgs()
        {
        }
    }
}
