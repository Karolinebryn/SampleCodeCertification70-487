using NuGetPackageExample; //This is the package created in project NuGetPackageExample and .nupkg file is added to ~/Package folder in this project and installed using NuGet B-)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NuGetExample
{
    public class UsingThePackage
    {
        public UsingThePackage()
        {
            //YAAAAAAAAAAAAAAAAAS
            var calculator = new Calculator();
            var result1 = calculator.Add(4);
            var result2 = calculator.Substract(1);
        }
    }
}