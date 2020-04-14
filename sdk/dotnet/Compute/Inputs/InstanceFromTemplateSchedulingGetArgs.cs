// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class InstanceFromTemplateSchedulingGetArgs : Pulumi.ResourceArgs
    {
        [Input("automaticRestart")]
        public Input<bool>? AutomaticRestart { get; set; }

        [Input("nodeAffinities")]
        private InputList<Inputs.InstanceFromTemplateSchedulingNodeAffinityGetArgs>? _nodeAffinities;
        public InputList<Inputs.InstanceFromTemplateSchedulingNodeAffinityGetArgs> NodeAffinities
        {
            get => _nodeAffinities ?? (_nodeAffinities = new InputList<Inputs.InstanceFromTemplateSchedulingNodeAffinityGetArgs>());
            set => _nodeAffinities = value;
        }

        [Input("onHostMaintenance")]
        public Input<string>? OnHostMaintenance { get; set; }

        [Input("preemptible")]
        public Input<bool>? Preemptible { get; set; }

        public InstanceFromTemplateSchedulingGetArgs()
        {
        }
    }
}
