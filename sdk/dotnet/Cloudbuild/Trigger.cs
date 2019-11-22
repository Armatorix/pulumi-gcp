// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Cloudbuild
{
    /// <summary>
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/cloudbuild_trigger.html.markdown.
    /// </summary>
    public partial class Trigger : Pulumi.CustomResource
    {
        /// <summary>
        /// Contents of the build template. Either a filename or build template must be provided.
        /// </summary>
        [Output("build")]
        public Output<Outputs.TriggerBuild?> Build { get; private set; } = null!;

        /// <summary>
        /// Time when the trigger was created.
        /// </summary>
        [Output("createTime")]
        public Output<string> CreateTime { get; private set; } = null!;

        /// <summary>
        /// Human-readable description of the trigger.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Whether the trigger is disabled or not. If true, the trigger will never result in a build.
        /// </summary>
        [Output("disabled")]
        public Output<bool?> Disabled { get; private set; } = null!;

        /// <summary>
        /// Path, from the source root, to a file whose contents is used for the template. Either a filename or build
        /// template must be provided.
        /// </summary>
        [Output("filename")]
        public Output<string?> Filename { get; private set; } = null!;

        /// <summary>
        /// Describes the configuration of a trigger that creates a build whenever a GitHub event is received.
        /// </summary>
        [Output("github")]
        public Output<Outputs.TriggerGithub?> Github { get; private set; } = null!;

        /// <summary>
        /// ignoredFiles and includedFiles are file glob matches using http://godoc/pkg/path/filepath#Match extended
        /// with support for '**'. If ignoredFiles and changed files are both empty, then they are not used to determine
        /// whether or not to trigger a build. If ignoredFiles is not empty, then we ignore any files that match any of
        /// the ignored_file globs. If the change has no files that are outside of the ignoredFiles globs, then we do
        /// not trigger a build.
        /// </summary>
        [Output("ignoredFiles")]
        public Output<ImmutableArray<string>> IgnoredFiles { get; private set; } = null!;

        /// <summary>
        /// ignoredFiles and includedFiles are file glob matches using http://godoc/pkg/path/filepath#Match extended
        /// with support for '**'. If any of the files altered in the commit pass the ignoredFiles filter and
        /// includedFiles is empty, then as far as this filter is concerned, we should trigger the build. If any of the
        /// files altered in the commit pass the ignoredFiles filter and includedFiles is not empty, then we make sure
        /// that at least one of those files matches a includedFiles glob. If not, then we do not trigger a build.
        /// </summary>
        [Output("includedFiles")]
        public Output<ImmutableArray<string>> IncludedFiles { get; private set; } = null!;

        /// <summary>
        /// Name of the trigger. Must be unique within the project.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Output("project")]
        public Output<string> Project { get; private set; } = null!;

        /// <summary>
        /// Substitutions data for Build resource.
        /// </summary>
        [Output("substitutions")]
        public Output<ImmutableDictionary<string, string>?> Substitutions { get; private set; } = null!;

        /// <summary>
        /// The unique identifier for the trigger.
        /// </summary>
        [Output("triggerId")]
        public Output<string> TriggerId { get; private set; } = null!;

        /// <summary>
        /// Template describing the types of source changes to trigger a build. Branch and tag names in trigger
        /// templates are interpreted as regular expressions. Any branch or tag change that matches that regular
        /// expression will trigger a build. This field is required, and will be validated as such in 3.0.0.
        /// </summary>
        [Output("triggerTemplate")]
        public Output<Outputs.TriggerTriggerTemplate?> TriggerTemplate { get; private set; } = null!;


        /// <summary>
        /// Create a Trigger resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Trigger(string name, TriggerArgs? args = null, CustomResourceOptions? options = null)
            : base("gcp:cloudbuild/trigger:Trigger", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private Trigger(string name, Input<string> id, TriggerState? state = null, CustomResourceOptions? options = null)
            : base("gcp:cloudbuild/trigger:Trigger", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Trigger resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Trigger Get(string name, Input<string> id, TriggerState? state = null, CustomResourceOptions? options = null)
        {
            return new Trigger(name, id, state, options);
        }
    }

    public sealed class TriggerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Contents of the build template. Either a filename or build template must be provided.
        /// </summary>
        [Input("build")]
        public Input<Inputs.TriggerBuildArgs>? Build { get; set; }

        /// <summary>
        /// Human-readable description of the trigger.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Whether the trigger is disabled or not. If true, the trigger will never result in a build.
        /// </summary>
        [Input("disabled")]
        public Input<bool>? Disabled { get; set; }

        /// <summary>
        /// Path, from the source root, to a file whose contents is used for the template. Either a filename or build
        /// template must be provided.
        /// </summary>
        [Input("filename")]
        public Input<string>? Filename { get; set; }

        /// <summary>
        /// Describes the configuration of a trigger that creates a build whenever a GitHub event is received.
        /// </summary>
        [Input("github")]
        public Input<Inputs.TriggerGithubArgs>? Github { get; set; }

        [Input("ignoredFiles")]
        private InputList<string>? _ignoredFiles;

        /// <summary>
        /// ignoredFiles and includedFiles are file glob matches using http://godoc/pkg/path/filepath#Match extended
        /// with support for '**'. If ignoredFiles and changed files are both empty, then they are not used to determine
        /// whether or not to trigger a build. If ignoredFiles is not empty, then we ignore any files that match any of
        /// the ignored_file globs. If the change has no files that are outside of the ignoredFiles globs, then we do
        /// not trigger a build.
        /// </summary>
        public InputList<string> IgnoredFiles
        {
            get => _ignoredFiles ?? (_ignoredFiles = new InputList<string>());
            set => _ignoredFiles = value;
        }

        [Input("includedFiles")]
        private InputList<string>? _includedFiles;

        /// <summary>
        /// ignoredFiles and includedFiles are file glob matches using http://godoc/pkg/path/filepath#Match extended
        /// with support for '**'. If any of the files altered in the commit pass the ignoredFiles filter and
        /// includedFiles is empty, then as far as this filter is concerned, we should trigger the build. If any of the
        /// files altered in the commit pass the ignoredFiles filter and includedFiles is not empty, then we make sure
        /// that at least one of those files matches a includedFiles glob. If not, then we do not trigger a build.
        /// </summary>
        public InputList<string> IncludedFiles
        {
            get => _includedFiles ?? (_includedFiles = new InputList<string>());
            set => _includedFiles = value;
        }

        /// <summary>
        /// Name of the trigger. Must be unique within the project.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        [Input("substitutions")]
        private InputMap<string>? _substitutions;

        /// <summary>
        /// Substitutions data for Build resource.
        /// </summary>
        public InputMap<string> Substitutions
        {
            get => _substitutions ?? (_substitutions = new InputMap<string>());
            set => _substitutions = value;
        }

        /// <summary>
        /// Template describing the types of source changes to trigger a build. Branch and tag names in trigger
        /// templates are interpreted as regular expressions. Any branch or tag change that matches that regular
        /// expression will trigger a build. This field is required, and will be validated as such in 3.0.0.
        /// </summary>
        [Input("triggerTemplate")]
        public Input<Inputs.TriggerTriggerTemplateArgs>? TriggerTemplate { get; set; }

        public TriggerArgs()
        {
        }
    }

    public sealed class TriggerState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Contents of the build template. Either a filename or build template must be provided.
        /// </summary>
        [Input("build")]
        public Input<Inputs.TriggerBuildGetArgs>? Build { get; set; }

        /// <summary>
        /// Time when the trigger was created.
        /// </summary>
        [Input("createTime")]
        public Input<string>? CreateTime { get; set; }

        /// <summary>
        /// Human-readable description of the trigger.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Whether the trigger is disabled or not. If true, the trigger will never result in a build.
        /// </summary>
        [Input("disabled")]
        public Input<bool>? Disabled { get; set; }

        /// <summary>
        /// Path, from the source root, to a file whose contents is used for the template. Either a filename or build
        /// template must be provided.
        /// </summary>
        [Input("filename")]
        public Input<string>? Filename { get; set; }

        /// <summary>
        /// Describes the configuration of a trigger that creates a build whenever a GitHub event is received.
        /// </summary>
        [Input("github")]
        public Input<Inputs.TriggerGithubGetArgs>? Github { get; set; }

        [Input("ignoredFiles")]
        private InputList<string>? _ignoredFiles;

        /// <summary>
        /// ignoredFiles and includedFiles are file glob matches using http://godoc/pkg/path/filepath#Match extended
        /// with support for '**'. If ignoredFiles and changed files are both empty, then they are not used to determine
        /// whether or not to trigger a build. If ignoredFiles is not empty, then we ignore any files that match any of
        /// the ignored_file globs. If the change has no files that are outside of the ignoredFiles globs, then we do
        /// not trigger a build.
        /// </summary>
        public InputList<string> IgnoredFiles
        {
            get => _ignoredFiles ?? (_ignoredFiles = new InputList<string>());
            set => _ignoredFiles = value;
        }

        [Input("includedFiles")]
        private InputList<string>? _includedFiles;

        /// <summary>
        /// ignoredFiles and includedFiles are file glob matches using http://godoc/pkg/path/filepath#Match extended
        /// with support for '**'. If any of the files altered in the commit pass the ignoredFiles filter and
        /// includedFiles is empty, then as far as this filter is concerned, we should trigger the build. If any of the
        /// files altered in the commit pass the ignoredFiles filter and includedFiles is not empty, then we make sure
        /// that at least one of those files matches a includedFiles glob. If not, then we do not trigger a build.
        /// </summary>
        public InputList<string> IncludedFiles
        {
            get => _includedFiles ?? (_includedFiles = new InputList<string>());
            set => _includedFiles = value;
        }

        /// <summary>
        /// Name of the trigger. Must be unique within the project.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The ID of the project in which the resource belongs.
        /// If it is not provided, the provider project is used.
        /// </summary>
        [Input("project")]
        public Input<string>? Project { get; set; }

        [Input("substitutions")]
        private InputMap<string>? _substitutions;

        /// <summary>
        /// Substitutions data for Build resource.
        /// </summary>
        public InputMap<string> Substitutions
        {
            get => _substitutions ?? (_substitutions = new InputMap<string>());
            set => _substitutions = value;
        }

        /// <summary>
        /// The unique identifier for the trigger.
        /// </summary>
        [Input("triggerId")]
        public Input<string>? TriggerId { get; set; }

        /// <summary>
        /// Template describing the types of source changes to trigger a build. Branch and tag names in trigger
        /// templates are interpreted as regular expressions. Any branch or tag change that matches that regular
        /// expression will trigger a build. This field is required, and will be validated as such in 3.0.0.
        /// </summary>
        [Input("triggerTemplate")]
        public Input<Inputs.TriggerTriggerTemplateGetArgs>? TriggerTemplate { get; set; }

        public TriggerState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class TriggerBuildArgs : Pulumi.ResourceArgs
    {
        [Input("images")]
        private InputList<string>? _images;
        public InputList<string> Images
        {
            get => _images ?? (_images = new InputList<string>());
            set => _images = value;
        }

        [Input("steps")]
        private InputList<TriggerBuildStepsArgs>? _steps;
        public InputList<TriggerBuildStepsArgs> Steps
        {
            get => _steps ?? (_steps = new InputList<TriggerBuildStepsArgs>());
            set => _steps = value;
        }

        [Input("tags")]
        private InputList<string>? _tags;
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        public TriggerBuildArgs()
        {
        }
    }

    public sealed class TriggerBuildGetArgs : Pulumi.ResourceArgs
    {
        [Input("images")]
        private InputList<string>? _images;
        public InputList<string> Images
        {
            get => _images ?? (_images = new InputList<string>());
            set => _images = value;
        }

        [Input("steps")]
        private InputList<TriggerBuildStepsGetArgs>? _steps;
        public InputList<TriggerBuildStepsGetArgs> Steps
        {
            get => _steps ?? (_steps = new InputList<TriggerBuildStepsGetArgs>());
            set => _steps = value;
        }

        [Input("tags")]
        private InputList<string>? _tags;
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        public TriggerBuildGetArgs()
        {
        }
    }

    public sealed class TriggerBuildStepsArgs : Pulumi.ResourceArgs
    {
        [Input("args")]
        private InputList<string>? _args;
        public InputList<string> Args
        {
            get => _args ?? (_args = new InputList<string>());
            set => _args = value;
        }

        [Input("dir")]
        public Input<string>? Dir { get; set; }

        [Input("entrypoint")]
        public Input<string>? Entrypoint { get; set; }

        [Input("envs")]
        private InputList<string>? _envs;
        public InputList<string> Envs
        {
            get => _envs ?? (_envs = new InputList<string>());
            set => _envs = value;
        }

        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("secretEnvs")]
        private InputList<string>? _secretEnvs;
        public InputList<string> SecretEnvs
        {
            get => _secretEnvs ?? (_secretEnvs = new InputList<string>());
            set => _secretEnvs = value;
        }

        [Input("timeout")]
        public Input<string>? Timeout { get; set; }

        [Input("timing")]
        public Input<string>? Timing { get; set; }

        [Input("volumes")]
        private InputList<TriggerBuildStepsVolumesArgs>? _volumes;
        public InputList<TriggerBuildStepsVolumesArgs> Volumes
        {
            get => _volumes ?? (_volumes = new InputList<TriggerBuildStepsVolumesArgs>());
            set => _volumes = value;
        }

        [Input("waitFors")]
        private InputList<string>? _waitFors;
        public InputList<string> WaitFors
        {
            get => _waitFors ?? (_waitFors = new InputList<string>());
            set => _waitFors = value;
        }

        public TriggerBuildStepsArgs()
        {
        }
    }

    public sealed class TriggerBuildStepsGetArgs : Pulumi.ResourceArgs
    {
        [Input("args")]
        private InputList<string>? _args;
        public InputList<string> Args
        {
            get => _args ?? (_args = new InputList<string>());
            set => _args = value;
        }

        [Input("dir")]
        public Input<string>? Dir { get; set; }

        [Input("entrypoint")]
        public Input<string>? Entrypoint { get; set; }

        [Input("envs")]
        private InputList<string>? _envs;
        public InputList<string> Envs
        {
            get => _envs ?? (_envs = new InputList<string>());
            set => _envs = value;
        }

        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("secretEnvs")]
        private InputList<string>? _secretEnvs;
        public InputList<string> SecretEnvs
        {
            get => _secretEnvs ?? (_secretEnvs = new InputList<string>());
            set => _secretEnvs = value;
        }

        [Input("timeout")]
        public Input<string>? Timeout { get; set; }

        [Input("timing")]
        public Input<string>? Timing { get; set; }

        [Input("volumes")]
        private InputList<TriggerBuildStepsVolumesGetArgs>? _volumes;
        public InputList<TriggerBuildStepsVolumesGetArgs> Volumes
        {
            get => _volumes ?? (_volumes = new InputList<TriggerBuildStepsVolumesGetArgs>());
            set => _volumes = value;
        }

        [Input("waitFors")]
        private InputList<string>? _waitFors;
        public InputList<string> WaitFors
        {
            get => _waitFors ?? (_waitFors = new InputList<string>());
            set => _waitFors = value;
        }

        public TriggerBuildStepsGetArgs()
        {
        }
    }

    public sealed class TriggerBuildStepsVolumesArgs : Pulumi.ResourceArgs
    {
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("path")]
        public Input<string>? Path { get; set; }

        public TriggerBuildStepsVolumesArgs()
        {
        }
    }

    public sealed class TriggerBuildStepsVolumesGetArgs : Pulumi.ResourceArgs
    {
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("path")]
        public Input<string>? Path { get; set; }

        public TriggerBuildStepsVolumesGetArgs()
        {
        }
    }

    public sealed class TriggerGithubArgs : Pulumi.ResourceArgs
    {
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("owner")]
        public Input<string>? Owner { get; set; }

        [Input("pullRequest")]
        public Input<TriggerGithubPullRequestArgs>? PullRequest { get; set; }

        [Input("push")]
        public Input<TriggerGithubPushArgs>? Push { get; set; }

        public TriggerGithubArgs()
        {
        }
    }

    public sealed class TriggerGithubGetArgs : Pulumi.ResourceArgs
    {
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("owner")]
        public Input<string>? Owner { get; set; }

        [Input("pullRequest")]
        public Input<TriggerGithubPullRequestGetArgs>? PullRequest { get; set; }

        [Input("push")]
        public Input<TriggerGithubPushGetArgs>? Push { get; set; }

        public TriggerGithubGetArgs()
        {
        }
    }

    public sealed class TriggerGithubPullRequestArgs : Pulumi.ResourceArgs
    {
        [Input("branch")]
        public Input<string>? Branch { get; set; }

        [Input("commentControl")]
        public Input<string>? CommentControl { get; set; }

        public TriggerGithubPullRequestArgs()
        {
        }
    }

    public sealed class TriggerGithubPullRequestGetArgs : Pulumi.ResourceArgs
    {
        [Input("branch")]
        public Input<string>? Branch { get; set; }

        [Input("commentControl")]
        public Input<string>? CommentControl { get; set; }

        public TriggerGithubPullRequestGetArgs()
        {
        }
    }

    public sealed class TriggerGithubPushArgs : Pulumi.ResourceArgs
    {
        [Input("branch")]
        public Input<string>? Branch { get; set; }

        [Input("tag")]
        public Input<string>? Tag { get; set; }

        public TriggerGithubPushArgs()
        {
        }
    }

    public sealed class TriggerGithubPushGetArgs : Pulumi.ResourceArgs
    {
        [Input("branch")]
        public Input<string>? Branch { get; set; }

        [Input("tag")]
        public Input<string>? Tag { get; set; }

        public TriggerGithubPushGetArgs()
        {
        }
    }

    public sealed class TriggerTriggerTemplateArgs : Pulumi.ResourceArgs
    {
        [Input("branchName")]
        public Input<string>? BranchName { get; set; }

        [Input("commitSha")]
        public Input<string>? CommitSha { get; set; }

        [Input("dir")]
        public Input<string>? Dir { get; set; }

        [Input("projectId")]
        public Input<string>? ProjectId { get; set; }

        [Input("repoName")]
        public Input<string>? RepoName { get; set; }

        [Input("tagName")]
        public Input<string>? TagName { get; set; }

        public TriggerTriggerTemplateArgs()
        {
        }
    }

    public sealed class TriggerTriggerTemplateGetArgs : Pulumi.ResourceArgs
    {
        [Input("branchName")]
        public Input<string>? BranchName { get; set; }

        [Input("commitSha")]
        public Input<string>? CommitSha { get; set; }

        [Input("dir")]
        public Input<string>? Dir { get; set; }

        [Input("projectId")]
        public Input<string>? ProjectId { get; set; }

        [Input("repoName")]
        public Input<string>? RepoName { get; set; }

        [Input("tagName")]
        public Input<string>? TagName { get; set; }

        public TriggerTriggerTemplateGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class TriggerBuild
    {
        public readonly ImmutableArray<string> Images;
        public readonly ImmutableArray<TriggerBuildSteps> Steps;
        public readonly ImmutableArray<string> Tags;

        [OutputConstructor]
        private TriggerBuild(
            ImmutableArray<string> images,
            ImmutableArray<TriggerBuildSteps> steps,
            ImmutableArray<string> tags)
        {
            Images = images;
            Steps = steps;
            Tags = tags;
        }
    }

    [OutputType]
    public sealed class TriggerBuildSteps
    {
        public readonly ImmutableArray<string> Args;
        public readonly string? Dir;
        public readonly string? Entrypoint;
        public readonly ImmutableArray<string> Envs;
        public readonly string? Id;
        public readonly string? Name;
        public readonly ImmutableArray<string> SecretEnvs;
        public readonly string? Timeout;
        public readonly string? Timing;
        public readonly ImmutableArray<TriggerBuildStepsVolumes> Volumes;
        public readonly ImmutableArray<string> WaitFors;

        [OutputConstructor]
        private TriggerBuildSteps(
            ImmutableArray<string> args,
            string? dir,
            string? entrypoint,
            ImmutableArray<string> envs,
            string? id,
            string? name,
            ImmutableArray<string> secretEnvs,
            string? timeout,
            string? timing,
            ImmutableArray<TriggerBuildStepsVolumes> volumes,
            ImmutableArray<string> waitFors)
        {
            Args = args;
            Dir = dir;
            Entrypoint = entrypoint;
            Envs = envs;
            Id = id;
            Name = name;
            SecretEnvs = secretEnvs;
            Timeout = timeout;
            Timing = timing;
            Volumes = volumes;
            WaitFors = waitFors;
        }
    }

    [OutputType]
    public sealed class TriggerBuildStepsVolumes
    {
        public readonly string? Name;
        public readonly string? Path;

        [OutputConstructor]
        private TriggerBuildStepsVolumes(
            string? name,
            string? path)
        {
            Name = name;
            Path = path;
        }
    }

    [OutputType]
    public sealed class TriggerGithub
    {
        public readonly string? Name;
        public readonly string? Owner;
        public readonly TriggerGithubPullRequest? PullRequest;
        public readonly TriggerGithubPush? Push;

        [OutputConstructor]
        private TriggerGithub(
            string? name,
            string? owner,
            TriggerGithubPullRequest? pullRequest,
            TriggerGithubPush? push)
        {
            Name = name;
            Owner = owner;
            PullRequest = pullRequest;
            Push = push;
        }
    }

    [OutputType]
    public sealed class TriggerGithubPullRequest
    {
        public readonly string? Branch;
        public readonly string? CommentControl;

        [OutputConstructor]
        private TriggerGithubPullRequest(
            string? branch,
            string? commentControl)
        {
            Branch = branch;
            CommentControl = commentControl;
        }
    }

    [OutputType]
    public sealed class TriggerGithubPush
    {
        public readonly string? Branch;
        public readonly string? Tag;

        [OutputConstructor]
        private TriggerGithubPush(
            string? branch,
            string? tag)
        {
            Branch = branch;
            Tag = tag;
        }
    }

    [OutputType]
    public sealed class TriggerTriggerTemplate
    {
        public readonly string? BranchName;
        public readonly string? CommitSha;
        public readonly string? Dir;
        public readonly string ProjectId;
        public readonly string? RepoName;
        public readonly string? TagName;

        [OutputConstructor]
        private TriggerTriggerTemplate(
            string? branchName,
            string? commitSha,
            string? dir,
            string projectId,
            string? repoName,
            string? tagName)
        {
            BranchName = branchName;
            CommitSha = commitSha;
            Dir = dir;
            ProjectId = projectId;
            RepoName = repoName;
            TagName = tagName;
        }
    }
    }
}
