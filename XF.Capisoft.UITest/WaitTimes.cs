using System;
using Xamarin.UITest.Utils;

namespace XF.Capisoft.UITest
{
    public class WaitTimes : IWaitTimes
    {
        public TimeSpan GestureWaitTimeout
        {
            get { return TimeSpan.FromMinutes(1); }
        }
        public TimeSpan WaitForTimeout
        {
            get { return TimeSpan.FromMinutes(1); }
        }

        public TimeSpan GestureCompletionTimeout
        {
            get { return TimeSpan.FromMinutes(1); }
        }
    }
}