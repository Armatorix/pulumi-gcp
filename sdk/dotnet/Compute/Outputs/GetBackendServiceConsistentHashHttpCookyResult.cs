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
    public sealed class GetBackendServiceConsistentHashHttpCookyResult
    {
        /// <summary>
        /// The name of the Backend Service.
        /// </summary>
        public readonly string Name;
        public readonly string Path;
        public readonly ImmutableArray<Outputs.GetBackendServiceConsistentHashHttpCookyTtlResult> Ttls;

        [OutputConstructor]
        private GetBackendServiceConsistentHashHttpCookyResult(
            string name,

            string path,

            ImmutableArray<Outputs.GetBackendServiceConsistentHashHttpCookyTtlResult> ttls)
        {
            Name = name;
            Path = path;
            Ttls = ttls;
        }
    }
}
