// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Container.Inputs
{

    public sealed class ClusterMasterAuthClientCertificateConfigArgs : Pulumi.ResourceArgs
    {
        [Input("issueClientCertificate", required: true)]
        public Input<bool> IssueClientCertificate { get; set; } = null!;

        public ClusterMasterAuthClientCertificateConfigArgs()
        {
        }
    }
}
