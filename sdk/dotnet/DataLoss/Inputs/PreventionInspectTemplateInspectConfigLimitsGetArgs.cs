// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.DataLoss.Inputs
{

    public sealed class PreventionInspectTemplateInspectConfigLimitsGetArgs : Pulumi.ResourceArgs
    {
        [Input("maxFindingsPerInfoTypes")]
        private InputList<Inputs.PreventionInspectTemplateInspectConfigLimitsMaxFindingsPerInfoTypeGetArgs>? _maxFindingsPerInfoTypes;

        /// <summary>
        /// Configuration of findings limit given for specified infoTypes.
        /// Structure is documented below.
        /// </summary>
        public InputList<Inputs.PreventionInspectTemplateInspectConfigLimitsMaxFindingsPerInfoTypeGetArgs> MaxFindingsPerInfoTypes
        {
            get => _maxFindingsPerInfoTypes ?? (_maxFindingsPerInfoTypes = new InputList<Inputs.PreventionInspectTemplateInspectConfigLimitsMaxFindingsPerInfoTypeGetArgs>());
            set => _maxFindingsPerInfoTypes = value;
        }

        /// <summary>
        /// Max number of findings that will be returned for each item scanned. The maximum returned is 2000.
        /// </summary>
        [Input("maxFindingsPerItem", required: true)]
        public Input<int> MaxFindingsPerItem { get; set; } = null!;

        /// <summary>
        /// Max number of findings that will be returned per request/job. The maximum returned is 2000.
        /// </summary>
        [Input("maxFindingsPerRequest", required: true)]
        public Input<int> MaxFindingsPerRequest { get; set; } = null!;

        public PreventionInspectTemplateInspectConfigLimitsGetArgs()
        {
        }
    }
}
