// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.DataLoss.Outputs
{

    [OutputType]
    public sealed class PreventionStoredInfoTypeLargeCustomDictionary
    {
        /// <summary>
        /// Field in a BigQuery table where each cell represents a dictionary phrase.
        /// Structure is documented below.
        /// </summary>
        public readonly Outputs.PreventionStoredInfoTypeLargeCustomDictionaryBigQueryField? BigQueryField;
        /// <summary>
        /// Set of files containing newline-delimited lists of dictionary phrases.
        /// Structure is documented below.
        /// </summary>
        public readonly Outputs.PreventionStoredInfoTypeLargeCustomDictionaryCloudStorageFileSet? CloudStorageFileSet;
        /// <summary>
        /// Location to store dictionary artifacts in Google Cloud Storage. These files will only be accessible by project owners and the DLP API.
        /// If any of these artifacts are modified, the dictionary is considered invalid and can no longer be used.
        /// Structure is documented below.
        /// </summary>
        public readonly Outputs.PreventionStoredInfoTypeLargeCustomDictionaryOutputPath OutputPath;

        [OutputConstructor]
        private PreventionStoredInfoTypeLargeCustomDictionary(
            Outputs.PreventionStoredInfoTypeLargeCustomDictionaryBigQueryField? bigQueryField,

            Outputs.PreventionStoredInfoTypeLargeCustomDictionaryCloudStorageFileSet? cloudStorageFileSet,

            Outputs.PreventionStoredInfoTypeLargeCustomDictionaryOutputPath outputPath)
        {
            BigQueryField = bigQueryField;
            CloudStorageFileSet = cloudStorageFileSet;
            OutputPath = outputPath;
        }
    }
}
