// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Sql.Outputs
{

    [OutputType]
    public sealed class DatabaseInstanceSettingsDatabaseFlag
    {
        /// <summary>
        /// A name for this whitelist entry.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// A CIDR notation IPv4 or IPv6 address that is allowed to
        /// access this instance. Must be set even if other two attributes are not for
        /// the whitelist to become active.
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private DatabaseInstanceSettingsDatabaseFlag(
            string name,

            string value)
        {
            Name = name;
            Value = value;
        }
    }
}
