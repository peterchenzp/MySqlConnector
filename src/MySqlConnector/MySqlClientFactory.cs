using System.Data.Common;

namespace MySqlConnector
{
	public sealed class MySqlClientFactory : DbProviderFactory
	{
		public static readonly MySqlClientFactory Instance = new();

		public override DbCommand CreateCommand() => new MySqlCommand();
		public override DbConnection CreateConnection() => new MySqlConnection();
		public override DbConnectionStringBuilder CreateConnectionStringBuilder() => new MySqlConnectionStringBuilder();
		public override DbParameter CreateParameter() => new MySqlParameter();

#if !NETSTANDARD1_3
		public override DbCommandBuilder CreateCommandBuilder() => new MySqlCommandBuilder();
		public override DbDataAdapter CreateDataAdapter() => new MySqlDataAdapter();
#endif

		public MySqlBatch CreateBatch() => new MySqlBatch();
		public MySqlBatchCommand CreateBatchCommand() => new MySqlBatchCommand();
		public bool CanCreateBatch => true;

		private MySqlClientFactory()
		{
		}
	}
}
