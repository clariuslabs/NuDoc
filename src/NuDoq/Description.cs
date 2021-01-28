﻿using System.Collections.Generic;

namespace NuDoq
{
    /// <summary>
    /// Represents the <c>description</c> documentation tag.
    /// </summary>
    /// <remarks>
    /// See http://msdn.microsoft.com/en-US/library/y3ww3c7e(v=vs.80).aspx.
    /// </remarks>
    public class Description : Container
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Description"/> class.
        /// </summary>
        /// <param name="elements">The elements that make up the description.</param>
        /// <param name="attributes">The attributes of the element, if any.</param>
        public Description(IEnumerable<Element> elements, IDictionary<string, string> attributes)
            : base(elements, attributes)
        {
        }

        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        public override TVisitor Accept<TVisitor>(TVisitor visitor)
        {
            visitor.VisitDescription(this);
            return visitor;
        }

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        public override string ToString() => "<description>" + base.ToString();
    }
}