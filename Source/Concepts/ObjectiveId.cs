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
    public class ObjectiveId : ConceptAs<Guid>
    {
        /// <summary>
        /// Implicitly convert from a <see cref="Guid"/> to a <see cref="ObjectiveId"/>
        /// </summary>
        /// <param name="value"><see cref="Guid"/> representing the unique identifier</param>
        public static implicit operator ObjectiveId(Guid value)
        {
            return new ObjectiveId {Value = value};
        }
    }
}
