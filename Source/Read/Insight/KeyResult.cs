/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System.Collections.Generic;
using Dolittle.ReadModels;

namespace Read.Insight
{
    /// <summary>
    /// Represents a key result for an <see cref="Objective"/>
    /// </summary>
    public class KeyResult : IReadModel
    {
        /// <summary>
        /// Gets or sets the identifier from the origin system for the <see cref="KeyResult"/>
        /// </summary>
        public string OriginIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the title of the <see cref="KeyResult"/>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description of the <see cref="KeyResult"/>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the confidence level of the <see cref="KeyResult"/>
        /// </summary>
        public float Confidence { get; set; }

        /// <summary>
        /// Gets or sets the leaders of the <see cref="KeyResult"/>
        /// </summary>
        public IEnumerable<Person> LeadBy { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="StatusGroup">status groups</see> in the <see cref="KeyResult"/>
        /// </summary>
        public IEnumerable<StatusGroup> StatusGroups { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Metric">metrics</see> for the <see cref="KeyResult"/>
        /// </summary>
        public IEnumerable<Metric> Metrics { get; set; }
    }
}