using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace FastFootApp.EntityFrameworkCore
{
    public static class FastFootAppDbContextConfigurer
    {
		public static void Configure(DbContextOptionsBuilder<FastFootAppDbContext> builder, string connectionString)
		{
			builder.UseSqlite(connectionString);
		}

		public static void Configure(DbContextOptionsBuilder<FastFootAppDbContext> builder, DbConnection connection)
		{
			builder.UseSqlite(connection);
		}
	}
}
