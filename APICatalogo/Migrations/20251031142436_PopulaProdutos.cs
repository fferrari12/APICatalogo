using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                   "VALUES ('Camiseta', 'Camiseta 100% algodão', 29.90, 'camiseta.jpg', 100, NOW(), 2);");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                     "VALUES ('Calça Jeans', 'Calça jeans azul escuro', 99.90, 'calca_jeans.jpg', 50, NOW(), 2);");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                        "VALUES ('Tênis Esportivo', 'Tênis para corrida e caminhada', 149.90, 'tenis_esportivo.jpg', 75, NOW(), 3);");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                        "VALUES ('Jaqueta de Couro', 'Jaqueta de couro legítimo', 199.90, 'jaqueta_couro.jpg', 30, NOW(), 4);");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                        "VALUES ('Vestido Floral', 'Vestido longo com estampa floral', 89.90, 'vestido_floral.jpg', 60, NOW(), 5);");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                        "VALUES ('Boné', 'Boné ajustável com logo bordado', 19.90, 'bone.jpg', 150, NOW(), 6);");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                        "VALUES ('Mochila Escolar', 'Mochila resistente para uso diário', 59.90, 'mochila_escolar.jpg', 80, NOW(), 7);");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                        "VALUES ('Relógio de Pulso', 'Relógio analógico com pulseira de couro', 129.90, 'relogio_pulso.jpg', 40, NOW(), 8);");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                        "VALUES ('Óculos de Sol', 'Óculos de sol com proteção UV', 79.90, 'oculos_sol.jpg', 70, NOW(), 9);");
            mb.Sql("INSERT INTO Produtos (Nome, Descricao, Preco, ImagemUrl, Estoque, DataCadastro, CategoriaId) " +
                        "VALUES ('Cinto de Couro', 'Cinto de couro legítimo com fivela metálica', 39.90, 'cinto_couro.jpg', 90, NOW(), 10);");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM produtos;");
        }
    }
}
