// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class InstanceScratchDiskGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The disk interface to use for attaching this disk; either SCSI or NVME.
        /// </summary>
        [Input("interface", required: true)]
        public Input<string> Interface { get; set; } = null!;

        public InstanceScratchDiskGetArgs()
        {
        }
    }
}
