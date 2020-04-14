// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package endpoints

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type ServiceApi struct {
	Methods []ServiceApiMethod `pulumi:"methods"`
	Name    *string            `pulumi:"name"`
	Syntax  *string            `pulumi:"syntax"`
	Version *string            `pulumi:"version"`
}

// ServiceApiInput is an input type that accepts ServiceApiArgs and ServiceApiOutput values.
// You can construct a concrete instance of `ServiceApiInput` via:
//
// 		 ServiceApiArgs{...}
//
type ServiceApiInput interface {
	pulumi.Input

	ToServiceApiOutput() ServiceApiOutput
	ToServiceApiOutputWithContext(context.Context) ServiceApiOutput
}

type ServiceApiArgs struct {
	Methods ServiceApiMethodArrayInput `pulumi:"methods"`
	Name    pulumi.StringPtrInput      `pulumi:"name"`
	Syntax  pulumi.StringPtrInput      `pulumi:"syntax"`
	Version pulumi.StringPtrInput      `pulumi:"version"`
}

func (ServiceApiArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ServiceApi)(nil)).Elem()
}

func (i ServiceApiArgs) ToServiceApiOutput() ServiceApiOutput {
	return i.ToServiceApiOutputWithContext(context.Background())
}

func (i ServiceApiArgs) ToServiceApiOutputWithContext(ctx context.Context) ServiceApiOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceApiOutput)
}

// ServiceApiArrayInput is an input type that accepts ServiceApiArray and ServiceApiArrayOutput values.
// You can construct a concrete instance of `ServiceApiArrayInput` via:
//
// 		 ServiceApiArray{ ServiceApiArgs{...} }
//
type ServiceApiArrayInput interface {
	pulumi.Input

	ToServiceApiArrayOutput() ServiceApiArrayOutput
	ToServiceApiArrayOutputWithContext(context.Context) ServiceApiArrayOutput
}

type ServiceApiArray []ServiceApiInput

func (ServiceApiArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ServiceApi)(nil)).Elem()
}

func (i ServiceApiArray) ToServiceApiArrayOutput() ServiceApiArrayOutput {
	return i.ToServiceApiArrayOutputWithContext(context.Background())
}

func (i ServiceApiArray) ToServiceApiArrayOutputWithContext(ctx context.Context) ServiceApiArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceApiArrayOutput)
}

type ServiceApiOutput struct{ *pulumi.OutputState }

func (ServiceApiOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ServiceApi)(nil)).Elem()
}

func (o ServiceApiOutput) ToServiceApiOutput() ServiceApiOutput {
	return o
}

func (o ServiceApiOutput) ToServiceApiOutputWithContext(ctx context.Context) ServiceApiOutput {
	return o
}

func (o ServiceApiOutput) Methods() ServiceApiMethodArrayOutput {
	return o.ApplyT(func(v ServiceApi) []ServiceApiMethod { return v.Methods }).(ServiceApiMethodArrayOutput)
}

func (o ServiceApiOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ServiceApi) *string { return v.Name }).(pulumi.StringPtrOutput)
}

func (o ServiceApiOutput) Syntax() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ServiceApi) *string { return v.Syntax }).(pulumi.StringPtrOutput)
}

func (o ServiceApiOutput) Version() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ServiceApi) *string { return v.Version }).(pulumi.StringPtrOutput)
}

type ServiceApiArrayOutput struct{ *pulumi.OutputState }

func (ServiceApiArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ServiceApi)(nil)).Elem()
}

func (o ServiceApiArrayOutput) ToServiceApiArrayOutput() ServiceApiArrayOutput {
	return o
}

func (o ServiceApiArrayOutput) ToServiceApiArrayOutputWithContext(ctx context.Context) ServiceApiArrayOutput {
	return o
}

func (o ServiceApiArrayOutput) Index(i pulumi.IntInput) ServiceApiOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) ServiceApi {
		return vs[0].([]ServiceApi)[vs[1].(int)]
	}).(ServiceApiOutput)
}

type ServiceApiMethod struct {
	Name         *string `pulumi:"name"`
	RequestType  *string `pulumi:"requestType"`
	ResponseType *string `pulumi:"responseType"`
	Syntax       *string `pulumi:"syntax"`
}

// ServiceApiMethodInput is an input type that accepts ServiceApiMethodArgs and ServiceApiMethodOutput values.
// You can construct a concrete instance of `ServiceApiMethodInput` via:
//
// 		 ServiceApiMethodArgs{...}
//
type ServiceApiMethodInput interface {
	pulumi.Input

	ToServiceApiMethodOutput() ServiceApiMethodOutput
	ToServiceApiMethodOutputWithContext(context.Context) ServiceApiMethodOutput
}

type ServiceApiMethodArgs struct {
	Name         pulumi.StringPtrInput `pulumi:"name"`
	RequestType  pulumi.StringPtrInput `pulumi:"requestType"`
	ResponseType pulumi.StringPtrInput `pulumi:"responseType"`
	Syntax       pulumi.StringPtrInput `pulumi:"syntax"`
}

func (ServiceApiMethodArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ServiceApiMethod)(nil)).Elem()
}

func (i ServiceApiMethodArgs) ToServiceApiMethodOutput() ServiceApiMethodOutput {
	return i.ToServiceApiMethodOutputWithContext(context.Background())
}

func (i ServiceApiMethodArgs) ToServiceApiMethodOutputWithContext(ctx context.Context) ServiceApiMethodOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceApiMethodOutput)
}

// ServiceApiMethodArrayInput is an input type that accepts ServiceApiMethodArray and ServiceApiMethodArrayOutput values.
// You can construct a concrete instance of `ServiceApiMethodArrayInput` via:
//
// 		 ServiceApiMethodArray{ ServiceApiMethodArgs{...} }
//
type ServiceApiMethodArrayInput interface {
	pulumi.Input

	ToServiceApiMethodArrayOutput() ServiceApiMethodArrayOutput
	ToServiceApiMethodArrayOutputWithContext(context.Context) ServiceApiMethodArrayOutput
}

type ServiceApiMethodArray []ServiceApiMethodInput

func (ServiceApiMethodArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ServiceApiMethod)(nil)).Elem()
}

func (i ServiceApiMethodArray) ToServiceApiMethodArrayOutput() ServiceApiMethodArrayOutput {
	return i.ToServiceApiMethodArrayOutputWithContext(context.Background())
}

func (i ServiceApiMethodArray) ToServiceApiMethodArrayOutputWithContext(ctx context.Context) ServiceApiMethodArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceApiMethodArrayOutput)
}

type ServiceApiMethodOutput struct{ *pulumi.OutputState }

func (ServiceApiMethodOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ServiceApiMethod)(nil)).Elem()
}

func (o ServiceApiMethodOutput) ToServiceApiMethodOutput() ServiceApiMethodOutput {
	return o
}

func (o ServiceApiMethodOutput) ToServiceApiMethodOutputWithContext(ctx context.Context) ServiceApiMethodOutput {
	return o
}

func (o ServiceApiMethodOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ServiceApiMethod) *string { return v.Name }).(pulumi.StringPtrOutput)
}

func (o ServiceApiMethodOutput) RequestType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ServiceApiMethod) *string { return v.RequestType }).(pulumi.StringPtrOutput)
}

func (o ServiceApiMethodOutput) ResponseType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ServiceApiMethod) *string { return v.ResponseType }).(pulumi.StringPtrOutput)
}

func (o ServiceApiMethodOutput) Syntax() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ServiceApiMethod) *string { return v.Syntax }).(pulumi.StringPtrOutput)
}

type ServiceApiMethodArrayOutput struct{ *pulumi.OutputState }

func (ServiceApiMethodArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ServiceApiMethod)(nil)).Elem()
}

func (o ServiceApiMethodArrayOutput) ToServiceApiMethodArrayOutput() ServiceApiMethodArrayOutput {
	return o
}

func (o ServiceApiMethodArrayOutput) ToServiceApiMethodArrayOutputWithContext(ctx context.Context) ServiceApiMethodArrayOutput {
	return o
}

func (o ServiceApiMethodArrayOutput) Index(i pulumi.IntInput) ServiceApiMethodOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) ServiceApiMethod {
		return vs[0].([]ServiceApiMethod)[vs[1].(int)]
	}).(ServiceApiMethodOutput)
}

type ServiceEndpoint struct {
	Address *string `pulumi:"address"`
	Name    *string `pulumi:"name"`
}

// ServiceEndpointInput is an input type that accepts ServiceEndpointArgs and ServiceEndpointOutput values.
// You can construct a concrete instance of `ServiceEndpointInput` via:
//
// 		 ServiceEndpointArgs{...}
//
type ServiceEndpointInput interface {
	pulumi.Input

	ToServiceEndpointOutput() ServiceEndpointOutput
	ToServiceEndpointOutputWithContext(context.Context) ServiceEndpointOutput
}

type ServiceEndpointArgs struct {
	Address pulumi.StringPtrInput `pulumi:"address"`
	Name    pulumi.StringPtrInput `pulumi:"name"`
}

func (ServiceEndpointArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ServiceEndpoint)(nil)).Elem()
}

func (i ServiceEndpointArgs) ToServiceEndpointOutput() ServiceEndpointOutput {
	return i.ToServiceEndpointOutputWithContext(context.Background())
}

func (i ServiceEndpointArgs) ToServiceEndpointOutputWithContext(ctx context.Context) ServiceEndpointOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceEndpointOutput)
}

// ServiceEndpointArrayInput is an input type that accepts ServiceEndpointArray and ServiceEndpointArrayOutput values.
// You can construct a concrete instance of `ServiceEndpointArrayInput` via:
//
// 		 ServiceEndpointArray{ ServiceEndpointArgs{...} }
//
type ServiceEndpointArrayInput interface {
	pulumi.Input

	ToServiceEndpointArrayOutput() ServiceEndpointArrayOutput
	ToServiceEndpointArrayOutputWithContext(context.Context) ServiceEndpointArrayOutput
}

type ServiceEndpointArray []ServiceEndpointInput

func (ServiceEndpointArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ServiceEndpoint)(nil)).Elem()
}

func (i ServiceEndpointArray) ToServiceEndpointArrayOutput() ServiceEndpointArrayOutput {
	return i.ToServiceEndpointArrayOutputWithContext(context.Background())
}

func (i ServiceEndpointArray) ToServiceEndpointArrayOutputWithContext(ctx context.Context) ServiceEndpointArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceEndpointArrayOutput)
}

type ServiceEndpointOutput struct{ *pulumi.OutputState }

func (ServiceEndpointOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ServiceEndpoint)(nil)).Elem()
}

func (o ServiceEndpointOutput) ToServiceEndpointOutput() ServiceEndpointOutput {
	return o
}

func (o ServiceEndpointOutput) ToServiceEndpointOutputWithContext(ctx context.Context) ServiceEndpointOutput {
	return o
}

func (o ServiceEndpointOutput) Address() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ServiceEndpoint) *string { return v.Address }).(pulumi.StringPtrOutput)
}

func (o ServiceEndpointOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ServiceEndpoint) *string { return v.Name }).(pulumi.StringPtrOutput)
}

type ServiceEndpointArrayOutput struct{ *pulumi.OutputState }

func (ServiceEndpointArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ServiceEndpoint)(nil)).Elem()
}

func (o ServiceEndpointArrayOutput) ToServiceEndpointArrayOutput() ServiceEndpointArrayOutput {
	return o
}

func (o ServiceEndpointArrayOutput) ToServiceEndpointArrayOutputWithContext(ctx context.Context) ServiceEndpointArrayOutput {
	return o
}

func (o ServiceEndpointArrayOutput) Index(i pulumi.IntInput) ServiceEndpointOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) ServiceEndpoint {
		return vs[0].([]ServiceEndpoint)[vs[1].(int)]
	}).(ServiceEndpointOutput)
}

type ServiceIamBindingCondition struct {
	Description *string `pulumi:"description"`
	Expression  string  `pulumi:"expression"`
	Title       string  `pulumi:"title"`
}

// ServiceIamBindingConditionInput is an input type that accepts ServiceIamBindingConditionArgs and ServiceIamBindingConditionOutput values.
// You can construct a concrete instance of `ServiceIamBindingConditionInput` via:
//
// 		 ServiceIamBindingConditionArgs{...}
//
type ServiceIamBindingConditionInput interface {
	pulumi.Input

	ToServiceIamBindingConditionOutput() ServiceIamBindingConditionOutput
	ToServiceIamBindingConditionOutputWithContext(context.Context) ServiceIamBindingConditionOutput
}

type ServiceIamBindingConditionArgs struct {
	Description pulumi.StringPtrInput `pulumi:"description"`
	Expression  pulumi.StringInput    `pulumi:"expression"`
	Title       pulumi.StringInput    `pulumi:"title"`
}

func (ServiceIamBindingConditionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ServiceIamBindingCondition)(nil)).Elem()
}

func (i ServiceIamBindingConditionArgs) ToServiceIamBindingConditionOutput() ServiceIamBindingConditionOutput {
	return i.ToServiceIamBindingConditionOutputWithContext(context.Background())
}

func (i ServiceIamBindingConditionArgs) ToServiceIamBindingConditionOutputWithContext(ctx context.Context) ServiceIamBindingConditionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceIamBindingConditionOutput)
}

func (i ServiceIamBindingConditionArgs) ToServiceIamBindingConditionPtrOutput() ServiceIamBindingConditionPtrOutput {
	return i.ToServiceIamBindingConditionPtrOutputWithContext(context.Background())
}

func (i ServiceIamBindingConditionArgs) ToServiceIamBindingConditionPtrOutputWithContext(ctx context.Context) ServiceIamBindingConditionPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceIamBindingConditionOutput).ToServiceIamBindingConditionPtrOutputWithContext(ctx)
}

// ServiceIamBindingConditionPtrInput is an input type that accepts ServiceIamBindingConditionArgs, ServiceIamBindingConditionPtr and ServiceIamBindingConditionPtrOutput values.
// You can construct a concrete instance of `ServiceIamBindingConditionPtrInput` via:
//
// 		 ServiceIamBindingConditionArgs{...}
//
//  or:
//
// 		 nil
//
type ServiceIamBindingConditionPtrInput interface {
	pulumi.Input

	ToServiceIamBindingConditionPtrOutput() ServiceIamBindingConditionPtrOutput
	ToServiceIamBindingConditionPtrOutputWithContext(context.Context) ServiceIamBindingConditionPtrOutput
}

type serviceIamBindingConditionPtrType ServiceIamBindingConditionArgs

func ServiceIamBindingConditionPtr(v *ServiceIamBindingConditionArgs) ServiceIamBindingConditionPtrInput {
	return (*serviceIamBindingConditionPtrType)(v)
}

func (*serviceIamBindingConditionPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**ServiceIamBindingCondition)(nil)).Elem()
}

func (i *serviceIamBindingConditionPtrType) ToServiceIamBindingConditionPtrOutput() ServiceIamBindingConditionPtrOutput {
	return i.ToServiceIamBindingConditionPtrOutputWithContext(context.Background())
}

func (i *serviceIamBindingConditionPtrType) ToServiceIamBindingConditionPtrOutputWithContext(ctx context.Context) ServiceIamBindingConditionPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceIamBindingConditionPtrOutput)
}

type ServiceIamBindingConditionOutput struct{ *pulumi.OutputState }

func (ServiceIamBindingConditionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ServiceIamBindingCondition)(nil)).Elem()
}

func (o ServiceIamBindingConditionOutput) ToServiceIamBindingConditionOutput() ServiceIamBindingConditionOutput {
	return o
}

func (o ServiceIamBindingConditionOutput) ToServiceIamBindingConditionOutputWithContext(ctx context.Context) ServiceIamBindingConditionOutput {
	return o
}

func (o ServiceIamBindingConditionOutput) ToServiceIamBindingConditionPtrOutput() ServiceIamBindingConditionPtrOutput {
	return o.ToServiceIamBindingConditionPtrOutputWithContext(context.Background())
}

func (o ServiceIamBindingConditionOutput) ToServiceIamBindingConditionPtrOutputWithContext(ctx context.Context) ServiceIamBindingConditionPtrOutput {
	return o.ApplyT(func(v ServiceIamBindingCondition) *ServiceIamBindingCondition {
		return &v
	}).(ServiceIamBindingConditionPtrOutput)
}
func (o ServiceIamBindingConditionOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ServiceIamBindingCondition) *string { return v.Description }).(pulumi.StringPtrOutput)
}

func (o ServiceIamBindingConditionOutput) Expression() pulumi.StringOutput {
	return o.ApplyT(func(v ServiceIamBindingCondition) string { return v.Expression }).(pulumi.StringOutput)
}

func (o ServiceIamBindingConditionOutput) Title() pulumi.StringOutput {
	return o.ApplyT(func(v ServiceIamBindingCondition) string { return v.Title }).(pulumi.StringOutput)
}

type ServiceIamBindingConditionPtrOutput struct{ *pulumi.OutputState }

func (ServiceIamBindingConditionPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ServiceIamBindingCondition)(nil)).Elem()
}

func (o ServiceIamBindingConditionPtrOutput) ToServiceIamBindingConditionPtrOutput() ServiceIamBindingConditionPtrOutput {
	return o
}

func (o ServiceIamBindingConditionPtrOutput) ToServiceIamBindingConditionPtrOutputWithContext(ctx context.Context) ServiceIamBindingConditionPtrOutput {
	return o
}

func (o ServiceIamBindingConditionPtrOutput) Elem() ServiceIamBindingConditionOutput {
	return o.ApplyT(func(v *ServiceIamBindingCondition) ServiceIamBindingCondition { return *v }).(ServiceIamBindingConditionOutput)
}

func (o ServiceIamBindingConditionPtrOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ServiceIamBindingCondition) *string { return v.Description }).(pulumi.StringPtrOutput)
}

func (o ServiceIamBindingConditionPtrOutput) Expression() pulumi.StringOutput {
	return o.ApplyT(func(v ServiceIamBindingCondition) string { return v.Expression }).(pulumi.StringOutput)
}

func (o ServiceIamBindingConditionPtrOutput) Title() pulumi.StringOutput {
	return o.ApplyT(func(v ServiceIamBindingCondition) string { return v.Title }).(pulumi.StringOutput)
}

type ServiceIamMemberCondition struct {
	Description *string `pulumi:"description"`
	Expression  string  `pulumi:"expression"`
	Title       string  `pulumi:"title"`
}

// ServiceIamMemberConditionInput is an input type that accepts ServiceIamMemberConditionArgs and ServiceIamMemberConditionOutput values.
// You can construct a concrete instance of `ServiceIamMemberConditionInput` via:
//
// 		 ServiceIamMemberConditionArgs{...}
//
type ServiceIamMemberConditionInput interface {
	pulumi.Input

	ToServiceIamMemberConditionOutput() ServiceIamMemberConditionOutput
	ToServiceIamMemberConditionOutputWithContext(context.Context) ServiceIamMemberConditionOutput
}

type ServiceIamMemberConditionArgs struct {
	Description pulumi.StringPtrInput `pulumi:"description"`
	Expression  pulumi.StringInput    `pulumi:"expression"`
	Title       pulumi.StringInput    `pulumi:"title"`
}

func (ServiceIamMemberConditionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ServiceIamMemberCondition)(nil)).Elem()
}

func (i ServiceIamMemberConditionArgs) ToServiceIamMemberConditionOutput() ServiceIamMemberConditionOutput {
	return i.ToServiceIamMemberConditionOutputWithContext(context.Background())
}

func (i ServiceIamMemberConditionArgs) ToServiceIamMemberConditionOutputWithContext(ctx context.Context) ServiceIamMemberConditionOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceIamMemberConditionOutput)
}

func (i ServiceIamMemberConditionArgs) ToServiceIamMemberConditionPtrOutput() ServiceIamMemberConditionPtrOutput {
	return i.ToServiceIamMemberConditionPtrOutputWithContext(context.Background())
}

func (i ServiceIamMemberConditionArgs) ToServiceIamMemberConditionPtrOutputWithContext(ctx context.Context) ServiceIamMemberConditionPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceIamMemberConditionOutput).ToServiceIamMemberConditionPtrOutputWithContext(ctx)
}

// ServiceIamMemberConditionPtrInput is an input type that accepts ServiceIamMemberConditionArgs, ServiceIamMemberConditionPtr and ServiceIamMemberConditionPtrOutput values.
// You can construct a concrete instance of `ServiceIamMemberConditionPtrInput` via:
//
// 		 ServiceIamMemberConditionArgs{...}
//
//  or:
//
// 		 nil
//
type ServiceIamMemberConditionPtrInput interface {
	pulumi.Input

	ToServiceIamMemberConditionPtrOutput() ServiceIamMemberConditionPtrOutput
	ToServiceIamMemberConditionPtrOutputWithContext(context.Context) ServiceIamMemberConditionPtrOutput
}

type serviceIamMemberConditionPtrType ServiceIamMemberConditionArgs

func ServiceIamMemberConditionPtr(v *ServiceIamMemberConditionArgs) ServiceIamMemberConditionPtrInput {
	return (*serviceIamMemberConditionPtrType)(v)
}

func (*serviceIamMemberConditionPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**ServiceIamMemberCondition)(nil)).Elem()
}

func (i *serviceIamMemberConditionPtrType) ToServiceIamMemberConditionPtrOutput() ServiceIamMemberConditionPtrOutput {
	return i.ToServiceIamMemberConditionPtrOutputWithContext(context.Background())
}

func (i *serviceIamMemberConditionPtrType) ToServiceIamMemberConditionPtrOutputWithContext(ctx context.Context) ServiceIamMemberConditionPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ServiceIamMemberConditionPtrOutput)
}

type ServiceIamMemberConditionOutput struct{ *pulumi.OutputState }

func (ServiceIamMemberConditionOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ServiceIamMemberCondition)(nil)).Elem()
}

func (o ServiceIamMemberConditionOutput) ToServiceIamMemberConditionOutput() ServiceIamMemberConditionOutput {
	return o
}

func (o ServiceIamMemberConditionOutput) ToServiceIamMemberConditionOutputWithContext(ctx context.Context) ServiceIamMemberConditionOutput {
	return o
}

func (o ServiceIamMemberConditionOutput) ToServiceIamMemberConditionPtrOutput() ServiceIamMemberConditionPtrOutput {
	return o.ToServiceIamMemberConditionPtrOutputWithContext(context.Background())
}

func (o ServiceIamMemberConditionOutput) ToServiceIamMemberConditionPtrOutputWithContext(ctx context.Context) ServiceIamMemberConditionPtrOutput {
	return o.ApplyT(func(v ServiceIamMemberCondition) *ServiceIamMemberCondition {
		return &v
	}).(ServiceIamMemberConditionPtrOutput)
}
func (o ServiceIamMemberConditionOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ServiceIamMemberCondition) *string { return v.Description }).(pulumi.StringPtrOutput)
}

func (o ServiceIamMemberConditionOutput) Expression() pulumi.StringOutput {
	return o.ApplyT(func(v ServiceIamMemberCondition) string { return v.Expression }).(pulumi.StringOutput)
}

func (o ServiceIamMemberConditionOutput) Title() pulumi.StringOutput {
	return o.ApplyT(func(v ServiceIamMemberCondition) string { return v.Title }).(pulumi.StringOutput)
}

type ServiceIamMemberConditionPtrOutput struct{ *pulumi.OutputState }

func (ServiceIamMemberConditionPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ServiceIamMemberCondition)(nil)).Elem()
}

func (o ServiceIamMemberConditionPtrOutput) ToServiceIamMemberConditionPtrOutput() ServiceIamMemberConditionPtrOutput {
	return o
}

func (o ServiceIamMemberConditionPtrOutput) ToServiceIamMemberConditionPtrOutputWithContext(ctx context.Context) ServiceIamMemberConditionPtrOutput {
	return o
}

func (o ServiceIamMemberConditionPtrOutput) Elem() ServiceIamMemberConditionOutput {
	return o.ApplyT(func(v *ServiceIamMemberCondition) ServiceIamMemberCondition { return *v }).(ServiceIamMemberConditionOutput)
}

func (o ServiceIamMemberConditionPtrOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ServiceIamMemberCondition) *string { return v.Description }).(pulumi.StringPtrOutput)
}

func (o ServiceIamMemberConditionPtrOutput) Expression() pulumi.StringOutput {
	return o.ApplyT(func(v ServiceIamMemberCondition) string { return v.Expression }).(pulumi.StringOutput)
}

func (o ServiceIamMemberConditionPtrOutput) Title() pulumi.StringOutput {
	return o.ApplyT(func(v ServiceIamMemberCondition) string { return v.Title }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(ServiceApiOutput{})
	pulumi.RegisterOutputType(ServiceApiArrayOutput{})
	pulumi.RegisterOutputType(ServiceApiMethodOutput{})
	pulumi.RegisterOutputType(ServiceApiMethodArrayOutput{})
	pulumi.RegisterOutputType(ServiceEndpointOutput{})
	pulumi.RegisterOutputType(ServiceEndpointArrayOutput{})
	pulumi.RegisterOutputType(ServiceIamBindingConditionOutput{})
	pulumi.RegisterOutputType(ServiceIamBindingConditionPtrOutput{})
	pulumi.RegisterOutputType(ServiceIamMemberConditionOutput{})
	pulumi.RegisterOutputType(ServiceIamMemberConditionPtrOutput{})
}
