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
    public sealed class FlexibleAppVersionResourcesVolume
    {
        /// <summary>
        /// The identifier for this object. Format specified above.
        /// </summary>
        public readonly string Name;
        public readonly int SizeGb;
        public readonly string VolumeType;

        [OutputConstructor]
        private FlexibleAppVersionResourcesVolume(
            string name,

            int sizeGb,

            string volumeType)
        {
            Name = name;
            SizeGb = sizeGb;
            VolumeType = volumeType;
        }
    }
}
