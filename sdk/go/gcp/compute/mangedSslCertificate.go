// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package compute

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

type MangedSslCertificate struct {
	s *pulumi.ResourceState
}

// NewMangedSslCertificate registers a new resource with the given unique name, arguments, and options.
func NewMangedSslCertificate(ctx *pulumi.Context,
	name string, args *MangedSslCertificateArgs, opts ...pulumi.ResourceOpt) (*MangedSslCertificate, error) {
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["certificateId"] = nil
		inputs["description"] = nil
		inputs["managed"] = nil
		inputs["name"] = nil
		inputs["project"] = nil
		inputs["type"] = nil
	} else {
		inputs["certificateId"] = args.CertificateId
		inputs["description"] = args.Description
		inputs["managed"] = args.Managed
		inputs["name"] = args.Name
		inputs["project"] = args.Project
		inputs["type"] = args.Type
	}
	inputs["creationTimestamp"] = nil
	inputs["expireTime"] = nil
	inputs["selfLink"] = nil
	inputs["subjectAlternativeNames"] = nil
	s, err := ctx.RegisterResource("gcp:compute/mangedSslCertificate:MangedSslCertificate", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &MangedSslCertificate{s: s}, nil
}

// GetMangedSslCertificate gets an existing MangedSslCertificate resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetMangedSslCertificate(ctx *pulumi.Context,
	name string, id pulumi.ID, state *MangedSslCertificateState, opts ...pulumi.ResourceOpt) (*MangedSslCertificate, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["certificateId"] = state.CertificateId
		inputs["creationTimestamp"] = state.CreationTimestamp
		inputs["description"] = state.Description
		inputs["expireTime"] = state.ExpireTime
		inputs["managed"] = state.Managed
		inputs["name"] = state.Name
		inputs["project"] = state.Project
		inputs["selfLink"] = state.SelfLink
		inputs["subjectAlternativeNames"] = state.SubjectAlternativeNames
		inputs["type"] = state.Type
	}
	s, err := ctx.ReadResource("gcp:compute/mangedSslCertificate:MangedSslCertificate", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &MangedSslCertificate{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *MangedSslCertificate) URN() pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *MangedSslCertificate) ID() pulumi.IDOutput {
	return r.s.ID()
}

// The unique identifier for the resource.
func (r *MangedSslCertificate) CertificateId() pulumi.IntOutput {
	return (pulumi.IntOutput)(r.s.State["certificateId"])
}

// Creation timestamp in RFC3339 text format.
func (r *MangedSslCertificate) CreationTimestamp() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["creationTimestamp"])
}

// An optional description of this resource.
func (r *MangedSslCertificate) Description() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["description"])
}

// Expire time of the certificate.
func (r *MangedSslCertificate) ExpireTime() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["expireTime"])
}

// Properties relevant to a managed certificate. These will be used if the certificate is managed (as indicated by a value
// of 'MANAGED' in 'type').
func (r *MangedSslCertificate) Managed() pulumi.Output {
	return r.s.State["managed"]
}

// Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and
// comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression
// '[a-z]([-a-z0-9]*[a-z0-9])?' which means the first character must be a lowercase letter, and all following characters
// must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash. These are in the same
// namespace as the managed SSL certificates.
func (r *MangedSslCertificate) Name() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["name"])
}

func (r *MangedSslCertificate) Project() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["project"])
}

func (r *MangedSslCertificate) SelfLink() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["selfLink"])
}

// Domains associated with the certificate via Subject Alternative Name.
func (r *MangedSslCertificate) SubjectAlternativeNames() pulumi.ArrayOutput {
	return (pulumi.ArrayOutput)(r.s.State["subjectAlternativeNames"])
}

// Enum field whose value is always 'MANAGED' - used to signal to the API which type this is.
func (r *MangedSslCertificate) Type() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["type"])
}

// Input properties used for looking up and filtering MangedSslCertificate resources.
type MangedSslCertificateState struct {
	// The unique identifier for the resource.
	CertificateId interface{}
	// Creation timestamp in RFC3339 text format.
	CreationTimestamp interface{}
	// An optional description of this resource.
	Description interface{}
	// Expire time of the certificate.
	ExpireTime interface{}
	// Properties relevant to a managed certificate. These will be used if the certificate is managed (as indicated by a value
	// of 'MANAGED' in 'type').
	Managed interface{}
	// Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and
	// comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression
	// '[a-z]([-a-z0-9]*[a-z0-9])?' which means the first character must be a lowercase letter, and all following characters
	// must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash. These are in the same
	// namespace as the managed SSL certificates.
	Name interface{}
	Project interface{}
	SelfLink interface{}
	// Domains associated with the certificate via Subject Alternative Name.
	SubjectAlternativeNames interface{}
	// Enum field whose value is always 'MANAGED' - used to signal to the API which type this is.
	Type interface{}
}

// The set of arguments for constructing a MangedSslCertificate resource.
type MangedSslCertificateArgs struct {
	// The unique identifier for the resource.
	CertificateId interface{}
	// An optional description of this resource.
	Description interface{}
	// Properties relevant to a managed certificate. These will be used if the certificate is managed (as indicated by a value
	// of 'MANAGED' in 'type').
	Managed interface{}
	// Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and
	// comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression
	// '[a-z]([-a-z0-9]*[a-z0-9])?' which means the first character must be a lowercase letter, and all following characters
	// must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash. These are in the same
	// namespace as the managed SSL certificates.
	Name interface{}
	Project interface{}
	// Enum field whose value is always 'MANAGED' - used to signal to the API which type this is.
	Type interface{}
}
