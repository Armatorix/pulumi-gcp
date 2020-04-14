// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.AppEngine.Inputs
{

    public sealed class FlexibleAppVersionResourcesArgs : Pulumi.ResourceArgs
    {
        [Input("cpu")]
        public Input<int>? Cpu { get; set; }

        [Input("diskGb")]
        public Input<int>? DiskGb { get; set; }

        [Input("memoryGb")]
        public Input<double>? MemoryGb { get; set; }

        [Input("volumes")]
        private InputList<Inputs.FlexibleAppVersionResourcesVolumeArgs>? _volumes;
        public InputList<Inputs.FlexibleAppVersionResourcesVolumeArgs> Volumes
        {
            get => _volumes ?? (_volumes = new InputList<Inputs.FlexibleAppVersionResourcesVolumeArgs>());
            set => _volumes = value;
        }

        public FlexibleAppVersionResourcesArgs()
        {
        }
    }
}
