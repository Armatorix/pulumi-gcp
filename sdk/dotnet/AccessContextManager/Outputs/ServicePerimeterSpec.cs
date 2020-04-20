// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.AccessContextManager.Outputs
{

    [OutputType]
    public sealed class ServicePerimeterSpec
    {
        public readonly ImmutableArray<string> AccessLevels;
        public readonly ImmutableArray<string> Resources;
        public readonly ImmutableArray<string> RestrictedServices;
        public readonly Outputs.ServicePerimeterSpecVpcAccessibleServices? VpcAccessibleServices;

        [OutputConstructor]
        private ServicePerimeterSpec(
            ImmutableArray<string> accessLevels,

            ImmutableArray<string> resources,

            ImmutableArray<string> restrictedServices,

            Outputs.ServicePerimeterSpecVpcAccessibleServices? vpcAccessibleServices)
        {
            AccessLevels = accessLevels;
            Resources = resources;
            RestrictedServices = restrictedServices;
            VpcAccessibleServices = vpcAccessibleServices;
        }
    }
}