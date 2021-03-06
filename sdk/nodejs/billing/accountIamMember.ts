// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Allows creation and management of a single member for a single binding within
 * the IAM policy for an existing Google Cloud Platform Billing Account.
 *
 * > **Note:** This resource __must not__ be used in conjunction with
 *    `gcp.billing.AccountIamBinding` for the __same role__ or they will fight over
 *    what your policy should be.
 */
export class AccountIamMember extends pulumi.CustomResource {
    /**
     * Get an existing AccountIamMember resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AccountIamMemberState, opts?: pulumi.CustomResourceOptions): AccountIamMember {
        return new AccountIamMember(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'gcp:billing/accountIamMember:AccountIamMember';

    /**
     * Returns true if the given object is an instance of AccountIamMember.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AccountIamMember {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AccountIamMember.__pulumiType;
    }

    /**
     * The billing account id.
     */
    public readonly billingAccountId!: pulumi.Output<string>;
    public readonly condition!: pulumi.Output<outputs.billing.AccountIamMemberCondition | undefined>;
    /**
     * (Computed) The etag of the billing account's IAM policy.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * The user that the role should apply to. For more details on format and restrictions see https://cloud.google.com/billing/reference/rest/v1/Policy#Binding
     */
    public readonly member!: pulumi.Output<string>;
    /**
     * The role that should be applied.
     */
    public readonly role!: pulumi.Output<string>;

    /**
     * Create a AccountIamMember resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AccountIamMemberArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AccountIamMemberArgs | AccountIamMemberState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as AccountIamMemberState | undefined;
            inputs["billingAccountId"] = state ? state.billingAccountId : undefined;
            inputs["condition"] = state ? state.condition : undefined;
            inputs["etag"] = state ? state.etag : undefined;
            inputs["member"] = state ? state.member : undefined;
            inputs["role"] = state ? state.role : undefined;
        } else {
            const args = argsOrState as AccountIamMemberArgs | undefined;
            if (!args || args.billingAccountId === undefined) {
                throw new Error("Missing required property 'billingAccountId'");
            }
            if (!args || args.member === undefined) {
                throw new Error("Missing required property 'member'");
            }
            if (!args || args.role === undefined) {
                throw new Error("Missing required property 'role'");
            }
            inputs["billingAccountId"] = args ? args.billingAccountId : undefined;
            inputs["condition"] = args ? args.condition : undefined;
            inputs["member"] = args ? args.member : undefined;
            inputs["role"] = args ? args.role : undefined;
            inputs["etag"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(AccountIamMember.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering AccountIamMember resources.
 */
export interface AccountIamMemberState {
    /**
     * The billing account id.
     */
    readonly billingAccountId?: pulumi.Input<string>;
    readonly condition?: pulumi.Input<inputs.billing.AccountIamMemberCondition>;
    /**
     * (Computed) The etag of the billing account's IAM policy.
     */
    readonly etag?: pulumi.Input<string>;
    /**
     * The user that the role should apply to. For more details on format and restrictions see https://cloud.google.com/billing/reference/rest/v1/Policy#Binding
     */
    readonly member?: pulumi.Input<string>;
    /**
     * The role that should be applied.
     */
    readonly role?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a AccountIamMember resource.
 */
export interface AccountIamMemberArgs {
    /**
     * The billing account id.
     */
    readonly billingAccountId: pulumi.Input<string>;
    readonly condition?: pulumi.Input<inputs.billing.AccountIamMemberCondition>;
    /**
     * The user that the role should apply to. For more details on format and restrictions see https://cloud.google.com/billing/reference/rest/v1/Policy#Binding
     */
    readonly member: pulumi.Input<string>;
    /**
     * The role that should be applied.
     */
    readonly role: pulumi.Input<string>;
}
