using System;

namespace FilaFIFO{

    class Program{
        static void Main(string[] args){

            Pilha pilha = new();

            //Inserção
            pilha.push(12);
            pilha.push(7);
            pilha.push(10);
            
            //Percurso = Impressão
            pilha.imprimir();

            //Consulta
            No noAtual = null;
            No noAnterior = null;
            pilha.consulta(7, ref noAtual, ref noAnterior);

            //Remoção
            pilha.pop();
            pilha.pop();
            pilha.pop();
            pilha.imprimir();

            //Contagem
            Console.WriteLine("Quantidade de elementos: " + pilha.contarElementos());

            //Par ou Ímpar
            pilha.push(12);
            pilha.push(7);
            pilha.push(10);
            pilha.ParOuImpar();


            //Separação de positivos e negativos
            Pilha pilhaPositivos = new();
            Pilha pilhaNegativos = new();
            pilha.separarPositivosENegativos(out pilhaPositivos, out pilhaNegativos);
            Console.WriteLine("Pilha de positivos:");
            pilhaPositivos.imprimir();
            Console.WriteLine("Pilha de negativos:");
            pilhaNegativos.imprimir();

            //Inversão
            pilha.ehPalindromo();

            // Inversão
            pilha.inverter();
            
        
            // transfirarElementos
            Pilha pilha2 = new();
            pilha2.push(1);
            pilha2.push(2);
            pilha2.push(3);
            pilha2.push(4);
            pilha2.push(5);
            


            
            
            
            

        }
    }
}