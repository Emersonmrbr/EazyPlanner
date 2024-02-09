using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EazyPlanner.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FinancialRecord",
                columns: table => new
                {
                    FinancialRecordId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecordType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlannedAmount = table.Column<decimal>(type: "money", precision: 20, scale: 2, nullable: false),
                    ActualAmount = table.Column<decimal>(type: "money", precision: 20, scale: 2, nullable: true),
                    Status = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ReceivedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Account = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Client = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Category = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CostCenter = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Invoice = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialRecord", x => x.FinancialRecordId);
                });

            migrationBuilder.CreateTable(
                name: "BankrollAccount",
                columns: table => new
                {
                    BankrollAccountsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FinancialRecordId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankrollAccount", x => x.BankrollAccountsId);
                    table.ForeignKey(
                        name: "FK_BankrollAccount_FinancialRecord_FinancialRecordId",
                        column: x => x.FinancialRecordId,
                        principalTable: "FinancialRecord",
                        principalColumn: "FinancialRecordId");
                });

            migrationBuilder.CreateTable(
                name: "CostCenter",
                columns: table => new
                {
                    CostCenterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FinancialRecordId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostCenter", x => x.CostCenterId);
                    table.ForeignKey(
                        name: "FK_CostCenter_FinancialRecord_FinancialRecordId",
                        column: x => x.FinancialRecordId,
                        principalTable: "FinancialRecord",
                        principalColumn: "FinancialRecordId");
                });

            migrationBuilder.CreateTable(
                name: "CustomerSupplier",
                columns: table => new
                {
                    CustomerSupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CNPJ = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    CompanyFantasy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    People = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ProvinceId = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    CityId = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    FinancialRecordId = table.Column<int>(type: "int", nullable: true),
                    StreetName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BuildingNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    SecondaryAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    State = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Website = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Phone1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Phone2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerSupplier", x => x.CustomerSupplierId);
                    table.ForeignKey(
                        name: "FK_CustomerSupplier_FinancialRecord_FinancialRecordId",
                        column: x => x.FinancialRecordId,
                        principalTable: "FinancialRecord",
                        principalColumn: "FinancialRecordId");
                });

            migrationBuilder.CreateTable(
                name: "FinanceCategory",
                columns: table => new
                {
                    FinanceCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FinancialRecordId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanceCategory", x => x.FinanceCategoryId);
                    table.ForeignKey(
                        name: "FK_FinanceCategory_FinancialRecord_FinancialRecordId",
                        column: x => x.FinancialRecordId,
                        principalTable: "FinancialRecord",
                        principalColumn: "FinancialRecordId");
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Amount = table.Column<decimal>(type: "money", precision: 20, scale: 2, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    File = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FinancialRecordId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.InvoiceId);
                    table.ForeignKey(
                        name: "FK_Invoice_FinancialRecord_FinancialRecordId",
                        column: x => x.FinancialRecordId,
                        principalTable: "FinancialRecord",
                        principalColumn: "FinancialRecordId");
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethod",
                columns: table => new
                {
                    PaymentMethodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FinancialRecordId = table.Column<int>(type: "int", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethod", x => x.PaymentMethodId);
                    table.ForeignKey(
                        name: "FK_PaymentMethod_FinancialRecord_FinancialRecordId",
                        column: x => x.FinancialRecordId,
                        principalTable: "FinancialRecord",
                        principalColumn: "FinancialRecordId");
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PeopleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    FinancialRecordId = table.Column<int>(type: "int", nullable: true),
                    StreetName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    BuildingNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    SecondaryAddress = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    State = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Website = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Phone1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Phone2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.PeopleId);
                    table.ForeignKey(
                        name: "FK_People_FinancialRecord_FinancialRecordId",
                        column: x => x.FinancialRecordId,
                        principalTable: "FinancialRecord",
                        principalColumn: "FinancialRecordId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_BankrollAccount_FinancialRecordId",
                table: "BankrollAccount",
                column: "FinancialRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_CostCenter_FinancialRecordId",
                table: "CostCenter",
                column: "FinancialRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerSupplier_FinancialRecordId",
                table: "CustomerSupplier",
                column: "FinancialRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_FinanceCategory_FinancialRecordId",
                table: "FinanceCategory",
                column: "FinancialRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoice_FinancialRecordId",
                table: "Invoice",
                column: "FinancialRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_FinancialRecordId",
                table: "PaymentMethod",
                column: "FinancialRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_People_FinancialRecordId",
                table: "People",
                column: "FinancialRecordId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BankrollAccount");

            migrationBuilder.DropTable(
                name: "CostCenter");

            migrationBuilder.DropTable(
                name: "CustomerSupplier");

            migrationBuilder.DropTable(
                name: "FinanceCategory");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "PaymentMethod");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "FinancialRecord");
        }
    }
}
