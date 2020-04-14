// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Storage.Inputs
{

    public sealed class TransferJobTransferSpecObjectConditionsGetArgs : Pulumi.ResourceArgs
    {
        [Input("excludePrefixes")]
        private InputList<string>? _excludePrefixes;

        /// <summary>
        /// `exclude_prefixes` must follow the requirements described for `include_prefixes`. See [Requirements](https://cloud.google.com/storage-transfer/docs/reference/rest/v1/TransferSpec#ObjectConditions).
        /// </summary>
        public InputList<string> ExcludePrefixes
        {
            get => _excludePrefixes ?? (_excludePrefixes = new InputList<string>());
            set => _excludePrefixes = value;
        }

        [Input("includePrefixes")]
        private InputList<string>? _includePrefixes;

        /// <summary>
        /// If `include_refixes` is specified, objects that satisfy the object conditions must have names that start with one of the `include_prefixes` and that do not start with any of the `exclude_prefixes`. If `include_prefixes` is not specified, all objects except those that have names starting with one of the `exclude_prefixes` must satisfy the object conditions. See [Requirements](https://cloud.google.com/storage-transfer/docs/reference/rest/v1/TransferSpec#ObjectConditions).
        /// </summary>
        public InputList<string> IncludePrefixes
        {
            get => _includePrefixes ?? (_includePrefixes = new InputList<string>());
            set => _includePrefixes = value;
        }

        /// <summary>
        /// A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".
        /// </summary>
        [Input("maxTimeElapsedSinceLastModification")]
        public Input<string>? MaxTimeElapsedSinceLastModification { get; set; }

        /// <summary>
        /// 
        /// A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s".
        /// </summary>
        [Input("minTimeElapsedSinceLastModification")]
        public Input<string>? MinTimeElapsedSinceLastModification { get; set; }

        public TransferJobTransferSpecObjectConditionsGetArgs()
        {
        }
    }
}
