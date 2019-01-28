/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System.Collections.Generic;
using Concepts;

namespace Read.Insight
{
    /// <summary>
    /// Represents an item for a <see cref="KeyResult"/>
    /// </summary>
    public class Item
    {
        /// <summary>
        /// Gets or sets the title
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets which system it originates from
        /// </summary>
        public string OriginSystem { get; set; }

        /// <summary>
        /// Gets or sets the identifier from the originating system
        /// </summary>
        public string OriginIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Label">labels</see>
        /// </summary>
        public IEnumerable<Label> Labels { get; set; }
    }
}