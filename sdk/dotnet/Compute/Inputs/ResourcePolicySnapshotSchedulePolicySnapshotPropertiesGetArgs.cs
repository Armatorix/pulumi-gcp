// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class ResourcePolicySnapshotSchedulePolicySnapshotPropertiesGetArgs : Pulumi.ResourceArgs
    {
        [Input("guestFlush")]
        public Input<bool>? GuestFlush { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("storageLocations")]
        public Input<string>? StorageLocations { get; set; }

        public ResourcePolicySnapshotSchedulePolicySnapshotPropertiesGetArgs()
        {
        }
    }
}
