// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Dataproc.Outputs
{

    [OutputType]
    public sealed class JobPysparkConfig
    {
        /// <summary>
        /// HCFS URIs of archives to be extracted in the working directory of .jar, .tar, .tar.gz, .tgz, and .zip.
        /// </summary>
        public readonly ImmutableArray<string> ArchiveUris;
        /// <summary>
        /// The arguments to pass to the driver. Do not include arguments, such as -libjars or -Dfoo=bar, that can be set as job properties, since a collision may occur that causes an incorrect job submission.
        /// </summary>
        public readonly ImmutableArray<string> Args;
        /// <summary>
        /// HCFS URIs of files to be copied to the working directory of Hadoop drivers and distributed tasks. Useful for naively parallel tasks.
        /// </summary>
        public readonly ImmutableArray<string> FileUris;
        /// <summary>
        /// HCFS URIs of jar files to be added to the Spark CLASSPATH.
        /// </summary>
        public readonly ImmutableArray<string> JarFileUris;
        public readonly Outputs.JobPysparkConfigLoggingConfig? LoggingConfig;
        public readonly string MainPythonFileUri;
        /// <summary>
        /// A mapping of property names to values, used to configure Spark SQL's SparkConf. Properties that conflict with values set by the Cloud Dataproc API may be overwritten.
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Properties;
        /// <summary>
        /// HCFS file URIs of Python files to pass to the PySpark framework. Supported file types: .py, .egg, and .zip.
        /// </summary>
        public readonly ImmutableArray<string> PythonFileUris;

        [OutputConstructor]
        private JobPysparkConfig(
            ImmutableArray<string> archiveUris,

            ImmutableArray<string> args,

            ImmutableArray<string> fileUris,

            ImmutableArray<string> jarFileUris,

            Outputs.JobPysparkConfigLoggingConfig? loggingConfig,

            string mainPythonFileUri,

            ImmutableDictionary<string, string>? properties,

            ImmutableArray<string> pythonFileUris)
        {
            ArchiveUris = archiveUris;
            Args = args;
            FileUris = fileUris;
            JarFileUris = jarFileUris;
            LoggingConfig = loggingConfig;
            MainPythonFileUri = mainPythonFileUri;
            Properties = properties;
            PythonFileUris = pythonFileUris;
        }
    }
}
