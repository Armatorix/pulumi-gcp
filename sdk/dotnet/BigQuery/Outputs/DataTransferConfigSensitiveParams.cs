// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.BigQuery.Outputs
{

    [OutputType]
    public sealed class DataTransferConfigSensitiveParams
    {
        /// <summary>
        /// The Secret Access Key of the AWS account transferring data from.
        /// **Note**: This property is sensitive and will not be displayed in the plan.
        /// </summary>
        public readonly string SecretAccessKey;

        [OutputConstructor]
        private DataTransferConfigSensitiveParams(string secretAccessKey)
        {
            SecretAccessKey = secretAccessKey;
        }
    }
}
