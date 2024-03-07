﻿using App;

public static class Program
{
    public static async Task Main(string[] args)
    {
        

        // Call WorksWithBothStackAndHeap method
        MemoryUseCases.WorksWithBothStackAndHeap();

        // Call StringAsMemoryExtensionMethod method
        MemoryUseCases.StringAsMemoryExtensionMethod();

        // Call UseMemoryOwner method
        MemoryUseCases.UseMemoryOwner();

        // Call ProcessFileAsync method
        // Replace "your_file_path" with the path to the file you want to process
        await MemoryUseCases.ProcessFileAsync("./File.txt");
    }
}