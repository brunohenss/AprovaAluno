using System.Runtime.CompilerServices;
/*
Console.WriteLine("Digite a nota do aluno...");
int nota = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Digite a frequência do aluno no ano...");
int freq = Convert.ToInt32(Console.ReadLine());

if (nota >= 6 && freq >= 75)

{
    Console.WriteLine("O aluno foi aprovado, e passou de ano!");
}

else if (nota >= 6 && freq <= 74)
{
    Console.WriteLine("O aluno teve boa média, mas não está apto por excesso de faltas não justificadas");
}
else if (nota <= 6 && freq >= 74)
{
    Console.WriteLine("Aluno não atingiu a média necessária para ser aprovado, mesmo frequentando as aulas");
}

else

{
    Console.WriteLine("Aluno não atingiu nenhum dos requisitos. Necessita cursar a série novamente");
}

*/



















bool choveu = true;
bool estaTarde = true;

if (!choveu && !estaTarde)
{
    Console.WriteLine("Vou sair para pedalar");
}

else
{
    Console.WriteLine("Vou pedalar outro dia");
}