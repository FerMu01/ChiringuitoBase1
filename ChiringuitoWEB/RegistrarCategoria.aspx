<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarCategoria.aspx.cs" Inherits="ChiringuitoWEB.RegistrarCategoria" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registrar Categoria</title>
    <style>
        body {
            background-image: url('imagenes/top-view-fish-chips-plate-with-copy-space.jpg'); /* Asegúrate de que esta ruta es correcta */
            background-size: cover;
            background-position: center;
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
            font-family: Arial, sans-serif;
        }
        .card {
            background-color: #ffffff;
            box-shadow: 0 4px 20px rgba(0, 0, 0, 0.2);
            border-radius: 10px;
            display: flex;
            overflow: hidden;
            width: 800px; /* Ancho fijo de la tarjeta */
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
        }
        .image-section {
            background-image: url('imagenes/pantalla.png');
            background-size: cover;
            background-position: center;
            flex: 1;
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
    <script>
        function validateForm() {
            var textName = document.getElementById('<%= textName.ClientID %>').value.trim();
            var textDescription = document.getElementById('<%= textDescription.ClientID %>').value.trim();
            var textDescuento = document.getElementById('<%= textDescuento.ClientID %>').value.trim();
            
            if (textName === "" || textDescription === "" || textDescuento === "") {
                alert("Todos los campos son obligatorios.");
                return false;
            }

            if (textName.startsWith(" ") || textDescription.startsWith(" ") || textDescuento.startsWith(" ")) {
                alert("El primer carácter no puede ser un espacio.");
                return false;
            }
            
            return true;
        }

        // Función para evitar escribir espacios al inicio
        function preventLeadingSpace(event) {
            if (event.target.value.length === 0 && event.key === " ") {
                event.preventDefault();
            }
        }

        function setupValidation() {
            var textDescuento = document.getElementById('<%= textDescuento.ClientID %>');
            var textName = document.getElementById('<%= textName.ClientID %>');
            var textDescription = document.getElementById('<%= textDescription.ClientID %>');

            textDescuento.addEventListener('keydown', preventLeadingSpace);
            textName.addEventListener('keydown', preventLeadingSpace);
            textDescription.addEventListener('keydown', preventLeadingSpace);
        }

        document.addEventListener('DOMContentLoaded', setupValidation);
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="card">
            <div class="form-section">
                <h1>EL CHIRINGUITO</h1>
                <asp:Label ID="lblMessage" runat="server" CssClass=""></asp:Label>
                <label for="textName">Nombre Categoria</label>
                <asp:TextBox ID="textName" runat="server" placeholder="Nombre Categoria"></asp:TextBox>

                <label for="textDescription">Descripcion</label>
                <asp:TextBox ID="textDescription" runat="server" placeholder="Descripcion"></asp:TextBox>

                <label for="textDescuento">Descuento</label>
                <asp:TextBox ID="textDescuento" runat="server" placeholder="Descuento"></asp:TextBox>

                <asp:Button ID="btnRegistrar" runat="server" CssClass="registrar" Text="Registrar" OnClick="btnRegistrar_Click" OnClientClick="return validateForm();" />
                <asp:Button ID="btnOtroRegistro" runat="server" CssClass="otroRegistro" Text="Otro Registro" OnClick="btnOtroRegistro_Click" />
                <asp:Button ID="btnVolver" runat="server" CssClass="volver" Text="Volver" OnClick="btnVolver_Click" />
            </div>
            <div class="image-section"></div>
        </div>
    </form>
</body>
</html>
