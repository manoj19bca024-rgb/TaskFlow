# TaskFlow
TaskFlow app

## PostgreSQL

Start PostgreSQL in Docker:

```bash
cp .env.example .env
docker compose up -d postgres
```

The database is available at `localhost:5432` with the credentials in `.env`.
Data is persisted in the Docker volume `taskflow_postgres_data`.

Check the service:

```bash
docker compose ps
docker compose logs postgres
```

Stop PostgreSQL without deleting data:

```bash
docker compose down
```

To remove the database and its data, run `docker compose down -v`.

## Backend

The layered .NET backend is under `backend/` and currently targets .NET 10 because
that is the SDK available in this development container. Set the database connection
string before running the API:

```bash
export ConnectionStrings__TaskFlow='Host=localhost;Port=5432;Database=taskflow;Username=taskflow;Password=taskflow_dev_password'
dotnet run --project backend/src/TaskFlow.Api
```

The API health endpoint is available at `http://localhost:5000/health` when using
the HTTP launch profile.
