<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="DesafioTeste._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="py-5 text-center">

        <h2>Portal - Paciente</h2>
        <p class="lead">Mostra informações dos pacientes.</p><br><br>
    </div>


    <div class="col-md-4">
        <p>
            <p><a href="Cads_Paciente.aspx" class="btn btn-primary btn-lg">Cadastro de Pacientes &raquo;</a></p>
        </p>
    </div>

    <p>
        <p><a href="Cons_Paciente.aspx" class="btn btn-primary btn-lg">Consulta de Pacientes &raquo;</a></p>
    </p> 

</asp:Content>
