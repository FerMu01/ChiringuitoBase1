<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistrarProveedor.aspx.cs" Inherits="ChiringuitoWEB.RegistrarProveedor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registrar Proveedor</title>
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
            background-color: #800080; /* Color de fondo para todos los botones */
            color: white; /* Color de texto para todos los botones */
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
        function validateNumberInput(event) {
            // Permite solo números
            var charCode = event.which ? event.which : event.keyCode;
            if (charCode > 31 && (charCode < 48 || charCode > 57)) {
                event.preventDefault();
            }
        }

        function validateFirstCharacterNoSpace(event) {
            // No permite espacio como primer carácter
            var input = event.target;
            if (input.value.length === 0 && event.which === 32) {
                event.preventDefault();
            }
        }

        function setupValidation() {
            var textNit = document.getElementById('<%= textNit.ClientID %>');
            var textNumber = document.getElementById('<%= textNumber.ClientID %>');
            var textName = document.getElementById('<%= textName.ClientID %>');

            textNit.addEventListener('keydown', validateNumberInput);
            textNit.addEventListener('keydown', validateFirstCharacterNoSpace);

            textNumber.addEventListener('keydown', validateNumberInput);
            textNumber.addEventListener('keydown', validateFirstCharacterNoSpace);

            textName.addEventListener('keydown', validateFirstCharacterNoSpace);
        }

        document.addEventListener('DOMContentLoaded', setupValidation);
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="card">
            <div class="form-section">
                <h1>EL CHIRINGUITO</h1>
                <asp:Label ID="lblMessage" runat="server" CssClass=""></asp:Label> <!-- Cambié la clase a una cadena vacía -->
                <label for="cinit">NIT</label>
                <asp:TextBox ID="textNit" runat="server" placeholder="Numero De NIT"></asp:TextBox>

                <label for="nombre-proveedor">Nombre Proveedor</label>
                <asp:TextBox ID="textName" runat="server" placeholder="Nombre Proveedor"></asp:TextBox>

                <label for="numero-telefono">Numero De Telefono</label>
                <asp:TextBox ID="textNumber" runat="server" placeholder="Numero De Telefono"></asp:TextBox>

                <asp:Button ID="btnRegistrar" runat="server" CssClass="boton" Text="Registrar" OnClick="btnRegistrar_Click" />
                <asp:Button ID="btnOtroRegistro" runat="server" CssClass="boton" Text="Otro Registro" OnClick="btnOtroRegistro_Click" />
                <asp:Button ID="btnVolver" runat="server" CssClass="boton" Text="Volver" OnClick="btnVolver_Click" />
            </div>
            <div class="image-section"></div>
        </div>
    </form>
</body>
</html>
