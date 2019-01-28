/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using Concepts;
using Dolittle.ReadModels;

namespace Read.Insight
{
    /// <summary>
    /// Represents a resource
    /// </summary>
    public class Resource : IReadModel
    {
        /// <summary>
        /// Gets or sets the Id
        /// </summary>
        public ResourceId Id { get; set; }

        /// <summary>
        /// Gets or sets the <see cref="ResourceType"/>
        /// </summary>
        public ResourceType Type { get; set; }

        /// <summary>
        /// Gets or sets the data associated with the <see cref="Resource"/>
        /// </summary>
        public string Data { get; set; }
    }
}