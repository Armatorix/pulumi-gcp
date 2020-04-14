// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Storage.Outputs
{

    [OutputType]
    public sealed class TransferJobTransferSpec
    {
        /// <summary>
        /// An AWS S3 data source. Structure documented below.
        /// </summary>
        public readonly Outputs.TransferJobTransferSpecAwsS3DataSource? AwsS3DataSource;
        /// <summary>
        /// A Google Cloud Storage data sink. Structure documented below.
        /// </summary>
        public readonly Outputs.TransferJobTransferSpecGcsDataSink? GcsDataSink;
        /// <summary>
        /// A Google Cloud Storage data source. Structure documented below.
        /// </summary>
        public readonly Outputs.TransferJobTransferSpecGcsDataSource? GcsDataSource;
        /// <summary>
        /// An HTTP URL data source. Structure documented below.
        /// </summary>
        public readonly Outputs.TransferJobTransferSpecHttpDataSource? HttpDataSource;
        /// <summary>
        /// Only objects that satisfy these object conditions are included in the set of data source and data sink objects. Object conditions based on objects' `last_modification_time` do not exclude objects in a data sink. Structure documented below.
        /// </summary>
        public readonly Outputs.TransferJobTransferSpecObjectConditions? ObjectConditions;
        /// <summary>
        /// Characteristics of how to treat files from datasource and sink during job. If the option `delete_objects_unique_in_sink` is true, object conditions based on objects' `last_modification_time` are ignored and do not exclude objects in a data source or a data sink. Structure documented below.
        /// </summary>
        public readonly Outputs.TransferJobTransferSpecTransferOptions? TransferOptions;

        [OutputConstructor]
        private TransferJobTransferSpec(
            Outputs.TransferJobTransferSpecAwsS3DataSource? awsS3DataSource,

            Outputs.TransferJobTransferSpecGcsDataSink? gcsDataSink,

            Outputs.TransferJobTransferSpecGcsDataSource? gcsDataSource,

            Outputs.TransferJobTransferSpecHttpDataSource? httpDataSource,

            Outputs.TransferJobTransferSpecObjectConditions? objectConditions,

            Outputs.TransferJobTransferSpecTransferOptions? transferOptions)
        {
            AwsS3DataSource = awsS3DataSource;
            GcsDataSink = gcsDataSink;
            GcsDataSource = gcsDataSource;
            HttpDataSource = httpDataSource;
            ObjectConditions = objectConditions;
            TransferOptions = transferOptions;
        }
    }
}
