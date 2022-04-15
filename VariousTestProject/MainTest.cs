using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UtilityLibrary.Classes;
using VariousTestProject.Base;

namespace VariousTestProject
{
    [TestClass]
    public partial class MainTest : TestBase
    {
        [TestMethod]
        [TestTraits(Trait.FileOperations)]
        public void ProjectNamesTest()
        {
            // arrange
            List<string> expected = new()
            {
                "SwitchExpressions_efcore.csproj",
                "OracleNorthWindLibrary.csproj",
                "JsonLibrary.csproj",
                "ConfigurationLibrary.csproj"
            };
            
            string solutionName = "C:\\OED\\Dotnetland\\VS2019\\MasterClass\\MasterClass.sln";

            // act
            var (list, exception) = SolutionHelper.ProjectNames(solutionName);
            var fileNames = list.Select(Path.GetFileName).ToList();

            // assert
            Assert.IsTrue(!expected.Except(fileNames).Any());

        }

        [TestMethod]
        [TestTraits(Trait.PlaceHolder)]
        public void ListFilesNotTesting()
        {
            string solutionName = "C:\\OED\\Dotnetland\\VS2019\\MasterClass\\MasterClass.sln";
            var (list, exception) = SolutionHelper.ProjectNames(solutionName);

            foreach (var projectName in list.OrderBy(x => x))
            {
                Console.WriteLine(projectName.Replace("C:\\OED\\Dotnetland\\VS2019\\MasterClass\\", ""));
            }
        }


        [TestMethod]
        [TestTraits(Trait.FileOperations)]
        public void ProjectNamesInvalidTest()
        {
            // arrange

            string solutionName = "C:\\OED\\Dotnetland\\VS2019\\MasterClass\\DoesNotExists.sln";

            // act
            var ( _ , exception) = SolutionHelper.ProjectNames(solutionName);

            // assert
            Assert.IsNotNull(exception);

        }

    }
}
