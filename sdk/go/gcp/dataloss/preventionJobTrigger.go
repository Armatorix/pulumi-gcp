// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package dataloss

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A job trigger configuration.
//
// To get more information about JobTrigger, see:
//
// * [API documentation](https://cloud.google.com/dlp/docs/reference/rest/v2/projects.jobTriggers)
// * How-to Guides
//     * [Official Documentation](https://cloud.google.com/dlp/docs/creating-job-triggers)
//
// ## Example Usage
type PreventionJobTrigger struct {
	pulumi.CustomResourceState

	// A description of the job trigger.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// User set display name of the job trigger.
	DisplayName pulumi.StringPtrOutput `pulumi:"displayName"`
	// Controls what and how to inspect for findings.
	// Structure is documented below.
	InspectJob PreventionJobTriggerInspectJobPtrOutput `pulumi:"inspectJob"`
	// The timestamp of the last time this trigger executed.
	LastRunTime pulumi.StringOutput `pulumi:"lastRunTime"`
	// The name of the Datastore kind.
	Name pulumi.StringOutput `pulumi:"name"`
	// The parent of the trigger, either in the format `projects/{{project}}`
	// or `projects/{{project}}/locations/{{location}}`
	Parent pulumi.StringOutput `pulumi:"parent"`
	// Whether the trigger is currently active.
	// Default value is `HEALTHY`.
	// Possible values are `PAUSED`, `HEALTHY`, and `CANCELLED`.
	Status pulumi.StringPtrOutput `pulumi:"status"`
	// What event needs to occur for a new job to be started.
	// Structure is documented below.
	Triggers PreventionJobTriggerTriggerArrayOutput `pulumi:"triggers"`
}

// NewPreventionJobTrigger registers a new resource with the given unique name, arguments, and options.
func NewPreventionJobTrigger(ctx *pulumi.Context,
	name string, args *PreventionJobTriggerArgs, opts ...pulumi.ResourceOption) (*PreventionJobTrigger, error) {
	if args == nil || args.Parent == nil {
		return nil, errors.New("missing required argument 'Parent'")
	}
	if args == nil || args.Triggers == nil {
		return nil, errors.New("missing required argument 'Triggers'")
	}
	if args == nil {
		args = &PreventionJobTriggerArgs{}
	}
	var resource PreventionJobTrigger
	err := ctx.RegisterResource("gcp:dataloss/preventionJobTrigger:PreventionJobTrigger", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetPreventionJobTrigger gets an existing PreventionJobTrigger resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetPreventionJobTrigger(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *PreventionJobTriggerState, opts ...pulumi.ResourceOption) (*PreventionJobTrigger, error) {
	var resource PreventionJobTrigger
	err := ctx.ReadResource("gcp:dataloss/preventionJobTrigger:PreventionJobTrigger", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering PreventionJobTrigger resources.
type preventionJobTriggerState struct {
	// A description of the job trigger.
	Description *string `pulumi:"description"`
	// User set display name of the job trigger.
	DisplayName *string `pulumi:"displayName"`
	// Controls what and how to inspect for findings.
	// Structure is documented below.
	InspectJob *PreventionJobTriggerInspectJob `pulumi:"inspectJob"`
	// The timestamp of the last time this trigger executed.
	LastRunTime *string `pulumi:"lastRunTime"`
	// The name of the Datastore kind.
	Name *string `pulumi:"name"`
	// The parent of the trigger, either in the format `projects/{{project}}`
	// or `projects/{{project}}/locations/{{location}}`
	Parent *string `pulumi:"parent"`
	// Whether the trigger is currently active.
	// Default value is `HEALTHY`.
	// Possible values are `PAUSED`, `HEALTHY`, and `CANCELLED`.
	Status *string `pulumi:"status"`
	// What event needs to occur for a new job to be started.
	// Structure is documented below.
	Triggers []PreventionJobTriggerTrigger `pulumi:"triggers"`
}

type PreventionJobTriggerState struct {
	// A description of the job trigger.
	Description pulumi.StringPtrInput
	// User set display name of the job trigger.
	DisplayName pulumi.StringPtrInput
	// Controls what and how to inspect for findings.
	// Structure is documented below.
	InspectJob PreventionJobTriggerInspectJobPtrInput
	// The timestamp of the last time this trigger executed.
	LastRunTime pulumi.StringPtrInput
	// The name of the Datastore kind.
	Name pulumi.StringPtrInput
	// The parent of the trigger, either in the format `projects/{{project}}`
	// or `projects/{{project}}/locations/{{location}}`
	Parent pulumi.StringPtrInput
	// Whether the trigger is currently active.
	// Default value is `HEALTHY`.
	// Possible values are `PAUSED`, `HEALTHY`, and `CANCELLED`.
	Status pulumi.StringPtrInput
	// What event needs to occur for a new job to be started.
	// Structure is documented below.
	Triggers PreventionJobTriggerTriggerArrayInput
}

func (PreventionJobTriggerState) ElementType() reflect.Type {
	return reflect.TypeOf((*preventionJobTriggerState)(nil)).Elem()
}

type preventionJobTriggerArgs struct {
	// A description of the job trigger.
	Description *string `pulumi:"description"`
	// User set display name of the job trigger.
	DisplayName *string `pulumi:"displayName"`
	// Controls what and how to inspect for findings.
	// Structure is documented below.
	InspectJob *PreventionJobTriggerInspectJob `pulumi:"inspectJob"`
	// The parent of the trigger, either in the format `projects/{{project}}`
	// or `projects/{{project}}/locations/{{location}}`
	Parent string `pulumi:"parent"`
	// Whether the trigger is currently active.
	// Default value is `HEALTHY`.
	// Possible values are `PAUSED`, `HEALTHY`, and `CANCELLED`.
	Status *string `pulumi:"status"`
	// What event needs to occur for a new job to be started.
	// Structure is documented below.
	Triggers []PreventionJobTriggerTrigger `pulumi:"triggers"`
}

// The set of arguments for constructing a PreventionJobTrigger resource.
type PreventionJobTriggerArgs struct {
	// A description of the job trigger.
	Description pulumi.StringPtrInput
	// User set display name of the job trigger.
	DisplayName pulumi.StringPtrInput
	// Controls what and how to inspect for findings.
	// Structure is documented below.
	InspectJob PreventionJobTriggerInspectJobPtrInput
	// The parent of the trigger, either in the format `projects/{{project}}`
	// or `projects/{{project}}/locations/{{location}}`
	Parent pulumi.StringInput
	// Whether the trigger is currently active.
	// Default value is `HEALTHY`.
	// Possible values are `PAUSED`, `HEALTHY`, and `CANCELLED`.
	Status pulumi.StringPtrInput
	// What event needs to occur for a new job to be started.
	// Structure is documented below.
	Triggers PreventionJobTriggerTriggerArrayInput
}

func (PreventionJobTriggerArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*preventionJobTriggerArgs)(nil)).Elem()
}
