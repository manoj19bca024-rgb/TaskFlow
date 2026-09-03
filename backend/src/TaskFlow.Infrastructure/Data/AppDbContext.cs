using Microsoft.EntityFrameworkCore;

namespace TaskFlow.Infrastructure.Data;

public sealed class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
}