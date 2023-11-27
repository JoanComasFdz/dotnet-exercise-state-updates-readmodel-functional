﻿using Microsoft.EntityFrameworkCore;

namespace system_reporter_v4;

public class DisconnectionsDBContext(DbContextOptions<DisconnectionsDBContext> options) : DbContext(options)
{
    public DbSet<Disconnection> Disconnections { get; set; }
}