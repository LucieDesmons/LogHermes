using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Stock.DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CATEGORIE",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    nom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    nature = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CATEGORIE", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CMD_CLIENT",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    dateCmd = table.Column<DateTime>(type: "datetime", nullable: true),
                    libelle = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    dateLivraison = table.Column<DateTime>(type: "date", nullable: true),
                    montantCmd = table.Column<decimal>(type: "decimal(15,2)", nullable: true),
                    etat = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    lieuLivraison = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    modePaiement = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    devise = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMD_CLIENT", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CMD_FOURNISSEUR",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    libelle = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    dateCmd = table.Column<DateTime>(type: "datetime", nullable: true),
                    dateLivraison = table.Column<DateTime>(type: "datetime", nullable: true),
                    montantCmd = table.Column<decimal>(type: "decimal(15,2)", nullable: true),
                    modePaiement = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    prixAchatHT = table.Column<decimal>(type: "decimal(15,2)", nullable: true),
                    taxe = table.Column<decimal>(type: "decimal(15,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CMD_FOURNISSEUR", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "EMPLACEMENT_STOCK",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    numRang = table.Column<int>(type: "int", nullable: true),
                    numCasier = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPLACEMENT_STOCK", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "EMPLOYE",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    nom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    prenom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    role = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMPLOYE", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "FOURNISSEUR",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    nom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    rue = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    codePostal = table.Column<int>(type: "int", nullable: true),
                    ville = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    pays = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    email = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    telephone = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    num_siret = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    num_TVA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FOURNISSEUR", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "ARTICLE",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    nom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    description = table.Column<string>(type: "varchar(350)", unicode: false, maxLength: 350, nullable: true),
                    image = table.Column<byte[]>(type: "binary(350)", fixedLength: true, maxLength: 350, nullable: true),
                    note = table.Column<decimal>(type: "decimal(2,2)", nullable: true),
                    cepage = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    annee = table.Column<DateTime>(type: "date", nullable: true),
                    prix = table.Column<decimal>(type: "decimal(15,2)", nullable: false),
                    taxe = table.Column<decimal>(type: "decimal(15,2)", nullable: true),
                    quantite = table.Column<int>(type: "int", nullable: true),
                    id_1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ARTICLE", x => x.id);
                    table.ForeignKey(
                        name: "FK__ARTICLE__id_1__36B12243",
                        column: x => x.id_1,
                        principalTable: "CATEGORIE",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "CLIENT",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    nom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    prenom = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    rue = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    codePostal = table.Column<int>(type: "int", nullable: true),
                    ville = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    pays = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    email = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    telephone = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    num_siret = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    num_TVA = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    id_1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENT", x => x.id);
                    table.ForeignKey(
                        name: "FK__CLIENT__id_1__398D8EEE",
                        column: x => x.id_1,
                        principalTable: "CMD_CLIENT",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "FACTURE",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    libelle = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    montant = table.Column<decimal>(type: "decimal(15,2)", nullable: true),
                    dateFacture = table.Column<DateTime>(type: "datetime", nullable: true),
                    id_1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FACTURE", x => x.id);
                    table.ForeignKey(
                        name: "FK__FACTURE__id_1__2A4B4B5E",
                        column: x => x.id_1,
                        principalTable: "CMD_CLIENT",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Organiser",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    id_1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Organise__6BC8951518A76114", x => new { x.id, x.id_1 });
                    table.ForeignKey(
                        name: "FK__Organiser__id__4F7CD00D",
                        column: x => x.id,
                        principalTable: "EMPLOYE",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Organiser__id_1__5070F446",
                        column: x => x.id_1,
                        principalTable: "EMPLACEMENT_STOCK",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Réaliser",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    id_1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Réaliser__6BC89515174D4FB1", x => new { x.id, x.id_1 });
                    table.ForeignKey(
                        name: "FK__Réaliser__id__5EBF139D",
                        column: x => x.id,
                        principalTable: "EMPLOYE",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Réaliser__id_1__5FB337D6",
                        column: x => x.id_1,
                        principalTable: "CMD_FOURNISSEUR",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "UTILISATEUR",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    nomUtilisateur = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    mot_de_passe = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    id_1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UTILISATEUR", x => x.id);
                    table.ForeignKey(
                        name: "FK__UTILISATEU__id_1__33D4B598",
                        column: x => x.id_1,
                        principalTable: "EMPLOYE",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Créer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    id_1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Créer__6BC89515D0C0851C", x => new { x.id, x.id_1 });
                    table.ForeignKey(
                        name: "FK__Créer__id__571DF1D5",
                        column: x => x.id,
                        principalTable: "FOURNISSEUR",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Créer__id_1__5812160E",
                        column: x => x.id_1,
                        principalTable: "EMPLOYE",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Livrer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    id_1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Livrer__6BC89515572A9E3D", x => new { x.id, x.id_1 });
                    table.ForeignKey(
                        name: "FK__Livrer__id__403A8C7D",
                        column: x => x.id,
                        principalTable: "FOURNISSEUR",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Livrer__id_1__412EB0B6",
                        column: x => x.id_1,
                        principalTable: "CMD_FOURNISSEUR",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Contenir",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    id_1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Contenir__6BC89515D75B7C29", x => new { x.id, x.id_1 });
                    table.ForeignKey(
                        name: "FK__Contenir__id__4BAC3F29",
                        column: x => x.id,
                        principalTable: "ARTICLE",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Contenir__id_1__4CA06362",
                        column: x => x.id_1,
                        principalTable: "EMPLACEMENT_STOCK",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Correspondre",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    id_1 = table.Column<int>(type: "int", nullable: false),
                    prixVente = table.Column<decimal>(type: "decimal(15,2)", nullable: true),
                    sortieStock = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Correspo__6BC89515B6C4D951", x => new { x.id, x.id_1 });
                    table.ForeignKey(
                        name: "FK__Correspond__id_1__44FF419A",
                        column: x => x.id_1,
                        principalTable: "CMD_CLIENT",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Correspondre__id__440B1D61",
                        column: x => x.id,
                        principalTable: "ARTICLE",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Enregistrer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    id_1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Enregist__6BC89515E9B0FCD9", x => new { x.id, x.id_1 });
                    table.ForeignKey(
                        name: "FK__Enregistre__id_1__5BE2A6F2",
                        column: x => x.id_1,
                        principalTable: "EMPLOYE",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Enregistrer__id__5AEE82B9",
                        column: x => x.id,
                        principalTable: "ARTICLE",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Receptionner",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    id_1 = table.Column<int>(type: "int", nullable: false),
                    entreeStock = table.Column<int>(type: "int", nullable: true),
                    prixAchat = table.Column<decimal>(type: "decimal(15,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Receptio__6BC8951514B79B67", x => new { x.id, x.id_1 });
                    table.ForeignKey(
                        name: "FK__Receptionn__id_1__3D5E1FD2",
                        column: x => x.id_1,
                        principalTable: "CMD_FOURNISSEUR",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Receptionner__id__3C69FB99",
                        column: x => x.id,
                        principalTable: "ARTICLE",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Inscrire",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    id_1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Inscrire__6BC8951525E9FA03", x => new { x.id, x.id_1 });
                    table.ForeignKey(
                        name: "FK__Inscrire__id__534D60F1",
                        column: x => x.id,
                        principalTable: "CLIENT",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Inscrire__id_1__5441852A",
                        column: x => x.id_1,
                        principalTable: "EMPLOYE",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Editer",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false),
                    id_1 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Editer__6BC89515AF141620", x => new { x.id, x.id_1 });
                    table.ForeignKey(
                        name: "FK__Editer__id__47DBAE45",
                        column: x => x.id,
                        principalTable: "FACTURE",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK__Editer__id_1__48CFD27E",
                        column: x => x.id_1,
                        principalTable: "EMPLOYE",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ARTICLE_id_1",
                table: "ARTICLE",
                column: "id_1");

            migrationBuilder.CreateIndex(
                name: "IX_CLIENT_id_1",
                table: "CLIENT",
                column: "id_1");

            migrationBuilder.CreateIndex(
                name: "IX_Contenir_id_1",
                table: "Contenir",
                column: "id_1");

            migrationBuilder.CreateIndex(
                name: "IX_Correspondre_id_1",
                table: "Correspondre",
                column: "id_1");

            migrationBuilder.CreateIndex(
                name: "IX_Créer_id_1",
                table: "Créer",
                column: "id_1");

            migrationBuilder.CreateIndex(
                name: "IX_Editer_id_1",
                table: "Editer",
                column: "id_1");

            migrationBuilder.CreateIndex(
                name: "IX_Enregistrer_id_1",
                table: "Enregistrer",
                column: "id_1");

            migrationBuilder.CreateIndex(
                name: "IX_FACTURE_id_1",
                table: "FACTURE",
                column: "id_1");

            migrationBuilder.CreateIndex(
                name: "IX_Inscrire_id_1",
                table: "Inscrire",
                column: "id_1");

            migrationBuilder.CreateIndex(
                name: "IX_Livrer_id_1",
                table: "Livrer",
                column: "id_1");

            migrationBuilder.CreateIndex(
                name: "IX_Organiser_id_1",
                table: "Organiser",
                column: "id_1");

            migrationBuilder.CreateIndex(
                name: "IX_Réaliser_id_1",
                table: "Réaliser",
                column: "id_1");

            migrationBuilder.CreateIndex(
                name: "IX_Receptionner_id_1",
                table: "Receptionner",
                column: "id_1");

            migrationBuilder.CreateIndex(
                name: "UQ__UTILISAT__9DB7D2A55BEC1EE9",
                table: "UTILISATEUR",
                column: "id_1",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contenir");

            migrationBuilder.DropTable(
                name: "Correspondre");

            migrationBuilder.DropTable(
                name: "Créer");

            migrationBuilder.DropTable(
                name: "Editer");

            migrationBuilder.DropTable(
                name: "Enregistrer");

            migrationBuilder.DropTable(
                name: "Inscrire");

            migrationBuilder.DropTable(
                name: "Livrer");

            migrationBuilder.DropTable(
                name: "Organiser");

            migrationBuilder.DropTable(
                name: "Réaliser");

            migrationBuilder.DropTable(
                name: "Receptionner");

            migrationBuilder.DropTable(
                name: "UTILISATEUR");

            migrationBuilder.DropTable(
                name: "FACTURE");

            migrationBuilder.DropTable(
                name: "CLIENT");

            migrationBuilder.DropTable(
                name: "FOURNISSEUR");

            migrationBuilder.DropTable(
                name: "EMPLACEMENT_STOCK");

            migrationBuilder.DropTable(
                name: "CMD_FOURNISSEUR");

            migrationBuilder.DropTable(
                name: "ARTICLE");

            migrationBuilder.DropTable(
                name: "EMPLOYE");

            migrationBuilder.DropTable(
                name: "CMD_CLIENT");

            migrationBuilder.DropTable(
                name: "CATEGORIE");
        }
    }
}
