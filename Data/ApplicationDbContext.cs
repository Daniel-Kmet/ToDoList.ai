using Microsoft.EntityFrameworkCore;

namespace ToDoList.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
    : DbContext(options)
{
}