Imports System
Imports System.Collections.Generic
Imports Microsoft.EntityFrameworkCore

Namespace Models
    Partial Public Class BaseContext
        Inherits DbContext

        Public Sub New()
        End Sub

        Public Sub New(options As DbContextOptions(Of BaseContext))
            MyBase.New(options)
        End Sub
        Public Overridable Property CiudadDTOs As DbSet(Of CiudadDTO)

        Public Overridable Property Ciudads As DbSet(Of Ciudad)

        Public Overridable Property Pais As DbSet(Of Pai)

        Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
            'TODO /!\ To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
            optionsBuilder.UseSqlServer("Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=base10;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False")
        End Sub

        Protected Overrides Sub OnModelCreating(modelBuilder As ModelBuilder)
            modelBuilder.Entity(Of Ciudad)(
                Sub(entity)
                    entity.HasKey(Function(e) e.Id).HasName("PK__tmp_ms_x__3214EC07FF315DF3")

                    entity.ToTable("Ciudad")

                    entity.Property(Function(e) e.Nombre).
                        HasMaxLength(50).
                        IsUnicode(False)

                    entity.HasOne(Function(d) d.IdPaisNavigation).WithMany(Function(p) p.Ciudads).
                        HasForeignKey(Function(d) d.IdPais).
                        HasConstraintName("FK_Ciudad_ToTable")
                End Sub)

            modelBuilder.Entity(Of Pai)(
                Sub(entity)
                    entity.HasKey(Function(e) e.Id).HasName("PK__Pais__3214EC07E5407F54")

                    entity.Property(Function(e) e.Nombre).
                        HasMaxLength(50).
                        IsUnicode(False)
                End Sub)

            OnModelCreatingPartial(modelBuilder)
        End Sub

        Partial Private Sub OnModelCreatingPartial(modelBuilder As ModelBuilder)
        End Sub
    End Class
End Namespace
