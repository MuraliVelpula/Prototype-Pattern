using System;

// Document class implementing ICloneable for deep copy
public class Document : ICloneable
{
    public string Title { get; set; } // Title of the document
    public string Content { get; set; } // Content of the document

    // Method to perform a deep copy using MemberwiseClone
    public object Clone()
    {
        return this.MemberwiseClone(); // Performs a shallow copy, but suitable for this example
    }

    // Method to display document details
    public void ShowDocument()
    {
        Console.WriteLine($"Title: {Title}"); // Outputs the document title
        Console.WriteLine($"Content: {Content}"); // Outputs the document content
    }
}

class Program
{
    static void Main()
    {
        // Create an initial document
        Document originalDoc = new Document
        {
            Title = "Original Document",
            Content = "This is the original document with complex content and formatting."
        };

        // Clone the original document (shallow copy for this example)
        Document clonedDoc = (Document)originalDoc.Clone();

        // Modify the cloned document
        clonedDoc.Title = "Cloned Document";
        clonedDoc.Content = "This is the cloned document with some modifications.";

        // Display both documents
        Console.WriteLine("Original Document:");
        originalDoc.ShowDocument(); // Shows details of the original document

        Console.WriteLine("\nCloned Document:");
        clonedDoc.ShowDocument(); // Shows details of the cloned document
    }
}
