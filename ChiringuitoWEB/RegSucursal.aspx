<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegSucursal.aspx.cs" Inherits="ChiringuitoWEB.RegSucursal" %>
<%@ Import Namespace="ChiringuitoWEB.Helpers" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registrar Sucursal</title>
    <style>
        body {
            background-image: url('imagenes/Prov.jpg'); /* Asegúrate de que esta ruta es correcta */
            background-size: cover;
            background-position: center;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
            font-family: Arial, sans-serif;
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
        .form-section input, .form-section select {
            width: calc(100% - 20px); /* Ajuste del ancho de los inputs y select */
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
            background-color: #800080; /* Color de fondo para todos los botones */
            color: white; /* Color de texto para todos los botones */
        }
        .form-section button:hover {
            background-color: #4B0082; /* Color de fondo al pasar el cursor */
        }
        .image-section {
            flex: 1;
            display: flex;
            justify-content: center;
            align-items: center;
        }
        .error-message {
            color: red;
            margin-bottom: 10px;
        }
        .success-message {
            color: green;
            margin-bottom: 10px;
        }
    </style>
    <script src="~/Scripts/jquery-3.7.1.min.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="form-section">
            <h1>Registrar Sucursal</h1>
            <asp:Label ID="lblMessage" runat="server" CssClass=""></asp:Label>
            
            <label for="codigo-sucursal">Código de Sucursal</label>
            <asp:TextBox ID="textCodigo" runat="server" placeholder="Código de Sucursal"></asp:TextBox>
            
            <label for="nombre-sucursal">Nombre de Sucursal</label>
            <asp:TextBox ID="textNombre" runat="server" placeholder="Nombre de Sucursal"></asp:TextBox>
            
            <label for="direccion-sucursal">Dirección de Sucursal</label>
            <asp:TextBox ID="textDireccion" runat="server" placeholder="Dirección de Sucursal"></asp:TextBox>
            
            <label for="ciudad">Ciudad</label>
            <asp:TextBox ID="textCiudad" runat="server" placeholder="Ciudad"></asp:TextBox>
            <label for="comboBox1">Ciudad</label>
            <asp:DropDownList ID="cbxCity" runat="server">
            
            </asp:DropDownList>
            
            <label for="comboBox2">Tipo de Sucursal</label>
            <asp:DropDownList ID="cbxTipo" runat="server">
                
            </asp:DropDownList>

            <asp:Button ID="btnRegistrar" runat="server" CssClass="boton" Text="Registrar"  />
            <asp:Button ID="btnOtroRegistro" runat="server" CssClass="boton" Text="Otro Registro" />
            <asp:Button ID="btnVolver" runat="server" CssClass="boton" Text="Volver" />
        </div>
        <div class="image-section">
            <% if (IsPostBack) { %>
                <%= ChiringuitoWEB.Helpers.MapsHelper.GetBingHtml(
                    key: "AnwbaMoJzU83DbBYxWWGkM5_t-vh8km3PNxeOmv0sVAjHZkeO-AmJbCSqY9hZZgd",
                    latitude: Request["latitude"],
                    longitude: Request["longitude"],
                    width: "700",
                    height: "700"
                ) %>
            <% } %>
        </div>
    </form>
</body>
</html>
