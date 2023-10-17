using Banco;

// "prepara" o nosso banco de dados
List<Conta> bancoDados = new List<Conta>();

// prepara a tela do computador para ser usada pelo software
Tela tela = new Tela();
tela.configurarTela();

// crias as variáveis que serão usadas no menu de opções 
string opcao;
List<string> menuPrincipal = new List<string>();
menuPrincipal.Add("1 - Lançar transação ");
menuPrincipal.Add("2 - Emitir extrato   ");
menuPrincipal.Add("3 - Consultar conta  ");
menuPrincipal.Add("4 - Bloqueio de conta");
menuPrincipal.Add("5 - Cadastro de conta");
menuPrincipal.Add("0 - Sair             ");

// agora vem o programa de verdade
while (true)
{
    tela.montarTelaSistema("Banco de Sistema");
    opcao = tela.mostrarMenu(menuPrincipal, 3, 3);

    // o usuario pediu pra sair do sistema
    if (opcao == "0") break;

    // usuario pediu pra cadastrar uma nova cona
    if (opcao == "5")
    {
        tela.montarMoldura(7, 7, 40, 12, "Nova conta");

        // pergunta o numero da conta
        Console.SetCursorPosition(8, 9);
        Console.Write("Numero  : ");
        string num = Console.ReadLine();

        // pergunta o titular da conta
        Console.SetCursorPosition(8, 10);
        Console.Write("Titular :");
        string tit = Console.ReadLine();

        // solicita confirmação para cadastro
        Console.SetCursorPosition(8, 11);
        Console.Write("Confirma cadastro (S/N) : ");
        string resp = Console.ReadLine();

        // coloca a nova conta no BD caso o usuário confirme
        // o cadastro
        if (resp.ToUpper()=="S")
        {
            // "cadastra" no BD
            bancoDados.Add(  new Conta(num,tit)  );

            // Conta c = new Conta(num,tit);
            // bancoDados.Add(c);
        }
    }
}
