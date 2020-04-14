// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Storage.Inputs
{

    public sealed class TransferJobTransferSpecAwsS3DataSourceAwsAccessKeyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// AWS Key ID.
        /// </summary>
        [Input("accessKeyId", required: true)]
        public Input<string> AccessKeyId { get; set; } = null!;

        /// <summary>
        /// AWS Secret Access Key.
        /// </summary>
        [Input("secretAccessKey", required: true)]
        public Input<string> SecretAccessKey { get; set; } = null!;

        public TransferJobTransferSpecAwsS3DataSourceAwsAccessKeyArgs()
        {
        }
    }
}
