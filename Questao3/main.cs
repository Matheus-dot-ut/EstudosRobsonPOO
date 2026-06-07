        Console.WriteLine("=== CADASTRO DO CARRO ===");
        Carro carro = new Carro();
        carro.ReceberDadosCarro();
 
        Console.WriteLine("\n=== CADASTRO DA MOTO ===");
        Moto moto = new Moto();
        moto.ReceberDadosMoto();
 
        Console.WriteLine("\n=== CADASTRO DO CAMINHÃO ===");
        Caminhao caminhao = new Caminhao();
        caminhao.ReceberDadosCaminhao();
 
 
        Console.WriteLine("\n[ CARRO ]");
        carro.MostrarDados();
 
        Console.WriteLine("\n[ MOTO ]");
        moto.MostrarDados();
 
        Console.WriteLine("\n[ CAMINHÃO ]");
        caminhao.MostrarDados();
