// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Dataproc.Inputs
{

    public sealed class ClusterClusterConfigWorkerConfigArgs : Pulumi.ResourceArgs
    {
        [Input("accelerators")]
        private InputList<Inputs.ClusterClusterConfigWorkerConfigAcceleratorArgs>? _accelerators;

        /// <summary>
        /// The Compute Engine accelerator configuration for these instances. Can be specified multiple times.
        /// </summary>
        public InputList<Inputs.ClusterClusterConfigWorkerConfigAcceleratorArgs> Accelerators
        {
            get => _accelerators ?? (_accelerators = new InputList<Inputs.ClusterClusterConfigWorkerConfigAcceleratorArgs>());
            set => _accelerators = value;
        }

        /// <summary>
        /// Disk Config
        /// </summary>
        [Input("diskConfig")]
        public Input<Inputs.ClusterClusterConfigWorkerConfigDiskConfigArgs>? DiskConfig { get; set; }

        /// <summary>
        /// The URI for the image to use for this worker.  See [the guide](https://cloud.google.com/dataproc/docs/guides/dataproc-images)
        /// for more information.
        /// </summary>
        [Input("imageUri")]
        public Input<string>? ImageUri { get; set; }

        [Input("instanceNames")]
        private InputList<string>? _instanceNames;
        public InputList<string> InstanceNames
        {
            get => _instanceNames ?? (_instanceNames = new InputList<string>());
            set => _instanceNames = value;
        }

        /// <summary>
        /// The name of a Google Compute Engine machine type
        /// to create for the worker nodes. If not specified, GCP will default to a predetermined
        /// computed value (currently `n1-standard-4`).
        /// </summary>
        [Input("machineType")]
        public Input<string>? MachineType { get; set; }

        /// <summary>
        /// The name of a minimum generation of CPU family
        /// for the master. If not specified, GCP will default to a predetermined computed value
        /// for each zone. See [the guide](https://cloud.google.com/compute/docs/instances/specify-min-cpu-platform)
        /// for details about which CPU families are available (and defaulted) for each zone.
        /// </summary>
        [Input("minCpuPlatform")]
        public Input<string>? MinCpuPlatform { get; set; }

        [Input("numInstances")]
        public Input<int>? NumInstances { get; set; }

        public ClusterClusterConfigWorkerConfigArgs()
        {
        }
    }
}
