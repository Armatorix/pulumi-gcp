// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Logging
{
    /// <summary>
    /// Logs-based metric can also be used to extract values from logs and create a a distribution
    /// of the values. The distribution records the statistics of the extracted values along with
    /// an optional histogram of the values as specified by the bucket options.
    /// 
    /// 
    /// To get more information about Metric, see:
    /// 
    /// * [API documentation](https://cloud.google.com/logging/docs/reference/v2/rest/v2/projects.metrics/create)
    /// * How-to Guides
    ///     * [Official Documentation](https://cloud.google.com/logging/docs/apis)
    /// </summary>
    public partial class Metric : Pulumi.CustomResource
    {
        /// <summary>
        /// The bucketOptions are required when the logs-based metric is using a DISTRIBUTION value type and it describes the bucket
        /// boundaries used to create a histogram of the extracted values.
        /// </summary>
        [Output("bucketOptions")]
        public Output<Outputs.MetricBucketOptions?> BucketOptions { get; private set; } = null!;

        /// <summary>
        /// A description of this metric, which is used in documentation. The maximum length of the description is 8000 characters.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// An advanced logs filter (https://cloud.google.com/logging/docs/view/advanced-filters) which is used to match log
        /// entries.
        /// </summary>
        [Output("filter")]
        public Output<string> Filter { get; private set; } = null!;

        /// <summary>
        /// A map from a label key string to an extractor expression which is used to extract data from a log entry field and assign
        /// as the label value. Each label key specified in the LabelDescriptor must have an associated extractor expression in this
        /// map. The syntax of the extractor expression is the same as for the valueExtractor field.
        /// </summary>
        [Output("labelExtractors")]
        public Output<ImmutableDictionary<string, string>?> LabelExtractors { get; private set; } = null!;

        /// <summary>
        /// The metric descriptor associated with the logs-based metric.
        /// </summary>
        [Output("metricDescriptor")]
        public Output<Outputs.MetricMetricDescriptor> MetricDescriptor { get; private set; } = null!;

        /// <summary>
        /// The client-assigned metric identifier. Examples - "error_count", "nginx/requests". Metric identifiers are limited to 100
        /// characters and can include only the following characters A-Z, a-z, 0-9, and the special characters _-.,+!*',()%/. The
        /// forward-slash character (/) denotes a hierarchy of name pieces, and it cannot be the first character of the name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Output("project")]
        public Output<string> Project { get; private set; } = null!;

        /// <summary>
        /// A valueExtractor is required when using a distribution logs-based metric to extract the values to record from a log
        /// entry. Two functions are supported for value extraction - EXTRACT(field) or REGEXP_EXTRACT(field, regex). The argument
        /// are 1. field - The name of the log entry field from which the value is to be extracted. 2. regex - A regular expression
        /// using the Google RE2 syntax (https://github.com/google/re2/wiki/Syntax) with a single capture group to extract data from
        /// the specified log entry field. The value of the field is converted to a string before applying the regex. It is an error
        /// to specify a regex that does not include exactly one capture group.
        /// </summary>
        [Output("valueExtractor")]
        public Output<string?> ValueExtractor { get; private set; } = null!;


        /// <summary>
        /// Create a Metric resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Metric(string name, MetricArgs args, CustomResourceOptions? options = null)
            : base("gcp:logging/metric:Metric", name, args ?? new MetricArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Metric(string name, Input<string> id, MetricState? state = null, CustomResourceOptions? options = null)
            : base("gcp:logging/metric:Metric", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Metric resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Metric Get(string name, Input<string> id, MetricState? state = null, CustomResourceOptions? options = null)
        {
            return new Metric(name, id, state, options);
        }
    }

    public sealed class MetricArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The bucketOptions are required when the logs-based metric is using a DISTRIBUTION value type and it describes the bucket
        /// boundaries used to create a histogram of the extracted values.
        /// </summary>
        [Input("bucketOptions")]
        public Input<Inputs.MetricBucketOptionsArgs>? BucketOptions { get; set; }

        /// <summary>
        /// A description of this metric, which is used in documentation. The maximum length of the description is 8000 characters.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// An advanced logs filter (https://cloud.google.com/logging/docs/view/advanced-filters) which is used to match log
        /// entries.
        /// </summary>
        [Input("filter", required: true)]
        public Input<string> Filter { get; set; } = null!;

        [Input("labelExtractors")]
        private InputMap<string>? _labelExtractors;

        /// <summary>
        /// A map from a label key string to an extractor expression which is used to extract data from a log entry field and assign
        /// as the label value. Each label key specified in the LabelDescriptor must have an associated extractor expression in this
        /// map. The syntax of the extractor expression is the same as for the valueExtractor field.
        /// </summary>
        public InputMap<string> LabelExtractors
        {
            get => _labelExtractors ?? (_labelExtractors = new InputMap<string>());
            set => _labelExtractors = value;
        }

        /// <summary>
        /// The metric descriptor associated with the logs-based metric.
        /// </summary>
        [Input("metricDescriptor", required: true)]
        public Input<Inputs.MetricMetricDescriptorArgs> MetricDescriptor { get; set; } = null!;

        /// <summary>
        /// The client-assigned metric identifier. Examples - "error_count", "nginx/requests". Metric identifiers are limited to 100
        /// characters and can include only the following characters A-Z, a-z, 0-9, and the special characters _-.,+!*',()%/. The
        /// forward-slash character (/) denotes a hierarchy of name pieces, and it cannot be the first character of the name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// A valueExtractor is required when using a distribution logs-based metric to extract the values to record from a log
        /// entry. Two functions are supported for value extraction - EXTRACT(field) or REGEXP_EXTRACT(field, regex). The argument
        /// are 1. field - The name of the log entry field from which the value is to be extracted. 2. regex - A regular expression
        /// using the Google RE2 syntax (https://github.com/google/re2/wiki/Syntax) with a single capture group to extract data from
        /// the specified log entry field. The value of the field is converted to a string before applying the regex. It is an error
        /// to specify a regex that does not include exactly one capture group.
        /// </summary>
        [Input("valueExtractor")]
        public Input<string>? ValueExtractor { get; set; }

        public MetricArgs()
        {
        }
    }

    public sealed class MetricState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The bucketOptions are required when the logs-based metric is using a DISTRIBUTION value type and it describes the bucket
        /// boundaries used to create a histogram of the extracted values.
        /// </summary>
        [Input("bucketOptions")]
        public Input<Inputs.MetricBucketOptionsGetArgs>? BucketOptions { get; set; }

        /// <summary>
        /// A description of this metric, which is used in documentation. The maximum length of the description is 8000 characters.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// An advanced logs filter (https://cloud.google.com/logging/docs/view/advanced-filters) which is used to match log
        /// entries.
        /// </summary>
        [Input("filter")]
        public Input<string>? Filter { get; set; }

        [Input("labelExtractors")]
        private InputMap<string>? _labelExtractors;

        /// <summary>
        /// A map from a label key string to an extractor expression which is used to extract data from a log entry field and assign
        /// as the label value. Each label key specified in the LabelDescriptor must have an associated extractor expression in this
        /// map. The syntax of the extractor expression is the same as for the valueExtractor field.
        /// </summary>
        public InputMap<string> LabelExtractors
        {
            get => _labelExtractors ?? (_labelExtractors = new InputMap<string>());
            set => _labelExtractors = value;
        }

        /// <summary>
        /// The metric descriptor associated with the logs-based metric.
        /// </summary>
        [Input("metricDescriptor")]
        public Input<Inputs.MetricMetricDescriptorGetArgs>? MetricDescriptor { get; set; }

        /// <summary>
        /// The client-assigned metric identifier. Examples - "error_count", "nginx/requests". Metric identifiers are limited to 100
        /// characters and can include only the following characters A-Z, a-z, 0-9, and the special characters _-.,+!*',()%/. The
        /// forward-slash character (/) denotes a hierarchy of name pieces, and it cannot be the first character of the name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        /// <summary>
        /// A valueExtractor is required when using a distribution logs-based metric to extract the values to record from a log
        /// entry. Two functions are supported for value extraction - EXTRACT(field) or REGEXP_EXTRACT(field, regex). The argument
        /// are 1. field - The name of the log entry field from which the value is to be extracted. 2. regex - A regular expression
        /// using the Google RE2 syntax (https://github.com/google/re2/wiki/Syntax) with a single capture group to extract data from
        /// the specified log entry field. The value of the field is converted to a string before applying the regex. It is an error
        /// to specify a regex that does not include exactly one capture group.
        /// </summary>
        [Input("valueExtractor")]
        public Input<string>? ValueExtractor { get; set; }

        public MetricState()
        {
        }
    }
}
