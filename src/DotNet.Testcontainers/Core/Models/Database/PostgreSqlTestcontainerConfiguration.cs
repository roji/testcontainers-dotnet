namespace DotNet.Testcontainers.Core.Models.Database
{
  public sealed class PostgreSqlTestcontainerConfiguration : TestcontainerDatabaseConfiguration
  {
    public PostgreSqlTestcontainerConfiguration() : base("postgres:11.2", 5432)
    {
    }

    public override string Database
    {
      get => this.Environments["POSTGRES_DB"];
      set => this.Environments["POSTGRES_DB"] = value;
    }

    public override string Username
    {
      get => this.Environments["POSTGRES_USER"];
      set => this.Environments["POSTGRES_USER"] = value;
    }

    public override string Password
    {
      get => this.Environments["POSTGRES_PASSWORD"];
      set => this.Environments["POSTGRES_PASSWORD"] = value;
    }
  }
}
