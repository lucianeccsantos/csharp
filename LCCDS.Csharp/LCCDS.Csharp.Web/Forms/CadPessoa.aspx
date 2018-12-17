<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CadPessoa.aspx.cs" Inherits="LCCDS.Csharp.Web.Forms.CadPessoa" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Cadastro de Pessoa</h1>
    <p>
        <asp:Label runat="server"> Nome:</asp:Label>
        <asp:TextBox ID="txtNome" CausesValidation="true" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvNome" runat="server" ControlToValidate="txtNome" ErrorMessage="O nome é obrigatório" ValidationGroup="cadPessoa"></asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:Label runat="server"> Logradouro:</asp:Label>
        <asp:TextBox ID="txtLogradouro" CausesValidation="true" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvLogradouro" runat="server" ControlToValidate="txtLogradouro" ErrorMessage="O logradouro é obrigatório" ValidationGroup="cadPessoa"></asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:Label runat="server"> Nº:</asp:Label>
        <asp:TextBox ID="txtNumero" CausesValidation="false" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label runat="server"> Complemento:</asp:Label>
        <asp:TextBox ID="txtComplemento" CausesValidation="false" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label runat="server"> Bairro:</asp:Label>
        <asp:TextBox ID="txtBairro" CausesValidation="false" runat="server"></asp:TextBox>
        <asp:Label runat="server"> Cidade:</asp:Label>
        <asp:TextBox ID="txtCidade" CausesValidation="true" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvCidade" runat="server" ControlToValidate="txtCidade" ErrorMessage="A cidade é obrigatória" ValidationGroup="cadPessoa"></asp:RequiredFieldValidator>
        <asp:Label runat="server"> Estado:</asp:Label>
        <asp:TextBox ID="txtEstado" CausesValidation="true" runat="server" MaxLength="2"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvEstado" runat="server" ControlToValidate="txtEstado" ErrorMessage="O estado é obrigatório" ValidationGroup="cadPessoa"></asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:Label runat="server"> CEP:</asp:Label>
        <asp:TextBox ID="txtCep" CausesValidation="true" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvCep" runat="server" ControlToValidate="txtCep" ErrorMessage="O CEP é obrigatório"  ValidationGroup="cadPessoa"></asp:RequiredFieldValidator>
    </p>
    <p>
        <asp:Button ID="btnLimpar" CommandName="Limpar" runat="server" Text="Limpar" OnClick="btnLimpar_Click"  />
        <asp:Button ID="btnEnviar" CommandName="Enviar" runat="server" Text="Enviar" ValidationGroup="cadPessoa" OnClick="btnEnviar_Click"/>
    </p>
    <asp:ValidationSummary runat="server" ID="vlsPessoa" DisplayMode="List" ShowMessageBox="false" ValidationGroup="cadPessoa"/>
</asp:Content>
