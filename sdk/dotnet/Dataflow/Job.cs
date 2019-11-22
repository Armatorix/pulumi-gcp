// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Dataflow
{
    /// <summary>
    /// Creates a job on Dataflow, which is an implementation of Apache Beam running on Google Compute Engine. For more information see
    /// the official documentation for
    /// [Beam](https://beam.apache.org) and [Dataflow](https://cloud.google.com/dataflow/).
    /// 
    /// 
    /// ## Note on "destroy" / "apply"
    /// 
    /// There are many types of Dataflow jobs.  Some Dataflow jobs run constantly, getting new data from (e.g.) a GCS bucket, and outputting data continuously.  Some jobs process a set amount of data then terminate.  All jobs can fail while running due to programming errors or other issues.  In this way, Dataflow jobs are different from most other resources.
    /// 
    /// The Dataflow resource is considered 'existing' while it is in a nonterminal state.  If it reaches a terminal state (e.g. 'FAILED', 'COMPLETE', 'CANCELLED'), it will be recreated on the next 'apply'.  This is as expected for jobs which run continuously, but may surprise users who use this resource for other kinds of Dataflow jobs.
    /// 
    /// A Dataflow job which is 'destroyed' may be "cancelled" or "drained".  If "cancelled", the job terminates - any data written remains where it is, but no new data will be processed.  If "drained", no new data will enter the pipeline, but any data currently in the pipeline will finish being processed.  The default is "cancelled", but if a user sets `on_delete` to `"drain"` in the configuration, you may experience a long wait for your destroy to complete.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/dataflow_job.html.markdown.
    /// </summary>
    public partial class Job : Pulumi.CustomResource
    {
        /// <summary>
        /// The configuration for VM IPs.  Options are `"WORKER_IP_PUBLIC"` or `"WORKER_IP_PUBLIC"`.
        /// </summary>
        [Output("ipConfiguration")]
        public Output<string?> IpConfiguration { get; private set; } = null!;

        /// <summary>
        /// User labels to be specified for the job. Keys and values should follow the restrictions specified in the [labeling restrictions](https://cloud.google.com/compute/docs/labeling-resources#restrictions) page.
        /// </summary>
        [Output("labels")]
        public Output<ImmutableDictionary<string, object>?> Labels { get; private set; } = null!;

        /// <summary>
        /// The machine type to use for the job.
        /// </summary>
        [Output("machineType")]
        public Output<string?> MachineType { get; private set; } = null!;

        /// <summary>
        /// The number of workers permitted to work on the job.  More workers may improve processing speed at additional cost.
        /// </summary>
        [Output("maxWorkers")]
        public Output<int?> MaxWorkers { get; private set; } = null!;

        /// <summary>
        /// A unique name for the resource, required by Dataflow.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The network to which VMs will be assigned. If it is not provided, "default" will be used.
        /// </summary>
        [Output("network")]
        public Output<string?> Network { get; private set; } = null!;

        /// <summary>
        /// One of "drain" or "cancel".  Specifies behavior of deletion during a destroy.  See above note.
        /// </summary>
        [Output("onDelete")]
        public Output<string?> OnDelete { get; private set; } = null!;

        /// <summary>
        /// Key/Value pairs to be passed to the Dataflow job (as used in the template).
        /// </summary>
        [Output("parameters")]
        public Output<ImmutableDictionary<string, object>?> Parameters { get; private set; } = null!;

        /// <summary>
        /// The project in which the resource belongs. If it is not provided, the provider project is used.
        /// </summary>
        [Output("project")]
        public Output<string> Project { get; private set; } = null!;

        [Output("region")]
        public Output<string?> Region { get; private set; } = null!;

        /// <summary>
        /// The Service Account email used to create the job.
        /// </summary>
        [Output("serviceAccountEmail")]
        public Output<string?> ServiceAccountEmail { get; private set; } = null!;

        /// <summary>
        /// The current state of the resource, selected from the [JobState enum](https://cloud.google.com/dataflow/docs/reference/rest/v1b3/projects.jobs#Job.JobState)
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;

        /// <summary>
        /// The subnetwork to which VMs will be assigned. Should be of the form "regions/REGION/subnetworks/SUBNETWORK".
        /// </summary>
        [Output("subnetwork")]
        public Output<string?> Subnetwork { get; private set; } = null!;

        /// <summary>
        /// A writeable location on GCS for the Dataflow job to dump its temporary data.
        /// </summary>
        [Output("tempGcsLocation")]
        public Output<string> TempGcsLocation { get; private set; } = null!;

        /// <summary>
        /// The GCS path to the Dataflow job template.
        /// </summary>
        [Output("templateGcsPath")]
        public Output<string> TemplateGcsPath { get; private set; } = null!;

        /// <summary>
        /// The zone in which the created job should run. If it is not provided, the provider zone is used.
        /// </summary>
        [Output("zone")]
        public Output<string?> Zone { get; private set; } = null!;


        /// <summary>
        /// Create a Job resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Job(string name, JobArgs args, CustomResourceOptions? options = null)
            : base("gcp:dataflow/job:Job", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private Job(string name, Input<string> id, JobState? state = null, CustomResourceOptions? options = null)
            : base("gcp:dataflow/job:Job", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Job resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Job Get(string name, Input<string> id, JobState? state = null, CustomResourceOptions? options = null)
        {
            return new Job(name, id, state, options);
        }
    }

    public sealed class JobArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The configuration for VM IPs.  Options are `"WORKER_IP_PUBLIC"` or `"WORKER_IP_PUBLIC"`.
        /// </summary>
        [Input("ipConfiguration")]
        public Input<string>? IpConfiguration { get; set; }

        [Input("labels")]
        private InputMap<object>? _labels;

        /// <summary>
        /// User labels to be specified for the job. Keys and values should follow the restrictions specified in the [labeling restrictions](https://cloud.google.com/compute/docs/labeling-resources#restrictions) page.
        /// </summary>
        public InputMap<object> Labels
        {
            get => _labels ?? (_labels = new InputMap<object>());
            set => _labels = value;
        }

        /// <summary>
        /// The machine type to use for the job.
        /// </summary>
        [Input("machineType")]
        public Input<string>? MachineType { get; set; }

        /// <summary>
        /// The number of workers permitted to work on the job.  More workers may improve processing speed at additional cost.
        /// </summary>
        [Input("maxWorkers")]
        public Input<int>? MaxWorkers { get; set; }

        /// <summary>
        /// A unique name for the resource, required by Dataflow.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The network to which VMs will be assigned. If it is not provided, "default" will be used.
        /// </summary>
        [Input("network")]
        public Input<string>? Network { get; set; }

        /// <summary>
        /// One of "drain" or "cancel".  Specifies behavior of deletion during a destroy.  See above note.
        /// </summary>
        [Input("onDelete")]
        public Input<string>? OnDelete { get; set; }

        [Input("parameters")]
        private InputMap<object>? _parameters;

        /// <summary>
        /// Key/Value pairs to be passed to the Dataflow job (as used in the template).
        /// </summary>
        public InputMap<object> Parameters
        {
            get => _parameters ?? (_parameters = new InputMap<object>());
            set => _parameters = value;
        }

        /// <summary>
        /// The project in which the resource belongs. If it is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        [Input("region")]
        public Input<string>? Region { get; set; }

        /// <summary>
        /// The Service Account email used to create the job.
        /// </summary>
        [Input("serviceAccountEmail")]
        public Input<string>? ServiceAccountEmail { get; set; }

        /// <summary>
        /// The subnetwork to which VMs will be assigned. Should be of the form "regions/REGION/subnetworks/SUBNETWORK".
        /// </summary>
        [Input("subnetwork")]
        public Input<string>? Subnetwork { get; set; }

        /// <summary>
        /// A writeable location on GCS for the Dataflow job to dump its temporary data.
        /// </summary>
        [Input("tempGcsLocation", required: true)]
        public Input<string> TempGcsLocation { get; set; } = null!;

        /// <summary>
        /// The GCS path to the Dataflow job template.
        /// </summary>
        [Input("templateGcsPath", required: true)]
        public Input<string> TemplateGcsPath { get; set; } = null!;

        /// <summary>
        /// The zone in which the created job should run. If it is not provided, the provider zone is used.
        /// </summary>
        [Input("zone")]
        public Input<string>? Zone { get; set; }

        public JobArgs()
        {
        }
    }

    public sealed class JobState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The configuration for VM IPs.  Options are `"WORKER_IP_PUBLIC"` or `"WORKER_IP_PUBLIC"`.
        /// </summary>
        [Input("ipConfiguration")]
        public Input<string>? IpConfiguration { get; set; }

        [Input("labels")]
        private InputMap<object>? _labels;

        /// <summary>
        /// User labels to be specified for the job. Keys and values should follow the restrictions specified in the [labeling restrictions](https://cloud.google.com/compute/docs/labeling-resources#restrictions) page.
        /// </summary>
        public InputMap<object> Labels
        {
            get => _labels ?? (_labels = new InputMap<object>());
            set => _labels = value;
        }

        /// <summary>
        /// The machine type to use for the job.
        /// </summary>
        [Input("machineType")]
        public Input<string>? MachineType { get; set; }

        /// <summary>
        /// The number of workers permitted to work on the job.  More workers may improve processing speed at additional cost.
        /// </summary>
        [Input("maxWorkers")]
        public Input<int>? MaxWorkers { get; set; }

        /// <summary>
        /// A unique name for the resource, required by Dataflow.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The network to which VMs will be assigned. If it is not provided, "default" will be used.
        /// </summary>
        [Input("network")]
        public Input<string>? Network { get; set; }

        /// <summary>
        /// One of "drain" or "cancel".  Specifies behavior of deletion during a destroy.  See above note.
        /// </summary>
        [Input("onDelete")]
        public Input<string>? OnDelete { get; set; }

        [Input("parameters")]
        private InputMap<object>? _parameters;

        /// <summary>
        /// Key/Value pairs to be passed to the Dataflow job (as used in the template).
        /// </summary>
        public InputMap<object> Parameters
        {
            get => _parameters ?? (_parameters = new InputMap<object>());
            set => _parameters = value;
        }

        /// <summary>
        /// The project in which the resource belongs. If it is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        [Input("region")]
        public Input<string>? Region { get; set; }

        /// <summary>
        /// The Service Account email used to create the job.
        /// </summary>
        [Input("serviceAccountEmail")]
        public Input<string>? ServiceAccountEmail { get; set; }

        /// <summary>
        /// The current state of the resource, selected from the [JobState enum](https://cloud.google.com/dataflow/docs/reference/rest/v1b3/projects.jobs#Job.JobState)
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        /// <summary>
        /// The subnetwork to which VMs will be assigned. Should be of the form "regions/REGION/subnetworks/SUBNETWORK".
        /// </summary>
        [Input("subnetwork")]
        public Input<string>? Subnetwork { get; set; }

        /// <summary>
        /// A writeable location on GCS for the Dataflow job to dump its temporary data.
        /// </summary>
        [Input("tempGcsLocation")]
        public Input<string>? TempGcsLocation { get; set; }

        /// <summary>
        /// The GCS path to the Dataflow job template.
        /// </summary>
        [Input("templateGcsPath")]
        public Input<string>? TemplateGcsPath { get; set; }

        /// <summary>
        /// The zone in which the created job should run. If it is not provided, the provider zone is used.
        /// </summary>
        [Input("zone")]
        public Input<string>? Zone { get; set; }

        public JobState()
        {
        }
    }
}
