// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class InstanceBootDiskGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether the disk will be auto-deleted when the instance
        /// is deleted. Defaults to true.
        /// </summary>
        [Input("autoDelete")]
        public Input<bool>? AutoDelete { get; set; }

        /// <summary>
        /// Name with which the attached disk will be accessible
        /// under `/dev/disk/by-id/google-*`
        /// </summary>
        [Input("deviceName")]
        public Input<string>? DeviceName { get; set; }

        /// <summary>
        /// A 256-bit [customer-supplied encryption key]
        /// (https://cloud.google.com/compute/docs/disks/customer-supplied-encryption),
        /// encoded in [RFC 4648 base64](https://tools.ietf.org/html/rfc4648#section-4)
        /// to encrypt this disk. Only one of `kms_key_self_link` and `disk_encryption_key_raw` may be set.
        /// </summary>
        [Input("diskEncryptionKeyRaw")]
        public Input<string>? DiskEncryptionKeyRaw { get; set; }

        [Input("diskEncryptionKeySha256")]
        public Input<string>? DiskEncryptionKeySha256 { get; set; }

        /// <summary>
        /// Parameters for a new disk that will be created
        /// alongside the new instance. Either `initialize_params` or `source` must be set.
        /// Structure is documented below.
        /// </summary>
        [Input("initializeParams")]
        public Input<Inputs.InstanceBootDiskInitializeParamsGetArgs>? InitializeParams { get; set; }

        /// <summary>
        /// The self_link of the encryption key that is
        /// stored in Google Cloud KMS to encrypt this disk. Only one of `kms_key_self_link`
        /// and `disk_encryption_key_raw` may be set.
        /// </summary>
        [Input("kmsKeySelfLink")]
        public Input<string>? KmsKeySelfLink { get; set; }

        /// <summary>
        /// Either "READ_ONLY" or "READ_WRITE", defaults to "READ_WRITE"
        /// If you have a persistent disk with data that you want to share
        /// between multiple instances, detach it from any read-write instances and
        /// attach it to one or more instances in read-only mode.
        /// </summary>
        [Input("mode")]
        public Input<string>? Mode { get; set; }

        /// <summary>
        /// The name or self_link of the disk to attach to this instance.
        /// </summary>
        [Input("source")]
        public Input<string>? Source { get; set; }

        public InstanceBootDiskGetArgs()
        {
        }
    }
}
