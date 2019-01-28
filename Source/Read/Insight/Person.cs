/*---------------------------------------------------------------------------------------------
 *  Copyright (c) Dolittle. All rights reserved.
 *  Licensed under the MIT License. See LICENSE in the project root for license information.
 *--------------------------------------------------------------------------------------------*/
using System.Collections.Generic;
using Concepts;

namespace Read.Insight
{
    /// <summary>
    /// Represents a person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Gets or sets the 
        /// </summary>
        public Name Name {  get; set; }

        /// <summary>
        /// Gets or sets the <see cref="Email"/>
        /// </summary>
        public Email Email {  get; set; }
    }
}