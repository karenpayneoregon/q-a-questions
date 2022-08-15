using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Resources;
using ChangeImage.Properties;

namespace ChangeImage.Classes
{
    public class ResourceHelpers
    {
        public static List<string> ByteArrayResourceNames()
        {

            try
            {

                var names = new List<string>();

                ResourceSet resourceSet = Resources
                    .ResourceManager
                    .GetResourceSet(CultureInfo.CurrentUICulture, true, true);

                names.AddRange(
                    from DictionaryEntry dictionaryEntry in resourceSet
                    where dictionaryEntry.Value is byte[]
                    select dictionaryEntry.Key.ToString());

                return names;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public static void Test()
        {
            List<ResourceByteItem> list = Resources.ResourceManager
                .GetResourceSet(CultureInfo.CurrentCulture, true, true)!
                .Cast<DictionaryEntry>()
                .Where(de => de.Value != null && de.Value.GetType() == typeof(byte[]))
                .Select(de => new ResourceByteItem(de.Key.ToString(), de.Value))
                .ToList();

        }

        public static void Interrogate()
        {
            foreach (var name in ByteArrayResourceNames())
            {
                Debug.WriteLine(name);
            }
        }


    }

    public class ResourceByteItem
    {
        public string Name { get; }
        public object Image { get; }

        public ResourceByteItem(string name, object image)
        {
            Name = name;
            Image = image;
        }
    }
}
