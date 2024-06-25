
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ChiringuitoWEB.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
    <style>
        body {
            background-image: url('imagenes/fondoq.jpg'); /* Asegúrate de que esta ruta es correcta */
            background-size: cover;
            background-position: center;           
            display: flex;
            justify-content: center;
            align-items: center;
            height: 100vh;
            margin: 0;
        }
        .container {
            display: flex;
            border-radius: 48px;
            overflow: hidden;
            box-shadow: 0 100px 100px rgba(0, 0, 0, 0.2);
            position: relative;
            width: 906px;
            height: 434px;
        }
        .left-panel, .right-panel {
            height: 434px;
            width: 453px;
        }
        .left-panel {
            background-image: url('imagenes/interfaz.png');
            background-size: cover;
            box-shadow: 0 100px 100px rgba(0, 0, 0, 0.2);
        }
        .right-panel {
            background-image: url('imagenes/interfaz 2.png');
            background-size: cover;
            display: flex;
            justify-content: center;
            align-items: center;
            box-shadow: 0 100px 100px rgba(0, 0, 0, 0.2);
        }
        .label {
            margin-bottom: 190px;
            color: ghostwhite;
        }
        .form-container {
            position: absolute;
            width: 453px;
            height: 434px;
            border-radius: 48px;
            display: flex;
            box-shadow: 0 100px 100px rgba(0, 0, 0, 0.2);
            flex-direction: column;
            justify-content: center;
            align-items: flex-end;
            padding: 20px;
            margin-bottom: -100px;
            right: 0;
        }
        .input-group {
            display: flex;
            align-items: center;
            margin-bottom: 35px;
            width: 80%;
            justify-content: flex-start;
        }
        .input-group input {
            font-family: 'Arial', sans-serif;
            font-size: 18px;
            font-weight: bold;
            padding: 10px;
            width: 70%;
            border: none;
            outline: none;
            background-color: transparent;
            color: white;
            border-bottom: 2px solid black;
        }
        .input-group input::placeholder {
            color: white; /* Color del placeholder */
        }
        .input-group i {
            color: white;
            margin-right: 10px;
            font-size: 22px;
        }
        .buttons {
            display: flex;
            justify-content: flex-start;
            width: 80%;
            gap: 125px;
            box-shadow: 0 100px 100px rgba(0, 0, 0, 0.2);
            margin-top: 30px; /* Mover botones más abajo */
            margin-left: 35px; /* Mover botones un poco a la derecha */
        }
        .button {
            background-color: #01C4DA;
            font-family: 'Impact', sans-serif;
            font-size: 19px;
            color: white;
            border: none;
            padding: 10px 20px;
            cursor: pointer;
            box-shadow: 0 100px 100px rgba(0, 0, 0, 0.2);
            border-radius: 5px;
            text-align: center;
        }
    </style>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css"/>
    <script>
        function redirectToIngresar() {
            document.getElementById('<%= btnIngresar.ClientID %>').click();
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <div class="left-panel"></div>
            <div class="right-panel">
                <div class="label">
                    <asp:Label ID="lblErrorMessage" CssClass="error" runat="server"></asp:Label>
                </div>
                <div class="form-container">
                    <div class="input-group">
                        <i class="fas fa-user"></i>
                        <asp:TextBox ID="txtUsername" runat="server" CssClass="input-text" placeholder="Nombre De Usuario"></asp:TextBox>
                    </div>
                    <div class="input-group">
                        <i class="fas fa-lock"></i>
                        <asp:TextBox ID="txtPassword" runat="server" CssClass="input-text" TextMode="Password" placeholder="Ingresa Tu Contraseña"></asp:TextBox>
                    </div>
                    <div class="buttons">
                        <asp:Button ID="btnSalir" runat="server" CssClass="button" Text="Salir" />
                        <asp:Button ID="btnIngresar" runat="server" CssClass="button" Text="Ingresar" OnClick="btnIngresar_Click" style="display:none;" />
                        <button type="button" class="button" onclick="redirectToIngresar()">Entrar</button>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
