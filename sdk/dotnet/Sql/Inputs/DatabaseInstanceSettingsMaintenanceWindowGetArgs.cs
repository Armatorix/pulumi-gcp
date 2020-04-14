// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Sql.Inputs
{

    public sealed class DatabaseInstanceSettingsMaintenanceWindowGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Day of week (`1-7`), starting on Monday
        /// </summary>
        [Input("day")]
        public Input<int>? Day { get; set; }

        /// <summary>
        /// Hour of day (`0-23`), ignored if `day` not set
        /// </summary>
        [Input("hour")]
        public Input<int>? Hour { get; set; }

        /// <summary>
        /// Receive updates earlier (`canary`) or later
        /// (`stable`)
        /// </summary>
        [Input("updateTrack")]
        public Input<string>? UpdateTrack { get; set; }

        public DatabaseInstanceSettingsMaintenanceWindowGetArgs()
        {
        }
    }
}
