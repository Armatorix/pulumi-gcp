// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.DataLoss.Inputs
{

    public sealed class PreventionJobTriggerInspectJobActionSaveFindingsGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Information on where to store output
        /// Structure is documented below.
        /// </summary>
        [Input("outputConfig", required: true)]
        public Input<Inputs.PreventionJobTriggerInspectJobActionSaveFindingsOutputConfigGetArgs> OutputConfig { get; set; } = null!;

        public PreventionJobTriggerInspectJobActionSaveFindingsGetArgs()
        {
        }
    }
}
