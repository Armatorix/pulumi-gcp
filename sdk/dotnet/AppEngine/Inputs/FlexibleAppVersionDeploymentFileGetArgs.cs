// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.AppEngine.Inputs
{

    public sealed class FlexibleAppVersionDeploymentFileGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The identifier for this object. Format specified above.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("sha1Sum")]
        public Input<string>? Sha1Sum { get; set; }

        [Input("sourceUrl", required: true)]
        public Input<string> SourceUrl { get; set; } = null!;

        public FlexibleAppVersionDeploymentFileGetArgs()
        {
        }
    }
}