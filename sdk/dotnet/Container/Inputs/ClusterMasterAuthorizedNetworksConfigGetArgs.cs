// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Container.Inputs
{

    public sealed class ClusterMasterAuthorizedNetworksConfigGetArgs : Pulumi.ResourceArgs
    {
        [Input("cidrBlocks")]
        private InputList<Inputs.ClusterMasterAuthorizedNetworksConfigCidrBlockGetArgs>? _cidrBlocks;

        /// <summary>
        /// External networks that can access the
        /// Kubernetes cluster master through HTTPS.
        /// </summary>
        public InputList<Inputs.ClusterMasterAuthorizedNetworksConfigCidrBlockGetArgs> CidrBlocks
        {
            get => _cidrBlocks ?? (_cidrBlocks = new InputList<Inputs.ClusterMasterAuthorizedNetworksConfigCidrBlockGetArgs>());
            set => _cidrBlocks = value;
        }

        public ClusterMasterAuthorizedNetworksConfigGetArgs()
        {
        }
    }
}
