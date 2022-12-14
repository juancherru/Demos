// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MusicStoreMVC.Data;

#nullable disable

namespace MusicStoreMVC.Migrations
{
    [DbContext(typeof(MusicStoreMVCContext))]
    [Migration("20220913192341_Album")]
    partial class Album
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("MusicStoreMVC.Models.Album", b =>
                {
                    b.Property<long>("AlbumId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("ArtistId")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("Column1")
                        .HasColumnType("BLOB");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(160)");

                    b.HasKey("AlbumId");

                    b.HasIndex(new[] { "ArtistId" }, "IFK_AlbumArtistId");

                    b.HasIndex(new[] { "AlbumId" }, "IPK_Album")
                        .IsUnique();

                    b.ToTable("Album", (string)null);
                });

            modelBuilder.Entity("MusicStoreMVC.Models.Artist", b =>
                {
                    b.Property<long>("ArtistId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(120)");

                    b.HasKey("ArtistId");

                    b.HasIndex(new[] { "ArtistId" }, "IPK_Artist")
                        .IsUnique();

                    b.ToTable("Artist", (string)null);
                });

            modelBuilder.Entity("MusicStoreMVC.Models.Customer", b =>
                {
                    b.Property<long>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("NVARCHAR(70)");

                    b.Property<string>("City")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("Company")
                        .HasColumnType("NVARCHAR(80)");

                    b.Property<string>("Country")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(60)");

                    b.Property<string>("Fax")
                        .HasColumnType("NVARCHAR(24)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("Phone")
                        .HasColumnType("NVARCHAR(24)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("NVARCHAR(10)");

                    b.Property<string>("State")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<long?>("SupportRepId")
                        .HasColumnType("INTEGER");

                    b.HasKey("CustomerId");

                    b.HasIndex(new[] { "SupportRepId" }, "IFK_CustomerSupportRepId");

                    b.HasIndex(new[] { "CustomerId" }, "IPK_Customer")
                        .IsUnique();

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("MusicStoreMVC.Models.Employee", b =>
                {
                    b.Property<long>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Address")
                        .HasColumnType("NVARCHAR(70)");

                    b.Property<byte[]>("BirthDate")
                        .HasColumnType("DATETIME");

                    b.Property<string>("City")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("Country")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("Email")
                        .HasColumnType("NVARCHAR(60)");

                    b.Property<string>("Fax")
                        .HasColumnType("NVARCHAR(24)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<byte[]>("HireDate")
                        .HasColumnType("DATETIME");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("Phone")
                        .HasColumnType("NVARCHAR(24)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("NVARCHAR(10)");

                    b.Property<long?>("ReportsTo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("State")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("Title")
                        .HasColumnType("NVARCHAR(30)");

                    b.HasKey("EmployeeId");

                    b.HasIndex(new[] { "ReportsTo" }, "IFK_EmployeeReportsTo");

                    b.HasIndex(new[] { "EmployeeId" }, "IPK_Employee")
                        .IsUnique();

                    b.ToTable("Employee", (string)null);
                });

            modelBuilder.Entity("MusicStoreMVC.Models.EmpView", b =>
                {
                    b.Property<string>("Address")
                        .HasColumnType("NVARCHAR(70)");

                    b.Property<byte[]>("BirthDate")
                        .HasColumnType("DATETIME");

                    b.Property<string>("City")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("Country")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("Email")
                        .HasColumnType("NVARCHAR(60)");

                    b.Property<long?>("EmployeeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Fax")
                        .HasColumnType("NVARCHAR(24)");

                    b.Property<string>("FirstName")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<byte[]>("HireDate")
                        .HasColumnType("DATETIME");

                    b.Property<string>("LastName")
                        .HasColumnType("NVARCHAR(20)");

                    b.Property<string>("Phone")
                        .HasColumnType("NVARCHAR(24)");

                    b.Property<string>("PostalCode")
                        .HasColumnType("NVARCHAR(10)");

                    b.Property<long?>("ReportsTo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("State")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("Title")
                        .HasColumnType("NVARCHAR(30)");

                    b.ToView("EmpView");
                });

            modelBuilder.Entity("MusicStoreMVC.Models.Foo", b =>
                {
                    b.Property<long?>("Bar")
                        .HasColumnType("int")
                        .HasColumnName("bar");

                    b.Property<string>("Baz")
                        .HasColumnType("varchar(20)")
                        .HasColumnName("baz");

                    b.ToTable("foo", (string)null);
                });

            modelBuilder.Entity("MusicStoreMVC.Models.Genre", b =>
                {
                    b.Property<long>("GenreId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(120)");

                    b.HasKey("GenreId");

                    b.HasIndex(new[] { "GenreId" }, "IPK_Genre")
                        .IsUnique();

                    b.ToTable("Genre", (string)null);
                });

            modelBuilder.Entity("MusicStoreMVC.Models.Invoice", b =>
                {
                    b.Property<long>("InvoiceId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("BillingAddress")
                        .HasColumnType("NVARCHAR(70)");

                    b.Property<string>("BillingCity")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("BillingCountry")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<string>("BillingPostalCode")
                        .HasColumnType("NVARCHAR(10)");

                    b.Property<string>("BillingState")
                        .HasColumnType("NVARCHAR(40)");

                    b.Property<long>("CustomerId")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("InvoiceDate")
                        .IsRequired()
                        .HasColumnType("DATETIME");

                    b.Property<byte[]>("Total")
                        .IsRequired()
                        .HasColumnType("NUMERIC(10,2)");

                    b.HasKey("InvoiceId");

                    b.HasIndex(new[] { "CustomerId" }, "IFK_InvoiceCustomerId");

                    b.HasIndex(new[] { "InvoiceId" }, "IPK_Invoice")
                        .IsUnique();

                    b.ToTable("Invoice", (string)null);
                });

            modelBuilder.Entity("MusicStoreMVC.Models.InvoiceLine", b =>
                {
                    b.Property<long>("InvoiceLineId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("InvoiceId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Quantity")
                        .HasColumnType("INTEGER");

                    b.Property<long>("TrackId")
                        .HasColumnType("INTEGER");

                    b.Property<byte[]>("UnitPrice")
                        .IsRequired()
                        .HasColumnType("NUMERIC(10,2)");

                    b.HasKey("InvoiceLineId");

                    b.HasIndex(new[] { "InvoiceId" }, "IFK_InvoiceLineInvoiceId");

                    b.HasIndex(new[] { "TrackId" }, "IFK_InvoiceLineTrackId");

                    b.HasIndex(new[] { "InvoiceLineId" }, "IPK_InvoiceLine")
                        .IsUnique();

                    b.ToTable("InvoiceLine", (string)null);
                });

            modelBuilder.Entity("MusicStoreMVC.Models.MediaType", b =>
                {
                    b.Property<long>("MediaTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(120)");

                    b.HasKey("MediaTypeId");

                    b.HasIndex(new[] { "MediaTypeId" }, "IPK_MediaType")
                        .IsUnique();

                    b.ToTable("MediaType", (string)null);
                });

            modelBuilder.Entity("MusicStoreMVC.Models.Playlist", b =>
                {
                    b.Property<long>("PlaylistId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(120)");

                    b.HasKey("PlaylistId");

                    b.HasIndex(new[] { "PlaylistId" }, "IPK_Playlist")
                        .IsUnique();

                    b.ToTable("Playlist", (string)null);
                });

            modelBuilder.Entity("MusicStoreMVC.Models.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<long>("Activo")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Descripcion")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<string>("Precio")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("MusicStoreMVC.Models.Test", b =>
                {
                    b.Property<byte[]>("Ct")
                        .HasColumnType("BLOB")
                        .HasColumnName("ct");

                    b.ToView("test");
                });

            modelBuilder.Entity("MusicStoreMVC.Models.Track", b =>
                {
                    b.Property<long>("TrackId")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("AlbumId")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("Bytes")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Composer")
                        .HasColumnType("NVARCHAR(220)");

                    b.Property<long?>("GenreId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("MediaTypeId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("Milliseconds")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("NVARCHAR(200)");

                    b.Property<byte[]>("UnitPrice")
                        .IsRequired()
                        .HasColumnType("NUMERIC(10,2)");

                    b.HasKey("TrackId");

                    b.HasIndex(new[] { "AlbumId" }, "IFK_TrackAlbumId");

                    b.HasIndex(new[] { "GenreId" }, "IFK_TrackGenreId");

                    b.HasIndex(new[] { "MediaTypeId" }, "IFK_TrackMediaTypeId");

                    b.HasIndex(new[] { "TrackId" }, "IPK_Track")
                        .IsUnique();

                    b.ToTable("Track", (string)null);
                });

            modelBuilder.Entity("PlaylistTrack", b =>
                {
                    b.Property<long>("PlaylistId")
                        .HasColumnType("INTEGER");

                    b.Property<long>("TrackId")
                        .HasColumnType("INTEGER");

                    b.HasKey("PlaylistId", "TrackId");

                    b.HasIndex(new[] { "TrackId" }, "IFK_PlaylistTrackTrackId");

                    b.HasIndex(new[] { "PlaylistId", "TrackId" }, "IPK_PlaylistTrack")
                        .IsUnique();

                    b.ToTable("PlaylistTrack", (string)null);
                });

            modelBuilder.Entity("MusicStoreMVC.Models.Album", b =>
                {
                    b.HasOne("MusicStoreMVC.Models.Artist", "Artist")
                        .WithMany("Albums")
                        .HasForeignKey("ArtistId")
                        .IsRequired();

                    b.Navigation("Artist");
                });

            modelBuilder.Entity("MusicStoreMVC.Models.Customer", b =>
                {
                    b.HasOne("MusicStoreMVC.Models.Employee", "SupportRep")
                        .WithMany("Customers")
                        .HasForeignKey("SupportRepId");

                    b.Navigation("SupportRep");
                });

            modelBuilder.Entity("MusicStoreMVC.Models.Employee", b =>
                {
                    b.HasOne("MusicStoreMVC.Models.Employee", "ReportsToNavigation")
                        .WithMany("InverseReportsToNavigation")
                        .HasForeignKey("ReportsTo");

                    b.Navigation("ReportsToNavigation");
                });

            modelBuilder.Entity("MusicStoreMVC.Models.Invoice", b =>
                {
                    b.HasOne("MusicStoreMVC.Models.Customer", "Customer")
                        .WithMany("Invoices")
                        .HasForeignKey("CustomerId")
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("MusicStoreMVC.Models.InvoiceLine", b =>
                {
                    b.HasOne("MusicStoreMVC.Models.Invoice", "Invoice")
                        .WithMany("InvoiceLines")
                        .HasForeignKey("InvoiceId")
                        .IsRequired();

                    b.HasOne("MusicStoreMVC.Models.Track", "Track")
                        .WithMany("InvoiceLines")
                        .HasForeignKey("TrackId")
                        .IsRequired();

                    b.Navigation("Invoice");

                    b.Navigation("Track");
                });

            modelBuilder.Entity("MusicStoreMVC.Models.Track", b =>
                {
                    b.HasOne("MusicStoreMVC.Models.Album", "Album")
                        .WithMany("Tracks")
                        .HasForeignKey("AlbumId");

                    b.HasOne("MusicStoreMVC.Models.Genre", "Genre")
                        .WithMany("Tracks")
                        .HasForeignKey("GenreId");

                    b.HasOne("MusicStoreMVC.Models.MediaType", "MediaType")
                        .WithMany("Tracks")
                        .HasForeignKey("MediaTypeId")
                        .IsRequired();

                    b.Navigation("Album");

                    b.Navigation("Genre");

                    b.Navigation("MediaType");
                });

            modelBuilder.Entity("PlaylistTrack", b =>
                {
                    b.HasOne("MusicStoreMVC.Models.Playlist", null)
                        .WithMany()
                        .HasForeignKey("PlaylistId")
                        .IsRequired();

                    b.HasOne("MusicStoreMVC.Models.Track", null)
                        .WithMany()
                        .HasForeignKey("TrackId")
                        .IsRequired();
                });

            modelBuilder.Entity("MusicStoreMVC.Models.Album", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("MusicStoreMVC.Models.Artist", b =>
                {
                    b.Navigation("Albums");
                });

            modelBuilder.Entity("MusicStoreMVC.Models.Customer", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("MusicStoreMVC.Models.Employee", b =>
                {
                    b.Navigation("Customers");

                    b.Navigation("InverseReportsToNavigation");
                });

            modelBuilder.Entity("MusicStoreMVC.Models.Genre", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("MusicStoreMVC.Models.Invoice", b =>
                {
                    b.Navigation("InvoiceLines");
                });

            modelBuilder.Entity("MusicStoreMVC.Models.MediaType", b =>
                {
                    b.Navigation("Tracks");
                });

            modelBuilder.Entity("MusicStoreMVC.Models.Track", b =>
                {
                    b.Navigation("InvoiceLines");
                });
#pragma warning restore 612, 618
        }
    }
}
