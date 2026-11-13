using Microsoft.Win32;
using Variant09.Models;

namespace Variant09.Services;

/// TODO 10: Сохранение параметров зала в HKCU (HKEY_CURRENT_USER).

public static class RegistryHelper
{
    private const string RegistryPath = @"Software\SeatBooking\Hall";

    public static void SaveHallParams(Hall hall)
    {
        if (!OperatingSystem.IsWindows())
        {
            Console.WriteLine("[HKCU] Реестр Windows недоступен. Параметры сохранены в памяти.");
            return;
        }

        using var key = Registry.CurrentUser.CreateSubKey(RegistryPath);
        key.SetValue("Name", hall.Name);
        key.SetValue("Rows", hall.Rows);
        key.SetValue("Columns", hall.Columns);
    }

    public static Hall? LoadHallParams()
    {
        if (!OperatingSystem.IsWindows()) return null;

        using var key = Registry.CurrentUser.OpenSubKey(RegistryPath);
        if (key == null) return null;

        string name = key.GetValue("Name") as string ?? "Зал";
        int rows = (int)key.GetValue("Rows", 5);
        int columns = (int)key.GetValue("Columns", 5);

        return new Hall(name, rows, columns);
    }
}