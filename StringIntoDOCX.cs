using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

//request was
//give me a code on C# that can insert string into *.docx

class Program
{
    static void Main(string[] args)
    {
        // Open the existing Word document
        using (WordprocessingDocument doc = WordprocessingDocument.Open("input.docx", true))
        {
            // Get the main document part
            MainDocumentPart mainPart = doc.MainDocumentPart;

            // Get the document's body element
            Body body = mainPart.Document.Body;

            // Create a new paragraph with the text to insert
            Paragraph newParagraph = new Paragraph();
            Run run = new Run();
            Text text = new Text("This is the text that will be inserted into the document.");
            run.Append(text);
            newParagraph.Append(run);

            // Insert the new paragraph at the beginning of the document
            body.InsertAt(newParagraph, 0);

            // Save the changes to the document
            mainPart.Document.Save();
        }
    }
}