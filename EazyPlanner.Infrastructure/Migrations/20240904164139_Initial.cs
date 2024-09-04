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
                name: "BankrollAccount",
                columns: table => new
                {
                    BankrollAccountId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Create_CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Create_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Create_UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Create_UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankrollAccount", x => x.BankrollAccountId);
                });

            migrationBuilder.CreateTable(
                name: "CostCenter",
                columns: table => new
                {
                    CostCenterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Create_CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Create_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Create_UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Create_UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CostCenter", x => x.CostCenterId);
                });

            migrationBuilder.CreateTable(
                name: "CustomerSupplier",
                columns: table => new
                {
                    CustomerSupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CNPJ = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CompanyFantasy = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ProvinceId = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    CityId = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Address_BuildingNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_SecondaryAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_StreetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact_Email1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact_Email2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact_Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact_Phone1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact_Phone2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Contact_Website = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Create_CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Create_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Create_UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Create_UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CustomerSupplier", x => x.CustomerSupplierId);
                });

            migrationBuilder.CreateTable(
                name: "FinanceCategory",
                columns: table => new
                {
                    FinanceCategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Create_CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Create_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Create_UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Create_UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanceCategory", x => x.FinanceCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Invoice",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Amount = table.Column<decimal>(type: "money", precision: 18, scale: 2, nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    File = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Create_CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Create_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Create_UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Create_UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoice", x => x.InvoiceId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethod",
                columns: table => new
                {
                    PaymentMethodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Create_CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Create_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Create_UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Create_UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethod", x => x.PaymentMethodId);
                });

            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    PeopleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "date", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerSupplierId = table.Column<int>(type: "int", nullable: true),
                    Create_CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Create_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Create_UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Create_UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.PeopleId);
                    table.ForeignKey(
                        name: "FK_People_CustomerSupplier_CustomerSupplierId",
                        column: x => x.CustomerSupplierId,
                        principalTable: "CustomerSupplier",
                        principalColumn: "CustomerSupplierId");
                });

            migrationBuilder.CreateTable(
                name: "FinancialRecord",
                columns: table => new
                {
                    FinanceCategoryId = table.Column<int>(type: "int", nullable: false),
                    FinancialRecordId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DueDate = table.Column<DateTime>(type: "date", nullable: false),
                    PlannedAmount = table.Column<decimal>(type: "money", precision: 10, scale: 2, nullable: false),
                    ReceivedDate = table.Column<DateTime>(type: "date", nullable: false),
                    ActualAmount = table.Column<decimal>(type: "money", precision: 10, scale: 2, nullable: false),
                    RecordType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankrollAccountId = table.Column<int>(type: "int", nullable: true),
                    CosteCenterId = table.Column<int>(type: "int", nullable: true),
                    CustomerSupplierId = table.Column<int>(type: "int", nullable: true),
                    InvoiceId = table.Column<int>(type: "int", nullable: true),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: true),
                    Create_CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Create_CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Create_UpdateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Create_UpdateBy = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialRecord", x => x.FinanceCategoryId);
                    table.ForeignKey(
                        name: "FK_FinancialRecord_BankrollAccount_BankrollAccountId",
                        column: x => x.BankrollAccountId,
                        principalTable: "BankrollAccount",
                        principalColumn: "BankrollAccountId");
                    table.ForeignKey(
                        name: "FK_FinancialRecord_CostCenter_CosteCenterId",
                        column: x => x.CosteCenterId,
                        principalTable: "CostCenter",
                        principalColumn: "CostCenterId");
                    table.ForeignKey(
                        name: "FK_FinancialRecord_CustomerSupplier_CustomerSupplierId",
                        column: x => x.CustomerSupplierId,
                        principalTable: "CustomerSupplier",
                        principalColumn: "CustomerSupplierId");
                    table.ForeignKey(
                        name: "FK_FinancialRecord_FinanceCategory_FinanceCategoryId",
                        column: x => x.FinanceCategoryId,
                        principalTable: "FinanceCategory",
                        principalColumn: "FinanceCategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FinancialRecord_Invoice_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoice",
                        principalColumn: "InvoiceId");
                    table.ForeignKey(
                        name: "FK_FinancialRecord_PaymentMethod_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethod",
                        principalColumn: "PaymentMethodId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_FinancialRecord_BankrollAccountId",
                table: "FinancialRecord",
                column: "BankrollAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_FinancialRecord_CosteCenterId",
                table: "FinancialRecord",
                column: "CosteCenterId");

            migrationBuilder.CreateIndex(
                name: "IX_FinancialRecord_CustomerSupplierId",
                table: "FinancialRecord",
                column: "CustomerSupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_FinancialRecord_InvoiceId",
                table: "FinancialRecord",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_FinancialRecord_PaymentMethodId",
                table: "FinancialRecord",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_People_CustomerSupplierId",
                table: "People",
                column: "CustomerSupplierId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FinancialRecord");

            migrationBuilder.DropTable(
                name: "People");

            migrationBuilder.DropTable(
                name: "BankrollAccount");

            migrationBuilder.DropTable(
                name: "CostCenter");

            migrationBuilder.DropTable(
                name: "FinanceCategory");

            migrationBuilder.DropTable(
                name: "Invoice");

            migrationBuilder.DropTable(
                name: "PaymentMethod");

            migrationBuilder.DropTable(
                name: "CustomerSupplier");
        }
    }
}
