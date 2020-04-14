// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class InstanceFromTemplateBootDiskGetArgs : Pulumi.ResourceArgs
    {
        [Input("autoDelete")]
        public Input<bool>? AutoDelete { get; set; }

        [Input("deviceName")]
        public Input<string>? DeviceName { get; set; }

        [Input("diskEncryptionKeyRaw")]
        public Input<string>? DiskEncryptionKeyRaw { get; set; }

        [Input("diskEncryptionKeySha256")]
        public Input<string>? DiskEncryptionKeySha256 { get; set; }

        [Input("initializeParams")]
        public Input<Inputs.InstanceFromTemplateBootDiskInitializeParamsGetArgs>? InitializeParams { get; set; }

        [Input("kmsKeySelfLink")]
        public Input<string>? KmsKeySelfLink { get; set; }

        [Input("mode")]
        public Input<string>? Mode { get; set; }

        [Input("source")]
        public Input<string>? Source { get; set; }

        public InstanceFromTemplateBootDiskGetArgs()
        {
        }
    }
}
