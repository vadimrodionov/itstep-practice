static void Main(string[] args)
{
    var mode = args.Length == 0
    ? String.Empty
    : OpenModes.ContainsKey(args[0])
    ? args[0]
    : "-h";



    OpenModes[mode](args);
}



static Dictionary<string, Action<string[]>> OpenModes => new Dictionary<string, Action<string[]>>()
{
{ String.Empty, OpenWithoutFile },
{ "-h", PrintHelp },
{ "-n", CreateFile },
{ "-o", OpenFile },
};



static void PrintHelp(string[] _) => Console.WriteLine("Справка");



static void PrintInvalidParametersMessage() =>
Console.WriteLine("Некорректные параметры: не указан путь к файлу для создания или открытия.");



static void OpenWithoutFile(string[] _)
{
    using MemoryStream memoryStream = new MemoryStream()
    OpenEditor(memoryStream);   
    Console.WriteLine("Редактор открыт без создания файла");

}



static void OpenFile(string[] args)
{
    if (args.Length > 1)
    {
        using FileStream fileStream = File.Open(args[1], FileMode.Open, FileAccess.ReadWrite);
        OpenEditor(fileStream);
    }
    else
        PrintInvalidParametersMessage();
}



static void CreateFile(string[] args)
{
    if (args.Length > 1)
    {
        using FileStream fileStream = File.Open(args[1], FileMode.CreateNew, FileAccess.ReadWrite);
        OpenEditor(fileStream);
    }
    else
        PrintInvalidParametersMessage();
}



static void OpenEditor(Stream underlyingStream)
{
    // edit text
}