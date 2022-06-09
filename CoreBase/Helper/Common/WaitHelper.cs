using System;
using System.Diagnostics;
using System.Threading;

namespace Re_Framework.CoreBase.Helper.Common
{
    public class WaitHelper
    {
        #region NaniWait Methods
        public static void NaniWait(
            Func<bool> condition,
            int sleepMilliseconds = 1000,
            int timeoutMilliseconds = 10000,
            string failureMessage = null)
        {
            var watch = new Stopwatch();
            watch.Start();

            while (true)
            {
                if (condition()) { return; }

                if (sleepMilliseconds > 0) { Thread.Sleep(sleepMilliseconds); }
                else
                {
                    throw new TimeoutException(
                            $"{sleepMilliseconds} milliseconds is not illegal");
                }

                if (watch.ElapsedMilliseconds > timeoutMilliseconds)
                {
                    if (failureMessage == null)
                    {
                        throw new TimeoutException(
                            $"Waited for {timeoutMilliseconds} milliseconds but failed");
                    }
                    else
                    {
                        throw new TimeoutException(
                                $"Waited for {failureMessage} for {timeoutMilliseconds} milliseconds but failed");
                    }
                }
            }
        }
    }
    #endregion
}
