using Document;

DocumentCreater[] documents = new DocumentCreater[2];
documents[0] = new Resume();
documents[1] = new Report();

foreach (DocumentCreater document in documents)
{
    Console.WriteLine("\n" + "--" + document.GetType().Name + "--");
    foreach (Page page in document.Pages)
    {
        Console.WriteLine(" " + page.GetType().Name);
    }
}