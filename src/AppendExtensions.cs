namespace PolyhydraGames.RetroAchievements;

public static class AppendExtensionsAlphabet
{
    public static string A(this string url, bool value)
    {
        var val = value ? 1 : 0;
        return url.A(val);
    }
    public static string A(this string url, int value)
    {
        return url + $"&a={value}";
    }
    public static string M(this string url, int value)
    {
        return url + $"&m={value}";
    }

    public static string G(this string url, int value)
    {
        return url + $"&g={value}";
    }

    public static string F(this string url, int value)
    {
        return url + $"&f={value}";
    }
    public static string H(this string url, int value)
    {
        return url + $"&h={value}";
    }
    public static string H(this string url, bool value)
    {
        return url.H(value ? 1 : 0);
    }
    public static string F(this string url, bool value)
    {
        return url.F(value ? 1 : 0);
    }
    public static string I(this string url, string value)
    {
        return url + $"&i={value}";
    }

    public static string T(this string url, int value)
    {
        return url + $"&t={value}";
    }
}

public static class AppendExtensions
{
    public static int ToEpoch(this DateTime time)
    {
        var t = time.ToUniversalTime() - new DateTime(1970, 1, 1);
        int secondsSinceEpoch = (int)t.TotalSeconds;
        return secondsSinceEpoch;
    }

    // I
    public static string Id(this string url, int id)
    {

        return $"{url}&i={id}";
    }
    // I
    public static string Id(this string url, string id)
    {

        return $"{url}&i={id}";
    }

    public static string Type(this string url, int @type)
    {
        return $"{url}&t={type}";
    }

    // F
    public static string OfficialOnly(this string url, bool officialOnly)
    {
        var code = officialOnly ? "3" : "5";
        return $"{url}&f={code}";
    }

    public static string AllUnlocks(this string url, bool allUnlocks)
    {
        var value = allUnlocks ? "5" : "3";
        return $"{url}&h={value}";
    }
    public static string ParamBool(this string url, string param, bool value)
    {
        var result = value ? 1 : 0;
        return $"{url}&{param}={result}";
    }
    public static string ParamString(this string url, string param, string value)
    {
        return $"{url}&{param}={value}";
    }

    // Z
    public static string AuthUser(this string url, string? userName)
    {
        if (userName == null)
        {
            return url;
        }

        return $"{url}&z={userName}";
    }

    // Y
    public static string ApiKey(this string url, string? apiKey)
    {
        if (apiKey == null)
        {
            return url;
        }

        return $"{url}&y={apiKey}";
    }

    // O
    public static string Offset(this string url, int? offset)
    {
        return offset == null ? url : $"{url}&o={offset}";
    }

    // C
    public static string Count(this string url, int? count)
    {
        if (count == null)
        {
            return url;
        }

        return $"{url}&c={count}";
    }

    // G
    public static string GameID(this string url, string? gameId)
    {
        if (gameId == null)
        {
            return url;
        }

        return $"{url}&g={gameId}";
    }
    // G
    public static string GameID(this string url, int? gameId)
    {
        if (gameId == null)
        {
            return url;
        }

        return $"{url}&g={gameId}";
    }

    // T
    public static string Masters(this string url, bool master)
    {
        var value = master ? "1" : "0";

        return $"{url}t={value}";
    }

    // U
    public static string User(this string url, string? user)
    {
        if (user == null)
        {
            return url;
        }

        return $"{url}&u={user}";
    }

    // K
    public static string Kinds(this string url, string? kinds)
    {
        if (kinds == null)
        {
            return url;
        }

        return $"{url}&k={kinds}";
    }

    // D
    public static string Date(this string url, DateTime? date)
    {
        if (date == null)
        {
            return url;
        }

        return $"{url}&d={date:yyyy-MM-dd}";
    }
}
