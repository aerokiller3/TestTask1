var path = "C:\\Users\\kiril\\source\\repos\\TestTask1\\TestTask2\\file.txt";
var text = "";

var connections1 = new List<Connection>();

using (var reader = new StreamReader(path, false))
{
    while (!reader.EndOfStream)
    {
        var line = reader.ReadLine();
        var lineResult = line.Replace("\"", " ").Split("   ");

        var connection = new Connection
        {
            Object = lineResult[0] + lineResult[1],
            ParentString = lineResult[2] + lineResult[3],
            Childrens = new List<Connection>()
        };

        connections1.Add(connection);

        foreach(var con in connections1)
        {
            if (con.Object.Trim().Equals(connection.ParentString.Trim()))
            {
                connection.Childrens.Add(con);
            }
        }
    }

    text = await reader.ReadToEndAsync();
}


foreach(var con1 in connections1)
{
    Show(con1, 0);
}

void Show(Connection con, int level)
{
    Console.WriteLine(new string(' ', level) + con.Object + " - " + con.ParentString);

    foreach (var item in con.Childrens)
    {
        Show(item, (level + 1) * 2);
    }
}

public class Connection
{
    public string ParentString { get; set; }
    public string Object { get; set; }
    public List<Connection> Childrens { get; set; }
}