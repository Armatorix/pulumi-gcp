// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Iap.Outputs
{

    [OutputType]
    public sealed class AppEngineServiceIamMemberCondition
    {
        /// <summary>
        /// An optional description of the expression. This is a longer text which describes the expression, e.g. when hovered over it in a UI.
        /// </summary>
        public readonly string? Description;
        /// <summary>
        /// Textual representation of an expression in Common Expression Language syntax.
        /// </summary>
        public readonly string Expression;
        /// <summary>
        /// A title for the expression, i.e. a short string describing its purpose.
        /// </summary>
        public readonly string Title;

        [OutputConstructor]
        private AppEngineServiceIamMemberCondition(
            string? description,

            string expression,

            string title)
        {
            Description = description;
            Expression = expression;
            Title = title;
        }
    }
}
