// Desafio: programa no VS, com menu, para cadastrar usuários no sistema e gerar seus emails

// automaticamente. Os usuários (nome completo e email) devem ser persistidos em arquivo.

// Além disso, é preciso mantê-los em uma lista dinâmica em memória, que é populada sempre que

// o programa executa.



// Menu

// 1 - Cadastrar usuário (só o nome completo)

// - gerar o email

// - verificar se este email já foi gerado (na lista)

// - caso não exista, colocar na lista e persistir no arquivo: nome completo;email

// 2 - Listar os usuários (nome completo e email)

// - mostrar ordenado (pode)

// 3 - Sair

// Opção:




//StreamReader, StreamWriter, List, Usuario

//popular a lista com dados do arquivo

/// <summary>
/// Chamando a classe apropriada para o sistema
/// </summary>
using ProblemaEmail;

/// <summary>
/// Criação da lista
/// </summary>
List<Usuario> listaUsuarios = new List<Usuario>();
string opcao;

//popular a lista com dados do arquivo
Util.carregarListas(listaUsuarios);

do
{
    /// <summary>
    /// Criação de MENU interativo para o usuário
    /// </summary>
    Console.Clear();
    Console.WriteLine("MENU");
    Console.WriteLine("1 - Cadastrar um usuario");
    Console.WriteLine("2 - Listar usuários");
    Console.WriteLine("3 - Sair");

    /// <summary>
    /// Colhendo dado do usuário para iniciar operação
    /// </summary>
    Console.Write("Opção: ");
    opcao = Console.ReadLine();


    /// <summary>
    /// Realizando cadastro do usuário
    /// </summary>
    switch (opcao)
    {
        case "1":
            //cadastrar um usuario;
            Util.cadastrarUsuario("Cadastrando usuário", listaUsuarios);
            break;
        case "2":
            //listar usuarios;
            Util.exibirLista("Exibindo a lista de usuários", listaUsuarios);
            break;
        case "3":
            Console.WriteLine("Obrigado por usar o sistema");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
    Console.Write("Pressione algo para continuar!");
    Console.ReadKey();
} while (opcao != "3");


