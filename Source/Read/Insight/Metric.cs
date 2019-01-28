/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System;

namespace Read.Insight
{
    /// <summary>
    /// Represents a metric
    /// </summary>
    public class Metric
    {
        /// <summary>
        /// Gets or sets the <see cref="MetricType"/>
        /// </summary>
        public MetricType Type { get; set; }

        /// <summary>
        /// Gets or sets the target value
        /// </summary>
        public string Target { get; set; }

        /// <summary>
        /// Gets or sets the current value
        /// </summary>
        public string Current { get; set; }

        /// <summary>
        /// Gets or sets the date for the metric to be met
        /// </summary>
        public DateTimeOffset Date { get; set; }
    }
}