// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Organizations.Outputs
{

    [OutputType]
    public sealed class IamAuditConfigAuditLogConfig
    {
        /// <summary>
        /// Identities that do not cause logging for this type of permission.
        /// Each entry can have one of the following values:
        /// * **user:{emailid}**: An email address that represents a specific Google account. For example, alice@gmail.com or joe@example.com.
        /// * **serviceAccount:{emailid}**: An email address that represents a service account. For example, my-other-app@appspot.gserviceaccount.com.
        /// * **group:{emailid}**: An email address that represents a Google group. For example, admins@example.com.
        /// * **domain:{domain}**: A G Suite domain (primary, instead of alias) name that represents all the users of that domain. For example, google.com or example.com.
        /// </summary>
        public readonly ImmutableArray<string> ExemptedMembers;
        /// <summary>
        /// Permission type for which logging is to be configured.  Must be one of `DATA_READ`, `DATA_WRITE`, or `ADMIN_READ`.
        /// </summary>
        public readonly string LogType;

        [OutputConstructor]
        private IamAuditConfigAuditLogConfig(
            ImmutableArray<string> exemptedMembers,

            string logType)
        {
            ExemptedMembers = exemptedMembers;
            LogType = logType;
        }
    }
}
