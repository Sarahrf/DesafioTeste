<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Cads_Paciente.aspx.cs" Inherits="DesafioTeste.Cads_Paciente" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <link href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css"> 
    <script src="../../assets/js/vendor/popper.min.js"></script>
    <script src="../../dist/js/bootstrap.min.js"></script>
    <script src="../../assets/js/vendor/holder.min.js"></script>
    <script src="//Script/validacoes.js"></script>


 <html>
  <head>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
    <meta name="description" content="">
    <meta name="author" content="">
    <link rel="icon" href="/docs/4.0/assets/img/favicons/favicon.ico">

    <link href="../../dist/css/bootstrap.min.css" rel="stylesheet">

    <link href="blog.css" rel="stylesheet">
  </head>

  <body>
        <form class="form-horizontal" id="form1">
            <fieldset>

             <div class="panel panel-primary">
                 <div class="panel-heading">Cadastro de Cliente</div>
    
                 <div class="panel-body">
             <div class="form-group">


              <div id ="divdadoscad" class="col-md-6 mb-3" runat ="server">
                <label >Prontuário</label>
                <input type="text" class="form-control" id="txtcadprontuario" runat="server" placeholder="" value=""  required />
    
                <label >Nome do Paciente</label>
                <input type="text" class="form-control" id="txtcadnome" runat="server" placeholder="" value=""   required />
          
                <label >Sobrenome do Paciente</label>
                <input type="text" class="form-control" id="txtcadsobrenome" runat="server" placeholder="" value=""  required />

                <label >Data Nascimento</label>
                <input type="date" max="9999-12-31" class="form-control" id="txtcaddt_nasc" runat="server" style="width :180px " placeholder="00/00/0000" 
                       pattern="\d{1,2}/\d{1,2}/\d{4}" value=""  required/><br>
        

                <label >Gênero</label>
                <select class="custom-select d-block w-200" id="cbogenero" runat="server"  required>
                    <option value="">Choose...</option>
                    <option>Feminino</option>
                    <option>Masculino</option>
                    <option>Não Definido</option>
                    <option>Outro</option>
                </select>            
                <br><br>
    
            
                <label >CPF</label>
                <input type="text" class="form-control" id="txtcadcpf" runat="server" style="width :150px" placeholder="" value="" 
                       data-error="Por favor, Inserir o CPF do paciente." required="" maxlength="11" pattern="[0-9]+$" />
            
           
                <label >R.G.</label>
                <input type="text" class="form-control" id="txtcadrg" runat="server" style="width :150px" placeholder="" value=""  required /><br>
       
           
                <label >UF do RG</label>
                <select class="custom-select d-block w-100" id="cboufrg" runat="server"  required>
                    <option value="">Choose...</option>
                    <option>RO</option>
                    <option>AC</option>
                    <option>AM</option>
                    <option>RR</option>
                    <option>PA</option>
                    <option>AP</option>
                    <option>TO</option>
                    <option>MA</option>
                    <option>PI</option>
                    <option>CE</option>
                    <option>RN</option>
                    <option>PB</option>
                    <option>PE</option>
                    <option>AL</option>
                    <option>SE</option>
                    <option>BA</option>
                    <option>MG</option>
                    <option>ES</option>
                    <option>RJ</option>
                    <option>SP</option>
                    <option>PR</option>
                    <option>SC</option>
                    <option>RS</option>
                    <option>MS</option>
                    <option>MT</option>
                    <option>GO</option>
                    <option>DF</option>
                </select>
                <br><br>
         
            
                <label>Email <span class="text-muted">(Optional)</span></label>
                <input type="email" class="form-control" id="txtcademail" runat="server" placeholder="you@example.com" 
                       typeof ="text" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$">

   
                <label >Celular</label>
                <input type="text" class="form-control" id="txtcadcel" runat="server" style="width :150px" placeholder="" value="" 
                             required maxlength="13" pattern="\[0-9]{2}\ [0-9]{4,6}-[0-9]{3,4}$"/>
     

                <label >Telefone<span class="text-muted">(Optional)</span></label>
                <input type="text" class="form-control" id="txtcadtel" runat="server" style="width :150px" placeholder="" value="" 
                       maxlength="13" pattern="\[0-9]{2}\ [0-9]{4,6}-[0-9]{3,4}$"/>

            
                <label >Convenio</label>
                <input type="text" class="form-control" id="txtcadconvenio" runat="server" placeholder="" value="" >
   
                <label>Carteirinha do Convenio</label>
                <input type="text" class="form-control" id="txtcadcarteirinha" runat="server" placeholder="" value="" >

                <label >Validade da Carteirinha do Convenio</label>
                <input type="date" max="9999-12" class="form-control" id="txtcadval_cart" runat="server" style="width :120px" 
                       placeholder="mm/yyyy" pattern="\d{1,2}/\d{4}" value="" >
              </div>

              <div class="row">
                <asp:Button ID="btnLimpar" runat="server" CssClass="button" Text="Limpar"  OnClick="btnLimpar_Click"/>
                <asp:Button ID="btnSalvar" runat="server" CssClass="button" Text="Salvar" OnClick="btnSalvar_Click" />
              </div>

          </fieldset>

        </form>
    </body>
    </html>
</asp:Content>