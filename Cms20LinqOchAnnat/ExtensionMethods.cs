using System.Collections.Generic;

namespace Cms20LinqOchAnnat;

public static class ExtensionMethods
{
    public static int CountLegends(this List<Player> sadasd)
    {
        int cnt = 0;
        foreach (var p in sadasd)
        {
            if (p.Name == "Auston Matthews")
                cnt++;
            if (p.Name == "Roman Josi")
                cnt++;
        }

        return cnt;
    }

}