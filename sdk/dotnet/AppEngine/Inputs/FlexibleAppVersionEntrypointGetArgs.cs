// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.AppEngine.Inputs
{

    public sealed class FlexibleAppVersionEntrypointGetArgs : Pulumi.ResourceArgs
    {
        [Input("shell", required: true)]
        public Input<string> Shell { get; set; } = null!;

        public FlexibleAppVersionEntrypointGetArgs()
        {
        }
    }
}
