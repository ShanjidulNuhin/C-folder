using System;

namespace OutputTracing
{
    // Declare a delegate for tracing output
    delegate void TraceDelegate(string message);

    class Program
    {
        // Method to trace messages to the console
        static void ConsoleTrace(string message)
        {
            Console.WriteLine($"Console Trace: {message}");
        }

        // Method to trace messages to a file (for simplicity, file path is hard-coded)
        static void FileTrace(string message)
        {
            string filePath = "output_trace.txt";
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(filePath, true))
            {
                file.WriteLine($"File Trace: {message}");
            }
        }

        static void Main(string[] args)
        {
            // Create delegate instances
            TraceDelegate traceToConsole = new TraceDelegate(ConsoleTrace);
            TraceDelegate traceToFile = new TraceDelegate(FileTrace);

            // Use the delegates to trace messages
            traceToConsole("This is a console trace message.");
            traceToFile("This is a file trace message.");

            // Combining delegates
            TraceDelegate multiTrace = traceToConsole + traceToFile;
            multiTrace("This message will be traced to both console and file.");

            Console.ReadKey();
        }
    }
}
