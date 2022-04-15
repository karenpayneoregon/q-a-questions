using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace UtilityLibrary.Classes
{
    public class SolutionHelper 
    {
        /// <summary>
        /// Returns project names from a solution file
        /// </summary>
        /// <param name="solutionName"></param>
        /// <returns></returns>
        public static (List<string> list, Exception exception) ProjectNames(string solutionName)
        {

            List<string> projectList = new();

            try
            {
                var content = File.ReadAllText(solutionName);

                var projReg = new Regex("Project\\(\"\\{[\\w-]*\\}\"\\) = \"([\\w _]*.*)\", \"(.*\\.(cs|vcx|vb)proj)\"", RegexOptions.Compiled);

                var matches = projReg.Matches(content).Cast<Match>();

                var projects = matches.Select(match => match.Groups[2].Value).ToList();
                for (var index = 0; index < projects.Count; ++index)
                {
                    if (!Path.IsPathRooted(projects[index]))
                    {
                        projects[index] = Path.Combine(path1: Path.GetDirectoryName(solutionName)!, path2: projects[index]);
                    }

                    projects[index] = Path.GetFullPath(projects[index]);
                    projectList.Add(Path.GetFileNameWithoutExtension(projects[index]));
                }

                return (projects, null);
            }
            catch (Exception ex)
            {
                return (null, ex);
            }


        }
        public static (List<string> list, Exception exception) ProjectFileNames(string solutionName)
        {

            List<string> projectList = new();

            try
            {
                var content = File.ReadAllText(solutionName);
                var projReg = new Regex("Project\\(\"\\{[\\w-]*\\}\"\\) = \"([\\w _]*.*)\", \"(.*\\.(cs|vcx|vb)proj)\"", RegexOptions.Compiled);

                var matches = projReg.Matches(content).Cast<Match>();

                var projects = matches.Select(match => match.Groups[2].Value).ToList();

                for (var index = 0; index < projects.Count; ++index)
                {
                    if (!Path.IsPathRooted(projects[index]))
                    {
                        projects[index] = Path.Combine(path1: Path.GetDirectoryName(solutionName)!, path2: projects[index]);
                    }
                    
                    projectList.Add(projects[index]);

                }

                return (projectList, null);
            }
            catch (Exception ex)
            {
                return (null, ex);
            }
        }
    }
}
