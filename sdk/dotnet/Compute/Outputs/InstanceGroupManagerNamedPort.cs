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
    public sealed class InstanceGroupManagerNamedPort
    {
        /// <summary>
        /// - Version name.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The port number.
        /// - - -
        /// </summary>
        public readonly int Port;

        [OutputConstructor]
        private InstanceGroupManagerNamedPort(
            string name,

            int port)
        {
            Name = name;
            Port = port;
        }
    }
}
