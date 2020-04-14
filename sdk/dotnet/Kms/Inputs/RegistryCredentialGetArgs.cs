// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Kms.Inputs
{

    public sealed class RegistryCredentialGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The certificate format and data.
        /// </summary>
        [Input("publicKeyCertificate", required: true)]
        public Input<Inputs.RegistryCredentialPublicKeyCertificateGetArgs> PublicKeyCertificate { get; set; } = null!;

        public RegistryCredentialGetArgs()
        {
        }
    }
}
