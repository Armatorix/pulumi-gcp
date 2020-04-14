// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Container.Outputs
{

    [OutputType]
    public sealed class GetClusterMasterAuthResult
    {
        public readonly string ClientCertificate;
        public readonly ImmutableArray<Outputs.GetClusterMasterAuthClientCertificateConfigResult> ClientCertificateConfigs;
        public readonly string ClientKey;
        public readonly string ClusterCaCertificate;
        public readonly string Password;
        public readonly string Username;

        [OutputConstructor]
        private GetClusterMasterAuthResult(
            string clientCertificate,

            ImmutableArray<Outputs.GetClusterMasterAuthClientCertificateConfigResult> clientCertificateConfigs,

            string clientKey,

            string clusterCaCertificate,

            string password,

            string username)
        {
            ClientCertificate = clientCertificate;
            ClientCertificateConfigs = clientCertificateConfigs;
            ClientKey = clientKey;
            ClusterCaCertificate = clusterCaCertificate;
            Password = password;
            Username = username;
        }
    }
}
