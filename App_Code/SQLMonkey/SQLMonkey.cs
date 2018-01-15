using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;


public class SQLMonkey
{
    public string connectionString { get; set; }

    public SQLMonkey(string connectionString)
    {
        this.connectionString = connectionString;
    }

    private void executeScalarQuery(string sqlQuery)
    {
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            var command = new SqlCommand(sqlQuery, connection);
            command.ExecuteScalar();
        }
    }

    public void insert<T>(T instance, string tableName)
    {
        var sqlQuery = SQLGeneration.generateInsertQuery<T>(instance, tableName);
        executeScalarQuery(sqlQuery);
    }

    public void update<T>(T instance, string tableName)
    {
        var sqlQuery = SQLGeneration.generateUpdateQuery<T>(instance, tableName);
        executeScalarQuery(sqlQuery);
    }

    public void delete<T>(T instance, string tableName)
    {
        var sqlQuery = SQLGeneration.generateDeleteQuery<T>(instance, tableName);
        executeScalarQuery(sqlQuery);
    }

    public IEnumerable<T> retrieve<T>(string tableName)
    {
        var sqlQuery = SQLGeneration.generateRetrieveQuery(tableName);
        using (var connection = new SqlConnection(connectionString))
        {
            connection.Open();
            var command = new SqlCommand(sqlQuery, connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var instance = (T)Activator.CreateInstance(typeof(T));
                    var propValuePairs = instance.GetType().GetProperties().Select(x => x.Name);

                    foreach (var prop in propValuePairs)
                    {
                        if (reader[prop] is DBNull)
                            continue;

                        instance.GetType().GetProperty(prop).SetValue(instance, reader[prop], null);
                    }

                    yield return instance;
                }
            }
        }
    }
}
