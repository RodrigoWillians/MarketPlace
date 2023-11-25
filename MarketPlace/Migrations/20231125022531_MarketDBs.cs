using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MarketPlace.Migrations
{
    public partial class MarketDBs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carrinhos_Clientes_ClienteId",
                table: "Carrinhos");

            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_Endereco_EnderecoId",
                table: "Clientes");

            migrationBuilder.DropForeignKey(
                name: "FK_itemCarrinhoss_Carrinhos_CarrinhoId",
                table: "itemCarrinhoss");

            migrationBuilder.DropForeignKey(
                name: "FK_itemCarrinhoss_Produtos_ProdutoId",
                table: "itemCarrinhoss");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Carrinhos_CarrinhoId",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Categoria_CategoriaId",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_Produtos_Vendedores_VendedorId",
                table: "Produtos");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendedores_Endereco_EnderecoId",
                table: "Vendedores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vendedores",
                table: "Vendedores");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_itemCarrinhoss",
                table: "itemCarrinhoss");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carrinhos",
                table: "Carrinhos");

            migrationBuilder.RenameTable(
                name: "Vendedores",
                newName: "Vendedor");

            migrationBuilder.RenameTable(
                name: "Produtos",
                newName: "Produto");

            migrationBuilder.RenameTable(
                name: "itemCarrinhoss",
                newName: "itemCarrinho");

            migrationBuilder.RenameTable(
                name: "Clientes",
                newName: "Cliente");

            migrationBuilder.RenameTable(
                name: "Carrinhos",
                newName: "Carrinho");

            migrationBuilder.RenameIndex(
                name: "IX_Vendedores_EnderecoId",
                table: "Vendedor",
                newName: "IX_Vendedor_EnderecoId");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos_VendedorId",
                table: "Produto",
                newName: "IX_Produto_VendedorId");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos_CategoriaId",
                table: "Produto",
                newName: "IX_Produto_CategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Produtos_CarrinhoId",
                table: "Produto",
                newName: "IX_Produto_CarrinhoId");

            migrationBuilder.RenameIndex(
                name: "IX_itemCarrinhoss_ProdutoId",
                table: "itemCarrinho",
                newName: "IX_itemCarrinho_ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_itemCarrinhoss_CarrinhoId",
                table: "itemCarrinho",
                newName: "IX_itemCarrinho_CarrinhoId");

            migrationBuilder.RenameIndex(
                name: "IX_Clientes_EnderecoId",
                table: "Cliente",
                newName: "IX_Cliente_EnderecoId");

            migrationBuilder.RenameIndex(
                name: "IX_Carrinhos_ClienteId",
                table: "Carrinho",
                newName: "IX_Carrinho_ClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vendedor",
                table: "Vendedor",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produto",
                table: "Produto",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_itemCarrinho",
                table: "itemCarrinho",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carrinho",
                table: "Carrinho",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Carrinho_Cliente_ClienteId",
                table: "Carrinho",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cliente_Endereco_EnderecoId",
                table: "Cliente",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_itemCarrinho_Carrinho_CarrinhoId",
                table: "itemCarrinho",
                column: "CarrinhoId",
                principalTable: "Carrinho",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_itemCarrinho_Produto_ProdutoId",
                table: "itemCarrinho",
                column: "ProdutoId",
                principalTable: "Produto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Carrinho_CarrinhoId",
                table: "Produto",
                column: "CarrinhoId",
                principalTable: "Carrinho",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Categoria_CategoriaId",
                table: "Produto",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produto_Vendedor_VendedorId",
                table: "Produto",
                column: "VendedorId",
                principalTable: "Vendedor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendedor_Endereco_EnderecoId",
                table: "Vendedor",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carrinho_Cliente_ClienteId",
                table: "Carrinho");

            migrationBuilder.DropForeignKey(
                name: "FK_Cliente_Endereco_EnderecoId",
                table: "Cliente");

            migrationBuilder.DropForeignKey(
                name: "FK_itemCarrinho_Carrinho_CarrinhoId",
                table: "itemCarrinho");

            migrationBuilder.DropForeignKey(
                name: "FK_itemCarrinho_Produto_ProdutoId",
                table: "itemCarrinho");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Carrinho_CarrinhoId",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Categoria_CategoriaId",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Produto_Vendedor_VendedorId",
                table: "Produto");

            migrationBuilder.DropForeignKey(
                name: "FK_Vendedor_Endereco_EnderecoId",
                table: "Vendedor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Vendedor",
                table: "Vendedor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Produto",
                table: "Produto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_itemCarrinho",
                table: "itemCarrinho");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carrinho",
                table: "Carrinho");

            migrationBuilder.RenameTable(
                name: "Vendedor",
                newName: "Vendedores");

            migrationBuilder.RenameTable(
                name: "Produto",
                newName: "Produtos");

            migrationBuilder.RenameTable(
                name: "itemCarrinho",
                newName: "itemCarrinhoss");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "Clientes");

            migrationBuilder.RenameTable(
                name: "Carrinho",
                newName: "Carrinhos");

            migrationBuilder.RenameIndex(
                name: "IX_Vendedor_EnderecoId",
                table: "Vendedores",
                newName: "IX_Vendedores_EnderecoId");

            migrationBuilder.RenameIndex(
                name: "IX_Produto_VendedorId",
                table: "Produtos",
                newName: "IX_Produtos_VendedorId");

            migrationBuilder.RenameIndex(
                name: "IX_Produto_CategoriaId",
                table: "Produtos",
                newName: "IX_Produtos_CategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_Produto_CarrinhoId",
                table: "Produtos",
                newName: "IX_Produtos_CarrinhoId");

            migrationBuilder.RenameIndex(
                name: "IX_itemCarrinho_ProdutoId",
                table: "itemCarrinhoss",
                newName: "IX_itemCarrinhoss_ProdutoId");

            migrationBuilder.RenameIndex(
                name: "IX_itemCarrinho_CarrinhoId",
                table: "itemCarrinhoss",
                newName: "IX_itemCarrinhoss_CarrinhoId");

            migrationBuilder.RenameIndex(
                name: "IX_Cliente_EnderecoId",
                table: "Clientes",
                newName: "IX_Clientes_EnderecoId");

            migrationBuilder.RenameIndex(
                name: "IX_Carrinho_ClienteId",
                table: "Carrinhos",
                newName: "IX_Carrinhos_ClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Vendedores",
                table: "Vendedores",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Produtos",
                table: "Produtos",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_itemCarrinhoss",
                table: "itemCarrinhoss",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Clientes",
                table: "Clientes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carrinhos",
                table: "Carrinhos",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Carrinhos_Clientes_ClienteId",
                table: "Carrinhos",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_Endereco_EnderecoId",
                table: "Clientes",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_itemCarrinhoss_Carrinhos_CarrinhoId",
                table: "itemCarrinhoss",
                column: "CarrinhoId",
                principalTable: "Carrinhos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_itemCarrinhoss_Produtos_ProdutoId",
                table: "itemCarrinhoss",
                column: "ProdutoId",
                principalTable: "Produtos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Carrinhos_CarrinhoId",
                table: "Produtos",
                column: "CarrinhoId",
                principalTable: "Carrinhos",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Categoria_CategoriaId",
                table: "Produtos",
                column: "CategoriaId",
                principalTable: "Categoria",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Produtos_Vendedores_VendedorId",
                table: "Produtos",
                column: "VendedorId",
                principalTable: "Vendedores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vendedores_Endereco_EnderecoId",
                table: "Vendedores",
                column: "EnderecoId",
                principalTable: "Endereco",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
