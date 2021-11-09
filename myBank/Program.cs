using System;


namespace myBank
{
    class Program
    {
        static void Main(string[] args)
        {

             Gerente gerenteOscar = new Gerente (){

                Nome = "Óscar",
                CPF = "333.423.147-12",
                Salario = 3000 ,
                NumeroDeAgencias = 4
            };
             gerenteOscar.Bonificacao = gerenteOscar.Salario;

            Vendedor VendedorIsaac = new Vendedor()
            {
                Nome = "Isaac Hill Wingding",
                CPF = "120.240.360-48",
                Salario = 1000 ,
                NumeroClientesAtendidos = 3
            };
            VendedorIsaac.Bonificacao = VendedorIsaac.Salario;

            Vendedor VendedorJoaoS = new Vendedor()
            {
                Nome = "João Sanchez",
                CPF = "999.999.999-99",
                Salario = 1000 ,
                NumeroClientesAtendidos = 1
            };
            VendedorJoaoS.Bonificacao = VendedorJoaoS.Salario;

            Vendedor VendedorWilson = new Vendedor()
            {
                Nome = "Wilson Roberto Silva",
                CPF = "123.456.68-91" ,
                Salario = 1000 ,
                NumeroClientesAtendidos = 2
            };
            VendedorWilson.Bonificacao = VendedorWilson.Salario;

            ContaCorrente contaJVGS = new ContaCorrente ("João Victor Godoy da Silva","153.557.656-10",365,3000,VendedorIsaac);
            contaJVGS.Conta = 2048;

            ContaCorrente ContaJose = new ContaCorrente ("José Pereira","159.438.345-80",365,2000,VendedorJoaoS);
            ContaJose.Conta = 5534;

            ContaCorrente ContaAdamastor = new ContaCorrente ("Adamastor Wakill","145.555.941-12",258,1000,VendedorWilson);
            ContaAdamastor.Conta = 3456;
           
            
            Console.WriteLine("----- Contas Correntes -----");
            Console.WriteLine("Conta 1: \nNome: " + contaJVGS.Titular + ";" + "\nCPF: " + contaJVGS.CPF + ";" + "\nAgência: " + contaJVGS.Agencia + ";" + "\nConta: " + contaJVGS.Conta + ";" + "\nSaldo: R$" + contaJVGS.Saldo + ".");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Conta 2: \nNome: " + ContaJose.Titular + ";" + "\nCPF: " + ContaJose.CPF + ";" + "\nAgência: " + ContaJose.Agencia + ";" + "\nConta: " + ContaJose.Conta + ";" + "\nSaldo: R$" + ContaJose.Saldo + ".");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Conta 3: \nNome: " + ContaAdamastor.Titular + ";" + "\nCPF: " + ContaAdamastor.CPF + ";" + "\nAgência: " + ContaAdamastor.Agencia + ";" + "\nConta: " + ContaAdamastor.Conta + ";" + "\nSaldo: R$" + ContaAdamastor.Saldo + ".");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("----- Funcinários -----");
            Console.WriteLine("Vendedor 1: \nNome: " + VendedorIsaac.Nome + ";" + "\nCPF: " + VendedorIsaac.CPF + ";" + "\nSalário: R$" + VendedorIsaac.Salario + ";" + "\nBonificação Anual R$: " + VendedorIsaac.Bonificacao + ";" + "\nRemuneração Total Anual: R$" + VendedorIsaac.RemuneracaoTotal(VendedorIsaac.Salario,VendedorIsaac.Bonificacao) + ";" + "\nDias de Férias: " + VendedorIsaac.CalcularFerias() + ".");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Vendedor 2: \nNome: " + VendedorJoaoS.Nome + ";" + "\nCPF: " + VendedorJoaoS.CPF + ";" + "\nSalário: R$" + VendedorJoaoS.Salario + ";" + "\nBonificação Anual R$: " + VendedorJoaoS.Bonificacao + ";" + "\nRemuneração Total Anual: R$" + VendedorJoaoS.RemuneracaoTotal(VendedorJoaoS.Salario,VendedorJoaoS.Bonificacao) + ";" + "\nDias de Férias: " + VendedorJoaoS.CalcularFerias() + ".");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Vendedor 3: \nNome: " + VendedorWilson.Nome + ";" + "\nCPF: " + VendedorWilson.CPF + ";" + "\nSalário: R$" + VendedorWilson.Salario + ";" + "\nBonificação Anual R$: " + VendedorWilson.Bonificacao + ";" + "\nRemuneração Total Anual: R$" + VendedorWilson.RemuneracaoTotal(VendedorWilson.Salario,VendedorWilson.Bonificacao) + ";" + "\nDias de Férias: " + VendedorWilson.CalcularFerias() + ".");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Gerente : \nNome: " + gerenteOscar.Nome + ";" + "\nCPF: " + gerenteOscar.CPF + ";" + "\nSalário: R$" + gerenteOscar.Salario + ";" + "\nBonificação Anual R$: " + gerenteOscar.Bonificacao + ";" + "\nRemuneração Total Anual: R$" + gerenteOscar.RemuneracaoTotal(gerenteOscar.Salario,gerenteOscar.Bonificacao) + ";" + "\nDias de Férias: " + gerenteOscar.CalcularFerias() + ".");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Total de contas criadas:" + ContaCorrente.TotalContaCriadas + ".");
        }}}
