// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Healthcare
{
    /// <summary>
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/healthcare_dataset_iam_binding.html.markdown.
    /// </summary>
    public partial class DatasetIamBinding : Pulumi.CustomResource
    {
        [Output("condition")]
        public Output<Outputs.DatasetIamBindingCondition?> Condition { get; private set; } = null!;

        /// <summary>
        /// The dataset ID, in the form
        /// `{project_id}/{location_name}/{dataset_name}` or
        /// `{location_name}/{dataset_name}`. In the second form, the provider's
        /// project setting will be used as a fallback.
        /// </summary>
        [Output("datasetId")]
        public Output<string> DatasetId { get; private set; } = null!;

        /// <summary>
        /// (Computed) The etag of the dataset's IAM policy.
        /// </summary>
        [Output("etag")]
        public Output<string> Etag { get; private set; } = null!;

        [Output("members")]
        public Output<ImmutableArray<string>> Members { get; private set; } = null!;

        /// <summary>
        /// The role that should be applied. Only one
        /// `gcp.healthcare.DatasetIamBinding` can be used per role. Note that custom roles must be of the format
        /// `[projects|organizations]/{parent-name}/roles/{role-name}`.
        /// </summary>
        [Output("role")]
        public Output<string> Role { get; private set; } = null!;


        /// <summary>
        /// Create a DatasetIamBinding resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DatasetIamBinding(string name, DatasetIamBindingArgs args, CustomResourceOptions? options = null)
            : base("gcp:healthcare/datasetIamBinding:DatasetIamBinding", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private DatasetIamBinding(string name, Input<string> id, DatasetIamBindingState? state = null, CustomResourceOptions? options = null)
            : base("gcp:healthcare/datasetIamBinding:DatasetIamBinding", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing DatasetIamBinding resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DatasetIamBinding Get(string name, Input<string> id, DatasetIamBindingState? state = null, CustomResourceOptions? options = null)
        {
            return new DatasetIamBinding(name, id, state, options);
        }
    }

    public sealed class DatasetIamBindingArgs : Pulumi.ResourceArgs
    {
        [Input("condition")]
        public Input<Inputs.DatasetIamBindingConditionArgs>? Condition { get; set; }

        /// <summary>
        /// The dataset ID, in the form
        /// `{project_id}/{location_name}/{dataset_name}` or
        /// `{location_name}/{dataset_name}`. In the second form, the provider's
        /// project setting will be used as a fallback.
        /// </summary>
        [Input("datasetId", required: true)]
        public Input<string> DatasetId { get; set; } = null!;

        [Input("members", required: true)]
        private InputList<string>? _members;
        public InputList<string> Members
        {
            get => _members ?? (_members = new InputList<string>());
            set => _members = value;
        }

        /// <summary>
        /// The role that should be applied. Only one
        /// `gcp.healthcare.DatasetIamBinding` can be used per role. Note that custom roles must be of the format
        /// `[projects|organizations]/{parent-name}/roles/{role-name}`.
        /// </summary>
        [Input("role", required: true)]
        public Input<string> Role { get; set; } = null!;

        public DatasetIamBindingArgs()
        {
        }
    }

    public sealed class DatasetIamBindingState : Pulumi.ResourceArgs
    {
        [Input("condition")]
        public Input<Inputs.DatasetIamBindingConditionGetArgs>? Condition { get; set; }

        /// <summary>
        /// The dataset ID, in the form
        /// `{project_id}/{location_name}/{dataset_name}` or
        /// `{location_name}/{dataset_name}`. In the second form, the provider's
        /// project setting will be used as a fallback.
        /// </summary>
        [Input("datasetId")]
        public Input<string>? DatasetId { get; set; }

        /// <summary>
        /// (Computed) The etag of the dataset's IAM policy.
        /// </summary>
        [Input("etag")]
        public Input<string>? Etag { get; set; }

        [Input("members")]
        private InputList<string>? _members;
        public InputList<string> Members
        {
            get => _members ?? (_members = new InputList<string>());
            set => _members = value;
        }

        /// <summary>
        /// The role that should be applied. Only one
        /// `gcp.healthcare.DatasetIamBinding` can be used per role. Note that custom roles must be of the format
        /// `[projects|organizations]/{parent-name}/roles/{role-name}`.
        /// </summary>
        [Input("role")]
        public Input<string>? Role { get; set; }

        public DatasetIamBindingState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class DatasetIamBindingConditionArgs : Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("expression", required: true)]
        public Input<string> Expression { get; set; } = null!;

        [Input("title", required: true)]
        public Input<string> Title { get; set; } = null!;

        public DatasetIamBindingConditionArgs()
        {
        }
    }

    public sealed class DatasetIamBindingConditionGetArgs : Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("expression", required: true)]
        public Input<string> Expression { get; set; } = null!;

        [Input("title", required: true)]
        public Input<string> Title { get; set; } = null!;

        public DatasetIamBindingConditionGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class DatasetIamBindingCondition
    {
        public readonly string? Description;
        public readonly string Expression;
        public readonly string Title;

        [OutputConstructor]
        private DatasetIamBindingCondition(
            string? description,
            string expression,
            string title)
        {
            Description = description;
            Expression = expression;
            Title = title;
        }
    }
    }
}
