// Measure the time needed for loop to complete executing
DateTimeOffset start = DateTimeOffset.Now;
for (int i = 0; i < 1_000_000; i++)
{
    // Sleep for 10ms
    // Thread.Sleep(10);
}
DateTimeOffset now = DateTimeOffset.Now;

// Prepare the contents to be saved to desktop
string message = $"Loop took {now.Subtract(start).Milliseconds} ms to complete";
string outputPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
    "appOutput.txt");

// Save contents to a new file in desktop
try
{
    File.WriteAllText(outputPath, message);
}
catch (Exception e)
{
    Console.WriteLine($"Couldn't save output to file. Error: {e}");
}