// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Provides access to available Google Compute regions for a given project.
 * See more about [regions and regions](https://cloud.google.com/compute/docs/regions-zones/) in the upstream docs.
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/d/google_compute_regions.html.markdown.
 */
export function getRegions(args?: GetRegionsArgs, opts?: pulumi.InvokeOptions): Promise<GetRegionsResult> {
    args = args || {};
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("gcp:compute/getRegions:getRegions", {
        "project": args.project,
        "status": args.status,
    }, opts);
}

/**
 * A collection of arguments for invoking getRegions.
 */
export interface GetRegionsArgs {
    /**
     * Project from which to list available regions. Defaults to project declared in the provider.
     */
    readonly project?: string;
    /**
     * Allows to filter list of regions based on their current status. Status can be either `UP` or `DOWN`.
     * Defaults to no filtering (all available regions - both `UP` and `DOWN`).
     */
    readonly status?: string;
}

/**
 * A collection of values returned by getRegions.
 */
export interface GetRegionsResult {
    /**
     * A list of regions available in the given project
     */
    readonly names: string[];
    readonly project: string;
    readonly status?: string;
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
