// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Container.Inputs
{

    public sealed class ClusterPrivateClusterConfigGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// When `true`, the cluster's private
        /// endpoint is used as the cluster endpoint and access through the public endpoint
        /// is disabled. When `false`, either endpoint can be used. This field only applies
        /// to private clusters, when `enable_private_nodes` is `true`.
        /// </summary>
        [Input("enablePrivateEndpoint", required: true)]
        public Input<bool> EnablePrivateEndpoint { get; set; } = null!;

        /// <summary>
        /// Enables the private cluster feature,
        /// creating a private endpoint on the cluster. In a private cluster, nodes only
        /// have RFC 1918 private addresses and communicate with the master's private
        /// endpoint via private networking.
        /// </summary>
        [Input("enablePrivateNodes")]
        public Input<bool>? EnablePrivateNodes { get; set; }

        /// <summary>
        /// The IP range in CIDR notation to use for
        /// the hosted master network. This range will be used for assigning private IP
        /// addresses to the cluster master(s) and the ILB VIP. This range must not overlap
        /// with any other ranges in use within the cluster's network, and it must be a /28
        /// subnet. See [Private Cluster Limitations](https://cloud.google.com/kubernetes-engine/docs/how-to/private-clusters#limitations)
        /// for more details. This field only applies to private clusters, when
        /// `enable_private_nodes` is `true`.
        /// </summary>
        [Input("masterIpv4CidrBlock")]
        public Input<string>? MasterIpv4CidrBlock { get; set; }

        /// <summary>
        /// The name of the peering between this cluster and the Google owned VPC.
        /// </summary>
        [Input("peeringName")]
        public Input<string>? PeeringName { get; set; }

        /// <summary>
        /// The internal IP address of this cluster's master endpoint.
        /// </summary>
        [Input("privateEndpoint")]
        public Input<string>? PrivateEndpoint { get; set; }

        /// <summary>
        /// The external IP address of this cluster's master endpoint.
        /// </summary>
        [Input("publicEndpoint")]
        public Input<string>? PublicEndpoint { get; set; }

        public ClusterPrivateClusterConfigGetArgs()
        {
        }
    }
}
