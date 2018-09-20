using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using NUnit.Framework;

namespace Metrics.Test
{
    [TestFixture]
    public class InstabilityTests
    {
        [Test]
        public void ShouldGetThisClassFromCurrentAssembly()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var classes = assembly.GetTypes().Select( x => x.FullName);

            CollectionAssert.Contains(classes, "Metrics.Test.InstabilityTests");
        }

        [Test]
        public void ShouldFindDependentClass()
        {
            var firstClass = new FirstClass();
            var dependentClasses = GetDependentClasses(firstClass.GetType());

            CollectionAssert.Contains(dependentClasses, "Metrics.Test.SecondClass");
        }

        private IEnumerable<string> GetDependentClasses(Type type)
        {
        }
    }
}
