/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using Dolittle.Concepts;
using System;

namespace Concepts
{
    /// <summary>
    /// Represents the concept of the unique identifier for a resource
    /// </summary>
    public class ResourceId : ConceptAs<Guid>
    {
        /// <summary>
        /// Implicitly convert from a <see cref="Guid"/> to a <see cref="ResourceId"/>
        /// </summary>
        /// <param name="value"><see cref="Guid"/> representing the unique identifier</param>
        public static implicit operator ResourceId(Guid value)
        {
            return new ResourceId {Value = value};
        }
    }
}
