// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package compute

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages a VM instance resource within GCE. For more information see
// [the official documentation](https://cloud.google.com/compute/docs/instances)
// and
// [API](https://cloud.google.com/compute/docs/reference/latest/instances).
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/compute_instance.html.markdown.
type Instance struct {
	s *pulumi.ResourceState
}

// NewInstance registers a new resource with the given unique name, arguments, and options.
func NewInstance(ctx *pulumi.Context,
	name string, args *InstanceArgs, opts ...pulumi.ResourceOpt) (*Instance, error) {
	if args == nil || args.BootDisk == nil {
		return nil, errors.New("missing required argument 'BootDisk'")
	}
	if args == nil || args.MachineType == nil {
		return nil, errors.New("missing required argument 'MachineType'")
	}
	if args == nil || args.NetworkInterfaces == nil {
		return nil, errors.New("missing required argument 'NetworkInterfaces'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["allowStoppingForUpdate"] = nil
		inputs["attachedDisks"] = nil
		inputs["bootDisk"] = nil
		inputs["canIpForward"] = nil
		inputs["deletionProtection"] = nil
		inputs["description"] = nil
		inputs["enableDisplay"] = nil
		inputs["guestAccelerators"] = nil
		inputs["hostname"] = nil
		inputs["labels"] = nil
		inputs["machineType"] = nil
		inputs["metadata"] = nil
		inputs["metadataStartupScript"] = nil
		inputs["minCpuPlatform"] = nil
		inputs["name"] = nil
		inputs["networkInterfaces"] = nil
		inputs["project"] = nil
		inputs["scheduling"] = nil
		inputs["scratchDisks"] = nil
		inputs["serviceAccount"] = nil
		inputs["shieldedInstanceConfig"] = nil
		inputs["tags"] = nil
		inputs["zone"] = nil
	} else {
		inputs["allowStoppingForUpdate"] = args.AllowStoppingForUpdate
		inputs["attachedDisks"] = args.AttachedDisks
		inputs["bootDisk"] = args.BootDisk
		inputs["canIpForward"] = args.CanIpForward
		inputs["deletionProtection"] = args.DeletionProtection
		inputs["description"] = args.Description
		inputs["enableDisplay"] = args.EnableDisplay
		inputs["guestAccelerators"] = args.GuestAccelerators
		inputs["hostname"] = args.Hostname
		inputs["labels"] = args.Labels
		inputs["machineType"] = args.MachineType
		inputs["metadata"] = args.Metadata
		inputs["metadataStartupScript"] = args.MetadataStartupScript
		inputs["minCpuPlatform"] = args.MinCpuPlatform
		inputs["name"] = args.Name
		inputs["networkInterfaces"] = args.NetworkInterfaces
		inputs["project"] = args.Project
		inputs["scheduling"] = args.Scheduling
		inputs["scratchDisks"] = args.ScratchDisks
		inputs["serviceAccount"] = args.ServiceAccount
		inputs["shieldedInstanceConfig"] = args.ShieldedInstanceConfig
		inputs["tags"] = args.Tags
		inputs["zone"] = args.Zone
	}
	inputs["cpuPlatform"] = nil
	inputs["instanceId"] = nil
	inputs["labelFingerprint"] = nil
	inputs["metadataFingerprint"] = nil
	inputs["selfLink"] = nil
	inputs["tagsFingerprint"] = nil
	s, err := ctx.RegisterResource("gcp:compute/instance:Instance", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Instance{s: s}, nil
}

// GetInstance gets an existing Instance resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetInstance(ctx *pulumi.Context,
	name string, id pulumi.ID, state *InstanceState, opts ...pulumi.ResourceOpt) (*Instance, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["allowStoppingForUpdate"] = state.AllowStoppingForUpdate
		inputs["attachedDisks"] = state.AttachedDisks
		inputs["bootDisk"] = state.BootDisk
		inputs["canIpForward"] = state.CanIpForward
		inputs["cpuPlatform"] = state.CpuPlatform
		inputs["deletionProtection"] = state.DeletionProtection
		inputs["description"] = state.Description
		inputs["enableDisplay"] = state.EnableDisplay
		inputs["guestAccelerators"] = state.GuestAccelerators
		inputs["hostname"] = state.Hostname
		inputs["instanceId"] = state.InstanceId
		inputs["labelFingerprint"] = state.LabelFingerprint
		inputs["labels"] = state.Labels
		inputs["machineType"] = state.MachineType
		inputs["metadata"] = state.Metadata
		inputs["metadataFingerprint"] = state.MetadataFingerprint
		inputs["metadataStartupScript"] = state.MetadataStartupScript
		inputs["minCpuPlatform"] = state.MinCpuPlatform
		inputs["name"] = state.Name
		inputs["networkInterfaces"] = state.NetworkInterfaces
		inputs["project"] = state.Project
		inputs["scheduling"] = state.Scheduling
		inputs["scratchDisks"] = state.ScratchDisks
		inputs["selfLink"] = state.SelfLink
		inputs["serviceAccount"] = state.ServiceAccount
		inputs["shieldedInstanceConfig"] = state.ShieldedInstanceConfig
		inputs["tags"] = state.Tags
		inputs["tagsFingerprint"] = state.TagsFingerprint
		inputs["zone"] = state.Zone
	}
	s, err := ctx.ReadResource("gcp:compute/instance:Instance", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Instance{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *Instance) URN() pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *Instance) ID() pulumi.IDOutput {
	return r.s.ID()
}

// If true, allows this provider to stop the instance to update its properties.
// If you try to update a property that requires stopping the instance without setting this field, the update will fail.
func (r *Instance) AllowStoppingForUpdate() pulumi.BoolOutput {
	return (pulumi.BoolOutput)(r.s.State["allowStoppingForUpdate"])
}

// Additional disks to attach to the instance. Can be repeated multiple times for multiple disks. Structure is documented below.
func (r *Instance) AttachedDisks() pulumi.ArrayOutput {
	return (pulumi.ArrayOutput)(r.s.State["attachedDisks"])
}

// The boot disk for the instance.
// Structure is documented below.
func (r *Instance) BootDisk() pulumi.Output {
	return r.s.State["bootDisk"]
}

// Whether to allow sending and receiving of
// packets with non-matching source or destination IPs.
// This defaults to false.
func (r *Instance) CanIpForward() pulumi.BoolOutput {
	return (pulumi.BoolOutput)(r.s.State["canIpForward"])
}

// The CPU platform used by this instance.
func (r *Instance) CpuPlatform() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["cpuPlatform"])
}

// Enable deletion protection on this instance. Defaults to false.
// **Note:** you must disable deletion protection before removing the resource, or the instance cannot be deleted and the deployment will not complete successfully.
func (r *Instance) DeletionProtection() pulumi.BoolOutput {
	return (pulumi.BoolOutput)(r.s.State["deletionProtection"])
}

// A brief description of this resource.
func (r *Instance) Description() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["description"])
}

// Enable [Virtual Displays](https://cloud.google.com/compute/docs/instances/enable-instance-virtual-display#verify_display_driver) on this instance.
// **Note**: `allowStoppingForUpdate` must be set to true in order to update this field.
func (r *Instance) EnableDisplay() pulumi.BoolOutput {
	return (pulumi.BoolOutput)(r.s.State["enableDisplay"])
}

// List of the type and count of accelerator cards attached to the instance. Structure documented below.
// **Note:** GPU accelerators can only be used with `onHostMaintenance` option set to TERMINATE.
func (r *Instance) GuestAccelerators() pulumi.ArrayOutput {
	return (pulumi.ArrayOutput)(r.s.State["guestAccelerators"])
}

// A custom hostname for the instance. Must be a fully qualified DNS name and RFC-1035-valid.
// Valid format is a series of labels 1-63 characters long matching the regular expression `a-z`, concatenated with periods.
// The entire hostname must not exceed 253 characters. Changing this forces a new resource to be created.
func (r *Instance) Hostname() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["hostname"])
}

// The server-assigned unique identifier of this instance.
func (r *Instance) InstanceId() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["instanceId"])
}

// The unique fingerprint of the labels.
func (r *Instance) LabelFingerprint() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["labelFingerprint"])
}

// A map of key/value label pairs to assign to the instance.
func (r *Instance) Labels() pulumi.MapOutput {
	return (pulumi.MapOutput)(r.s.State["labels"])
}

// The machine type to create.
func (r *Instance) MachineType() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["machineType"])
}

// Metadata key/value pairs to make available from
// within the instance. Ssh keys attached in the Cloud Console will be removed.
// Add them to your config in order to keep them attached to your instance.
func (r *Instance) Metadata() pulumi.MapOutput {
	return (pulumi.MapOutput)(r.s.State["metadata"])
}

// The unique fingerprint of the metadata.
func (r *Instance) MetadataFingerprint() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["metadataFingerprint"])
}

// An alternative to using the
// startup-script metadata key, except this one forces the instance to be
// recreated (thus re-running the script) if it is changed. This replaces the
// startup-script metadata key on the created instance and thus the two
// mechanisms are not allowed to be used simultaneously.
func (r *Instance) MetadataStartupScript() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["metadataStartupScript"])
}

// Specifies a minimum CPU platform for the VM instance. Applicable values are the friendly names of CPU platforms, such as
// `Intel Haswell` or `Intel Skylake`. See the complete list [here](https://cloud.google.com/compute/docs/instances/specify-min-cpu-platform).
// **Note**: `allowStoppingForUpdate` must be set to true in order to update this field.
func (r *Instance) MinCpuPlatform() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["minCpuPlatform"])
}

// A unique name for the resource, required by GCE.
// Changing this forces a new resource to be created.
func (r *Instance) Name() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["name"])
}

// Networks to attach to the instance. This can
// be specified multiple times. Structure is documented below.
func (r *Instance) NetworkInterfaces() pulumi.ArrayOutput {
	return (pulumi.ArrayOutput)(r.s.State["networkInterfaces"])
}

// The ID of the project in which the resource belongs. If it
// is not provided, the provider project is used.
func (r *Instance) Project() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["project"])
}

// The scheduling strategy to use. More details about
// this configuration option are detailed below.
func (r *Instance) Scheduling() pulumi.Output {
	return r.s.State["scheduling"]
}

// Scratch disks to attach to the instance. This can be
// specified multiple times for multiple scratch disks. Structure is documented below.
func (r *Instance) ScratchDisks() pulumi.ArrayOutput {
	return (pulumi.ArrayOutput)(r.s.State["scratchDisks"])
}

// The URI of the created resource.
func (r *Instance) SelfLink() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["selfLink"])
}

// Service account to attach to the instance.
// Structure is documented below.
// **Note**: `allowStoppingForUpdate` must be set to true in order to update this field.
func (r *Instance) ServiceAccount() pulumi.Output {
	return r.s.State["serviceAccount"]
}

// Enable [Shielded VM](https://cloud.google.com/security/shielded-cloud/shielded-vm) on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Structure is documented below.
// **Note**: `shieldedInstanceConfig` can only be used with boot images with shielded vm support. See the complete list [here](https://cloud.google.com/compute/docs/images#shielded-images).
func (r *Instance) ShieldedInstanceConfig() pulumi.Output {
	return r.s.State["shieldedInstanceConfig"]
}

// A list of tags to attach to the instance.
func (r *Instance) Tags() pulumi.ArrayOutput {
	return (pulumi.ArrayOutput)(r.s.State["tags"])
}

// The unique fingerprint of the tags.
func (r *Instance) TagsFingerprint() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["tagsFingerprint"])
}

// The zone that the machine should be created in.
func (r *Instance) Zone() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["zone"])
}

// Input properties used for looking up and filtering Instance resources.
type InstanceState struct {
	// If true, allows this provider to stop the instance to update its properties.
	// If you try to update a property that requires stopping the instance without setting this field, the update will fail.
	AllowStoppingForUpdate interface{}
	// Additional disks to attach to the instance. Can be repeated multiple times for multiple disks. Structure is documented below.
	AttachedDisks interface{}
	// The boot disk for the instance.
	// Structure is documented below.
	BootDisk interface{}
	// Whether to allow sending and receiving of
	// packets with non-matching source or destination IPs.
	// This defaults to false.
	CanIpForward interface{}
	// The CPU platform used by this instance.
	CpuPlatform interface{}
	// Enable deletion protection on this instance. Defaults to false.
	// **Note:** you must disable deletion protection before removing the resource, or the instance cannot be deleted and the deployment will not complete successfully.
	DeletionProtection interface{}
	// A brief description of this resource.
	Description interface{}
	// Enable [Virtual Displays](https://cloud.google.com/compute/docs/instances/enable-instance-virtual-display#verify_display_driver) on this instance.
	// **Note**: `allowStoppingForUpdate` must be set to true in order to update this field.
	EnableDisplay interface{}
	// List of the type and count of accelerator cards attached to the instance. Structure documented below.
	// **Note:** GPU accelerators can only be used with `onHostMaintenance` option set to TERMINATE.
	GuestAccelerators interface{}
	// A custom hostname for the instance. Must be a fully qualified DNS name and RFC-1035-valid.
	// Valid format is a series of labels 1-63 characters long matching the regular expression `a-z`, concatenated with periods.
	// The entire hostname must not exceed 253 characters. Changing this forces a new resource to be created.
	Hostname interface{}
	// The server-assigned unique identifier of this instance.
	InstanceId interface{}
	// The unique fingerprint of the labels.
	LabelFingerprint interface{}
	// A map of key/value label pairs to assign to the instance.
	Labels interface{}
	// The machine type to create.
	MachineType interface{}
	// Metadata key/value pairs to make available from
	// within the instance. Ssh keys attached in the Cloud Console will be removed.
	// Add them to your config in order to keep them attached to your instance.
	Metadata interface{}
	// The unique fingerprint of the metadata.
	MetadataFingerprint interface{}
	// An alternative to using the
	// startup-script metadata key, except this one forces the instance to be
	// recreated (thus re-running the script) if it is changed. This replaces the
	// startup-script metadata key on the created instance and thus the two
	// mechanisms are not allowed to be used simultaneously.
	MetadataStartupScript interface{}
	// Specifies a minimum CPU platform for the VM instance. Applicable values are the friendly names of CPU platforms, such as
	// `Intel Haswell` or `Intel Skylake`. See the complete list [here](https://cloud.google.com/compute/docs/instances/specify-min-cpu-platform).
	// **Note**: `allowStoppingForUpdate` must be set to true in order to update this field.
	MinCpuPlatform interface{}
	// A unique name for the resource, required by GCE.
	// Changing this forces a new resource to be created.
	Name interface{}
	// Networks to attach to the instance. This can
	// be specified multiple times. Structure is documented below.
	NetworkInterfaces interface{}
	// The ID of the project in which the resource belongs. If it
	// is not provided, the provider project is used.
	Project interface{}
	// The scheduling strategy to use. More details about
	// this configuration option are detailed below.
	Scheduling interface{}
	// Scratch disks to attach to the instance. This can be
	// specified multiple times for multiple scratch disks. Structure is documented below.
	ScratchDisks interface{}
	// The URI of the created resource.
	SelfLink interface{}
	// Service account to attach to the instance.
	// Structure is documented below.
	// **Note**: `allowStoppingForUpdate` must be set to true in order to update this field.
	ServiceAccount interface{}
	// Enable [Shielded VM](https://cloud.google.com/security/shielded-cloud/shielded-vm) on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Structure is documented below.
	// **Note**: `shieldedInstanceConfig` can only be used with boot images with shielded vm support. See the complete list [here](https://cloud.google.com/compute/docs/images#shielded-images).
	ShieldedInstanceConfig interface{}
	// A list of tags to attach to the instance.
	Tags interface{}
	// The unique fingerprint of the tags.
	TagsFingerprint interface{}
	// The zone that the machine should be created in.
	Zone interface{}
}

// The set of arguments for constructing a Instance resource.
type InstanceArgs struct {
	// If true, allows this provider to stop the instance to update its properties.
	// If you try to update a property that requires stopping the instance without setting this field, the update will fail.
	AllowStoppingForUpdate interface{}
	// Additional disks to attach to the instance. Can be repeated multiple times for multiple disks. Structure is documented below.
	AttachedDisks interface{}
	// The boot disk for the instance.
	// Structure is documented below.
	BootDisk interface{}
	// Whether to allow sending and receiving of
	// packets with non-matching source or destination IPs.
	// This defaults to false.
	CanIpForward interface{}
	// Enable deletion protection on this instance. Defaults to false.
	// **Note:** you must disable deletion protection before removing the resource, or the instance cannot be deleted and the deployment will not complete successfully.
	DeletionProtection interface{}
	// A brief description of this resource.
	Description interface{}
	// Enable [Virtual Displays](https://cloud.google.com/compute/docs/instances/enable-instance-virtual-display#verify_display_driver) on this instance.
	// **Note**: `allowStoppingForUpdate` must be set to true in order to update this field.
	EnableDisplay interface{}
	// List of the type and count of accelerator cards attached to the instance. Structure documented below.
	// **Note:** GPU accelerators can only be used with `onHostMaintenance` option set to TERMINATE.
	GuestAccelerators interface{}
	// A custom hostname for the instance. Must be a fully qualified DNS name and RFC-1035-valid.
	// Valid format is a series of labels 1-63 characters long matching the regular expression `a-z`, concatenated with periods.
	// The entire hostname must not exceed 253 characters. Changing this forces a new resource to be created.
	Hostname interface{}
	// A map of key/value label pairs to assign to the instance.
	Labels interface{}
	// The machine type to create.
	MachineType interface{}
	// Metadata key/value pairs to make available from
	// within the instance. Ssh keys attached in the Cloud Console will be removed.
	// Add them to your config in order to keep them attached to your instance.
	Metadata interface{}
	// An alternative to using the
	// startup-script metadata key, except this one forces the instance to be
	// recreated (thus re-running the script) if it is changed. This replaces the
	// startup-script metadata key on the created instance and thus the two
	// mechanisms are not allowed to be used simultaneously.
	MetadataStartupScript interface{}
	// Specifies a minimum CPU platform for the VM instance. Applicable values are the friendly names of CPU platforms, such as
	// `Intel Haswell` or `Intel Skylake`. See the complete list [here](https://cloud.google.com/compute/docs/instances/specify-min-cpu-platform).
	// **Note**: `allowStoppingForUpdate` must be set to true in order to update this field.
	MinCpuPlatform interface{}
	// A unique name for the resource, required by GCE.
	// Changing this forces a new resource to be created.
	Name interface{}
	// Networks to attach to the instance. This can
	// be specified multiple times. Structure is documented below.
	NetworkInterfaces interface{}
	// The ID of the project in which the resource belongs. If it
	// is not provided, the provider project is used.
	Project interface{}
	// The scheduling strategy to use. More details about
	// this configuration option are detailed below.
	Scheduling interface{}
	// Scratch disks to attach to the instance. This can be
	// specified multiple times for multiple scratch disks. Structure is documented below.
	ScratchDisks interface{}
	// Service account to attach to the instance.
	// Structure is documented below.
	// **Note**: `allowStoppingForUpdate` must be set to true in order to update this field.
	ServiceAccount interface{}
	// Enable [Shielded VM](https://cloud.google.com/security/shielded-cloud/shielded-vm) on this instance. Shielded VM provides verifiable integrity to prevent against malware and rootkits. Defaults to disabled. Structure is documented below.
	// **Note**: `shieldedInstanceConfig` can only be used with boot images with shielded vm support. See the complete list [here](https://cloud.google.com/compute/docs/images#shielded-images).
	ShieldedInstanceConfig interface{}
	// A list of tags to attach to the instance.
	Tags interface{}
	// The zone that the machine should be created in.
	Zone interface{}
}
