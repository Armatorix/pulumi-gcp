// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package dns

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Manages a set of DNS records within Google Cloud DNS. For more information see [the official documentation](https://cloud.google.com/dns/records/) and
// [API](https://cloud.google.com/dns/api/v1/resourceRecordSets).
//
// > **Note:** The provider treats this resource as an authoritative record set. This means existing records (including
// the default records) for the given type will be overwritten when you create this resource in the provider.
// In addition, the Google Cloud DNS API requires NS records to be present at all times, so the provider
// will not actually remove NS records during destroy but will report that it did.
type RecordSet struct {
	pulumi.CustomResourceState

	// The name of the zone in which this record set will
	// reside.
	ManagedZone pulumi.StringOutput `pulumi:"managedZone"`
	// The DNS name this record set will apply to.
	Name pulumi.StringOutput `pulumi:"name"`
	// The ID of the project in which the resource belongs. If it
	// is not provided, the provider project is used.
	Project pulumi.StringOutput `pulumi:"project"`
	// The string data for the records in this record set
	// whose meaning depends on the DNS type. For TXT record, if the string data contains spaces, add surrounding `\"` if you don't want your string to get split on spaces. To specify a single record value longer than 255 characters such as a TXT record for DKIM, add `\"\"` inside the provider configuration string (e.g. `"first255characters\"\"morecharacters"`).
	Rrdatas pulumi.StringArrayOutput `pulumi:"rrdatas"`
	// The time-to-live of this record set (seconds).
	Ttl pulumi.IntOutput `pulumi:"ttl"`
	// The DNS record set type.
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewRecordSet registers a new resource with the given unique name, arguments, and options.
func NewRecordSet(ctx *pulumi.Context,
	name string, args *RecordSetArgs, opts ...pulumi.ResourceOption) (*RecordSet, error) {
	if args == nil || args.ManagedZone == nil {
		return nil, errors.New("missing required argument 'ManagedZone'")
	}
	if args == nil || args.Rrdatas == nil {
		return nil, errors.New("missing required argument 'Rrdatas'")
	}
	if args == nil || args.Ttl == nil {
		return nil, errors.New("missing required argument 'Ttl'")
	}
	if args == nil || args.Type == nil {
		return nil, errors.New("missing required argument 'Type'")
	}
	if args == nil {
		args = &RecordSetArgs{}
	}
	var resource RecordSet
	err := ctx.RegisterResource("gcp:dns/recordSet:RecordSet", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetRecordSet gets an existing RecordSet resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetRecordSet(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *RecordSetState, opts ...pulumi.ResourceOption) (*RecordSet, error) {
	var resource RecordSet
	err := ctx.ReadResource("gcp:dns/recordSet:RecordSet", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering RecordSet resources.
type recordSetState struct {
	// The name of the zone in which this record set will
	// reside.
	ManagedZone *string `pulumi:"managedZone"`
	// The DNS name this record set will apply to.
	Name *string `pulumi:"name"`
	// The ID of the project in which the resource belongs. If it
	// is not provided, the provider project is used.
	Project *string `pulumi:"project"`
	// The string data for the records in this record set
	// whose meaning depends on the DNS type. For TXT record, if the string data contains spaces, add surrounding `\"` if you don't want your string to get split on spaces. To specify a single record value longer than 255 characters such as a TXT record for DKIM, add `\"\"` inside the provider configuration string (e.g. `"first255characters\"\"morecharacters"`).
	Rrdatas []string `pulumi:"rrdatas"`
	// The time-to-live of this record set (seconds).
	Ttl *int `pulumi:"ttl"`
	// The DNS record set type.
	Type *string `pulumi:"type"`
}

type RecordSetState struct {
	// The name of the zone in which this record set will
	// reside.
	ManagedZone pulumi.StringPtrInput
	// The DNS name this record set will apply to.
	Name pulumi.StringPtrInput
	// The ID of the project in which the resource belongs. If it
	// is not provided, the provider project is used.
	Project pulumi.StringPtrInput
	// The string data for the records in this record set
	// whose meaning depends on the DNS type. For TXT record, if the string data contains spaces, add surrounding `\"` if you don't want your string to get split on spaces. To specify a single record value longer than 255 characters such as a TXT record for DKIM, add `\"\"` inside the provider configuration string (e.g. `"first255characters\"\"morecharacters"`).
	Rrdatas pulumi.StringArrayInput
	// The time-to-live of this record set (seconds).
	Ttl pulumi.IntPtrInput
	// The DNS record set type.
	Type pulumi.StringPtrInput
}

func (RecordSetState) ElementType() reflect.Type {
	return reflect.TypeOf((*recordSetState)(nil)).Elem()
}

type recordSetArgs struct {
	// The name of the zone in which this record set will
	// reside.
	ManagedZone string `pulumi:"managedZone"`
	// The DNS name this record set will apply to.
	Name *string `pulumi:"name"`
	// The ID of the project in which the resource belongs. If it
	// is not provided, the provider project is used.
	Project *string `pulumi:"project"`
	// The string data for the records in this record set
	// whose meaning depends on the DNS type. For TXT record, if the string data contains spaces, add surrounding `\"` if you don't want your string to get split on spaces. To specify a single record value longer than 255 characters such as a TXT record for DKIM, add `\"\"` inside the provider configuration string (e.g. `"first255characters\"\"morecharacters"`).
	Rrdatas []string `pulumi:"rrdatas"`
	// The time-to-live of this record set (seconds).
	Ttl int `pulumi:"ttl"`
	// The DNS record set type.
	Type string `pulumi:"type"`
}

// The set of arguments for constructing a RecordSet resource.
type RecordSetArgs struct {
	// The name of the zone in which this record set will
	// reside.
	ManagedZone pulumi.StringInput
	// The DNS name this record set will apply to.
	Name pulumi.StringPtrInput
	// The ID of the project in which the resource belongs. If it
	// is not provided, the provider project is used.
	Project pulumi.StringPtrInput
	// The string data for the records in this record set
	// whose meaning depends on the DNS type. For TXT record, if the string data contains spaces, add surrounding `\"` if you don't want your string to get split on spaces. To specify a single record value longer than 255 characters such as a TXT record for DKIM, add `\"\"` inside the provider configuration string (e.g. `"first255characters\"\"morecharacters"`).
	Rrdatas pulumi.StringArrayInput
	// The time-to-live of this record set (seconds).
	Ttl pulumi.IntInput
	// The DNS record set type.
	Type pulumi.StringInput
}

func (RecordSetArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*recordSetArgs)(nil)).Elem()
}
