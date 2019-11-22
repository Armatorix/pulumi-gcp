// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Organizations
{
    public static partial class Invokes
    {
        /// <summary>
        /// Get an active folder within GCP by `display_name` and `parent`.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/d/active_folder.html.markdown.
        /// </summary>
        public static Task<GetActiveFolderResult> GetActiveFolder(GetActiveFolderArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetActiveFolderResult>("gcp:organizations/getActiveFolder:getActiveFolder", args ?? ResourceArgs.Empty, options.WithVersion());
    }

    public sealed class GetActiveFolderArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The folder's display name.
        /// </summary>
        [Input("displayName", required: true)]
        public Input<string> DisplayName { get; set; } = null!;

        /// <summary>
        /// The resource name of the parent Folder or Organization.
        /// </summary>
        [Input("parent", required: true)]
        public Input<string> Parent { get; set; } = null!;

        public GetActiveFolderArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetActiveFolderResult
    {
        public readonly string DisplayName;
        /// <summary>
        /// The resource name of the Folder. This uniquely identifies the folder.
        /// </summary>
        public readonly string Name;
        public readonly string Parent;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetActiveFolderResult(
            string displayName,
            string name,
            string parent,
            string id)
        {
            DisplayName = displayName;
            Name = name;
            Parent = parent;
            Id = id;
        }
    }
}
