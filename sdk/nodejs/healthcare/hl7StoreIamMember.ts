// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * > **Warning:** These resources are in beta, and should be used with the terraform-provider-google-beta provider.
 * See [Provider Versions](https://terraform.io/docs/providers/google/provider_versions.html) for more details on beta resources.
 * 
 * Three different resources help you manage your IAM policy for Healthcare HL7v2 store. Each of these resources serves a different use case:
 * 
 * * `google_healthcare_hl7_v2_store_iam_policy`: Authoritative. Sets the IAM policy for the HL7v2 store and replaces any existing policy already attached.
 * * `google_healthcare_hl7_v2_store_iam_binding`: Authoritative for a given role. Updates the IAM policy to grant a role to a list of members. Other roles within the IAM policy for the HL7v2 store are preserved.
 * * `google_healthcare_hl7_v2_store_iam_member`: Non-authoritative. Updates the IAM policy to grant a role to a new member. Other members for the role for the HL7v2 store are preserved.
 * 
 * > **Note:** `google_healthcare_hl7_v2_store_iam_policy` **cannot** be used in conjunction with `google_healthcare_hl7_v2_store_iam_binding` and `google_healthcare_hl7_v2_store_iam_member` or they will fight over what your policy should be.
 * 
 * > **Note:** `google_healthcare_hl7_v2_store_iam_binding` resources **can be** used in conjunction with `google_healthcare_hl7_v2_store_iam_member` resources **only if** they do not grant privilege to the same role.
 * 
 * ## google\_healthcare\_hl7\_v2\_store\_iam\_policy
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as gcp from "@pulumi/gcp";
 * 
 * const admin = pulumi.output(gcp.organizations.getIAMPolicy({
 *     bindings: [{
 *         members: ["user:jane@example.com"],
 *         role: "roles/editor",
 *     }],
 * }));
 * const hl7V2Store = new gcp.healthcare.Hl7StoreIamPolicy("hl7_v2_store", {
 *     hl7V2StoreId: "your-hl7-v2-store-id",
 *     policyData: admin.policyData,
 * });
 * ```
 * 
 * ## google\_healthcare\_hl7\_v2\_store\_iam\_binding
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as gcp from "@pulumi/gcp";
 * 
 * const hl7V2Store = new gcp.healthcare.Hl7StoreIamBinding("hl7_v2_store", {
 *     hl7V2StoreId: "your-hl7-v2-store-id",
 *     members: ["user:jane@example.com"],
 *     role: "roles/editor",
 * });
 * ```
 * 
 * ## google\_healthcare\_hl7\_v2\_store\_iam\_member
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as gcp from "@pulumi/gcp";
 * 
 * const hl7V2Store = new gcp.healthcare.Hl7StoreIamMember("hl7_v2_store", {
 *     hl7V2StoreId: "your-hl7-v2-store-id",
 *     member: "user:jane@example.com",
 *     role: "roles/editor",
 * });
 * ```
 */
export class Hl7StoreIamMember extends pulumi.CustomResource {
    /**
     * Get an existing Hl7StoreIamMember resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: Hl7StoreIamMemberState, opts?: pulumi.CustomResourceOptions): Hl7StoreIamMember {
        return new Hl7StoreIamMember(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'gcp:healthcare/hl7StoreIamMember:Hl7StoreIamMember';

    /**
     * Returns true if the given object is an instance of Hl7StoreIamMember.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Hl7StoreIamMember {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Hl7StoreIamMember.__pulumiType;
    }

    /**
     * (Computed) The etag of the HL7v2 store's IAM policy.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * The HL7v2 store ID, in the form
     * `{project_id}/{location_name}/{dataset_name}/{hl7_v2_store_name}` or
     * `{location_name}/{dataset_name}/{hl7_v2_store_name}`. In the second form, the provider's
     * project setting will be used as a fallback.
     */
    public readonly hl7V2StoreId!: pulumi.Output<string>;
    public readonly member!: pulumi.Output<string>;
    /**
     * The role that should be applied. Only one
     * `google_healthcare_hl7_v2_store_iam_binding` can be used per role. Note that custom roles must be of the format
     * `[projects|organizations]/{parent-name}/roles/{role-name}`.
     */
    public readonly role!: pulumi.Output<string>;

    /**
     * Create a Hl7StoreIamMember resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: Hl7StoreIamMemberArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: Hl7StoreIamMemberArgs | Hl7StoreIamMemberState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as Hl7StoreIamMemberState | undefined;
            inputs["etag"] = state ? state.etag : undefined;
            inputs["hl7V2StoreId"] = state ? state.hl7V2StoreId : undefined;
            inputs["member"] = state ? state.member : undefined;
            inputs["role"] = state ? state.role : undefined;
        } else {
            const args = argsOrState as Hl7StoreIamMemberArgs | undefined;
            if (!args || args.hl7V2StoreId === undefined) {
                throw new Error("Missing required property 'hl7V2StoreId'");
            }
            if (!args || args.member === undefined) {
                throw new Error("Missing required property 'member'");
            }
            if (!args || args.role === undefined) {
                throw new Error("Missing required property 'role'");
            }
            inputs["hl7V2StoreId"] = args ? args.hl7V2StoreId : undefined;
            inputs["member"] = args ? args.member : undefined;
            inputs["role"] = args ? args.role : undefined;
            inputs["etag"] = undefined /*out*/;
        }
        super(Hl7StoreIamMember.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Hl7StoreIamMember resources.
 */
export interface Hl7StoreIamMemberState {
    /**
     * (Computed) The etag of the HL7v2 store's IAM policy.
     */
    readonly etag?: pulumi.Input<string>;
    /**
     * The HL7v2 store ID, in the form
     * `{project_id}/{location_name}/{dataset_name}/{hl7_v2_store_name}` or
     * `{location_name}/{dataset_name}/{hl7_v2_store_name}`. In the second form, the provider's
     * project setting will be used as a fallback.
     */
    readonly hl7V2StoreId?: pulumi.Input<string>;
    readonly member?: pulumi.Input<string>;
    /**
     * The role that should be applied. Only one
     * `google_healthcare_hl7_v2_store_iam_binding` can be used per role. Note that custom roles must be of the format
     * `[projects|organizations]/{parent-name}/roles/{role-name}`.
     */
    readonly role?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Hl7StoreIamMember resource.
 */
export interface Hl7StoreIamMemberArgs {
    /**
     * The HL7v2 store ID, in the form
     * `{project_id}/{location_name}/{dataset_name}/{hl7_v2_store_name}` or
     * `{location_name}/{dataset_name}/{hl7_v2_store_name}`. In the second form, the provider's
     * project setting will be used as a fallback.
     */
    readonly hl7V2StoreId: pulumi.Input<string>;
    readonly member: pulumi.Input<string>;
    /**
     * The role that should be applied. Only one
     * `google_healthcare_hl7_v2_store_iam_binding` can be used per role. Note that custom roles must be of the format
     * `[projects|organizations]/{parent-name}/roles/{role-name}`.
     */
    readonly role: pulumi.Input<string>;
}
