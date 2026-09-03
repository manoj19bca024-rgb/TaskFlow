# TaskFlow - Copilot Instructions

## Stack

- Backend: ASP.NET Core 8 Web API, EF Core Code-First, layered architecture
  (Api / Application / Domain / Infrastructure).
- Frontend: Angular standalone components, Reactive Forms, functional guards and interceptors.
- Database: PostgreSQL. Local deployment: Docker Compose.

## Conventions

- Keep controllers thin; business logic belongs in Application services.
- Use DTOs for API input and output; do not expose EF entities directly.
- New endpoints require `[Authorize]` with explicit roles unless intentionally public.
- Use dependency injection and explicit typed interfaces.
- Use PascalCase for C# types and members, camelCase for TypeScript, and kebab-case for Angular files and routes.
- Do not generate migrations unless explicitly requested.

## Roles

- Admin: full CRUD access to users, projects, and tasks.
- Member: access only to tasks assigned within projects they belong to.

## Security

- Never hardcode secrets or connection strings.
- Use environment variables in containers and user secrets for local development.