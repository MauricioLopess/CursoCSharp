using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosIntPOO
{
    internal class Aluno
    {
        /*
        ex 03
        Fazer um programa para ler o nome de um aluno e as três notas que ele obteve nos três trimestres do ano
        (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final, mostrar qual a nota final do aluno no
        ano. Dizer também se o aluno está APROVADO ou REPROVADO e, em caso negativo, quantos pontos faltam
        para o aluno obter o mínimo para ser aprovado (que é 60 pontos).
        */
        public string Nome;
        public double Nota1, Nota2, Nota3;
        public double NotaFinal;

        public void CalcNotaFinal()
        {
            NotaFinal = Nota1 + Nota2 + Nota3;
        }
    }
}
