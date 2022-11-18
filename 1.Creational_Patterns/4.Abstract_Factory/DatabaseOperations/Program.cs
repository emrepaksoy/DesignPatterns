using DatabaseOperations;
using DatabaseOperations.Databases.Factory;

CustomOperation customOperation = new CustomOperation(new PostgreSQLDatabaseFactory());

customOperation.Add(2);
customOperation.RemoveById(3);

CustomOperation customOperation2 = new CustomOperation(new OracleDatabaseFactory());

customOperation2.RemoveById(3);

