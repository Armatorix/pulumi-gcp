// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.CloudTasks.Inputs
{

    public sealed class QueueAppEngineRoutingOverrideGetArgs : Pulumi.ResourceArgs
    {
        [Input("host")]
        public Input<string>? Host { get; set; }

        [Input("instance")]
        public Input<string>? Instance { get; set; }

        [Input("service")]
        public Input<string>? Service { get; set; }

        [Input("version")]
        public Input<string>? Version { get; set; }

        public QueueAppEngineRoutingOverrideGetArgs()
        {
        }
    }
}
