// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Compute.Inputs
{

    public sealed class ReservationSpecificReservationInstancePropertiesGuestAcceleratorArgs : Pulumi.ResourceArgs
    {
        [Input("acceleratorCount", required: true)]
        public Input<int> AcceleratorCount { get; set; } = null!;

        [Input("acceleratorType", required: true)]
        public Input<string> AcceleratorType { get; set; } = null!;

        public ReservationSpecificReservationInstancePropertiesGuestAcceleratorArgs()
        {
        }
    }
}
