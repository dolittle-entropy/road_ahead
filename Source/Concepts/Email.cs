/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using Dolittle.Concepts;

namespace Concepts
{
    /// <summary>
    /// Represents the concept of an email
    /// </summary>
    public class Email : ConceptAs<string>
    {
        /// <summary>
        /// Implicitly convert a <see cref="string"/> to an <see cref="Email"/>
        /// </summary>
        /// <param name="email">String containing email</param>
        public static implicit operator Email(string email)
        {
            return new Email {  Value = email };
        }
    }
}