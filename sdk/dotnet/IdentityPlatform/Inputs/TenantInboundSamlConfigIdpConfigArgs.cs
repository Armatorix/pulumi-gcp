// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.IdentityPlatform.Inputs
{

    public sealed class TenantInboundSamlConfigIdpConfigArgs : Pulumi.ResourceArgs
    {
        [Input("idpCertificates", required: true)]
        private InputList<Inputs.TenantInboundSamlConfigIdpConfigIdpCertificateArgs>? _idpCertificates;
        public InputList<Inputs.TenantInboundSamlConfigIdpConfigIdpCertificateArgs> IdpCertificates
        {
            get => _idpCertificates ?? (_idpCertificates = new InputList<Inputs.TenantInboundSamlConfigIdpConfigIdpCertificateArgs>());
            set => _idpCertificates = value;
        }

        [Input("idpEntityId", required: true)]
        public Input<string> IdpEntityId { get; set; } = null!;

        [Input("signRequest")]
        public Input<bool>? SignRequest { get; set; }

        [Input("ssoUrl", required: true)]
        public Input<string> SsoUrl { get; set; } = null!;

        public TenantInboundSamlConfigIdpConfigArgs()
        {
        }
    }
}
