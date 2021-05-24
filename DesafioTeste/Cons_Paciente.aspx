<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Cons_Paciente.aspx.cs" Inherits="DesafioTeste.Cons_Paciente" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<link href="//maxcdn.bootstrapcdn.com/bootstrap/3.3.0/css/bootstrap.min.css" rel="stylesheet" id="bootstrap-css"> 
<script src="../../assets/js/vendor/popper.min.js"></script>
<script src="../../dist/js/bootstrap.min.js"></script>
<script src="../../assets/js/vendor/holder.min.js"></script>
<script src="//Script/validacoes.js"></script>


<script type="text/javascript">


</script>  
    
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

    <form class="form-horizontal" id="form2">
      <fieldset>

            <div class="panel panel-primary">
                <div class="panel-heading">Cadastro de Cliente</div>

            <div class="form-group">

          <div class="col-md-6 mb-3" id="divpesq" runat="server">
                <label for="CPF">CPF</label>
                <input type="text" class="form-control" id="txtpesqcpf" runat="server" style="width :150px" placeholder="" value="" 
                            required="" maxlength="11" pattern="[0-9]+$" />   
                <asp:Button ID="btnconsultacpf" runat="server" CssClass="button" Text="Consulta CPF"  OnClick="btnConsultarCPF_Click"/>
          </div>
                
          <div class="col-md-6 mb-3" id="divdados" runat="server">
            <label for="Prontuario">Prontuário</label>
            <input type="text" class="form-control" id="txtprontuario" runat="server" placeholder="" value="" required />
    
            <label for="Nome">Nome do Paciente</label>
            <input type="text" class="form-control" id="txtnome" runat="server" placeholder="" value=""   required />
          
            <label for="Sobrenome">Sobrenome do Paciente</label>
            <input type="text" class="form-control" id="txtsobrenome" runat="server" placeholder="" value=""  required />

            <label for="Data Nascimento">Data Nascimento</label>
            <input type="date" max="9999-12-31" class="form-control" id="txtdt_nasc" runat="server" style="width :180px " placeholder="00/00/0000" 
                   pattern="\d{1,2}/\d{1,2}/\d{4}" value=""  required/><br>
        

            <label for="Genero">Gênero</label>
            <select class="custom-select d-block w-200" id="cbogenero" runat="server"  required>
                <option value="">Choose...</option>
                <option>Feminino</option>
                <option>Masculino</option>
                <option>Não Definido</option>
                <option>Outro</option>
            </select>            
            <br><br>
    
            
            <label for="CPF">CPF</label>
            <input type="text" class="form-control" id="txtcpf" runat="server" style="width :150px" placeholder="" value="" 
                        required="" maxlength="11" pattern="[0-9]+$" />
            
           
            <label for="RG">R.G.</label>
            <input type="text" class="form-control" id="txtrg" runat="server" style="width :150px" placeholder="" value="" 
                        required /><br>
       
           
            <label for="UFRG">UF do RG</label>
            <select class="custom-select d-block w-100" id="cboufrg" runat="server" data-error="Por favor, selecione um estado." required>
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
         
            
            <label for="email">Email <span class="text-muted">(Optional)</span></label>
            <input type="email" class="form-control" id="txtemail" runat="server" placeholder="you@example.com" 
                   typeof ="text" pattern="[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}$">

   
            <label for="Celular">Celular</label>
            <input type="text" class="form-control" id="txtcel" runat="server" style="width :150px" placeholder="" value="" 
                         required maxlength="13" pattern="\[0-9]{2}\ [0-9]{4,6}-[0-9]{3,4}$"/>
     

            <label for="Telefone">Telefone<span class="text-muted">(Optional)</span></label>
            <input type="text" class="form-control" id="txttel" runat="server" style="width :150px" placeholder="" value="" maxlength="13" pattern="\[0-9]{2}\ [0-9]{4,6}-[0-9]{3,4}$"/>

            
            <label for="Convenio">Convenio</label>
            <input type="text" class="form-control" id="txtconvenio" runat="server" placeholder="" value="" >
   
            <label for="CarteirinhaConvenio">Carteirinha do Convenio</label>
            <input type="text" class="form-control" id="txtcarteirinha" runat="server" placeholder="" value="" >

            <label for="Valid_CarteirinhaConvenio">Validade da Carteirinha do Convenio</label>
            <input type="date" max="9999-12" class="form-control" id="txtval_cart" runat="server" style="width :120px" 
                placeholder="mm/yyyy" pattern="\d{1,2}/\d{4}" value="" >
          </div>

          <div class="row">
            <asp:Button ID="btnLimpar" runat="server" CssClass="button" Text="Limpar"  OnClick="btnLimpar_Click"/>
            <asp:Button ID="btnAlterar" runat="server" CssClass="button" Text="Alterar" OnClick="btnAlterar_Click"/>
          </div>

      </fieldset>
    </form>

  </body>

</html>


</asp:Content>

