// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.ContainerAnalysis.Inputs
{

    public sealed class NoteAttestationAuthorityArgs : Pulumi.ResourceArgs
    {
        [Input("hint", required: true)]
        public Input<Inputs.NoteAttestationAuthorityHintArgs> Hint { get; set; } = null!;

        public NoteAttestationAuthorityArgs()
        {
        }
    }
}
