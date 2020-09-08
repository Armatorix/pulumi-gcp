// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Patch deployments are configurations that individual patch jobs use to complete a patch.
 * These configurations include instance filter, package repository settings, and a schedule.
 *
 * To get more information about PatchDeployment, see:
 *
 * * [API documentation](https://cloud.google.com/compute/docs/osconfig/rest)
 * * How-to Guides
 *     * [Official Documentation](https://cloud.google.com/compute/docs/os-patch-management)
 *
 * ## Example Usage
 */
export class PatchDeployment extends pulumi.CustomResource {
    /**
     * Get an existing PatchDeployment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: PatchDeploymentState, opts?: pulumi.CustomResourceOptions): PatchDeployment {
        return new PatchDeployment(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'gcp:osconfig/patchDeployment:PatchDeployment';

    /**
     * Returns true if the given object is an instance of PatchDeployment.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is PatchDeployment {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PatchDeployment.__pulumiType;
    }

    /**
     * Time the patch deployment was created. Timestamp is in RFC3339 text format. A timestamp in RFC3339 UTC "Zulu" format,
     * accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".
     */
    public /*out*/ readonly createTime!: pulumi.Output<string>;
    /**
     * Description of the patch deployment. Length of the description is limited to 1024 characters.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * Duration of the patch. After the duration ends, the patch times out.
     * A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s"
     */
    public readonly duration!: pulumi.Output<string | undefined>;
    /**
     * VM instances to patch.
     * Structure is documented below.
     */
    public readonly instanceFilter!: pulumi.Output<outputs.osconfig.PatchDeploymentInstanceFilter>;
    /**
     * -
     * The time the last patch job ran successfully.
     * A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".
     */
    public /*out*/ readonly lastExecuteTime!: pulumi.Output<string>;
    /**
     * Unique name for the patch deployment resource in a project. The patch deployment name is in the form:
     * projects/{project_id}/patchDeployments/{patchDeploymentId}.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Schedule a one-time execution.
     * Structure is documented below.
     */
    public readonly oneTimeSchedule!: pulumi.Output<outputs.osconfig.PatchDeploymentOneTimeSchedule | undefined>;
    /**
     * Patch configuration that is applied.
     * Structure is documented below.
     */
    public readonly patchConfig!: pulumi.Output<outputs.osconfig.PatchDeploymentPatchConfig | undefined>;
    /**
     * A name for the patch deployment in the project. When creating a name the following rules apply:
     * * Must contain only lowercase letters, numbers, and hyphens.
     * * Must start with a letter.
     * * Must be between 1-63 characters.
     * * Must end with a number or a letter.
     * * Must be unique within the project.
     */
    public readonly patchDeploymentId!: pulumi.Output<string>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    public readonly project!: pulumi.Output<string>;
    /**
     * Schedule recurring executions.
     * Structure is documented below.
     */
    public readonly recurringSchedule!: pulumi.Output<outputs.osconfig.PatchDeploymentRecurringSchedule | undefined>;
    /**
     * Rollout strategy of the patch job.
     * Structure is documented below.
     */
    public readonly rollout!: pulumi.Output<outputs.osconfig.PatchDeploymentRollout | undefined>;
    /**
     * Time the patch deployment was last updated. Timestamp is in RFC3339 text format. A timestamp in RFC3339 UTC "Zulu"
     * format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".
     */
    public /*out*/ readonly updateTime!: pulumi.Output<string>;

    /**
     * Create a PatchDeployment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: PatchDeploymentArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: PatchDeploymentArgs | PatchDeploymentState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as PatchDeploymentState | undefined;
            inputs["createTime"] = state ? state.createTime : undefined;
            inputs["description"] = state ? state.description : undefined;
            inputs["duration"] = state ? state.duration : undefined;
            inputs["instanceFilter"] = state ? state.instanceFilter : undefined;
            inputs["lastExecuteTime"] = state ? state.lastExecuteTime : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["oneTimeSchedule"] = state ? state.oneTimeSchedule : undefined;
            inputs["patchConfig"] = state ? state.patchConfig : undefined;
            inputs["patchDeploymentId"] = state ? state.patchDeploymentId : undefined;
            inputs["project"] = state ? state.project : undefined;
            inputs["recurringSchedule"] = state ? state.recurringSchedule : undefined;
            inputs["rollout"] = state ? state.rollout : undefined;
            inputs["updateTime"] = state ? state.updateTime : undefined;
        } else {
            const args = argsOrState as PatchDeploymentArgs | undefined;
            if (!args || args.instanceFilter === undefined) {
                throw new Error("Missing required property 'instanceFilter'");
            }
            if (!args || args.patchDeploymentId === undefined) {
                throw new Error("Missing required property 'patchDeploymentId'");
            }
            inputs["description"] = args ? args.description : undefined;
            inputs["duration"] = args ? args.duration : undefined;
            inputs["instanceFilter"] = args ? args.instanceFilter : undefined;
            inputs["oneTimeSchedule"] = args ? args.oneTimeSchedule : undefined;
            inputs["patchConfig"] = args ? args.patchConfig : undefined;
            inputs["patchDeploymentId"] = args ? args.patchDeploymentId : undefined;
            inputs["project"] = args ? args.project : undefined;
            inputs["recurringSchedule"] = args ? args.recurringSchedule : undefined;
            inputs["rollout"] = args ? args.rollout : undefined;
            inputs["createTime"] = undefined /*out*/;
            inputs["lastExecuteTime"] = undefined /*out*/;
            inputs["name"] = undefined /*out*/;
            inputs["updateTime"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(PatchDeployment.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering PatchDeployment resources.
 */
export interface PatchDeploymentState {
    /**
     * Time the patch deployment was created. Timestamp is in RFC3339 text format. A timestamp in RFC3339 UTC "Zulu" format,
     * accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".
     */
    readonly createTime?: pulumi.Input<string>;
    /**
     * Description of the patch deployment. Length of the description is limited to 1024 characters.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Duration of the patch. After the duration ends, the patch times out.
     * A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s"
     */
    readonly duration?: pulumi.Input<string>;
    /**
     * VM instances to patch.
     * Structure is documented below.
     */
    readonly instanceFilter?: pulumi.Input<inputs.osconfig.PatchDeploymentInstanceFilter>;
    /**
     * -
     * The time the last patch job ran successfully.
     * A timestamp in RFC3339 UTC "Zulu" format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".
     */
    readonly lastExecuteTime?: pulumi.Input<string>;
    /**
     * Unique name for the patch deployment resource in a project. The patch deployment name is in the form:
     * projects/{project_id}/patchDeployments/{patchDeploymentId}.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Schedule a one-time execution.
     * Structure is documented below.
     */
    readonly oneTimeSchedule?: pulumi.Input<inputs.osconfig.PatchDeploymentOneTimeSchedule>;
    /**
     * Patch configuration that is applied.
     * Structure is documented below.
     */
    readonly patchConfig?: pulumi.Input<inputs.osconfig.PatchDeploymentPatchConfig>;
    /**
     * A name for the patch deployment in the project. When creating a name the following rules apply:
     * * Must contain only lowercase letters, numbers, and hyphens.
     * * Must start with a letter.
     * * Must be between 1-63 characters.
     * * Must end with a number or a letter.
     * * Must be unique within the project.
     */
    readonly patchDeploymentId?: pulumi.Input<string>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    readonly project?: pulumi.Input<string>;
    /**
     * Schedule recurring executions.
     * Structure is documented below.
     */
    readonly recurringSchedule?: pulumi.Input<inputs.osconfig.PatchDeploymentRecurringSchedule>;
    /**
     * Rollout strategy of the patch job.
     * Structure is documented below.
     */
    readonly rollout?: pulumi.Input<inputs.osconfig.PatchDeploymentRollout>;
    /**
     * Time the patch deployment was last updated. Timestamp is in RFC3339 text format. A timestamp in RFC3339 UTC "Zulu"
     * format, accurate to nanoseconds. Example: "2014-10-02T15:01:23.045123456Z".
     */
    readonly updateTime?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a PatchDeployment resource.
 */
export interface PatchDeploymentArgs {
    /**
     * Description of the patch deployment. Length of the description is limited to 1024 characters.
     */
    readonly description?: pulumi.Input<string>;
    /**
     * Duration of the patch. After the duration ends, the patch times out.
     * A duration in seconds with up to nine fractional digits, terminated by 's'. Example: "3.5s"
     */
    readonly duration?: pulumi.Input<string>;
    /**
     * VM instances to patch.
     * Structure is documented below.
     */
    readonly instanceFilter: pulumi.Input<inputs.osconfig.PatchDeploymentInstanceFilter>;
    /**
     * Schedule a one-time execution.
     * Structure is documented below.
     */
    readonly oneTimeSchedule?: pulumi.Input<inputs.osconfig.PatchDeploymentOneTimeSchedule>;
    /**
     * Patch configuration that is applied.
     * Structure is documented below.
     */
    readonly patchConfig?: pulumi.Input<inputs.osconfig.PatchDeploymentPatchConfig>;
    /**
     * A name for the patch deployment in the project. When creating a name the following rules apply:
     * * Must contain only lowercase letters, numbers, and hyphens.
     * * Must start with a letter.
     * * Must be between 1-63 characters.
     * * Must end with a number or a letter.
     * * Must be unique within the project.
     */
    readonly patchDeploymentId: pulumi.Input<string>;
    /**
     * The ID of the project in which the resource belongs.
     * If it is not provided, the provider project is used.
     */
    readonly project?: pulumi.Input<string>;
    /**
     * Schedule recurring executions.
     * Structure is documented below.
     */
    readonly recurringSchedule?: pulumi.Input<inputs.osconfig.PatchDeploymentRecurringSchedule>;
    /**
     * Rollout strategy of the patch job.
     * Structure is documented below.
     */
    readonly rollout?: pulumi.Input<inputs.osconfig.PatchDeploymentRollout>;
}
