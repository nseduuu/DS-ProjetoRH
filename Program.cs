using System; 
using Aula02RH.models; 
using Aula02RH.models.Enuns; //referenciando as listas de tipos

namespace Aula02RH
{
    class Program
    {
        static void Main(string[] args)
        {      
            Funcionario func = new Funcionario();

            Console.WriteLine("Digite o nome do funcionario: ");
            func.Nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF: ");
            func.Cpf = Console.ReadLine();

            Console.WriteLine("Digite a data de adimissão: ");
            func.DataAdmissao = DateTime.Parse(Console.ReadLine()); 

            Console.WriteLine("Digite o salario: ");
            func.Salario = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Escolha o tipo de Funcinário (1 - CLT | 2 - Aprendiz) ");
            int opcao = int.Parse(Console.ReadLine());

            func.TipoFuncionario = (opcao == 1) ? TipoFuncionarioEnum.CLT : TipoFuncionarioEnum.Aprendiz;
            //fazer a atividade a partir daqui
            // ExibirPeriodoExperiencia, contarCaracteres, validarCpf 


            func.ReajusteSalarial();
            decimal valorDescontoVT = func.CalcularDescontoVT(6);

            func.ExibirPeriodoExperiencia();
            string experiencia = func.ExibirPeriodoExperiencia();

            // quando o metodo estiver "private" ele é somente reconhecido dentro do mesmo arquivo, não da para referenciar em outro

            Console.WriteLine("=================================");
            Console.WriteLine($"O tempo de experiência do funcionario é: {experiencia}. \n");
            Console.WriteLine($"O sálario reajustado é: {func.Salario}. \n");
            Console.WriteLine($"O desconto do VT é de:  {valorDescontoVT}.");
            Console.WriteLine("=================================");
        }
    }
}

