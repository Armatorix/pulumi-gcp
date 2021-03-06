// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datacatalog

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Tags are used to attach custom metadata to Data Catalog resources. Tags conform to the specifications within their tag template.
//
// See [Data Catalog IAM](https://cloud.google.com/data-catalog/docs/concepts/iam) for information on the permissions needed to create or view tags.
//
// To get more information about Tag, see:
//
// * [API documentation](https://cloud.google.com/data-catalog/docs/reference/rest/v1/projects.locations.entryGroups.tags)
// * How-to Guides
//     * [Official Documentation](https://cloud.google.com/data-catalog/docs)
//
// ## Example Usage
type Tag struct {
	pulumi.CustomResourceState

	// Resources like Entry can have schemas associated with them. This scope allows users to attach tags to an
	// individual column based on that schema.
	// For attaching a tag to a nested column, use `.` to separate the column names. Example:
	// `outer_column.inner_column`
	Column pulumi.StringPtrOutput `pulumi:"column"`
	// This maps the ID of a tag field to the value of and additional information about that field.
	// Valid field IDs are defined by the tag's template. A tag must have at least 1 field and at most 500 fields.
	// Structure is documented below.
	Fields TagFieldArrayOutput `pulumi:"fields"`
	// The resource name of the tag in URL format. Example:
	// projects/{project_id}/locations/{location}/entrygroups/{entryGroupId}/entries/{entryId}/tags/{tag_id} or
	// projects/{project_id}/locations/{location}/entrygroups/{entryGroupId}/tags/{tag_id} where tag_id is a system-generated
	// identifier. Note that this Tag may not actually be stored in the location in this name.
	Name pulumi.StringOutput `pulumi:"name"`
	// The name of the parent this tag is attached to. This can be the name of an entry or an entry group. If an entry group, the tag will be attached to
	// all entries in that group.
	Parent pulumi.StringPtrOutput `pulumi:"parent"`
	// The resource name of the tag template that this tag uses. Example:
	// projects/{project_id}/locations/{location}/tagTemplates/{tagTemplateId}
	// This field cannot be modified after creation.
	Template pulumi.StringOutput `pulumi:"template"`
	// The display name of the tag template.
	TemplateDisplayname pulumi.StringOutput `pulumi:"templateDisplayname"`
}

// NewTag registers a new resource with the given unique name, arguments, and options.
func NewTag(ctx *pulumi.Context,
	name string, args *TagArgs, opts ...pulumi.ResourceOption) (*Tag, error) {
	if args == nil || args.Fields == nil {
		return nil, errors.New("missing required argument 'Fields'")
	}
	if args == nil || args.Template == nil {
		return nil, errors.New("missing required argument 'Template'")
	}
	if args == nil {
		args = &TagArgs{}
	}
	var resource Tag
	err := ctx.RegisterResource("gcp:datacatalog/tag:Tag", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetTag gets an existing Tag resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetTag(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *TagState, opts ...pulumi.ResourceOption) (*Tag, error) {
	var resource Tag
	err := ctx.ReadResource("gcp:datacatalog/tag:Tag", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Tag resources.
type tagState struct {
	// Resources like Entry can have schemas associated with them. This scope allows users to attach tags to an
	// individual column based on that schema.
	// For attaching a tag to a nested column, use `.` to separate the column names. Example:
	// `outer_column.inner_column`
	Column *string `pulumi:"column"`
	// This maps the ID of a tag field to the value of and additional information about that field.
	// Valid field IDs are defined by the tag's template. A tag must have at least 1 field and at most 500 fields.
	// Structure is documented below.
	Fields []TagField `pulumi:"fields"`
	// The resource name of the tag in URL format. Example:
	// projects/{project_id}/locations/{location}/entrygroups/{entryGroupId}/entries/{entryId}/tags/{tag_id} or
	// projects/{project_id}/locations/{location}/entrygroups/{entryGroupId}/tags/{tag_id} where tag_id is a system-generated
	// identifier. Note that this Tag may not actually be stored in the location in this name.
	Name *string `pulumi:"name"`
	// The name of the parent this tag is attached to. This can be the name of an entry or an entry group. If an entry group, the tag will be attached to
	// all entries in that group.
	Parent *string `pulumi:"parent"`
	// The resource name of the tag template that this tag uses. Example:
	// projects/{project_id}/locations/{location}/tagTemplates/{tagTemplateId}
	// This field cannot be modified after creation.
	Template *string `pulumi:"template"`
	// The display name of the tag template.
	TemplateDisplayname *string `pulumi:"templateDisplayname"`
}

type TagState struct {
	// Resources like Entry can have schemas associated with them. This scope allows users to attach tags to an
	// individual column based on that schema.
	// For attaching a tag to a nested column, use `.` to separate the column names. Example:
	// `outer_column.inner_column`
	Column pulumi.StringPtrInput
	// This maps the ID of a tag field to the value of and additional information about that field.
	// Valid field IDs are defined by the tag's template. A tag must have at least 1 field and at most 500 fields.
	// Structure is documented below.
	Fields TagFieldArrayInput
	// The resource name of the tag in URL format. Example:
	// projects/{project_id}/locations/{location}/entrygroups/{entryGroupId}/entries/{entryId}/tags/{tag_id} or
	// projects/{project_id}/locations/{location}/entrygroups/{entryGroupId}/tags/{tag_id} where tag_id is a system-generated
	// identifier. Note that this Tag may not actually be stored in the location in this name.
	Name pulumi.StringPtrInput
	// The name of the parent this tag is attached to. This can be the name of an entry or an entry group. If an entry group, the tag will be attached to
	// all entries in that group.
	Parent pulumi.StringPtrInput
	// The resource name of the tag template that this tag uses. Example:
	// projects/{project_id}/locations/{location}/tagTemplates/{tagTemplateId}
	// This field cannot be modified after creation.
	Template pulumi.StringPtrInput
	// The display name of the tag template.
	TemplateDisplayname pulumi.StringPtrInput
}

func (TagState) ElementType() reflect.Type {
	return reflect.TypeOf((*tagState)(nil)).Elem()
}

type tagArgs struct {
	// Resources like Entry can have schemas associated with them. This scope allows users to attach tags to an
	// individual column based on that schema.
	// For attaching a tag to a nested column, use `.` to separate the column names. Example:
	// `outer_column.inner_column`
	Column *string `pulumi:"column"`
	// This maps the ID of a tag field to the value of and additional information about that field.
	// Valid field IDs are defined by the tag's template. A tag must have at least 1 field and at most 500 fields.
	// Structure is documented below.
	Fields []TagField `pulumi:"fields"`
	// The name of the parent this tag is attached to. This can be the name of an entry or an entry group. If an entry group, the tag will be attached to
	// all entries in that group.
	Parent *string `pulumi:"parent"`
	// The resource name of the tag template that this tag uses. Example:
	// projects/{project_id}/locations/{location}/tagTemplates/{tagTemplateId}
	// This field cannot be modified after creation.
	Template string `pulumi:"template"`
}

// The set of arguments for constructing a Tag resource.
type TagArgs struct {
	// Resources like Entry can have schemas associated with them. This scope allows users to attach tags to an
	// individual column based on that schema.
	// For attaching a tag to a nested column, use `.` to separate the column names. Example:
	// `outer_column.inner_column`
	Column pulumi.StringPtrInput
	// This maps the ID of a tag field to the value of and additional information about that field.
	// Valid field IDs are defined by the tag's template. A tag must have at least 1 field and at most 500 fields.
	// Structure is documented below.
	Fields TagFieldArrayInput
	// The name of the parent this tag is attached to. This can be the name of an entry or an entry group. If an entry group, the tag will be attached to
	// all entries in that group.
	Parent pulumi.StringPtrInput
	// The resource name of the tag template that this tag uses. Example:
	// projects/{project_id}/locations/{location}/tagTemplates/{tagTemplateId}
	// This field cannot be modified after creation.
	Template pulumi.StringInput
}

func (TagArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*tagArgs)(nil)).Elem()
}
