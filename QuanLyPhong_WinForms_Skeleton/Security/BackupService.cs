using System;
using System.IO;

namespace QuanLyPhong_WinForms_Skeleton.Security;

public static class BackupService
{
    public static string Backup(string dbPath, string backupFolder)
    {
        Directory.CreateDirectory(backupFolder);
        var name = $"backup_{DateTime.Now:yyyyMMdd_HHmmss}.bak";
        var dest = Path.Combine(backupFolder, name);
        File.Copy(dbPath, dest, overwrite:true);
        return dest;
    }

    public static void Restore(string backupFile, string dbPath)
    {
        File.Copy(backupFile, dbPath, overwrite:true);
    }
}
