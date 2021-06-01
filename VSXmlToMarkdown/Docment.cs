﻿using System;
using System.Xml.Serialization;
using System.Collections.Generic;


namespace VSXmlToMarkdown
{
    [XmlRoot(ElementName = "assembly")]
    public class Assembly
    {
        [XmlText]
        public string Text
        {
            get; set;
        }

        [XmlElement(ElementName = "name")]
        public string Name
        {
            get; set;
        }
    }

    [XmlRoot(ElementName = "member")]
    public class Member
    {
        [XmlText]
        public string Text
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "name")]
        public string Name
        {
            get; set;
        }
        [XmlElement(ElementName = "value")]
        public string Value
        {
            get; set;
        }
        [XmlElement(ElementName = "param")]
        public List<Param> Param
        {
            get; set;
        }
        [XmlElement(ElementName = "returns")]
        public Returns Returns
        {
            get; set;
        }

        [XmlElement(ElementName = "summary")]
        public Summary Summary
        {
            get; set;
        }
        [XmlElement(ElementName = "remarks")]
        public Remarks Remarks
        {
            get; set;
        }
        [XmlElement(ElementName = "example")]
        public Example Example
        {
            get; set;
        }
        [XmlElement(ElementName = "exception")]
        public Exceptionss Exception
        {
            get; set;
        }
    }

    [XmlRoot(ElementName = "returns")]
    public class Returns
    {

        [XmlElement(ElementName = "see")]
        public List<See> See
        {
            get; set;
        }
        [XmlElement(ElementName = "seealso")]
        public List<Seealso> Seealso
        {
            get; set;
        }

        [XmlText]
        public string Text
        {
            get; set;
        }
    }

    [XmlRoot(ElementName = "param")]
    public class Param
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name
        {
            get; set;
        }
        [XmlText]
        public string Text
        {
            get; set;
        }

        [XmlElement(ElementName = "see")]
        public See See
        {
            get; set;
        }

        [XmlElement(ElementName = "seealso")]
        public Seealso Seealso
        {
            get; set;
        }
    }

    [XmlRoot(ElementName = "summary")]
    public class Summary
    {
        [XmlText]
        public string Text
        {
            get; set;
        }

        [XmlElement(ElementName = "para")]
        public string Para
        {
            get; set;
        }
        [XmlElement(ElementName = "obsolete")]
        public string Obsolete
        {
            get; set;
        }

        [XmlElement(ElementName = "group")]
        public string Group
        {
            get; set;
        }

    }

    [XmlRoot(ElementName = "paramref")]
    public class Paramref
    {
        [XmlAttribute(AttributeName = "name")]
        public string Name
        {
            get; set;
        }

        [XmlText]
        public string Text
        {
            get; set;
        }
    }

    [XmlRoot(ElementName = "see")]
    public class See
    {
        [XmlAttribute(AttributeName = "cref")]
        public string Cref
        {
            get; set;
        }

        [XmlText]
        public string Text
        {
            get; set;
        }
    }

    [XmlRoot(ElementName = "seealso")]
    public class Seealso
    {
        [XmlText]
        public string Text
        {
            get; set;
        }

        [XmlAttribute(AttributeName = "cref")]
        public string Cref
        {
            get; set;
        }
    }

    [XmlRoot(ElementName = "remarks")]
    public class Remarks
    {
        [XmlText]
        public List<string> Text
        {
            get; set;
        }

        [XmlElement(ElementName = "paramref")]
        public Paramref Paramref
        {
            get; set;
        }
        [XmlElement(ElementName = "see")]
        public List<See> See
        {
            get; set;
        }
        [XmlElement(ElementName = "seealso")]
        public List<Seealso> Seealso
        {
            get; set;
        }
    }

    [XmlRoot(ElementName = "example")]
    public class Example
    {
        [XmlElement(ElementName = "code")]
        public string Code
        {
            get; set;
        }
        [XmlElement(ElementName = "c")]
        public string C
        {
            get; set;
        }

        [XmlText]
        public string Text
        {
            get; set;
        }
    }

    [XmlRoot(ElementName = "exception")]
    public class Exceptionss
    {
        [XmlAttribute(AttributeName = "cref")]
        public string Cref
        {
            get; set;
        }
        [XmlText]
        public string Text
        {
            get; set;
        }

        [XmlElement(ElementName = "see")]
        public List<See> See
        {
            get; set;
        }
        [XmlElement(ElementName = "seealso")]
        public List<Seealso> Seealso
        {
            get; set;
        }
    }

    [XmlRoot(ElementName = "members")]
    public class Members
    {
        [XmlElement(ElementName = "member")]
        public List<Member> Member
        {
            get; set;
        }

        [XmlText]
        public string Text
        {
            get; set;
        }
    }

    [XmlRoot(ElementName = "doc")]
    public class Doc
    {
        [XmlElement(ElementName = "assembly")]
        public Assembly Assembly
        {
            get; set;
        }
        [XmlElement(ElementName = "members")]
        public Members Members
        {
            get; set;
        }

        [XmlText]
        public string Text
        {
            get; set;
        }
    }

    public class Catelog
    {

        public string catelog
        {
            get;set;
        }

        public string filename
        {
            get;
            set;
        }

        public string Obsolete
        {
            get; set;
        }

        public string ObsoleteText
        {
            get; set;
        }

        public string Group
        {
            get; set;
        }
        public string Intr
        {
            get; set;
        }
    }
}
