// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.CloudFunctions.Outputs
{

    [OutputType]
    public sealed class FunctionEventTriggerFailurePolicy
    {
        /// <summary>
        /// Whether the function should be retried on failure. Defaults to `false`.
        /// </summary>
        public readonly bool Retry;

        [OutputConstructor]
        private FunctionEventTriggerFailurePolicy(bool retry)
        {
            Retry = retry;
        }
    }
}