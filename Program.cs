using System;
using Variant09.Models;

namespace Variant09;

internal static class Program
{
    private static async Task Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("Зачётный проект 09: Система бронирования мест");
        Console.WriteLine(new string('=', 64));

        // TODO 1: Создать модель зала и свободных мест.
        var hall = new Hall("Кинозал 1", 5, 5);
        Console.WriteLine($"Создан зал: {hall.Name}");
        Console.WriteLine($"Размер: {hall.Rows} рядов × {hall.Columns} мест");
        Console.WriteLine($"Всего мест: {hall.Seats.Length}");

        // Вывод первых 5 мест для проверки
        Console.WriteLine("\nПервые 5 мест:");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"  {hall.Seats[i]} - {(hall.Seats[i].IsBooked ? "Занято" : "Свободно")}");
        }

        // Проверка получения места по ID
        var seat = hall.GetSeatById(7);
        if (seat != null)
        {
            Console.WriteLine($"\nПолучено место по ID=7: {seat}");
        }

        Console.WriteLine();
        Console.WriteLine("Нажмите Enter для завершения.");
        Console.ReadLine();

        await Task.CompletedTask;
    }
}

public sealed class ProjectService
{
    public async Task RunAsync()
    {
        // TODO: перенесите предметную логику в отдельные методы и классы.
        // TODO: не размещайте весь проект в Main.
        // TODO 1: Создать модель зала и свободных мест.
        // TODO 2: Реализовать бронирование и отмену.
        // TODO 3: Смоделировать конкурентную попытку забронировать одно место.
        // TODO 4: Защитить проверку и изменение статуса места одной критической секцией.
        // TODO 5: Ограничить число одновременных запросов.
        // TODO 6: Реализовать параллельную проверку занятости мест.
        // TODO 7: Добавить журнал бронирований.

        // TODO 8: Добавить очередь ожидания через Channel.
        // TODO 9: Сформировать статистику через LINQ/PLINQ.
        // TODO 10: Сохранять параметры зала в HKCU.

        Console.WriteLine("Стартовый проект собран. Реализуйте задания варианта.");
        await Task.CompletedTask;
    }
}
