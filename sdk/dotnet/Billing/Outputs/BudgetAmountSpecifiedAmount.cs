// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Gcp.Billing.Outputs
{

    [OutputType]
    public sealed class BudgetAmountSpecifiedAmount
    {
        public readonly string? CurrencyCode;
        public readonly int? Nanos;
        public readonly string? Units;

        [OutputConstructor]
        private BudgetAmountSpecifiedAmount(
            string? currencyCode,

            int? nanos,

            string? units)
        {
            CurrencyCode = currencyCode;
            Nanos = nanos;
            Units = units;
        }
    }
}
