// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Dataproc.Inputs
{

    public sealed class ClusterClusterConfigPreemptibleWorkerConfigDiskConfigGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Size of the primary disk attached to each preemptible worker node, specified
        /// in GB. The smallest allowed disk size is 10GB. GCP will default to a predetermined
        /// computed value if not set (currently 500GB). Note: If SSDs are not
        /// attached, it also contains the HDFS data blocks and Hadoop working directories.
        /// </summary>
        [Input("bootDiskSizeGb")]
        public Input<int>? BootDiskSizeGb { get; set; }

        /// <summary>
        /// The disk type of the primary disk attached to each preemptible worker node.
        /// One of `"pd-ssd"` or `"pd-standard"`. Defaults to `"pd-standard"`.
        /// </summary>
        [Input("bootDiskType")]
        public Input<string>? BootDiskType { get; set; }

        /// <summary>
        /// The amount of local SSD disks that will be
        /// attached to each preemptible worker node. Defaults to 0.
        /// </summary>
        [Input("numLocalSsds")]
        public Input<int>? NumLocalSsds { get; set; }

        public ClusterClusterConfigPreemptibleWorkerConfigDiskConfigGetArgs()
        {
        }
    }
}
