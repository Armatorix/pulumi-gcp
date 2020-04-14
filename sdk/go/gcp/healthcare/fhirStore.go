// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package healthcare

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// A FhirStore is a datastore inside a Healthcare dataset that conforms to the FHIR (https://www.hl7.org/fhir/STU3/)
// standard for Healthcare information exchange
//
// To get more information about FhirStore, see:
//
// * [API documentation](https://cloud.google.com/healthcare/docs/reference/rest/v1beta1/projects.locations.datasets.fhirStores)
// * How-to Guides
//     * [Creating a FHIR store](https://cloud.google.com/healthcare/docs/how-tos/fhir)
type FhirStore struct {
	pulumi.CustomResourceState

	// Identifies the dataset addressed by this request. Must be in the format
	// 'projects/{project}/locations/{location}/datasets/{dataset}'
	Dataset pulumi.StringOutput `pulumi:"dataset"`
	// Whether to disable referential integrity in this FHIR store. This field is immutable after FHIR store creation. The
	// default value is false, meaning that the API will enforce referential integrity and fail the requests that will result
	// in inconsistent state in the FHIR store. When this field is set to true, the API will skip referential integrity check.
	// Consequently, operations that rely on references, such as Patient.get$everything, will not return all the results if
	// broken references exist. ** Changing this property may recreate the FHIR store (removing all data) **
	DisableReferentialIntegrity pulumi.BoolPtrOutput `pulumi:"disableReferentialIntegrity"`
	// Whether to disable resource versioning for this FHIR store. This field can not be changed after the creation of FHIR
	// store. If set to false, which is the default behavior, all write operations will cause historical versions to be
	// recorded automatically. The historical versions can be fetched through the history APIs, but cannot be updated. If set
	// to true, no historical versions will be kept. The server will send back errors for attempts to read the historical
	// versions. ** Changing this property may recreate the FHIR store (removing all data) **
	DisableResourceVersioning pulumi.BoolPtrOutput `pulumi:"disableResourceVersioning"`
	// Whether to allow the bulk import API to accept history bundles and directly insert historical resource versions into the
	// FHIR store. Importing resource histories creates resource interactions that appear to have occurred in the past, which
	// clients may not want to allow. If set to false, history bundles within an import will fail with an error. ** Changing
	// this property may recreate the FHIR store (removing all data) ** ** This property can be changed manually in the Google
	// Cloud Healthcare admin console without recreating the FHIR store **
	EnableHistoryImport pulumi.BoolPtrOutput `pulumi:"enableHistoryImport"`
	// Whether this FHIR store has the updateCreate capability. This determines if the client can use an Update operation to
	// create a new resource with a client-specified ID. If false, all IDs are server-assigned through the Create operation and
	// attempts to Update a non-existent resource will return errors. Please treat the audit logs with appropriate levels of
	// care if client-specified resource IDs contain sensitive data such as patient identifiers, those IDs will be part of the
	// FHIR resource path recorded in Cloud audit logs and Cloud Pub/Sub notifications.
	EnableUpdateCreate pulumi.BoolPtrOutput `pulumi:"enableUpdateCreate"`
	// User-supplied key-value pairs used to organize FHIR stores. Label keys must be between 1 and 63 characters long, have a
	// UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression:
	// [\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}_-]{0,62} Label values are optional, must be between 1 and 63 characters long, have a
	// UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression:
	// [\p{Ll}\p{Lo}\p{N}_-]{0,63} No more than 64 labels can be associated with a given store. An object containing a list of
	// "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.
	Labels pulumi.StringMapOutput `pulumi:"labels"`
	// The resource name for the FhirStore. ** Changing this property may recreate the FHIR store (removing all data) **
	Name pulumi.StringOutput `pulumi:"name"`
	// A nested object resource
	NotificationConfig FhirStoreNotificationConfigPtrOutput `pulumi:"notificationConfig"`
	// The fully qualified name of this dataset
	SelfLink pulumi.StringOutput `pulumi:"selfLink"`
	// The FHIR specification version. Supported values include DSTU2, STU3 and R4. Defaults to STU3.
	Version pulumi.StringPtrOutput `pulumi:"version"`
}

// NewFhirStore registers a new resource with the given unique name, arguments, and options.
func NewFhirStore(ctx *pulumi.Context,
	name string, args *FhirStoreArgs, opts ...pulumi.ResourceOption) (*FhirStore, error) {
	if args == nil || args.Dataset == nil {
		return nil, errors.New("missing required argument 'Dataset'")
	}
	if args == nil {
		args = &FhirStoreArgs{}
	}
	var resource FhirStore
	err := ctx.RegisterResource("gcp:healthcare/fhirStore:FhirStore", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetFhirStore gets an existing FhirStore resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetFhirStore(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *FhirStoreState, opts ...pulumi.ResourceOption) (*FhirStore, error) {
	var resource FhirStore
	err := ctx.ReadResource("gcp:healthcare/fhirStore:FhirStore", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering FhirStore resources.
type fhirStoreState struct {
	// Identifies the dataset addressed by this request. Must be in the format
	// 'projects/{project}/locations/{location}/datasets/{dataset}'
	Dataset *string `pulumi:"dataset"`
	// Whether to disable referential integrity in this FHIR store. This field is immutable after FHIR store creation. The
	// default value is false, meaning that the API will enforce referential integrity and fail the requests that will result
	// in inconsistent state in the FHIR store. When this field is set to true, the API will skip referential integrity check.
	// Consequently, operations that rely on references, such as Patient.get$everything, will not return all the results if
	// broken references exist. ** Changing this property may recreate the FHIR store (removing all data) **
	DisableReferentialIntegrity *bool `pulumi:"disableReferentialIntegrity"`
	// Whether to disable resource versioning for this FHIR store. This field can not be changed after the creation of FHIR
	// store. If set to false, which is the default behavior, all write operations will cause historical versions to be
	// recorded automatically. The historical versions can be fetched through the history APIs, but cannot be updated. If set
	// to true, no historical versions will be kept. The server will send back errors for attempts to read the historical
	// versions. ** Changing this property may recreate the FHIR store (removing all data) **
	DisableResourceVersioning *bool `pulumi:"disableResourceVersioning"`
	// Whether to allow the bulk import API to accept history bundles and directly insert historical resource versions into the
	// FHIR store. Importing resource histories creates resource interactions that appear to have occurred in the past, which
	// clients may not want to allow. If set to false, history bundles within an import will fail with an error. ** Changing
	// this property may recreate the FHIR store (removing all data) ** ** This property can be changed manually in the Google
	// Cloud Healthcare admin console without recreating the FHIR store **
	EnableHistoryImport *bool `pulumi:"enableHistoryImport"`
	// Whether this FHIR store has the updateCreate capability. This determines if the client can use an Update operation to
	// create a new resource with a client-specified ID. If false, all IDs are server-assigned through the Create operation and
	// attempts to Update a non-existent resource will return errors. Please treat the audit logs with appropriate levels of
	// care if client-specified resource IDs contain sensitive data such as patient identifiers, those IDs will be part of the
	// FHIR resource path recorded in Cloud audit logs and Cloud Pub/Sub notifications.
	EnableUpdateCreate *bool `pulumi:"enableUpdateCreate"`
	// User-supplied key-value pairs used to organize FHIR stores. Label keys must be between 1 and 63 characters long, have a
	// UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression:
	// [\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}_-]{0,62} Label values are optional, must be between 1 and 63 characters long, have a
	// UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression:
	// [\p{Ll}\p{Lo}\p{N}_-]{0,63} No more than 64 labels can be associated with a given store. An object containing a list of
	// "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.
	Labels map[string]string `pulumi:"labels"`
	// The resource name for the FhirStore. ** Changing this property may recreate the FHIR store (removing all data) **
	Name *string `pulumi:"name"`
	// A nested object resource
	NotificationConfig *FhirStoreNotificationConfig `pulumi:"notificationConfig"`
	// The fully qualified name of this dataset
	SelfLink *string `pulumi:"selfLink"`
	// The FHIR specification version. Supported values include DSTU2, STU3 and R4. Defaults to STU3.
	Version *string `pulumi:"version"`
}

type FhirStoreState struct {
	// Identifies the dataset addressed by this request. Must be in the format
	// 'projects/{project}/locations/{location}/datasets/{dataset}'
	Dataset pulumi.StringPtrInput
	// Whether to disable referential integrity in this FHIR store. This field is immutable after FHIR store creation. The
	// default value is false, meaning that the API will enforce referential integrity and fail the requests that will result
	// in inconsistent state in the FHIR store. When this field is set to true, the API will skip referential integrity check.
	// Consequently, operations that rely on references, such as Patient.get$everything, will not return all the results if
	// broken references exist. ** Changing this property may recreate the FHIR store (removing all data) **
	DisableReferentialIntegrity pulumi.BoolPtrInput
	// Whether to disable resource versioning for this FHIR store. This field can not be changed after the creation of FHIR
	// store. If set to false, which is the default behavior, all write operations will cause historical versions to be
	// recorded automatically. The historical versions can be fetched through the history APIs, but cannot be updated. If set
	// to true, no historical versions will be kept. The server will send back errors for attempts to read the historical
	// versions. ** Changing this property may recreate the FHIR store (removing all data) **
	DisableResourceVersioning pulumi.BoolPtrInput
	// Whether to allow the bulk import API to accept history bundles and directly insert historical resource versions into the
	// FHIR store. Importing resource histories creates resource interactions that appear to have occurred in the past, which
	// clients may not want to allow. If set to false, history bundles within an import will fail with an error. ** Changing
	// this property may recreate the FHIR store (removing all data) ** ** This property can be changed manually in the Google
	// Cloud Healthcare admin console without recreating the FHIR store **
	EnableHistoryImport pulumi.BoolPtrInput
	// Whether this FHIR store has the updateCreate capability. This determines if the client can use an Update operation to
	// create a new resource with a client-specified ID. If false, all IDs are server-assigned through the Create operation and
	// attempts to Update a non-existent resource will return errors. Please treat the audit logs with appropriate levels of
	// care if client-specified resource IDs contain sensitive data such as patient identifiers, those IDs will be part of the
	// FHIR resource path recorded in Cloud audit logs and Cloud Pub/Sub notifications.
	EnableUpdateCreate pulumi.BoolPtrInput
	// User-supplied key-value pairs used to organize FHIR stores. Label keys must be between 1 and 63 characters long, have a
	// UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression:
	// [\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}_-]{0,62} Label values are optional, must be between 1 and 63 characters long, have a
	// UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression:
	// [\p{Ll}\p{Lo}\p{N}_-]{0,63} No more than 64 labels can be associated with a given store. An object containing a list of
	// "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.
	Labels pulumi.StringMapInput
	// The resource name for the FhirStore. ** Changing this property may recreate the FHIR store (removing all data) **
	Name pulumi.StringPtrInput
	// A nested object resource
	NotificationConfig FhirStoreNotificationConfigPtrInput
	// The fully qualified name of this dataset
	SelfLink pulumi.StringPtrInput
	// The FHIR specification version. Supported values include DSTU2, STU3 and R4. Defaults to STU3.
	Version pulumi.StringPtrInput
}

func (FhirStoreState) ElementType() reflect.Type {
	return reflect.TypeOf((*fhirStoreState)(nil)).Elem()
}

type fhirStoreArgs struct {
	// Identifies the dataset addressed by this request. Must be in the format
	// 'projects/{project}/locations/{location}/datasets/{dataset}'
	Dataset string `pulumi:"dataset"`
	// Whether to disable referential integrity in this FHIR store. This field is immutable after FHIR store creation. The
	// default value is false, meaning that the API will enforce referential integrity and fail the requests that will result
	// in inconsistent state in the FHIR store. When this field is set to true, the API will skip referential integrity check.
	// Consequently, operations that rely on references, such as Patient.get$everything, will not return all the results if
	// broken references exist. ** Changing this property may recreate the FHIR store (removing all data) **
	DisableReferentialIntegrity *bool `pulumi:"disableReferentialIntegrity"`
	// Whether to disable resource versioning for this FHIR store. This field can not be changed after the creation of FHIR
	// store. If set to false, which is the default behavior, all write operations will cause historical versions to be
	// recorded automatically. The historical versions can be fetched through the history APIs, but cannot be updated. If set
	// to true, no historical versions will be kept. The server will send back errors for attempts to read the historical
	// versions. ** Changing this property may recreate the FHIR store (removing all data) **
	DisableResourceVersioning *bool `pulumi:"disableResourceVersioning"`
	// Whether to allow the bulk import API to accept history bundles and directly insert historical resource versions into the
	// FHIR store. Importing resource histories creates resource interactions that appear to have occurred in the past, which
	// clients may not want to allow. If set to false, history bundles within an import will fail with an error. ** Changing
	// this property may recreate the FHIR store (removing all data) ** ** This property can be changed manually in the Google
	// Cloud Healthcare admin console without recreating the FHIR store **
	EnableHistoryImport *bool `pulumi:"enableHistoryImport"`
	// Whether this FHIR store has the updateCreate capability. This determines if the client can use an Update operation to
	// create a new resource with a client-specified ID. If false, all IDs are server-assigned through the Create operation and
	// attempts to Update a non-existent resource will return errors. Please treat the audit logs with appropriate levels of
	// care if client-specified resource IDs contain sensitive data such as patient identifiers, those IDs will be part of the
	// FHIR resource path recorded in Cloud audit logs and Cloud Pub/Sub notifications.
	EnableUpdateCreate *bool `pulumi:"enableUpdateCreate"`
	// User-supplied key-value pairs used to organize FHIR stores. Label keys must be between 1 and 63 characters long, have a
	// UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression:
	// [\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}_-]{0,62} Label values are optional, must be between 1 and 63 characters long, have a
	// UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression:
	// [\p{Ll}\p{Lo}\p{N}_-]{0,63} No more than 64 labels can be associated with a given store. An object containing a list of
	// "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.
	Labels map[string]string `pulumi:"labels"`
	// The resource name for the FhirStore. ** Changing this property may recreate the FHIR store (removing all data) **
	Name *string `pulumi:"name"`
	// A nested object resource
	NotificationConfig *FhirStoreNotificationConfig `pulumi:"notificationConfig"`
	// The FHIR specification version. Supported values include DSTU2, STU3 and R4. Defaults to STU3.
	Version *string `pulumi:"version"`
}

// The set of arguments for constructing a FhirStore resource.
type FhirStoreArgs struct {
	// Identifies the dataset addressed by this request. Must be in the format
	// 'projects/{project}/locations/{location}/datasets/{dataset}'
	Dataset pulumi.StringInput
	// Whether to disable referential integrity in this FHIR store. This field is immutable after FHIR store creation. The
	// default value is false, meaning that the API will enforce referential integrity and fail the requests that will result
	// in inconsistent state in the FHIR store. When this field is set to true, the API will skip referential integrity check.
	// Consequently, operations that rely on references, such as Patient.get$everything, will not return all the results if
	// broken references exist. ** Changing this property may recreate the FHIR store (removing all data) **
	DisableReferentialIntegrity pulumi.BoolPtrInput
	// Whether to disable resource versioning for this FHIR store. This field can not be changed after the creation of FHIR
	// store. If set to false, which is the default behavior, all write operations will cause historical versions to be
	// recorded automatically. The historical versions can be fetched through the history APIs, but cannot be updated. If set
	// to true, no historical versions will be kept. The server will send back errors for attempts to read the historical
	// versions. ** Changing this property may recreate the FHIR store (removing all data) **
	DisableResourceVersioning pulumi.BoolPtrInput
	// Whether to allow the bulk import API to accept history bundles and directly insert historical resource versions into the
	// FHIR store. Importing resource histories creates resource interactions that appear to have occurred in the past, which
	// clients may not want to allow. If set to false, history bundles within an import will fail with an error. ** Changing
	// this property may recreate the FHIR store (removing all data) ** ** This property can be changed manually in the Google
	// Cloud Healthcare admin console without recreating the FHIR store **
	EnableHistoryImport pulumi.BoolPtrInput
	// Whether this FHIR store has the updateCreate capability. This determines if the client can use an Update operation to
	// create a new resource with a client-specified ID. If false, all IDs are server-assigned through the Create operation and
	// attempts to Update a non-existent resource will return errors. Please treat the audit logs with appropriate levels of
	// care if client-specified resource IDs contain sensitive data such as patient identifiers, those IDs will be part of the
	// FHIR resource path recorded in Cloud audit logs and Cloud Pub/Sub notifications.
	EnableUpdateCreate pulumi.BoolPtrInput
	// User-supplied key-value pairs used to organize FHIR stores. Label keys must be between 1 and 63 characters long, have a
	// UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression:
	// [\p{Ll}\p{Lo}][\p{Ll}\p{Lo}\p{N}_-]{0,62} Label values are optional, must be between 1 and 63 characters long, have a
	// UTF-8 encoding of maximum 128 bytes, and must conform to the following PCRE regular expression:
	// [\p{Ll}\p{Lo}\p{N}_-]{0,63} No more than 64 labels can be associated with a given store. An object containing a list of
	// "key": value pairs. Example: { "name": "wrench", "mass": "1.3kg", "count": "3" }.
	Labels pulumi.StringMapInput
	// The resource name for the FhirStore. ** Changing this property may recreate the FHIR store (removing all data) **
	Name pulumi.StringPtrInput
	// A nested object resource
	NotificationConfig FhirStoreNotificationConfigPtrInput
	// The FHIR specification version. Supported values include DSTU2, STU3 and R4. Defaults to STU3.
	Version pulumi.StringPtrInput
}

func (FhirStoreArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*fhirStoreArgs)(nil)).Elem()
}
