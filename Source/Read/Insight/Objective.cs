/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Collections.Generic;
using Concepts;
using Dolittle.ReadModels;

namespace Read.Insight
{
    /// <summary>
    /// Represents an objective
    /// </summary>
    public class Objective : IReadModel
    {
        /// <summary>
        /// Gets or sets the <see cref="ObjectiveId"/>
        /// </summary>
        public ObjectiveId Id { get; set; }

        /// <summary>
        /// Gets or sets the identifier from an originating system
        /// </summary>
        /// <value></value>
        public string OriginIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the title of the objective
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description of the objective
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets whether or not the objective is aspirational
        /// </summary>
        public bool Aspirational { get; set; }

        /// <summary>
        /// Gets or sets all the <see cref="KeyResult">key results</see> for the objective
        /// </summary>
        public IEnumerable<KeyResult> KeyResults { get; set; }

        /// <summary>
        /// Gets or sets all the <see cref="Resource">resources</see> for the objective
        /// </summary>
        public IEnumerable<Resource> Resources { get; set; }
    }
}