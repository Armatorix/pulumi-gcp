// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.CloudRun.Inputs
{

    public sealed class DomainMappingMetadataGetArgs : Pulumi.ResourceArgs
    {
        [Input("annotations")]
        private InputMap<string>? _annotations;
        public InputMap<string> Annotations
        {
            get => _annotations ?? (_annotations = new InputMap<string>());
            set => _annotations = value;
        }

        [Input("generation")]
        public Input<int>? Generation { get; set; }

        [Input("labels")]
        private InputMap<string>? _labels;
        public InputMap<string> Labels
        {
            get => _labels ?? (_labels = new InputMap<string>());
            set => _labels = value;
        }

        [Input("namespace", required: true)]
        public Input<string> Namespace { get; set; } = null!;

        [Input("resourceVersion")]
        public Input<string>? ResourceVersion { get; set; }

        [Input("selfLink")]
        public Input<string>? SelfLink { get; set; }

        [Input("uid")]
        public Input<string>? Uid { get; set; }

        public DomainMappingMetadataGetArgs()
        {
        }
    }
}
