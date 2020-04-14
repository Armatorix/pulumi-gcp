// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.BinaryAuthorization.Inputs
{

    public sealed class AttestorAttestationAuthorityNotePublicKeyGetArgs : Pulumi.ResourceArgs
    {
        [Input("asciiArmoredPgpPublicKey")]
        public Input<string>? AsciiArmoredPgpPublicKey { get; set; }

        [Input("comment")]
        public Input<string>? Comment { get; set; }

        /// <summary>
        /// an identifier for the resource with format `projects/{{project}}/attestors/{{name}}`
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("pkixPublicKey")]
        public Input<Inputs.AttestorAttestationAuthorityNotePublicKeyPkixPublicKeyGetArgs>? PkixPublicKey { get; set; }

        public AttestorAttestationAuthorityNotePublicKeyGetArgs()
        {
        }
    }
}
