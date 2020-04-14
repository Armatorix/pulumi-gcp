// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Dataproc.Inputs
{

    public sealed class JobPigConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Whether to continue executing queries if a query fails. The default value is false. Setting to true can be useful when executing independent parallel queries. Defaults to false.
        /// </summary>
        [Input("continueOnFailure")]
        public Input<bool>? ContinueOnFailure { get; set; }

        [Input("jarFileUris")]
        private InputList<string>? _jarFileUris;

        /// <summary>
        /// HCFS URIs of jar files to be added to the Spark CLASSPATH.
        /// </summary>
        public InputList<string> JarFileUris
        {
            get => _jarFileUris ?? (_jarFileUris = new InputList<string>());
            set => _jarFileUris = value;
        }

        [Input("loggingConfig")]
        public Input<Inputs.JobPigConfigLoggingConfigArgs>? LoggingConfig { get; set; }

        [Input("properties")]
        private InputMap<string>? _properties;

        /// <summary>
        /// A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Cloud Dataproc API may be overwritten.
        /// </summary>
        public InputMap<string> Properties
        {
            get => _properties ?? (_properties = new InputMap<string>());
            set => _properties = value;
        }

        /// <summary>
        /// The HCFS URI of the script that contains SQL queries.
        /// Conflicts with `query_list`
        /// </summary>
        [Input("queryFileUri")]
        public Input<string>? QueryFileUri { get; set; }

        [Input("queryLists")]
        private InputList<string>? _queryLists;
        public InputList<string> QueryLists
        {
            get => _queryLists ?? (_queryLists = new InputList<string>());
            set => _queryLists = value;
        }

        [Input("scriptVariables")]
        private InputMap<string>? _scriptVariables;

        /// <summary>
        /// Mapping of query variable names to values (equivalent to the Spark SQL command: `SET name="value";`).
        /// </summary>
        public InputMap<string> ScriptVariables
        {
            get => _scriptVariables ?? (_scriptVariables = new InputMap<string>());
            set => _scriptVariables = value;
        }

        public JobPigConfigArgs()
        {
        }
    }
}
