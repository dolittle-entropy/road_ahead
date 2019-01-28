/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using Dolittle.Concepts;

namespace Concepts
{
    /// <summary>
    /// Represents the concept of a label
    /// </summary>
    public class Label : ConceptAs<string>
    {
        /// <summary>
        /// Implicitly convert a <see cref="string"/> to a <see cref="Label"/>
        /// </summary>
        /// <param name="value">Label represented as <see cref="string"/></param>
        public static implicit operator Label(string value)
        {
            return new Label {Value = value};
        }
    }
}
