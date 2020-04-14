// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Endpoints.Inputs
{

    public sealed class ServiceApiGetArgs : Pulumi.ResourceArgs
    {
        [Input("methods")]
        private InputList<Inputs.ServiceApiMethodGetArgs>? _methods;
        public InputList<Inputs.ServiceApiMethodGetArgs> Methods
        {
            get => _methods ?? (_methods = new InputList<Inputs.ServiceApiMethodGetArgs>());
            set => _methods = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("syntax")]
        public Input<string>? Syntax { get; set; }

        [Input("version")]
        public Input<string>? Version { get; set; }

        public ServiceApiGetArgs()
        {
        }
    }
}
