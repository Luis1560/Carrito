<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ListaProductos.aspx.cs" Inherits="Carrito.Views.ListaProductos" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Lista de Productos</title>
    <style>
        /* Estilos para la tabla */
        .product-table {
            width: 80%;
            margin: 20px auto;
            border-collapse: collapse;
            font-family: Arial, sans-serif;
        }

        .product-table th, .product-table td {
            padding: 10px;
            border: 1px solid #ddd;
            text-align: center;
        }

        .product-table th {
            background-color: #4CAF50;
            color: white;
        }

        .product-table tr:nth-child(even) {
            background-color: #f2f2f2;
        }

        .product-table img {
            width: 100px;
            height: auto;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 style="text-align:center;">Lista de Productos</h2>
            <asp:GridView ID="gvProductos" runat="server" CssClass="product-table" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="ID" HeaderText="ID" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                    <asp:BoundField DataField="Cantidad" HeaderText="Cantidad" />
                    <asp:BoundField DataField="Costo" HeaderText="Costo" DataFormatString="{0:C}" />


                    <asp:TemplateField HeaderText="Imagen">
                        <ItemTemplate>
                            <asp:Image ID="imgProducto" runat="server" ImageUrl='<%# "data:image/png;base64," + Convert.ToBase64String((byte[])Eval("Imagen")) %>' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>

