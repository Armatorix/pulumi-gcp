// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package compute

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Represents an Autoscaler resource.
//
// Autoscalers allow you to automatically scale virtual machine instances in
// managed instance groups according to an autoscaling policy that you
// define.
//
//
// To get more information about Autoscaler, see:
//
// * [API documentation](https://cloud.google.com/compute/docs/reference/rest/v1/autoscalers)
// * How-to Guides
//     * [Autoscaling Groups of Instances](https://cloud.google.com/compute/docs/autoscaler/)
type Autoscaler struct {
	pulumi.CustomResourceState

	// The configuration parameters for the autoscaling algorithm. You can define one or more of the policies for an
	// autoscaler: cpuUtilization, customMetricUtilizations, and loadBalancingUtilization. If none of these are specified, the
	// default will be to autoscale based on cpuUtilization to 0.6 or 60%.
	AutoscalingPolicy AutoscalerAutoscalingPolicyOutput `pulumi:"autoscalingPolicy"`
	// Creation timestamp in RFC3339 text format.
	CreationTimestamp pulumi.StringOutput `pulumi:"creationTimestamp"`
	// An optional description of this resource.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Name of the resource. The name must be 1-63 characters long and match the regular expression
	// '[a-z]([-a-z0-9]*[a-z0-9])?' which means the first character must be a lowercase letter, and all following characters
	// must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
	Name pulumi.StringOutput `pulumi:"name"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project pulumi.StringOutput `pulumi:"project"`
	// The URI of the created resource.
	SelfLink pulumi.StringOutput `pulumi:"selfLink"`
	// URL of the managed instance group that this autoscaler will scale.
	Target pulumi.StringOutput `pulumi:"target"`
	// URL of the zone where the instance group resides.
	Zone pulumi.StringOutput `pulumi:"zone"`
}

// NewAutoscaler registers a new resource with the given unique name, arguments, and options.
func NewAutoscaler(ctx *pulumi.Context,
	name string, args *AutoscalerArgs, opts ...pulumi.ResourceOption) (*Autoscaler, error) {
	if args == nil || args.AutoscalingPolicy == nil {
		return nil, errors.New("missing required argument 'AutoscalingPolicy'")
	}
	if args == nil || args.Target == nil {
		return nil, errors.New("missing required argument 'Target'")
	}
	if args == nil {
		args = &AutoscalerArgs{}
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("gcp:compute/autoscalar:Autoscalar"),
		},
	})
	opts = append(opts, aliases)
	var resource Autoscaler
	err := ctx.RegisterResource("gcp:compute/autoscaler:Autoscaler", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetAutoscaler gets an existing Autoscaler resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAutoscaler(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *AutoscalerState, opts ...pulumi.ResourceOption) (*Autoscaler, error) {
	var resource Autoscaler
	err := ctx.ReadResource("gcp:compute/autoscaler:Autoscaler", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Autoscaler resources.
type autoscalerState struct {
	// The configuration parameters for the autoscaling algorithm. You can define one or more of the policies for an
	// autoscaler: cpuUtilization, customMetricUtilizations, and loadBalancingUtilization. If none of these are specified, the
	// default will be to autoscale based on cpuUtilization to 0.6 or 60%.
	AutoscalingPolicy *AutoscalerAutoscalingPolicy `pulumi:"autoscalingPolicy"`
	// Creation timestamp in RFC3339 text format.
	CreationTimestamp *string `pulumi:"creationTimestamp"`
	// An optional description of this resource.
	Description *string `pulumi:"description"`
	// Name of the resource. The name must be 1-63 characters long and match the regular expression
	// '[a-z]([-a-z0-9]*[a-z0-9])?' which means the first character must be a lowercase letter, and all following characters
	// must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
	Name *string `pulumi:"name"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project *string `pulumi:"project"`
	// The URI of the created resource.
	SelfLink *string `pulumi:"selfLink"`
	// URL of the managed instance group that this autoscaler will scale.
	Target *string `pulumi:"target"`
	// URL of the zone where the instance group resides.
	Zone *string `pulumi:"zone"`
}

type AutoscalerState struct {
	// The configuration parameters for the autoscaling algorithm. You can define one or more of the policies for an
	// autoscaler: cpuUtilization, customMetricUtilizations, and loadBalancingUtilization. If none of these are specified, the
	// default will be to autoscale based on cpuUtilization to 0.6 or 60%.
	AutoscalingPolicy AutoscalerAutoscalingPolicyPtrInput
	// Creation timestamp in RFC3339 text format.
	CreationTimestamp pulumi.StringPtrInput
	// An optional description of this resource.
	Description pulumi.StringPtrInput
	// Name of the resource. The name must be 1-63 characters long and match the regular expression
	// '[a-z]([-a-z0-9]*[a-z0-9])?' which means the first character must be a lowercase letter, and all following characters
	// must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
	Name pulumi.StringPtrInput
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project pulumi.StringPtrInput
	// The URI of the created resource.
	SelfLink pulumi.StringPtrInput
	// URL of the managed instance group that this autoscaler will scale.
	Target pulumi.StringPtrInput
	// URL of the zone where the instance group resides.
	Zone pulumi.StringPtrInput
}

func (AutoscalerState) ElementType() reflect.Type {
	return reflect.TypeOf((*autoscalerState)(nil)).Elem()
}

type autoscalerArgs struct {
	// The configuration parameters for the autoscaling algorithm. You can define one or more of the policies for an
	// autoscaler: cpuUtilization, customMetricUtilizations, and loadBalancingUtilization. If none of these are specified, the
	// default will be to autoscale based on cpuUtilization to 0.6 or 60%.
	AutoscalingPolicy AutoscalerAutoscalingPolicy `pulumi:"autoscalingPolicy"`
	// An optional description of this resource.
	Description *string `pulumi:"description"`
	// Name of the resource. The name must be 1-63 characters long and match the regular expression
	// '[a-z]([-a-z0-9]*[a-z0-9])?' which means the first character must be a lowercase letter, and all following characters
	// must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
	Name *string `pulumi:"name"`
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project *string `pulumi:"project"`
	// URL of the managed instance group that this autoscaler will scale.
	Target string `pulumi:"target"`
	// URL of the zone where the instance group resides.
	Zone *string `pulumi:"zone"`
}

// The set of arguments for constructing a Autoscaler resource.
type AutoscalerArgs struct {
	// The configuration parameters for the autoscaling algorithm. You can define one or more of the policies for an
	// autoscaler: cpuUtilization, customMetricUtilizations, and loadBalancingUtilization. If none of these are specified, the
	// default will be to autoscale based on cpuUtilization to 0.6 or 60%.
	AutoscalingPolicy AutoscalerAutoscalingPolicyInput
	// An optional description of this resource.
	Description pulumi.StringPtrInput
	// Name of the resource. The name must be 1-63 characters long and match the regular expression
	// '[a-z]([-a-z0-9]*[a-z0-9])?' which means the first character must be a lowercase letter, and all following characters
	// must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
	Name pulumi.StringPtrInput
	// The ID of the project in which the resource belongs.
	// If it is not provided, the provider project is used.
	Project pulumi.StringPtrInput
	// URL of the managed instance group that this autoscaler will scale.
	Target pulumi.StringInput
	// URL of the zone where the instance group resides.
	Zone pulumi.StringPtrInput
}

func (AutoscalerArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*autoscalerArgs)(nil)).Elem()
}
