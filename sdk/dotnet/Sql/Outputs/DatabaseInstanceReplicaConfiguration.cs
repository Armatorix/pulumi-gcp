// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Sql.Outputs
{

    [OutputType]
    public sealed class DatabaseInstanceReplicaConfiguration
    {
        /// <summary>
        /// PEM representation of the trusted CA's x509
        /// certificate.
        /// </summary>
        public readonly string? CaCertificate;
        /// <summary>
        /// PEM representation of the slave's x509
        /// certificate.
        /// </summary>
        public readonly string? ClientCertificate;
        /// <summary>
        /// PEM representation of the slave's private key. The
        /// corresponding public key in encoded in the `client_certificate`.
        /// </summary>
        public readonly string? ClientKey;
        /// <summary>
        /// The number of seconds
        /// between connect retries.
        /// </summary>
        public readonly int? ConnectRetryInterval;
        /// <summary>
        /// Path to a SQL file in GCS from which slave
        /// instances are created. Format is `gs://bucket/filename`.
        /// </summary>
        public readonly string? DumpFilePath;
        /// <summary>
        /// Specifies if the replica is the failover target.
        /// If the field is set to true the replica will be designated as a failover replica.
        /// If the master instance fails, the replica instance will be promoted as
        /// the new master instance.
        /// </summary>
        public readonly bool? FailoverTarget;
        /// <summary>
        /// Time in ms between replication
        /// heartbeats.
        /// </summary>
        public readonly int? MasterHeartbeatPeriod;
        /// <summary>
        /// Password for the replication connection.
        /// </summary>
        public readonly string? Password;
        public readonly string? SslCipher;
        /// <summary>
        /// Username for replication connection.
        /// </summary>
        public readonly string? Username;
        /// <summary>
        /// True if the master's common name
        /// value is checked during the SSL handshake.
        /// </summary>
        public readonly bool? VerifyServerCertificate;

        [OutputConstructor]
        private DatabaseInstanceReplicaConfiguration(
            string? caCertificate,

            string? clientCertificate,

            string? clientKey,

            int? connectRetryInterval,

            string? dumpFilePath,

            bool? failoverTarget,

            int? masterHeartbeatPeriod,

            string? password,

            string? sslCipher,

            string? username,

            bool? verifyServerCertificate)
        {
            CaCertificate = caCertificate;
            ClientCertificate = clientCertificate;
            ClientKey = clientKey;
            ConnectRetryInterval = connectRetryInterval;
            DumpFilePath = dumpFilePath;
            FailoverTarget = failoverTarget;
            MasterHeartbeatPeriod = masterHeartbeatPeriod;
            Password = password;
            SslCipher = sslCipher;
            Username = username;
            VerifyServerCertificate = verifyServerCertificate;
        }
    }
}
