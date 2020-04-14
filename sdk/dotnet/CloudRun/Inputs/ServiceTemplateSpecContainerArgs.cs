// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.CloudRun.Inputs
{

    public sealed class ServiceTemplateSpecContainerArgs : Pulumi.ResourceArgs
    {
        [Input("args")]
        private InputList<string>? _args;
        public InputList<string> Args
        {
            get => _args ?? (_args = new InputList<string>());
            set => _args = value;
        }

        [Input("commands")]
        private InputList<string>? _commands;
        public InputList<string> Commands
        {
            get => _commands ?? (_commands = new InputList<string>());
            set => _commands = value;
        }

        [Input("envFroms")]
        private InputList<Inputs.ServiceTemplateSpecContainerEnvFromArgs>? _envFroms;
        [Obsolete(@"Not supported by Cloud Run fully managed")]
        public InputList<Inputs.ServiceTemplateSpecContainerEnvFromArgs> EnvFroms
        {
            get => _envFroms ?? (_envFroms = new InputList<Inputs.ServiceTemplateSpecContainerEnvFromArgs>());
            set => _envFroms = value;
        }

        [Input("envs")]
        private InputList<Inputs.ServiceTemplateSpecContainerEnvArgs>? _envs;
        public InputList<Inputs.ServiceTemplateSpecContainerEnvArgs> Envs
        {
            get => _envs ?? (_envs = new InputList<Inputs.ServiceTemplateSpecContainerEnvArgs>());
            set => _envs = value;
        }

        [Input("image", required: true)]
        public Input<string> Image { get; set; } = null!;

        [Input("resources")]
        public Input<Inputs.ServiceTemplateSpecContainerResourcesArgs>? Resources { get; set; }

        [Input("workingDir")]
        public Input<string>? WorkingDir { get; set; }

        public ServiceTemplateSpecContainerArgs()
        {
        }
    }
}
