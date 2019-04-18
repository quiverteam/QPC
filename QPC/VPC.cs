//
// Defines some interfaces for VPC/VGC structures
//
using System;
using System.Collections.Generic;

namespace QPC.VPC
{
    //
    // These exist inside of other sections or in the root of the file
    // $SectionType "attribs" "moreattribs" {}
    //
    public abstract class Section
    {
        //
        // List of contained variables
        //
        public List<Variable> Variables { get; internal set; }

        //
        // List of child sections
        //
        public List<Section> Sections { get; internal set; }

        //
        // Conditional enabling or disabling this section
        //
        public string Condition { get; internal set; }

        //
        // Type of the section
        //
        public string Type { get; internal set; }

        //
        // A list of attributes that come after the section declaration
        //
        public List<string> Attributes { get; internal set; }
    }

    //
    // These exist inside of VPC sections or not
    // $MyVar "hi"
    //
    public abstract class Variable
    {
        //
        // Name corresponds with the type of parameter
        // typeof() should be used when casting however
        //
        public string Name { get; internal set; }

        //
        // Attributes are the values associated with the variable
        //
        public List<string> Attributes { get; internal set; }

        //
        // The condition of the expression exists at the end of the line
        // [$WIN32||$POSIX] is an example of an expression
        // You can evaluate this expression by setting inputs
        //
        public string Condition { get; internal set; }
    }
}