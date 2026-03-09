using System;
using System.IO;
using System.Runtime.InteropServices;

class VoskTest {
    // Импорт функции из твоей нативной DLL
    [DllImport("libvosk.dll", CallingConvention = CallingConvention.Cdecl)]
    public static extern void vosk_set_log_level(int level);

    public static void Main() {
        string exeDir = AppDomain.CurrentDomain.BaseDirectory;
        string dllPath = Path.Combine(exeDir, "libvosk.dll");
        string modelPath = "model";

        Console.WriteLine($"[.NET Sharp Test] Running from: {exeDir}");

        // 1. Проверка наличия DLL в папке запуска
        if (!File.Exists(dllPath)) {
            Console.WriteLine($"ERROR: libvosk.dll not found in {exeDir}");
            Console.WriteLine("Please copy libvosk.dll and all runtime dependencies from the ZIP archive to this folder.");
            return;
        }

        // 2. Проверка пути к модели (без магии)
        if (!Directory.Exists(modelPath)) {
            Console.WriteLine($"ERROR: Model folder not found at: {Path.GetFullPath(modelPath)}");
            Console.WriteLine("Note: Explicit path is required. Auto-download is disabled.");
            return;
        }

        try {
            // Если мы здесь, пробуем вызвать API
            vosk_set_log_level(0);
            Console.WriteLine("SUCCESS: libvosk.dll loaded and Vosk API initialized!");
        } catch (Exception e) {
            Console.WriteLine($"FATAL ERROR: {e.Message}");
            if (e is BadImageFormatException) {
                Console.WriteLine("Check architecture: This DLL is UCRT64 (x64). Your .NET app must be x64.");
            }
        }
    }
}