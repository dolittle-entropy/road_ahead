/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using Dolittle.Concepts;

namespace Concepts
{
    /// <summary>
    /// Represents a name
    /// </summary>
    public class Name : ConceptAs<string>
    {
        /// <summary>
        /// Implicitly convert a <see cref="string"/> to an <see cref="Name"/>
        /// </summary>
        /// <param name="name">String containing name</param>
        public static implicit operator Name(string name)
        {
            return new Name {  Value = name };
        }
    }
}