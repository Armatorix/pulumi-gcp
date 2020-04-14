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
    public sealed class InstanceBootDiskInitializeParams
    {
        /// <summary>
        /// The image from which to initialize this disk. This can be
        /// one of: the image's `self_link`, `projects/{project}/global/images/{image}`,
        /// `projects/{project}/global/images/family/{family}`, `global/images/{image}`,
        /// `global/images/family/{family}`, `family/{family}`, `{project}/{family}`,
        /// `{project}/{image}`, `{family}`, or `{image}`. If referred by family, the
        /// images names must include the family name. If they don't, use the
        /// [gcp.compute.Image data source](https://www.terraform.io/docs/providers/google/d/datasource_compute_image.html).
        /// For instance, the image `centos-6-v20180104` includes its family name `centos-6`.
        /// These images can be referred by family name here.
        /// </summary>
        public readonly string? Image;
        /// <summary>
        /// A map of key/value label pairs to assign to the instance.
        /// </summary>
        public readonly ImmutableDictionary<string, object>? Labels;
        /// <summary>
        /// The size of the image in gigabytes. If not specified, it
        /// will inherit the size of its base image.
        /// </summary>
        public readonly int? Size;
        /// <summary>
        /// The accelerator type resource to expose to this instance. E.g. `nvidia-tesla-k80`.
        /// </summary>
        public readonly string? Type;

        [OutputConstructor]
        private InstanceBootDiskInitializeParams(
            string? image,

            ImmutableDictionary<string, object>? labels,

            int? size,

            string? type)
        {
            Image = image;
            Labels = labels;
            Size = size;
            Type = type;
        }
    }
}
