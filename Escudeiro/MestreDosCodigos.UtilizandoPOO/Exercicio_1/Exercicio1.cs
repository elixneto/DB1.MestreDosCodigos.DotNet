using MestreDosCodigos.TrabalhandoNoConsole;
using MestreDosCodigos.UtilizandoPOO.Exercicio_1.Abstracao;
using MestreDosCodigos.UtilizandoPOO.Exercicio_1.AbstractClassVSInterface;
using MestreDosCodigos.UtilizandoPOO.Exercicio_1.AbstractClassVSInterface.Computadores;
using MestreDosCodigos.UtilizandoPOO.Exercicio_1.Encapsulamento;
using MestreDosCodigos.UtilizandoPOO.Exercicio_1.Interfaces;
using MestreDosCodigos.UtilizandoPOO.Exercicio_1.Polimorfismo;
using MestreDosCodigos.UtilizandoPOO.Exercicio_1.POO;
using System;
using System.Linq;

namespace MestreDosCodigos.UtilizandoPOO.Exercicio_1
{
    public class Exercicio1
    {
        public Exercicio1()
        {
            ConsoleHelper.Cabecalho("EXERCICIO 1");

            POO();
            Abstracao();
            Polimorfismo();
            Encapsulamento();
            AbstractClassVSInterface();
            Interfaces();
        }

        private void POO()
        {
            var carro = new Carro();

            ConsoleHelper.Subtitulo("POO",
                "Programação Orientada à Objetos. É um paradigma de programação que trata da resolução de problemas com classes, propriedades e métodos");

            TextoPOO.Mostrar();
        }

        private void Abstracao()
        {
            ConsoleHelper.Subtitulo("Abstração",
                "Capacidade de definir uma estrutura base para ser herdada com propriedades e métodos que são, ou não, implementados por padrão");

            TextoAbstracao.Mostrar();
        }

        private void Polimorfismo()
        {
            ConsoleHelper.Subtitulo("Polimorfismo",
                "Um princípio no qual duas ou mais classes derivadas de uma baseclass podem invocar métodos que têm a mesma assinatura porém comportamentos diferentes");

            TextoPolimorfismo.Mostrar();

            Passaro beijaflor = new BeijaFlor();
            Passaro avestruz = new Avestruz();

            beijaflor.BaterAsas();
            avestruz.BaterAsas();
        }

        private void Encapsulamento()
        {
            ConsoleHelper.Subtitulo("Encapsulamento",
                "Um conceito que protege a implementação e evita acessos indevidos do contexto externo definindo modificadores de acesso que alteram a visibilidade dos objetos, suas propriedades e métodos.",
                "Getters, Setters, Public, Protectedm Private, Sealed e outros recursos são utilizados para aplicar o encapasulamento no C#");

            TextoEncapsulamento.Mostrar();

            var aviao = new Aviao("LATAM", 300);
            aviao.Cor = "AMARELO";
            aviao.Decolar();
            aviao.Pousar();

            Console.WriteLine();
        }

        private void AbstractClassVSInterface()
        {
            ConsoleHelper.Subtitulo("Abstract Class VS Interface",
                "Utilizamos Interface quando é necessário expôr uma abstração como um contrato, sem implementações ou comportamentos padrão;",
                "Uma classe abstrata é utilizada quando a abstração possui comportamentos que serão reaproveitados pelas classes derivadas podendo, ou não, sobrescerver esses comportamentos para cada especificação");

            TextoAbstractClassVSInterface.Mostrar();

            Ligavel ventilador = new Ventilador();
            Ligavel lampada = new Lampada();

            ventilador.Ligar();
            ventilador.Desligar();
            lampada.Ligar();
            lampada.Desligar();

            Computador samsung = new NotebookSAMSUNG();
            Computador lenovo = new NotebookLENOVO();

            Console.WriteLine("LENOVO:");
            lenovo.Ligar();
            lenovo.Desligar();

            Console.WriteLine("SAMSUNG:");
            samsung.Ligar();
            samsung.Desligar();

            Console.WriteLine();
        }

        private void Interfaces()
        {
            ConsoleHelper.Subtitulo("IDisposable | IEnumerable | IComparable | ICloneable",
                "IDisposable: Fornece um mecanismo para liberar recursos não gerenciados;",
                "IEnumerable: Expõe um enumerador que dá suporte à iteração em uma coleção;",
                "IComparable: Define um método de comparação que permite ordenar e classificar as instâncias;",
                "ICloneable: Permite uma implementação que cria uma cópia superficial ou profunda de um objeto;");

            TextoInterfaces.MostrarIDisposable();

            var instancia = new Descartavel();
            using (instancia)
            {
                // Mesmo não chamando diretamente o método Descartavel.Dispose() ele é invocado
                // implicitamente com a utilização do using (que só possível em classes que 
                // herdam de IDisposable)
            }
            instancia.Dispose(); // Pode ser chamado diretamente


            TextoInterfaces.MostrarIEnumerable();

            var listaDeEnumeravel = new ListaDeEnumeravel();
            var arrayDeEnumeravel = new MinhaClasse[3]
            {
                    new MinhaClasse(1, "Grande"),
                    new MinhaClasse(2, "Pequeno"),
                    new MinhaClasse(3, "Médio")
            };
            listaDeEnumeravel.Adicionar(arrayDeEnumeravel);
            foreach (var enumeravel in listaDeEnumeravel)
            {
                // Ao executar o foreach é invocado o método Next() do Enumerador
            }
            for (int indice = 0; indice < listaDeEnumeravel.Tamanho; indice++)
            {
                // Ao executar o for o método Next() não é chamado implicitamente
            }

            TextoInterfaces.MostrarIComparable();

            var lista = arrayDeEnumeravel.ToList();
            Console.WriteLine("Antes do Sort()");
            foreach (var item in lista)
            {
                Console.WriteLine(item.Nome);
            }

            lista.Sort();

            Console.WriteLine();
            Console.WriteLine("Depois do Sort()");
            foreach (var item in lista)
            {
                Console.WriteLine(item.Nome);
            }

            TextoInterfaces.MostrarIClonable();

            var minhaClasse = new MinhaClasse(1, "Meu Nome");
            minhaClasse.Referencia = minhaClasse;

            var cloneDaMinhaClasse = minhaClasse.Clone();

            Console.WriteLine("- Utilizando o método Clone() que retorna uma nova classe a referência não é mantida:");
            Console.WriteLine(minhaClasse);
            Console.WriteLine(cloneDaMinhaClasse);
            Console.WriteLine("-----------------");
            Console.WriteLine("Ao trocar o nome:");
            minhaClasse.Nome = "Y";
            Console.WriteLine(minhaClasse);
            Console.WriteLine(cloneDaMinhaClasse);

            Console.WriteLine();
            Console.WriteLine("- Utilizando o método Clone() que retorna MemberwiseClone() a referência é mantida:");
            var memberwise = new MinhaClasse(10, "Memberwise");
            memberwise.Referencia = memberwise;
            var memberwiseClone = memberwise.Clone();
            ((MinhaClasse)memberwiseClone).ID = 888;
            Console.WriteLine(memberwise);
            Console.WriteLine(memberwiseClone);

            Console.WriteLine("-----------------");
            Console.WriteLine("Ao trocar o nome:");
            ((MinhaClasse)memberwise).Nome = "X";
            Console.WriteLine(memberwise);
            Console.WriteLine(memberwiseClone);
        }
    }
}

