// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Dataproc.Inputs
{

    public sealed class ClusterClusterConfigSecurityConfigKerberosConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The admin server (IP or hostname) for the
        /// remote trusted realm in a cross realm trust relationship.
        /// </summary>
        [Input("crossRealmTrustAdminServer")]
        public Input<string>? CrossRealmTrustAdminServer { get; set; }

        /// <summary>
        /// The KDC (IP or hostname) for the
        /// remote trusted realm in a cross realm trust relationship.
        /// </summary>
        [Input("crossRealmTrustKdc")]
        public Input<string>? CrossRealmTrustKdc { get; set; }

        /// <summary>
        /// The remote realm the Dataproc on-cluster KDC will
        /// trust, should the user enable cross realm trust.
        /// </summary>
        [Input("crossRealmTrustRealm")]
        public Input<string>? CrossRealmTrustRealm { get; set; }

        /// <summary>
        /// The Cloud Storage URI of a KMS
        /// encrypted file containing the shared password between the on-cluster Kerberos realm
        /// and the remote trusted realm, in a cross realm trust relationship.
        /// </summary>
        [Input("crossRealmTrustSharedPasswordUri")]
        public Input<string>? CrossRealmTrustSharedPasswordUri { get; set; }

        /// <summary>
        /// Flag to indicate whether to Kerberize the cluster.
        /// </summary>
        [Input("enableKerberos")]
        public Input<bool>? EnableKerberos { get; set; }

        /// <summary>
        /// The Cloud Storage URI of a KMS encrypted file containing
        /// the master key of the KDC database.
        /// </summary>
        [Input("kdcDbKeyUri")]
        public Input<string>? KdcDbKeyUri { get; set; }

        /// <summary>
        /// The Cloud Storage URI of a KMS encrypted file containing
        /// the password to the user provided key. For the self-signed certificate, this password
        /// is generated by Dataproc.
        /// </summary>
        [Input("keyPasswordUri")]
        public Input<string>? KeyPasswordUri { get; set; }

        /// <summary>
        /// The Cloud Storage URI of a KMS encrypted file containing
        /// the password to the user provided keystore. For the self-signed certificated, the password
        /// is generated by Dataproc.
        /// </summary>
        [Input("keystorePasswordUri")]
        public Input<string>? KeystorePasswordUri { get; set; }

        /// <summary>
        /// The Cloud Storage URI of the keystore file used for SSL encryption.
        /// If not provided, Dataproc will provide a self-signed certificate.
        /// </summary>
        [Input("keystoreUri")]
        public Input<string>? KeystoreUri { get; set; }

        /// <summary>
        /// The URI of the KMS key used to encrypt various sensitive files.
        /// </summary>
        [Input("kmsKeyUri", required: true)]
        public Input<string> KmsKeyUri { get; set; } = null!;

        /// <summary>
        /// The name of the on-cluster Kerberos realm. If not specified, the
        /// uppercased domain of hostnames will be the realm.
        /// </summary>
        [Input("realm")]
        public Input<string>? Realm { get; set; }

        /// <summary>
        /// The Cloud Storage URI of a KMS encrypted file
        /// containing the root principal password.
        /// </summary>
        [Input("rootPrincipalPasswordUri", required: true)]
        public Input<string> RootPrincipalPasswordUri { get; set; } = null!;

        /// <summary>
        /// The lifetime of the ticket granting ticket, in hours.
        /// </summary>
        [Input("tgtLifetimeHours")]
        public Input<int>? TgtLifetimeHours { get; set; }

        /// <summary>
        /// The Cloud Storage URI of a KMS encrypted file
        /// containing the password to the user provided truststore. For the self-signed
        /// certificate, this password is generated by Dataproc.
        /// </summary>
        [Input("truststorePasswordUri")]
        public Input<string>? TruststorePasswordUri { get; set; }

        /// <summary>
        /// The Cloud Storage URI of the truststore file used for
        /// SSL encryption. If not provided, Dataproc will provide a self-signed certificate.
        /// </summary>
        [Input("truststoreUri")]
        public Input<string>? TruststoreUri { get; set; }

        public ClusterClusterConfigSecurityConfigKerberosConfigArgs()
        {
        }
    }
}
