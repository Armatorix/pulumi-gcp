// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class AutoscalerAutoscalingPolicyGetArgs : Pulumi.ResourceArgs
    {
        [Input("cooldownPeriod")]
        public Input<int>? CooldownPeriod { get; set; }

        [Input("cpuUtilization")]
        public Input<Inputs.AutoscalerAutoscalingPolicyCpuUtilizationGetArgs>? CpuUtilization { get; set; }

        [Input("loadBalancingUtilization")]
        public Input<Inputs.AutoscalerAutoscalingPolicyLoadBalancingUtilizationGetArgs>? LoadBalancingUtilization { get; set; }

        [Input("maxReplicas", required: true)]
        public Input<int> MaxReplicas { get; set; } = null!;

        [Input("metrics")]
        private InputList<Inputs.AutoscalerAutoscalingPolicyMetricGetArgs>? _metrics;
        public InputList<Inputs.AutoscalerAutoscalingPolicyMetricGetArgs> Metrics
        {
            get => _metrics ?? (_metrics = new InputList<Inputs.AutoscalerAutoscalingPolicyMetricGetArgs>());
            set => _metrics = value;
        }

        [Input("minReplicas", required: true)]
        public Input<int> MinReplicas { get; set; } = null!;

        public AutoscalerAutoscalingPolicyGetArgs()
        {
        }
    }
}
