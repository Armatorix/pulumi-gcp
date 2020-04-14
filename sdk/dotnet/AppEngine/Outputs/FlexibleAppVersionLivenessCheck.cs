// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.AppEngine.Outputs
{

    [OutputType]
    public sealed class FlexibleAppVersionLivenessCheck
    {
        public readonly string? CheckInterval;
        public readonly double? FailureThreshold;
        public readonly string? Host;
        public readonly string? InitialDelay;
        public readonly string Path;
        public readonly double? SuccessThreshold;
        public readonly string? Timeout;

        [OutputConstructor]
        private FlexibleAppVersionLivenessCheck(
            string? checkInterval,

            double? failureThreshold,

            string? host,

            string? initialDelay,

            string path,

            double? successThreshold,

            string? timeout)
        {
            CheckInterval = checkInterval;
            FailureThreshold = failureThreshold;
            Host = host;
            InitialDelay = initialDelay;
            Path = path;
            SuccessThreshold = successThreshold;
            Timeout = timeout;
        }
    }
}
