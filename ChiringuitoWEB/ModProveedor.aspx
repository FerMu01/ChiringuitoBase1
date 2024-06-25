<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ModProveedor.aspx.cs" Inherits="ChiringuitoWEB.ModProveedor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registrar Proveedor</title>
    <style>
        body {
background-image: url('imagenes/Prov.jpg'); /* Asegúrate de que esta ruta es correcta */
background-size: cover;
background-position: center;            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
            font-family: Arial, sans-serif;
        }
        .card {
            background-color: #ffffff;
            box-shadow: 0 24px 20px rgba(0, 0, 0, 0.2);
            border-radius: 10px;
            display: flex;
            overflow: hidden;
            height: 650px;
            width: 1200px; /* Ancho fijo de la tarjeta */
        }
        .form-section {
            padding: 20px;
            flex: 1;
        }
        .form-section h1 {
            text-align: center;
        }
        .form-section label {
            display: block;
            margin-bottom: 5px;
        }
        .form-section input {
            width: calc(100% - 20px); /* Ajuste del ancho de los inputs */
            padding: 10px;
            margin-bottom: 15px;
            border: 1px solid #ccc;
            border-radius: 5px;
        }
        .form-section button {
            width: 100%;
            padding: 10px;
            margin-bottom: 10px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
            font-size: 16px;
        }
        .form-section button.registrar {
            background-color: #00bfff;
            color: white;
        }
        .form-section .volver {
            background-color: #800080;
            color: white;
            width: 100px;
        }
        .image-section {
            background-image: url('imagenes/pantalla.png');
            background-size: cover;
            background-position: center;
            flex: 1;
        }
        /* Estilo de la tabla con bandas minimalista */
        .striped-table {
            width: calc(100% - 25px); /* Ajuste del ancho de la tabla */
            border-collapse: collapse;
            margin-top: 70px; /* Espacio para que se vea bien */
            border-radius: 15px;
            margin-right: 25px; /* Margen derecho */
            overflow: hidden; /* Para mantener los bordes redondeados */
        }
        .striped-table th, .striped-table td {
            padding: 12px 15px;
            border: 1px solid #ccc;
            text-align: left;
        }
        .striped-table tr:nth-child(even) {
            background-color: #eee;
        }
        .striped-table tr:nth-child(odd) {
            background-color: #fff;
        }
        .striped-table th {
            background-color: #f2f2f2;
            font-weight: bold;
            color: #333;
        }
        .striped-table tr:hover {
            background-color: #f1f1f1;
        }
        .striped-table th, .striped-table td {
            border-radius: 0; /* Remover el borde redondeado de celdas individuales */
        }
        .striped-table {
            border-radius: 15px; /* Aplicar el borde redondeado a la tabla en general */
            overflow: hidden; /* Asegurarse de que el borde redondeado funcione */
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="card">
            <div class="form-section">
                <h1>EL CHIRINGUITO</h1>
                <asp:TextBox ID="textID" runat="server" Visible="false" ></asp:TextBox>
                <label for="cinit">NIT</label>
                <asp:TextBox ID="textNit" runat="server" placeholder="Numero De NIT" OnTextChanged="textNit_TextChanged"></asp:TextBox>

                <label for="nombre-proveedor">Nombre Proveedor</label>
                <asp:TextBox ID="textName" runat="server" placeholder="Nombre Proveedor" ></asp:TextBox>

                <label for="numero-telefono">Numero De Telefono</label>
                <asp:TextBox ID="textNumber" runat="server" placeholder="Numero De Telefono" OnTextChanged="textNumber_TextChanged"></asp:TextBox>

                <asp:Button ID="btnModificar" runat="server" CssClass="volver" Text="Modificar" OnClick="btnModificar_Click" />
                <asp:Button ID="btnGuardar" runat="server" CssClass="volver" Text="Guardar" OnClick="btnGuardar_Click" />
                <asp:Button ID="btnEliminar" runat="server" CssClass="volver" Text="Eliminar"  OnClick="btnEliminar_Click"/>
                <asp:Button ID="btnVolver" runat="server" CssClass="volver" Text="Volver" OnClick="btnVolver_Click"  />
            </div>
            <div>
                <asp:GridView ID="gridData" runat="server" AutoGenerateColumns="false" CssClass="striped-table">
                    <Columns>
                        <asp:TemplateField HeaderText="ID" Visible="false">
                            <ItemTemplate>
                                <asp:Label ID="IDlbl" Text='<%# Eval("id") %>' runat="server" > </asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:BoundField DataField="NIT" HeaderText="NIT" ItemStyle-width="150" />
                        <asp:BoundField DataField="Nombre Proveedor" HeaderText="Nombre Proveedor" ItemStyle-width="150" />
                        <asp:BoundField DataField="Numero De Contacto" HeaderText="Numero De Contacto" ItemStyle-width="150" />
                        <asp:TemplateField HeaderText="Ver" ItemStyle-width="30">
                            <ItemTemplate>
                                <asp:Button ID="btnVer" runat="server" text="Ver" CssClass="volver" OnClick="btnVer_Click"/>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
