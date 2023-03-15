using SampleFunctionApp.Fundamentals.Interfaces.Concepts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleFunctionApp.Fundamentals.Interfaces.IConcepts
{
    internal interface IProcessor : IConcept
    {
        // To specially indicate that a class or interface and the following branches will not store long-term any data, only pass it through the memory and memory paging files during execution.
        // examples of this is throughout the project. There are many aspects in common with this particular concept with an API.
    }
}
