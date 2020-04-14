// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.DeploymentManager.Inputs
{

    public sealed class DeploymentTargetArgs : Pulumi.ResourceArgs
    {
        [Input("config", required: true)]
        public Input<Inputs.DeploymentTargetConfigArgs> Config { get; set; } = null!;

        [Input("imports")]
        private InputList<Inputs.DeploymentTargetImportArgs>? _imports;
        public InputList<Inputs.DeploymentTargetImportArgs> Imports
        {
            get => _imports ?? (_imports = new InputList<Inputs.DeploymentTargetImportArgs>());
            set => _imports = value;
        }

        public DeploymentTargetArgs()
        {
        }
    }
}
