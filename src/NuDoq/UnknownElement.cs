﻿using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace NuDoq
{
    /// <summary>
    /// An unsupported or unknown XML documentation element.
    /// </summary>
    public class UnknownElement : Container
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnknownElement"/> class.
        /// </summary>
        /// <param name="xml">The <see cref="XElement"/> containing the entire element markup.</param>
        /// <param name="content">The child content.</param>
        public UnknownElement(XElement xml, IEnumerable<Element> content)
            : base(content, new ReadOnlyDictionary<string, string>(new Dictionary<string, string>()))
            => Xml = xml;

        /// <summary>
        /// Gets the <see cref="XElement"/> containing the entire element markup.
        /// </summary>
        public XElement Xml { get; }

        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        public override TVisitor Accept<TVisitor>(TVisitor visitor)
        {
            visitor.VisitUnknownElement(this);
            return visitor;
        }

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        public override string ToString() => "unknown:<" + Xml.Name.LocalName + ">" + base.ToString();
    }
}