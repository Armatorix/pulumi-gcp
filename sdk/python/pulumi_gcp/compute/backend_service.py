# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class BackendService(pulumi.CustomResource):
    affinity_cookie_ttl_sec: pulumi.Output[float]
    """
    Lifetime of cookies in seconds if session_affinity is GENERATED_COOKIE. If set to 0, the cookie is non-persistent and
    lasts only until the end of the browser session (or equivalent). The maximum allowed value for TTL is one day. When the
    load balancing scheme is INTERNAL, this field is not used.
    """
    backends: pulumi.Output[list]
    """
    The set of backends that serve this BackendService.

      * `balancingMode` (`str`)
      * `capacityScaler` (`float`)
      * `description` (`str`)
      * `group` (`str`)
      * `maxConnections` (`float`)
      * `maxConnectionsPerEndpoint` (`float`)
      * `maxConnectionsPerInstance` (`float`)
      * `maxRate` (`float`)
      * `maxRatePerEndpoint` (`float`)
      * `maxRatePerInstance` (`float`)
      * `maxUtilization` (`float`)
    """
    cdn_policy: pulumi.Output[dict]
    """
    Cloud CDN configuration for this BackendService.

      * `cacheKeyPolicy` (`dict`)
        * `includeHost` (`bool`)
        * `includeProtocol` (`bool`)
        * `includeQueryString` (`bool`)
        * `queryStringBlacklists` (`list`)
        * `queryStringWhitelists` (`list`)

      * `signedUrlCacheMaxAgeSec` (`float`)
    """
    circuit_breakers: pulumi.Output[dict]
    """
    Settings controlling the volume of connections to a backend service. This field is applicable only when the
    load_balancing_scheme is set to INTERNAL_SELF_MANAGED.

      * `connectTimeout` (`dict`)
        * `nanos` (`float`)
        * `seconds` (`float`)

      * `maxConnections` (`float`)
      * `maxPendingRequests` (`float`)
      * `maxRequests` (`float`)
      * `maxRequestsPerConnection` (`float`)
      * `maxRetries` (`float`)
    """
    connection_draining_timeout_sec: pulumi.Output[float]
    """
    Time for which instance will be drained (not accept new connections, but still work to finish started).
    """
    consistent_hash: pulumi.Output[dict]
    """
    Consistent Hash-based load balancing can be used to provide soft session affinity based on HTTP headers, cookies or
    other properties. This load balancing policy is applicable only for HTTP connections. The affinity to a particular
    destination host will be lost when one or more hosts are added/removed from the destination service. This field
    specifies parameters that control consistent hashing. This field only applies if the load_balancing_scheme is set to
    INTERNAL_SELF_MANAGED. This field is only applicable when locality_lb_policy is set to MAGLEV or RING_HASH.

      * `httpCookie` (`dict`)
        * `name` (`str`)
        * `path` (`str`)
        * `ttl` (`dict`)
          * `nanos` (`float`)
          * `seconds` (`float`)

      * `httpHeaderName` (`str`)
      * `minimumRingSize` (`float`)
    """
    creation_timestamp: pulumi.Output[str]
    """
    Creation timestamp in RFC3339 text format.
    """
    custom_request_headers: pulumi.Output[list]
    """
    Headers that the HTTP/S load balancer should add to proxied requests.
    """
    description: pulumi.Output[str]
    """
    An optional description of this resource.
    """
    enable_cdn: pulumi.Output[bool]
    """
    If true, enable Cloud CDN for this BackendService.
    """
    fingerprint: pulumi.Output[str]
    """
    Fingerprint of this resource. A hash of the contents stored in this object. This field is used in optimistic locking.
    """
    health_checks: pulumi.Output[str]
    """
    The set of URLs to the HttpHealthCheck or HttpsHealthCheck resource for health checking this BackendService. Currently
    at most one health check can be specified, and a health check is required. For internal load balancing, a URL to a
    HealthCheck resource must be specified instead.
    """
    iap: pulumi.Output[dict]
    """
    Settings for enabling Cloud Identity Aware Proxy

      * `oauth2ClientId` (`str`)
      * `oauth2ClientSecret` (`str`)
      * `oauth2ClientSecretSha256` (`str`)
    """
    load_balancing_scheme: pulumi.Output[str]
    """
    Indicates whether the backend service will be used with internal or external load balancing. A backend service created
    for one type of load balancing cannot be used with the other. Must be 'EXTERNAL' or 'INTERNAL_SELF_MANAGED' for a global
    backend service. Defaults to 'EXTERNAL'.
    """
    locality_lb_policy: pulumi.Output[str]
    """
    The load balancing algorithm used within the scope of the locality. The possible values are - ROUND_ROBIN - This is a
    simple policy in which each healthy backend is selected in round robin order. LEAST_REQUEST - An O(1) algorithm which
    selects two random healthy hosts and picks the host which has fewer active requests. RING_HASH - The ring/modulo hash
    load balancer implements consistent hashing to backends. The algorithm has the property that the addition/removal of a
    host from a set of N hosts only affects 1/N of the requests. RANDOM - The load balancer selects a random healthy host.
    ORIGINAL_DESTINATION - Backend host is selected based on the client connection metadata, i.e., connections are opened to
    the same address as the destination address of the incoming connection before the connection was redirected to the load
    balancer. MAGLEV - used as a drop in replacement for the ring hash load balancer. Maglev is not as stable as ring hash
    but has faster table lookup build times and host selection times. For more information about Maglev, refer to
    https://ai.google/research/pubs/pub44824 This field is applicable only when the load_balancing_scheme is set to
    INTERNAL_SELF_MANAGED.
    """
    log_config: pulumi.Output[dict]
    """
    This field denotes the logging options for the load balancer traffic served by this backend service. If logging is
    enabled, logs will be exported to Stackdriver.

      * `enable` (`bool`)
      * `sampleRate` (`float`)
    """
    name: pulumi.Output[str]
    """
    Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and
    comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression
    '[a-z]([-a-z0-9]*[a-z0-9])?' which means the first character must be a lowercase letter, and all following characters
    must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
    """
    outlier_detection: pulumi.Output[dict]
    """
    Settings controlling eviction of unhealthy hosts from the load balancing pool. This field is applicable only when the
    load_balancing_scheme is set to INTERNAL_SELF_MANAGED.

      * `baseEjectionTime` (`dict`)
        * `nanos` (`float`)
        * `seconds` (`float`)

      * `consecutiveErrors` (`float`)
      * `consecutiveGatewayFailure` (`float`)
      * `enforcingConsecutiveErrors` (`float`)
      * `enforcingConsecutiveGatewayFailure` (`float`)
      * `enforcingSuccessRate` (`float`)
      * `interval` (`dict`)
        * `nanos` (`float`)
        * `seconds` (`float`)

      * `maxEjectionPercent` (`float`)
      * `successRateMinimumHosts` (`float`)
      * `successRateRequestVolume` (`float`)
      * `successRateStdevFactor` (`float`)
    """
    port_name: pulumi.Output[str]
    """
    Name of backend port. The same name should appear in the instance groups referenced by this service. Required when the
    load balancing scheme is EXTERNAL.
    """
    project: pulumi.Output[str]
    """
    The ID of the project in which the resource belongs.
    If it is not provided, the provider project is used.
    """
    protocol: pulumi.Output[str]
    """
    The protocol this BackendService uses to communicate with backends. Possible values are HTTP, HTTPS, HTTP2, TCP, and
    SSL. The default is HTTP. **NOTE**: HTTP2 is only valid for beta HTTP/2 load balancer types and may result in errors if
    used with the GA API.
    """
    security_policy: pulumi.Output[str]
    """
    The security policy associated with this backend service.
    """
    self_link: pulumi.Output[str]
    """
    The URI of the created resource.
    """
    session_affinity: pulumi.Output[str]
    """
    Type of session affinity to use. The default is NONE. Session affinity is not applicable if the protocol is UDP.
    """
    timeout_sec: pulumi.Output[float]
    """
    How many seconds to wait for the backend before considering it a failed request. Default is 30 seconds. Valid range is
    [1, 86400].
    """
    def __init__(__self__, resource_name, opts=None, affinity_cookie_ttl_sec=None, backends=None, cdn_policy=None, circuit_breakers=None, connection_draining_timeout_sec=None, consistent_hash=None, custom_request_headers=None, description=None, enable_cdn=None, health_checks=None, iap=None, load_balancing_scheme=None, locality_lb_policy=None, log_config=None, name=None, outlier_detection=None, port_name=None, project=None, protocol=None, security_policy=None, session_affinity=None, timeout_sec=None, __props__=None, __name__=None, __opts__=None):
        """
        A Backend Service defines a group of virtual machines that will serve
        traffic for load balancing. This resource is a global backend service,
        appropriate for external load balancing or self-managed internal load balancing.
        For managed internal load balancing, use a regional backend service instead.

        Currently self-managed internal load balancing is only available in beta.


        To get more information about BackendService, see:

        * [API documentation](https://cloud.google.com/compute/docs/reference/v1/backendServices)
        * How-to Guides
            * [Official Documentation](https://cloud.google.com/compute/docs/load-balancing/http/backend-service)

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[float] affinity_cookie_ttl_sec: Lifetime of cookies in seconds if session_affinity is GENERATED_COOKIE. If set to 0, the cookie is non-persistent and
               lasts only until the end of the browser session (or equivalent). The maximum allowed value for TTL is one day. When the
               load balancing scheme is INTERNAL, this field is not used.
        :param pulumi.Input[list] backends: The set of backends that serve this BackendService.
        :param pulumi.Input[dict] cdn_policy: Cloud CDN configuration for this BackendService.
        :param pulumi.Input[dict] circuit_breakers: Settings controlling the volume of connections to a backend service. This field is applicable only when the
               load_balancing_scheme is set to INTERNAL_SELF_MANAGED.
        :param pulumi.Input[float] connection_draining_timeout_sec: Time for which instance will be drained (not accept new connections, but still work to finish started).
        :param pulumi.Input[dict] consistent_hash: Consistent Hash-based load balancing can be used to provide soft session affinity based on HTTP headers, cookies or
               other properties. This load balancing policy is applicable only for HTTP connections. The affinity to a particular
               destination host will be lost when one or more hosts are added/removed from the destination service. This field
               specifies parameters that control consistent hashing. This field only applies if the load_balancing_scheme is set to
               INTERNAL_SELF_MANAGED. This field is only applicable when locality_lb_policy is set to MAGLEV or RING_HASH.
        :param pulumi.Input[list] custom_request_headers: Headers that the HTTP/S load balancer should add to proxied requests.
        :param pulumi.Input[str] description: An optional description of this resource.
        :param pulumi.Input[bool] enable_cdn: If true, enable Cloud CDN for this BackendService.
        :param pulumi.Input[str] health_checks: The set of URLs to the HttpHealthCheck or HttpsHealthCheck resource for health checking this BackendService. Currently
               at most one health check can be specified, and a health check is required. For internal load balancing, a URL to a
               HealthCheck resource must be specified instead.
        :param pulumi.Input[dict] iap: Settings for enabling Cloud Identity Aware Proxy
        :param pulumi.Input[str] load_balancing_scheme: Indicates whether the backend service will be used with internal or external load balancing. A backend service created
               for one type of load balancing cannot be used with the other. Must be 'EXTERNAL' or 'INTERNAL_SELF_MANAGED' for a global
               backend service. Defaults to 'EXTERNAL'.
        :param pulumi.Input[str] locality_lb_policy: The load balancing algorithm used within the scope of the locality. The possible values are - ROUND_ROBIN - This is a
               simple policy in which each healthy backend is selected in round robin order. LEAST_REQUEST - An O(1) algorithm which
               selects two random healthy hosts and picks the host which has fewer active requests. RING_HASH - The ring/modulo hash
               load balancer implements consistent hashing to backends. The algorithm has the property that the addition/removal of a
               host from a set of N hosts only affects 1/N of the requests. RANDOM - The load balancer selects a random healthy host.
               ORIGINAL_DESTINATION - Backend host is selected based on the client connection metadata, i.e., connections are opened to
               the same address as the destination address of the incoming connection before the connection was redirected to the load
               balancer. MAGLEV - used as a drop in replacement for the ring hash load balancer. Maglev is not as stable as ring hash
               but has faster table lookup build times and host selection times. For more information about Maglev, refer to
               https://ai.google/research/pubs/pub44824 This field is applicable only when the load_balancing_scheme is set to
               INTERNAL_SELF_MANAGED.
        :param pulumi.Input[dict] log_config: This field denotes the logging options for the load balancer traffic served by this backend service. If logging is
               enabled, logs will be exported to Stackdriver.
        :param pulumi.Input[str] name: Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and
               comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression
               '[a-z]([-a-z0-9]*[a-z0-9])?' which means the first character must be a lowercase letter, and all following characters
               must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
        :param pulumi.Input[dict] outlier_detection: Settings controlling eviction of unhealthy hosts from the load balancing pool. This field is applicable only when the
               load_balancing_scheme is set to INTERNAL_SELF_MANAGED.
        :param pulumi.Input[str] port_name: Name of backend port. The same name should appear in the instance groups referenced by this service. Required when the
               load balancing scheme is EXTERNAL.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.
        :param pulumi.Input[str] protocol: The protocol this BackendService uses to communicate with backends. Possible values are HTTP, HTTPS, HTTP2, TCP, and
               SSL. The default is HTTP. **NOTE**: HTTP2 is only valid for beta HTTP/2 load balancer types and may result in errors if
               used with the GA API.
        :param pulumi.Input[str] security_policy: The security policy associated with this backend service.
        :param pulumi.Input[str] session_affinity: Type of session affinity to use. The default is NONE. Session affinity is not applicable if the protocol is UDP.
        :param pulumi.Input[float] timeout_sec: How many seconds to wait for the backend before considering it a failed request. Default is 30 seconds. Valid range is
               [1, 86400].

        The **backends** object supports the following:

          * `balancingMode` (`pulumi.Input[str]`)
          * `capacityScaler` (`pulumi.Input[float]`)
          * `description` (`pulumi.Input[str]`)
          * `group` (`pulumi.Input[str]`)
          * `maxConnections` (`pulumi.Input[float]`)
          * `maxConnectionsPerEndpoint` (`pulumi.Input[float]`)
          * `maxConnectionsPerInstance` (`pulumi.Input[float]`)
          * `maxRate` (`pulumi.Input[float]`)
          * `maxRatePerEndpoint` (`pulumi.Input[float]`)
          * `maxRatePerInstance` (`pulumi.Input[float]`)
          * `maxUtilization` (`pulumi.Input[float]`)

        The **cdn_policy** object supports the following:

          * `cacheKeyPolicy` (`pulumi.Input[dict]`)
            * `includeHost` (`pulumi.Input[bool]`)
            * `includeProtocol` (`pulumi.Input[bool]`)
            * `includeQueryString` (`pulumi.Input[bool]`)
            * `queryStringBlacklists` (`pulumi.Input[list]`)
            * `queryStringWhitelists` (`pulumi.Input[list]`)

          * `signedUrlCacheMaxAgeSec` (`pulumi.Input[float]`)

        The **circuit_breakers** object supports the following:

          * `connectTimeout` (`pulumi.Input[dict]`)
            * `nanos` (`pulumi.Input[float]`)
            * `seconds` (`pulumi.Input[float]`)

          * `maxConnections` (`pulumi.Input[float]`)
          * `maxPendingRequests` (`pulumi.Input[float]`)
          * `maxRequests` (`pulumi.Input[float]`)
          * `maxRequestsPerConnection` (`pulumi.Input[float]`)
          * `maxRetries` (`pulumi.Input[float]`)

        The **consistent_hash** object supports the following:

          * `httpCookie` (`pulumi.Input[dict]`)
            * `name` (`pulumi.Input[str]`)
            * `path` (`pulumi.Input[str]`)
            * `ttl` (`pulumi.Input[dict]`)
              * `nanos` (`pulumi.Input[float]`)
              * `seconds` (`pulumi.Input[float]`)

          * `httpHeaderName` (`pulumi.Input[str]`)
          * `minimumRingSize` (`pulumi.Input[float]`)

        The **iap** object supports the following:

          * `oauth2ClientId` (`pulumi.Input[str]`)
          * `oauth2ClientSecret` (`pulumi.Input[str]`)
          * `oauth2ClientSecretSha256` (`pulumi.Input[str]`)

        The **log_config** object supports the following:

          * `enable` (`pulumi.Input[bool]`)
          * `sampleRate` (`pulumi.Input[float]`)

        The **outlier_detection** object supports the following:

          * `baseEjectionTime` (`pulumi.Input[dict]`)
            * `nanos` (`pulumi.Input[float]`)
            * `seconds` (`pulumi.Input[float]`)

          * `consecutiveErrors` (`pulumi.Input[float]`)
          * `consecutiveGatewayFailure` (`pulumi.Input[float]`)
          * `enforcingConsecutiveErrors` (`pulumi.Input[float]`)
          * `enforcingConsecutiveGatewayFailure` (`pulumi.Input[float]`)
          * `enforcingSuccessRate` (`pulumi.Input[float]`)
          * `interval` (`pulumi.Input[dict]`)
            * `nanos` (`pulumi.Input[float]`)
            * `seconds` (`pulumi.Input[float]`)

          * `maxEjectionPercent` (`pulumi.Input[float]`)
          * `successRateMinimumHosts` (`pulumi.Input[float]`)
          * `successRateRequestVolume` (`pulumi.Input[float]`)
          * `successRateStdevFactor` (`pulumi.Input[float]`)
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            __props__['affinity_cookie_ttl_sec'] = affinity_cookie_ttl_sec
            __props__['backends'] = backends
            __props__['cdn_policy'] = cdn_policy
            __props__['circuit_breakers'] = circuit_breakers
            __props__['connection_draining_timeout_sec'] = connection_draining_timeout_sec
            __props__['consistent_hash'] = consistent_hash
            __props__['custom_request_headers'] = custom_request_headers
            __props__['description'] = description
            __props__['enable_cdn'] = enable_cdn
            if health_checks is None:
                raise TypeError("Missing required property 'health_checks'")
            __props__['health_checks'] = health_checks
            __props__['iap'] = iap
            __props__['load_balancing_scheme'] = load_balancing_scheme
            __props__['locality_lb_policy'] = locality_lb_policy
            __props__['log_config'] = log_config
            __props__['name'] = name
            __props__['outlier_detection'] = outlier_detection
            __props__['port_name'] = port_name
            __props__['project'] = project
            __props__['protocol'] = protocol
            __props__['security_policy'] = security_policy
            __props__['session_affinity'] = session_affinity
            __props__['timeout_sec'] = timeout_sec
            __props__['creation_timestamp'] = None
            __props__['fingerprint'] = None
            __props__['self_link'] = None
        super(BackendService, __self__).__init__(
            'gcp:compute/backendService:BackendService',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, affinity_cookie_ttl_sec=None, backends=None, cdn_policy=None, circuit_breakers=None, connection_draining_timeout_sec=None, consistent_hash=None, creation_timestamp=None, custom_request_headers=None, description=None, enable_cdn=None, fingerprint=None, health_checks=None, iap=None, load_balancing_scheme=None, locality_lb_policy=None, log_config=None, name=None, outlier_detection=None, port_name=None, project=None, protocol=None, security_policy=None, self_link=None, session_affinity=None, timeout_sec=None):
        """
        Get an existing BackendService resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[float] affinity_cookie_ttl_sec: Lifetime of cookies in seconds if session_affinity is GENERATED_COOKIE. If set to 0, the cookie is non-persistent and
               lasts only until the end of the browser session (or equivalent). The maximum allowed value for TTL is one day. When the
               load balancing scheme is INTERNAL, this field is not used.
        :param pulumi.Input[list] backends: The set of backends that serve this BackendService.
        :param pulumi.Input[dict] cdn_policy: Cloud CDN configuration for this BackendService.
        :param pulumi.Input[dict] circuit_breakers: Settings controlling the volume of connections to a backend service. This field is applicable only when the
               load_balancing_scheme is set to INTERNAL_SELF_MANAGED.
        :param pulumi.Input[float] connection_draining_timeout_sec: Time for which instance will be drained (not accept new connections, but still work to finish started).
        :param pulumi.Input[dict] consistent_hash: Consistent Hash-based load balancing can be used to provide soft session affinity based on HTTP headers, cookies or
               other properties. This load balancing policy is applicable only for HTTP connections. The affinity to a particular
               destination host will be lost when one or more hosts are added/removed from the destination service. This field
               specifies parameters that control consistent hashing. This field only applies if the load_balancing_scheme is set to
               INTERNAL_SELF_MANAGED. This field is only applicable when locality_lb_policy is set to MAGLEV or RING_HASH.
        :param pulumi.Input[str] creation_timestamp: Creation timestamp in RFC3339 text format.
        :param pulumi.Input[list] custom_request_headers: Headers that the HTTP/S load balancer should add to proxied requests.
        :param pulumi.Input[str] description: An optional description of this resource.
        :param pulumi.Input[bool] enable_cdn: If true, enable Cloud CDN for this BackendService.
        :param pulumi.Input[str] fingerprint: Fingerprint of this resource. A hash of the contents stored in this object. This field is used in optimistic locking.
        :param pulumi.Input[str] health_checks: The set of URLs to the HttpHealthCheck or HttpsHealthCheck resource for health checking this BackendService. Currently
               at most one health check can be specified, and a health check is required. For internal load balancing, a URL to a
               HealthCheck resource must be specified instead.
        :param pulumi.Input[dict] iap: Settings for enabling Cloud Identity Aware Proxy
        :param pulumi.Input[str] load_balancing_scheme: Indicates whether the backend service will be used with internal or external load balancing. A backend service created
               for one type of load balancing cannot be used with the other. Must be 'EXTERNAL' or 'INTERNAL_SELF_MANAGED' for a global
               backend service. Defaults to 'EXTERNAL'.
        :param pulumi.Input[str] locality_lb_policy: The load balancing algorithm used within the scope of the locality. The possible values are - ROUND_ROBIN - This is a
               simple policy in which each healthy backend is selected in round robin order. LEAST_REQUEST - An O(1) algorithm which
               selects two random healthy hosts and picks the host which has fewer active requests. RING_HASH - The ring/modulo hash
               load balancer implements consistent hashing to backends. The algorithm has the property that the addition/removal of a
               host from a set of N hosts only affects 1/N of the requests. RANDOM - The load balancer selects a random healthy host.
               ORIGINAL_DESTINATION - Backend host is selected based on the client connection metadata, i.e., connections are opened to
               the same address as the destination address of the incoming connection before the connection was redirected to the load
               balancer. MAGLEV - used as a drop in replacement for the ring hash load balancer. Maglev is not as stable as ring hash
               but has faster table lookup build times and host selection times. For more information about Maglev, refer to
               https://ai.google/research/pubs/pub44824 This field is applicable only when the load_balancing_scheme is set to
               INTERNAL_SELF_MANAGED.
        :param pulumi.Input[dict] log_config: This field denotes the logging options for the load balancer traffic served by this backend service. If logging is
               enabled, logs will be exported to Stackdriver.
        :param pulumi.Input[str] name: Name of the resource. Provided by the client when the resource is created. The name must be 1-63 characters long, and
               comply with RFC1035. Specifically, the name must be 1-63 characters long and match the regular expression
               '[a-z]([-a-z0-9]*[a-z0-9])?' which means the first character must be a lowercase letter, and all following characters
               must be a dash, lowercase letter, or digit, except the last character, which cannot be a dash.
        :param pulumi.Input[dict] outlier_detection: Settings controlling eviction of unhealthy hosts from the load balancing pool. This field is applicable only when the
               load_balancing_scheme is set to INTERNAL_SELF_MANAGED.
        :param pulumi.Input[str] port_name: Name of backend port. The same name should appear in the instance groups referenced by this service. Required when the
               load balancing scheme is EXTERNAL.
        :param pulumi.Input[str] project: The ID of the project in which the resource belongs.
               If it is not provided, the provider project is used.
        :param pulumi.Input[str] protocol: The protocol this BackendService uses to communicate with backends. Possible values are HTTP, HTTPS, HTTP2, TCP, and
               SSL. The default is HTTP. **NOTE**: HTTP2 is only valid for beta HTTP/2 load balancer types and may result in errors if
               used with the GA API.
        :param pulumi.Input[str] security_policy: The security policy associated with this backend service.
        :param pulumi.Input[str] self_link: The URI of the created resource.
        :param pulumi.Input[str] session_affinity: Type of session affinity to use. The default is NONE. Session affinity is not applicable if the protocol is UDP.
        :param pulumi.Input[float] timeout_sec: How many seconds to wait for the backend before considering it a failed request. Default is 30 seconds. Valid range is
               [1, 86400].

        The **backends** object supports the following:

          * `balancingMode` (`pulumi.Input[str]`)
          * `capacityScaler` (`pulumi.Input[float]`)
          * `description` (`pulumi.Input[str]`)
          * `group` (`pulumi.Input[str]`)
          * `maxConnections` (`pulumi.Input[float]`)
          * `maxConnectionsPerEndpoint` (`pulumi.Input[float]`)
          * `maxConnectionsPerInstance` (`pulumi.Input[float]`)
          * `maxRate` (`pulumi.Input[float]`)
          * `maxRatePerEndpoint` (`pulumi.Input[float]`)
          * `maxRatePerInstance` (`pulumi.Input[float]`)
          * `maxUtilization` (`pulumi.Input[float]`)

        The **cdn_policy** object supports the following:

          * `cacheKeyPolicy` (`pulumi.Input[dict]`)
            * `includeHost` (`pulumi.Input[bool]`)
            * `includeProtocol` (`pulumi.Input[bool]`)
            * `includeQueryString` (`pulumi.Input[bool]`)
            * `queryStringBlacklists` (`pulumi.Input[list]`)
            * `queryStringWhitelists` (`pulumi.Input[list]`)

          * `signedUrlCacheMaxAgeSec` (`pulumi.Input[float]`)

        The **circuit_breakers** object supports the following:

          * `connectTimeout` (`pulumi.Input[dict]`)
            * `nanos` (`pulumi.Input[float]`)
            * `seconds` (`pulumi.Input[float]`)

          * `maxConnections` (`pulumi.Input[float]`)
          * `maxPendingRequests` (`pulumi.Input[float]`)
          * `maxRequests` (`pulumi.Input[float]`)
          * `maxRequestsPerConnection` (`pulumi.Input[float]`)
          * `maxRetries` (`pulumi.Input[float]`)

        The **consistent_hash** object supports the following:

          * `httpCookie` (`pulumi.Input[dict]`)
            * `name` (`pulumi.Input[str]`)
            * `path` (`pulumi.Input[str]`)
            * `ttl` (`pulumi.Input[dict]`)
              * `nanos` (`pulumi.Input[float]`)
              * `seconds` (`pulumi.Input[float]`)

          * `httpHeaderName` (`pulumi.Input[str]`)
          * `minimumRingSize` (`pulumi.Input[float]`)

        The **iap** object supports the following:

          * `oauth2ClientId` (`pulumi.Input[str]`)
          * `oauth2ClientSecret` (`pulumi.Input[str]`)
          * `oauth2ClientSecretSha256` (`pulumi.Input[str]`)

        The **log_config** object supports the following:

          * `enable` (`pulumi.Input[bool]`)
          * `sampleRate` (`pulumi.Input[float]`)

        The **outlier_detection** object supports the following:

          * `baseEjectionTime` (`pulumi.Input[dict]`)
            * `nanos` (`pulumi.Input[float]`)
            * `seconds` (`pulumi.Input[float]`)

          * `consecutiveErrors` (`pulumi.Input[float]`)
          * `consecutiveGatewayFailure` (`pulumi.Input[float]`)
          * `enforcingConsecutiveErrors` (`pulumi.Input[float]`)
          * `enforcingConsecutiveGatewayFailure` (`pulumi.Input[float]`)
          * `enforcingSuccessRate` (`pulumi.Input[float]`)
          * `interval` (`pulumi.Input[dict]`)
            * `nanos` (`pulumi.Input[float]`)
            * `seconds` (`pulumi.Input[float]`)

          * `maxEjectionPercent` (`pulumi.Input[float]`)
          * `successRateMinimumHosts` (`pulumi.Input[float]`)
          * `successRateRequestVolume` (`pulumi.Input[float]`)
          * `successRateStdevFactor` (`pulumi.Input[float]`)
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["affinity_cookie_ttl_sec"] = affinity_cookie_ttl_sec
        __props__["backends"] = backends
        __props__["cdn_policy"] = cdn_policy
        __props__["circuit_breakers"] = circuit_breakers
        __props__["connection_draining_timeout_sec"] = connection_draining_timeout_sec
        __props__["consistent_hash"] = consistent_hash
        __props__["creation_timestamp"] = creation_timestamp
        __props__["custom_request_headers"] = custom_request_headers
        __props__["description"] = description
        __props__["enable_cdn"] = enable_cdn
        __props__["fingerprint"] = fingerprint
        __props__["health_checks"] = health_checks
        __props__["iap"] = iap
        __props__["load_balancing_scheme"] = load_balancing_scheme
        __props__["locality_lb_policy"] = locality_lb_policy
        __props__["log_config"] = log_config
        __props__["name"] = name
        __props__["outlier_detection"] = outlier_detection
        __props__["port_name"] = port_name
        __props__["project"] = project
        __props__["protocol"] = protocol
        __props__["security_policy"] = security_policy
        __props__["self_link"] = self_link
        __props__["session_affinity"] = session_affinity
        __props__["timeout_sec"] = timeout_sec
        return BackendService(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

