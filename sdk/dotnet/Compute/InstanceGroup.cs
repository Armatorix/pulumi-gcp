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
    /// Creates a group of dissimilar Compute Engine virtual machine instances.
    /// For more information, see [the official documentation](https://cloud.google.com/compute/docs/instance-groups/#unmanaged_instance_groups)
    /// and [API](https://cloud.google.com/compute/docs/reference/latest/instanceGroups)
    /// </summary>
    public partial class InstanceGroup : Pulumi.CustomResource
    {
        /// <summary>
        /// An optional textual description of the instance
        /// group.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// List of instances in the group. They should be given
        /// as self_link URLs. When adding instances they must all be in the same
        /// network and zone as the instance group.
        /// </summary>
        [Output("instances")]
        public Output<ImmutableArray<string>> Instances { get; private set; } = null!;

        /// <summary>
        /// The name which the port will be mapped to.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The named port configuration. See the section below
        /// for details on configuration.
        /// </summary>
        [Output("namedPorts")]
        public Output<ImmutableArray<Outputs.InstanceGroupNamedPort>> NamedPorts { get; private set; } = null!;

        /// <summary>
        /// The URL of the network the instance group is in. If
        /// this is different from the network where the instances are in, the creation
        /// fails. Defaults to the network where the instances are in (if neither
        /// `network` nor `instances` is specified, this field will be blank).
        /// </summary>
        [Output("network")]
        public Output<string> Network { get; private set; } = null!;

        /// <summary>
        /// The ID of the project in which the resource belongs. If it
        /// is not provided, the provider project is used.
        /// </summary>
        [Output("project")]
        public Output<string> Project { get; private set; } = null!;

        /// <summary>
        /// The URI of the created resource.
        /// </summary>
        [Output("selfLink")]
        public Output<string> SelfLink { get; private set; } = null!;

        /// <summary>
        /// The number of instances in the group.
        /// </summary>
        [Output("size")]
        public Output<int> Size { get; private set; } = null!;

        /// <summary>
        /// The zone that this instance group should be created in.
        /// </summary>
        [Output("zone")]
        public Output<string> Zone { get; private set; } = null!;


        /// <summary>
        /// Create a InstanceGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public InstanceGroup(string name, InstanceGroupArgs? args = null, CustomResourceOptions? options = null)
            : base("gcp:compute/instanceGroup:InstanceGroup", name, args ?? new InstanceGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private InstanceGroup(string name, Input<string> id, InstanceGroupState? state = null, CustomResourceOptions? options = null)
            : base("gcp:compute/instanceGroup:InstanceGroup", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing InstanceGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static InstanceGroup Get(string name, Input<string> id, InstanceGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new InstanceGroup(name, id, state, options);
        }
    }

    public sealed class InstanceGroupArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// An optional textual description of the instance
        /// group.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("instances")]
        private InputList<string>? _instances;

        /// <summary>
        /// List of instances in the group. They should be given
        /// as self_link URLs. When adding instances they must all be in the same
        /// network and zone as the instance group.
        /// </summary>
        public InputList<string> Instances
        {
            get => _instances ?? (_instances = new InputList<string>());
            set => _instances = value;
        }

        /// <summary>
        /// The name which the port will be mapped to.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("namedPorts")]
        private InputList<Inputs.InstanceGroupNamedPortArgs>? _namedPorts;

        /// <summary>
        /// The named port configuration. See the section below
        /// for details on configuration.
        /// </summary>
        public InputList<Inputs.InstanceGroupNamedPortArgs> NamedPorts
        {
            get => _namedPorts ?? (_namedPorts = new InputList<Inputs.InstanceGroupNamedPortArgs>());
            set => _namedPorts = value;
        }

        /// <summary>
        /// The URL of the network the instance group is in. If
        /// this is different from the network where the instances are in, the creation
        /// fails. Defaults to the network where the instances are in (if neither
        /// `network` nor `instances` is specified, this field will be blank).
        /// </summary>
        [Input("network")]
        public Input<string>? Network { get; set; }

        /// <summary>
        /// The ID of the project in which the resource belongs. If it
        /// is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// The zone that this instance group should be created in.
        /// </summary>
        [Input("zone")]
        public Input<string>? Zone { get; set; }

        public InstanceGroupArgs()
        {
        }
    }

    public sealed class InstanceGroupState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// An optional textual description of the instance
        /// group.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("instances")]
        private InputList<string>? _instances;

        /// <summary>
        /// List of instances in the group. They should be given
        /// as self_link URLs. When adding instances they must all be in the same
        /// network and zone as the instance group.
        /// </summary>
        public InputList<string> Instances
        {
            get => _instances ?? (_instances = new InputList<string>());
            set => _instances = value;
        }

        /// <summary>
        /// The name which the port will be mapped to.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("namedPorts")]
        private InputList<Inputs.InstanceGroupNamedPortGetArgs>? _namedPorts;

        /// <summary>
        /// The named port configuration. See the section below
        /// for details on configuration.
        /// </summary>
        public InputList<Inputs.InstanceGroupNamedPortGetArgs> NamedPorts
        {
            get => _namedPorts ?? (_namedPorts = new InputList<Inputs.InstanceGroupNamedPortGetArgs>());
            set => _namedPorts = value;
        }

        /// <summary>
        /// The URL of the network the instance group is in. If
        /// this is different from the network where the instances are in, the creation
        /// fails. Defaults to the network where the instances are in (if neither
        /// `network` nor `instances` is specified, this field will be blank).
        /// </summary>
        [Input("network")]
        public Input<string>? Network { get; set; }

        /// <summary>
        /// The ID of the project in which the resource belongs. If it
        /// is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// The URI of the created resource.
        /// </summary>
        [Input("selfLink")]
        public Input<string>? SelfLink { get; set; }

        /// <summary>
        /// The number of instances in the group.
        /// </summary>
        [Input("size")]
        public Input<int>? Size { get; set; }

        /// <summary>
        /// The zone that this instance group should be created in.
        /// </summary>
        [Input("zone")]
        public Input<string>? Zone { get; set; }

        public InstanceGroupState()
        {
        }
    }
}
