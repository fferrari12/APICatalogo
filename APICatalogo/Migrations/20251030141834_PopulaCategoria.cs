using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    /// <inheritdoc />
    public partial class PopulaCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Bebidas', 'bebidas.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Lanches', 'lanches.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Sobremesas', 'sobremesas.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Pratos Principais', 'pratosprincipais.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Acompanhamentos', 'acompanhamentos.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Saladas', 'saladas.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Massas', 'massas.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Sopas', 'sopas.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Petiscos', 'petiscos.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Cafés', 'cafes.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Chás', 'chas.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Sucos', 'sucos.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Doces', 'doces.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Salgados', 'salgados.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Bolos', 'bolos.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Pizzas', 'pizzas.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Hambúrgueres', 'hamburgueres.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Sushi', 'sushi.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Cervejas', 'cervejas.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Vinhos', 'vinhos.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Drinks', 'drinks.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Coquetéis', 'coqueteis.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Refeições Veganas', 'refeicoesveganas.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Refeições Vegetarianas', 'refeicoesvegetarianas.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Comidas Típicas', 'comidastipicas.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Comidas Rápidas', 'comidasrapidas.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Lanches Saudáveis', 'lanchessaudaveis.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Bebidas Energéticas', 'bebidasenergeticas.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Águas Aromatizadas', 'aguasaromatizadas.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Chocolates', 'chocolates.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Sorvetes', 'sorvetes.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Iogurtes', 'iogurtes.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Frutas', 'frutas.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Vegetais', 'vegetais.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Cereais', 'cereais.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Nozes e Sementes', 'nozesesementes.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Leguminosas', 'leguminosas.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Temperos e Ervas', 'temperoseervas.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Pães e Produtos de Padaria', 'paesprodutosdepadeira.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Produtos Dietéticos', 'produtosdieteticos.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Produtos Orgânicos', 'produtosorganicos.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Bebidas Alcoólicas', 'bebidasalcoolicas.png');");
            mb.Sql("INSERT INTO Categorias (Nome, ImagemUrl) VALUES ('Bebidas Não Alcoólicas', 'bebidasnaoalcoolicas.png');");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("DELETE FROM Categorias WHERE Nome IN ('Bebidas', 'Lanches', 'Sobremesas', 'Pratos Principais', 'Acompanhamentos', 'Saladas', 'Massas', 'Sopas', 'Petiscos', 'Cafés', 'Chás', 'Sucos', 'Doces', 'Salgados', 'Bolos', 'Pizzas', 'Hambúrgueres', 'Sushi', 'Cervejas', 'Vinhos', 'Drinks', 'Coquetéis', 'Refeições Veganas', 'Refeições Vegetarianas', 'Comidas Típicas', 'Comidas Rápidas', 'Lanches Saudáveis', 'Bebidas Energéticas', 'Águas Aromatizadas', 'Chocolates', 'Sorvetes', 'Iogurtes', 'Frutas', 'Vegetais', 'Cereais', 'Nozes e Sementes', 'Leguminosas', 'Temperos e Ervas', 'Pães e Produtos de Padaria', 'Produtos Dietéticos', 'Produtos Orgânicos', 'Bebidas Alcoólicas', 'Bebidas Não Alcoólicas');");
        }
    }
}
