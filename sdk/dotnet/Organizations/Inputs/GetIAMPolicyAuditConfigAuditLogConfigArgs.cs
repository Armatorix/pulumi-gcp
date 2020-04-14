// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Organizations.Inputs
{

    public sealed class GetIAMPolicyAuditConfigAuditLogConfigArgs : Pulumi.InvokeArgs
    {
        [Input("exemptedMembers")]
        private List<string>? _exemptedMembers;

        /// <summary>
        /// Specifies the identities that are exempt from these types of logging operations. Follows the same format of the `members` array for `binding`.
        /// </summary>
        public List<string> ExemptedMembers
        {
            get => _exemptedMembers ?? (_exemptedMembers = new List<string>());
            set => _exemptedMembers = value;
        }

        /// <summary>
        /// Defines the logging level. `DATA_READ`, `DATA_WRITE` and `ADMIN_READ` capture different types of events. See [the audit configuration documentation](https://cloud.google.com/resource-manager/reference/rest/Shared.Types/AuditConfig) for more details.
        /// </summary>
        [Input("logType", required: true)]
        public string LogType { get; set; } = null!;

        public GetIAMPolicyAuditConfigAuditLogConfigArgs()
        {
        }
    }
}
