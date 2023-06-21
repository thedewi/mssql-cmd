using Microsoft.Data.SqlClient;

if (args.Length == 0) {
    Console.Error.WriteLine("Please supply a connection string.");
    return;
}

if (args.Length == 1)
{
    Console.Error.WriteLine("Please supply a query.");
    return;
}

using var db = new SqlConnection(args[0]);
using var cmd = new SqlCommand(args[1], db);
db.Open();
var rowsAffected = cmd.ExecuteNonQuery();
Console.WriteLine($"Query succeeded. Affected rows: {rowsAffected}");
