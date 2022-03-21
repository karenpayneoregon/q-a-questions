using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDelegateEventAction.Classes
{
    public class Operations
    {
        public delegate void OnError(Exception sender);
        public static event OnError ErrorHandler;

        public delegate void OnProgress(int sender);
        public static event OnProgress Progress;

        public delegate void AddItem(string item);
        public static event AddItem OnAddItem;

        public static void InvokeError()
        {
            try
            {
                for (int index = 0; index < 20; index++)
                {
                    Progress?.Invoke(index);
                    if (index == 12)
                    {
                        throw new Exception("Intentional error");
                    }
                }
            }
            catch (Exception exception)
            {
                ErrorHandler?.Invoke(exception);
            }
        }

        public static async Task Load(int value)
        {
            var currentIndex = 0;

            while (currentIndex <= value - 1)
            {
                OnAddItem?.Invoke($"{currentIndex} item");
                currentIndex += 1;
                await Task.Delay(250);
            }
        }
    }
}
