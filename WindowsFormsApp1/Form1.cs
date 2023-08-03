using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Windows.Forms;

namespace ActiveDirectoryApp
{
    /// <summary>
    /// https://www.codemag.com/article/1312041/Using-Active-Directory-in-.NET
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            (IEnumerable<string> groups, Exception exception) = GetGroupsWindowsIdentity("paynek");

            if (exception == null)
            {
                File.WriteAllLines("groups.txt", groups);
            }
            else
            {
                MessageBox.Show($@"Encountered an issue\n{exception.Message}");
            }

        }

        private static (IEnumerable<string> list, Exception exception) GetGroupsWindowsIdentity(string userName)
        {
            var results = new List<string>();

            try
            {
                var wi = new WindowsIdentity(userName);

                if (wi.Groups != null)
                {
                    foreach (var group in wi.Groups)
                    {
                        try
                        {
                            results.Add(@group.Translate(typeof(NTAccount)).ToString());
                        }
                        catch (Exception ex)
                        {
                            throw new ApplicationException("Unable to query Active Directory.", ex);
                        }
                    }
                }
            }
            catch (Exception localException)
            {

                return (results, localException);
            }

            return (results, null);
        }

        private void GetAllUsers()
        {
            var list = new List<string>();

            SearchResultCollection results;
            DirectorySearcher ds = null;
            DirectoryEntry de = new DirectoryEntry(GetCurrentDomainPath());

            ds = new DirectorySearcher(de);
            ds.Filter = "(&(objectCategory=User)(objectClass=person))";

            results = ds.FindAll();

            foreach (SearchResult sr in results)
            {
                // Using the index zero (0) is required!
                list.Add(sr.Properties["name"][0].ToString());
            }

            File.WriteAllLines("All.txt", list);

        }
        private string GetCurrentDomainPath()
        {
            DirectoryEntry de = new DirectoryEntry("LDAP://RootDSE");

            return "LDAP://" + de.Properties["defaultNamingContext"][0].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GetAllUsers();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var list = ActiveDirectoryHelper.GetAllUserRealNamesFromAdGroup();
            foreach (var item in list)
            {
                Debug.WriteLine(item);
            }
        }

        /// <summary>
        /// Get-ADGroupMember -Identity "Web Team" | ConvertTo-json >all1.json
        /// </summary>
        private void button4_Click(object sender, EventArgs e)
        {
            var json = File.ReadAllText("all1.json");
            Employee[] employees = JsonConvert.DeserializeObject<Employee[]>(json);
            foreach (var employee in employees)
            {
                Debug.WriteLine($"{employee.Name,-30}{employee.SamAccountName,-20}{employee.DistinguishedName}");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var lines = File.ReadAllLines("all.txt")
                .Where(line => line.Contains("Business Intelligence"))
                .ToList();

            List<string> nameList = new List<string>();
            foreach (var line in lines)
            {
                nameList.Add(line.Replace("DistinguishedName : CN=", "").Split(',')[0]);
            }

            nameList.Sort();

            foreach (var s in nameList)
            {
                Console.WriteLine(s);
            }


        }
    }

    /// <summary>
    /// https://stackoverflow.com/questions/52838005/get-list-of-all-users-of-specific-activedirectorygroup
    /// </summary>
    public static class ActiveDirectoryHelper
    {
        public static List<string> GetAllUserRealNamesFromAdGroup(string directoryGroup = "OED\\Web Team")
        {
            var users = new List<string>();

            using (var context = new PrincipalContext(ContextType.Domain, "oed.state"))
            {
                using (var group = GroupPrincipal.FindByIdentity(context, directoryGroup))
                {
                    if (group != null)
                    {
                        var usersPrincipals = group.GetMembers(true);
                        foreach (var principal in usersPrincipals)
                        {
                            var user = (UserPrincipal)principal;
                            users.Add($"{user.GivenName} {user.Surname}\t{user.DistinguishedName}");
                            var groups = user.GetGroups();
                            Console.WriteLine(user.StructuralObjectClass);
                        }
                    }
                }
                return users;
            }
        }
    }


    public class Root
    {
        public Employee[] Property1 { get; set; }
    }

    public class Employee
    {
        public string SamAccountName { get; set; }
        public SID SID { get; set; }
        public string DistinguishedName { get; set; }
        public string Name { get; set; }
        public string ObjectClass { get; set; }
        public string ObjectGuid { get; set; }
        public string[] PropertyNames { get; set; }
        public object[] AddedProperties { get; set; }
        public object[] RemovedProperties { get; set; }
        public object[] ModifiedProperties { get; set; }
        public int PropertyCount { get; set; }
        public string distinguishedName { get; set; }
        public string name { get; set; }
        public string objectClass { get; set; }
        public string objectGUID { get; set; }
    }

    public class SID
    {
        public int BinaryLength { get; set; }
        public string AccountDomainSid { get; set; }
        public string Value { get; set; }
    }

}
