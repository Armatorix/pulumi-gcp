// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Outputs
{

    [OutputType]
    public sealed class BackendServiceOutlierDetectionBaseEjectionTime
    {
        public readonly int? Nanos;
        public readonly int Seconds;

        [OutputConstructor]
        private BackendServiceOutlierDetectionBaseEjectionTime(
            int? nanos,

            int seconds)
        {
            Nanos = nanos;
            Seconds = seconds;
        }
    }
}
