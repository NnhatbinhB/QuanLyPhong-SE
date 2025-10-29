using System;
using System.Collections.Concurrent;

namespace QuanLyPhong_WinForms_Skeleton.Security;

public static class OtpService
{
    private static readonly ConcurrentDictionary<string,(string code, DateTime exp)> store = new();

    public static string Generate(string username, int ttlMinutes = 5)
    {
        var code = new Random().Next(100000, 999999).ToString();
        store[username] = (code, DateTime.UtcNow.AddMinutes(ttlMinutes));
        return code;
    }

    public static bool Verify(string username, string code)
    {
        if (store.TryGetValue(username, out var entry))
        {
            if (DateTime.UtcNow <= entry.exp && entry.code == code) { store.TryRemove(username, out _); return true; }
        }
        return false;
    }
}
