using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneSignal.CSharp.SDK.Resources.Notifications
{
    public enum AndroidVisibilityEnum
    {
        Public = 1,
        Private = 0,
        Secret = -1
    }

    public enum IosBadgeTypeEnum
    {
        None,
        SetTo,
        Increase
    }

    public enum DelayedOptionEnum
    {
        TimeZone,
        LastActive,
        SendAfter
    }
}
