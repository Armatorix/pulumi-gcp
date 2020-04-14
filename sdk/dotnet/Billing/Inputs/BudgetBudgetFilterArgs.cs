// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Billing.Inputs
{

    public sealed class BudgetBudgetFilterArgs : Pulumi.ResourceArgs
    {
        [Input("creditTypesTreatment")]
        public Input<string>? CreditTypesTreatment { get; set; }

        [Input("projects")]
        private InputList<string>? _projects;
        public InputList<string> Projects
        {
            get => _projects ?? (_projects = new InputList<string>());
            set => _projects = value;
        }

        [Input("services")]
        private InputList<string>? _services;
        public InputList<string> Services
        {
            get => _services ?? (_services = new InputList<string>());
            set => _services = value;
        }

        public BudgetBudgetFilterArgs()
        {
        }
    }
}
