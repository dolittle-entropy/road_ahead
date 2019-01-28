/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/

using System.Collections.Generic;

namespace Read.Insight
{
    /// <summary>
    /// Represents a group for <see cref="Items"/> for a specific status
    /// </summary>
    public class StatusGroup
    {
        /// <summary>
        /// Gets or sets the title of the <see cref="StatusGroup"/>
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Item">items</see> for the <see cref="StatusGroup"/>
        /// </summary>
        public IEnumerable<Item> Items { get; set; }
    }
}