// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.AppEngine.Inputs
{

    public sealed class ApplicationIapGetArgs : Pulumi.ResourceArgs
    {
        [Input("oauth2ClientId", required: true)]
        public Input<string> Oauth2ClientId { get; set; } = null!;

        [Input("oauth2ClientSecret", required: true)]
        public Input<string> Oauth2ClientSecret { get; set; } = null!;

        [Input("oauth2ClientSecretSha256")]
        public Input<string>? Oauth2ClientSecretSha256 { get; set; }

        public ApplicationIapGetArgs()
        {
        }
    }
}
