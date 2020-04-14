// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Monitoring.Outputs
{

    [OutputType]
    public sealed class UptimeCheckConfigMonitoredResource
    {
        public readonly ImmutableDictionary<string, string> Labels;
        public readonly string Type;

        [OutputConstructor]
        private UptimeCheckConfigMonitoredResource(
            ImmutableDictionary<string, string> labels,

            string type)
        {
            Labels = labels;
            Type = type;
        }
    }
}
