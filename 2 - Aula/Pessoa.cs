using System;
using System.Runtime.CompilerServices;

public class Pessoa
{
    private string nome;
    private string cpf;
    private int idade;
    private string sexo;
    private double peso;
    private double altura;

    public Pessoa(string nome, string cpf, int idade, string sexo,  double peso, double altura)
    {
        this.nome = nome;
        this.cpf = cpf;
        this.idade = idade;
        this.sexo = sexo;
        this.peso = peso;
        this.altura = altura;

    }
    public double CalcularIMC(double altura, double peso)
    {
        return peso/Math.Pow(altura, 2);
    }
    public (double, string, string) CalcularIMC()
    {
        double imc = this.peso/Math.Pow(this.altura, 2);
        string classificacao;
        string grau;
        
        if (imc < 18.5)
        {
            classificacao = "Magreza";
            grau = "0";
        }
        else if (imc >= 18.5 &&  imc <= 24.9)
        {
            classificacao = "Normal";
            grau = "0";
        }
        else if (imc >= 25.0 && imc <= 29.9)
        {
            classificacao = "SobrePeso";
            grau = "I";
        }
        else if (imc >= 30.0 && imc <= 39.9)
        {
            classificacao = "Obesidade";
            grau = "II";
        }
        else
        {
            classificacao = "Obesidade Grave";
            grau = "III";
        }
        return (imc, classificacao, grau);
    }
    public double getPessoa()
    {
        return this.peso;
    }
    public void setPessoa(double peso)
    {

    }

}
