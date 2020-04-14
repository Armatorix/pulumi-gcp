// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute
{
    /// <summary>
    /// Manages a Target Pool within GCE. This is a collection of instances used as
    /// target of a network load balancer (Forwarding Rule). For more information see
    /// [the official
    /// documentation](https://cloud.google.com/compute/docs/load-balancing/network/target-pools)
    /// and [API](https://cloud.google.com/compute/docs/reference/latest/targetPools).
    /// </summary>
    public partial class TargetPool : Pulumi.CustomResource
    {
        /// <summary>
        /// URL to the backup target pool. Must also set
        /// failover\_ratio.
        /// </summary>
        [Output("backupPool")]
        public Output<string?> BackupPool { get; private set; } = null!;

        /// <summary>
        /// Textual description field.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Ratio (0 to 1) of failed nodes before using the
        /// backup pool (which must also be set).
        /// </summary>
        [Output("failoverRatio")]
        public Output<double?> FailoverRatio { get; private set; } = null!;

        /// <summary>
        /// List of zero or one health check name or self_link. Only
        /// legacy `gcp.compute.HttpHealthCheck` is supported.
        /// </summary>
        [Output("healthChecks")]
        public Output<string?> HealthChecks { get; private set; } = null!;

        /// <summary>
        /// List of instances in the pool. They can be given as
        /// URLs, or in the form of "zone/name". Note that the instances need not exist
        /// at the time of target pool creation, so there is no need to use the
        /// interpolation to create a dependency on the instances from the
        /// target pool.
        /// </summary>
        [Output("instances")]
        public Output<ImmutableArray<string>> Instances { get; private set; } = null!;

        /// <summary>
        /// A unique name for the resource, required by GCE. Changing
        /// this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The ID of the project in which the resource belongs. If it
        /// is not provided, the provider project is used.
        /// </summary>
        [Output("project")]
        public Output<string> Project { get; private set; } = null!;

        /// <summary>
        /// Where the target pool resides. Defaults to project
        /// region.
        /// </summary>
        [Output("region")]
        public Output<string> Region { get; private set; } = null!;

        /// <summary>
        /// The URI of the created resource.
        /// </summary>
        [Output("selfLink")]
        public Output<string> SelfLink { get; private set; } = null!;

        /// <summary>
        /// How to distribute load. Options are "NONE" (no
        /// affinity). "CLIENT\_IP" (hash of the source/dest addresses / ports), and
        /// "CLIENT\_IP\_PROTO" also includes the protocol (default "NONE").
        /// </summary>
        [Output("sessionAffinity")]
        public Output<string?> SessionAffinity { get; private set; } = null!;


        /// <summary>
        /// Create a TargetPool resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public TargetPool(string name, TargetPoolArgs? args = null, CustomResourceOptions? options = null)
            : base("gcp:compute/targetPool:TargetPool", name, args ?? new TargetPoolArgs(), MakeResourceOptions(options, ""))
        {
        }

        private TargetPool(string name, Input<string> id, TargetPoolState? state = null, CustomResourceOptions? options = null)
            : base("gcp:compute/targetPool:TargetPool", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing TargetPool resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static TargetPool Get(string name, Input<string> id, TargetPoolState? state = null, CustomResourceOptions? options = null)
        {
            return new TargetPool(name, id, state, options);
        }
    }

    public sealed class TargetPoolArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// URL to the backup target pool. Must also set
        /// failover\_ratio.
        /// </summary>
        [Input("backupPool")]
        public Input<string>? BackupPool { get; set; }

        /// <summary>
        /// Textual description field.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Ratio (0 to 1) of failed nodes before using the
        /// backup pool (which must also be set).
        /// </summary>
        [Input("failoverRatio")]
        public Input<double>? FailoverRatio { get; set; }

        /// <summary>
        /// List of zero or one health check name or self_link. Only
        /// legacy `gcp.compute.HttpHealthCheck` is supported.
        /// </summary>
        [Input("healthChecks")]
        public Input<string>? HealthChecks { get; set; }

        [Input("instances")]
        private InputList<string>? _instances;

        /// <summary>
        /// List of instances in the pool. They can be given as
        /// URLs, or in the form of "zone/name". Note that the instances need not exist
        /// at the time of target pool creation, so there is no need to use the
        /// interpolation to create a dependency on the instances from the
        /// target pool.
        /// </summary>
        public InputList<string> Instances
        {
            get => _instances ?? (_instances = new InputList<string>());
            set => _instances = value;
        }

        /// <summary>
        /// A unique name for the resource, required by GCE. Changing
        /// this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The ID of the project in which the resource belongs. If it
        /// is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// Where the target pool resides. Defaults to project
        /// region.
        /// </summary>
        [Input("region")]
        public Input<string>? Region { get; set; }

        /// <summary>
        /// How to distribute load. Options are "NONE" (no
        /// affinity). "CLIENT\_IP" (hash of the source/dest addresses / ports), and
        /// "CLIENT\_IP\_PROTO" also includes the protocol (default "NONE").
        /// </summary>
        [Input("sessionAffinity")]
        public Input<string>? SessionAffinity { get; set; }

        public TargetPoolArgs()
        {
        }
    }

    public sealed class TargetPoolState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// URL to the backup target pool. Must also set
        /// failover\_ratio.
        /// </summary>
        [Input("backupPool")]
        public Input<string>? BackupPool { get; set; }

        /// <summary>
        /// Textual description field.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Ratio (0 to 1) of failed nodes before using the
        /// backup pool (which must also be set).
        /// </summary>
        [Input("failoverRatio")]
        public Input<double>? FailoverRatio { get; set; }

        /// <summary>
        /// List of zero or one health check name or self_link. Only
        /// legacy `gcp.compute.HttpHealthCheck` is supported.
        /// </summary>
        [Input("healthChecks")]
        public Input<string>? HealthChecks { get; set; }

        [Input("instances")]
        private InputList<string>? _instances;

        /// <summary>
        /// List of instances in the pool. They can be given as
        /// URLs, or in the form of "zone/name". Note that the instances need not exist
        /// at the time of target pool creation, so there is no need to use the
        /// interpolation to create a dependency on the instances from the
        /// target pool.
        /// </summary>
        public InputList<string> Instances
        {
            get => _instances ?? (_instances = new InputList<string>());
            set => _instances = value;
        }

        /// <summary>
        /// A unique name for the resource, required by GCE. Changing
        /// this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The ID of the project in which the resource belongs. If it
        /// is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// Where the target pool resides. Defaults to project
        /// region.
        /// </summary>
        [Input("region")]
        public Input<string>? Region { get; set; }

        /// <summary>
        /// The URI of the created resource.
        /// </summary>
        [Input("selfLink")]
        public Input<string>? SelfLink { get; set; }

        /// <summary>
        /// How to distribute load. Options are "NONE" (no
        /// affinity). "CLIENT\_IP" (hash of the source/dest addresses / ports), and
        /// "CLIENT\_IP\_PROTO" also includes the protocol (default "NONE").
        /// </summary>
        [Input("sessionAffinity")]
        public Input<string>? SessionAffinity { get; set; }

        public TargetPoolState()
        {
        }
    }
}
