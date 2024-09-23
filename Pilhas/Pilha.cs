using System.Diagnostics.Contracts;

public class Pilha
{
    private No inicio;
    public No topo;

    public Pilha()
    {
        this.topo = null;
        this.inicio = null;
    }

    public Boolean estaVazia()
    {
        if (this.topo == null)
        {
            return (true);
        }
        return (false);
    }

    public void push(int Valor)
    {
        No novoNo = new(Valor);

        if (this.estaVazia() == true)
        {
            this.topo = novoNo;
            this.inicio = novoNo; 
        }
        else
        {
            novoNo.prox = this.topo;
            this.topo = novoNo;
        }
    }

    public No pop()
    {
        No aux = null;

        if (this.estaVazia() == true)
        {
            return (aux);
        }
        else
        {
            aux = this.topo;
            this.topo = this.topo.prox;
            return (aux);
        }
    }

public int contarElementos()
{
    int contador = 0;
    No noAux = this.inicio;

    while (noAux != null)
    {
        contador++;
        noAux = noAux.prox;
    }

    return contador;
}

public void separarPositivosENegativos(out Pilha pilhaPositivos, out Pilha pilhaNegativos)
{
    pilhaPositivos = new Pilha();
    pilhaNegativos = new Pilha();
    No noAux = this.inicio;

    while (noAux != null)
    {
        if (noAux.valor >= 0)
        {
            pilhaPositivos.push(noAux.valor);
        }
        else
        {
            pilhaNegativos.push(noAux.valor);
        }
        noAux = noAux.prox;
    }

}

public void ehPalindromo()
{
    Pilha pilhaAuxiliar = new Pilha();
    No noAtual = this.topo;

    while (noAtual != null)
    {
        pilhaAuxiliar.push(noAtual.valor);
        noAtual = noAtual.prox;
    }

    noAtual = this.topo;
    No noAuxiliar = pilhaAuxiliar.topo;

    while (noAtual != null)
    {
        if (noAtual.valor != noAuxiliar.valor)
        {
            Console.WriteLine("\nNão é um palíndromo");
            return;
        }
        noAtual = noAtual.prox;
        noAuxiliar = noAuxiliar.prox;
    }

    Console.WriteLine("\nÉ um palíndromo");
}

public void inverter()
{
    Pilha pilhaAuxiliar = new Pilha();
    No noAtual = this.topo;

    while (noAtual != null)
    {
        pilhaAuxiliar.push(noAtual.valor);
        noAtual = noAtual.prox;
    }

    this.topo = pilhaAuxiliar.topo;
    this.inicio = pilhaAuxiliar.inicio;
    Console.WriteLine("\nPilha invertida");
}

public void transferirElementos(Pilha pilhaDestino)
{
    Pilha pilhaAuxiliar = new Pilha();
    No noAtual = this.topo;

    
    while (noAtual != null)
    {
        pilhaAuxiliar.push(noAtual.valor);
        noAtual = noAtual.prox;
    }

    
    noAtual = pilhaAuxiliar.topo;
    while (noAtual != null)
    {
        pilhaDestino.push(noAtual.valor);
        noAtual = noAtual.prox;
    }
}


public void ParOuImpar()
{
    int pares = 0;
    int impares = 0;
    No noAux = this.inicio;

    while (noAux != null)
    {
        if (noAux.valor % 2 == 0)
        {
            pares++;
        }
        else
        {
            impares++;
        }
        noAux = noAux.prox;
    }

    Console.WriteLine($"Pares: {pares}, Ímpares: {impares}");
}


    public Boolean consulta(int valor, ref No noAtual, ref No noAnterior)
    {
        noAtual = this.inicio;
        noAnterior = null;

        while (noAtual != null)
        {
            if (noAtual.valor == valor)
            {
                return (true);
            }
            noAnterior = noAtual;
            noAtual = noAtual.prox;
        }
        return (false);
    }

    public void imprimir()
    {
        No noAux = this.inicio;

        Console.WriteLine("Elementos: ");
        while (noAux != null)
        {
            Console.WriteLine(noAux.valor + "->");
            noAux = noAux.prox;
        }
    }
}