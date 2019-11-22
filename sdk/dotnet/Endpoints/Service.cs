// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Endpoints
{
    /// <summary>
    /// This resource creates and rolls out a Cloud Endpoints service using OpenAPI or gRPC.  View the relevant docs for [OpenAPI](https://cloud.google.com/endpoints/docs/openapi/) and [gRPC](https://cloud.google.com/endpoints/docs/grpc/).
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-google/blob/master/website/docs/r/endpoints_service.html.markdown.
    /// </summary>
    public partial class Service : Pulumi.CustomResource
    {
        [Output("apis")]
        public Output<ImmutableArray<Outputs.ServiceApis>> Apis { get; private set; } = null!;

        [Output("configId")]
        public Output<string> ConfigId { get; private set; } = null!;

        [Output("dnsAddress")]
        public Output<string> DnsAddress { get; private set; } = null!;

        [Output("endpoints")]
        public Output<ImmutableArray<Outputs.ServiceEndpoints>> Endpoints { get; private set; } = null!;

        [Output("grpcConfig")]
        public Output<string?> GrpcConfig { get; private set; } = null!;

        [Output("openapiConfig")]
        public Output<string?> OpenapiConfig { get; private set; } = null!;

        [Output("project")]
        public Output<string> Project { get; private set; } = null!;

        [Output("protocOutputBase64")]
        public Output<string?> ProtocOutputBase64 { get; private set; } = null!;

        [Output("serviceName")]
        public Output<string> ServiceName { get; private set; } = null!;


        /// <summary>
        /// Create a Service resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Service(string name, ServiceArgs args, CustomResourceOptions? options = null)
            : base("gcp:endpoints/service:Service", name, args ?? ResourceArgs.Empty, MakeResourceOptions(options, ""))
        {
        }

        private Service(string name, Input<string> id, ServiceState? state = null, CustomResourceOptions? options = null)
            : base("gcp:endpoints/service:Service", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Service resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Service Get(string name, Input<string> id, ServiceState? state = null, CustomResourceOptions? options = null)
        {
            return new Service(name, id, state, options);
        }
    }

    public sealed class ServiceArgs : Pulumi.ResourceArgs
    {
        [Input("grpcConfig")]
        public Input<string>? GrpcConfig { get; set; }

        [Input("openapiConfig")]
        public Input<string>? OpenapiConfig { get; set; }

        [Input("project")]
        public Input<string>? Project { get; set; }

        [Input("protocOutputBase64")]
        public Input<string>? ProtocOutputBase64 { get; set; }

        [Input("serviceName", required: true)]
        public Input<string> ServiceName { get; set; } = null!;

        public ServiceArgs()
        {
        }
    }

    public sealed class ServiceState : Pulumi.ResourceArgs
    {
        [Input("apis")]
        private InputList<Inputs.ServiceApisGetArgs>? _apis;
        public InputList<Inputs.ServiceApisGetArgs> Apis
        {
            get => _apis ?? (_apis = new InputList<Inputs.ServiceApisGetArgs>());
            set => _apis = value;
        }

        [Input("configId")]
        public Input<string>? ConfigId { get; set; }

        [Input("dnsAddress")]
        public Input<string>? DnsAddress { get; set; }

        [Input("endpoints")]
        private InputList<Inputs.ServiceEndpointsGetArgs>? _endpoints;
        public InputList<Inputs.ServiceEndpointsGetArgs> Endpoints
        {
            get => _endpoints ?? (_endpoints = new InputList<Inputs.ServiceEndpointsGetArgs>());
            set => _endpoints = value;
        }

        [Input("grpcConfig")]
        public Input<string>? GrpcConfig { get; set; }

        [Input("openapiConfig")]
        public Input<string>? OpenapiConfig { get; set; }

        [Input("project")]
        public Input<string>? Project { get; set; }

        [Input("protocOutputBase64")]
        public Input<string>? ProtocOutputBase64 { get; set; }

        [Input("serviceName")]
        public Input<string>? ServiceName { get; set; }

        public ServiceState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class ServiceApisGetArgs : Pulumi.ResourceArgs
    {
        [Input("methods")]
        private InputList<ServiceApisMethodsGetArgs>? _methods;
        public InputList<ServiceApisMethodsGetArgs> Methods
        {
            get => _methods ?? (_methods = new InputList<ServiceApisMethodsGetArgs>());
            set => _methods = value;
        }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("syntax")]
        public Input<string>? Syntax { get; set; }

        [Input("version")]
        public Input<string>? Version { get; set; }

        public ServiceApisGetArgs()
        {
        }
    }

    public sealed class ServiceApisMethodsGetArgs : Pulumi.ResourceArgs
    {
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("requestType")]
        public Input<string>? RequestType { get; set; }

        [Input("responseType")]
        public Input<string>? ResponseType { get; set; }

        [Input("syntax")]
        public Input<string>? Syntax { get; set; }

        public ServiceApisMethodsGetArgs()
        {
        }
    }

    public sealed class ServiceEndpointsGetArgs : Pulumi.ResourceArgs
    {
        [Input("address")]
        public Input<string>? Address { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        public ServiceEndpointsGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class ServiceApis
    {
        public readonly ImmutableArray<ServiceApisMethods> Methods;
        public readonly string Name;
        public readonly string Syntax;
        public readonly string Version;

        [OutputConstructor]
        private ServiceApis(
            ImmutableArray<ServiceApisMethods> methods,
            string name,
            string syntax,
            string version)
        {
            Methods = methods;
            Name = name;
            Syntax = syntax;
            Version = version;
        }
    }

    [OutputType]
    public sealed class ServiceApisMethods
    {
        public readonly string Name;
        public readonly string RequestType;
        public readonly string ResponseType;
        public readonly string Syntax;

        [OutputConstructor]
        private ServiceApisMethods(
            string name,
            string requestType,
            string responseType,
            string syntax)
        {
            Name = name;
            RequestType = requestType;
            ResponseType = responseType;
            Syntax = syntax;
        }
    }

    [OutputType]
    public sealed class ServiceEndpoints
    {
        public readonly string Address;
        public readonly string Name;

        [OutputConstructor]
        private ServiceEndpoints(
            string address,
            string name)
        {
            Address = address;
            Name = name;
        }
    }
    }
}
