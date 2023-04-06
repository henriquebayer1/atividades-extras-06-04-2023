Console.WriteLine($"Pesquisa sobre o produto");




Console.WriteLine($"Entrevistado 1");

Console.WriteLine($"Qual o seu sexo: m (masculino) ou f (feminino)");
string S1 = Console.ReadLine();

Console.WriteLine($"Responda a pergunta com s (sim) ou n (nao):");

Console.WriteLine($"Pergunta sobre o produto:");
string R1 = Console.ReadLine();

Console.WriteLine($"Entrevistado 2");

Console.WriteLine($"Qual o seu sexo: m (masculino) ou f (feminino)");
string S2 = Console.ReadLine();

Console.WriteLine($"Responda a pergunta com s (sim) ou n (nao):");

Console.WriteLine($"Pergunta sobre o produto:");
string R2 = Console.ReadLine();

Console.WriteLine($"Entrevistado 3");

Console.WriteLine($"Qual o seu sexo: m (masculino) ou f (feminino)");
string S3 = Console.ReadLine();

Console.WriteLine($"Responda a pergunta com s (sim) ou n (nao):");

Console.WriteLine($"Pergunta sobre o produto:");
string R3 = Console.ReadLine();

Console.WriteLine($"Entrevistado 4");

Console.WriteLine($"Qual o seu sexo: m (masculino) ou f (feminino)");
string S4 = Console.ReadLine();

Console.WriteLine($"Responda a pergunta com s (sim) ou n (nao):");

Console.WriteLine($"Pergunta sobre o produto:");
string R4 = Console.ReadLine();

Console.WriteLine($"Entrevistado 5");

Console.WriteLine($"Qual o seu sexo: m (masculino) ou f (feminino)");
string S5 = Console.ReadLine();

Console.WriteLine($"Responda a pergunta com s (sim) ou n (nao):");

Console.WriteLine($"Pergunta sobre o produto:");
string R5 = Console.ReadLine();

Console.WriteLine($"Entrevistado 6");

Console.WriteLine($"Qual o seu sexo: m (masculino) ou f (feminino)");
string S6 = Console.ReadLine();

Console.WriteLine($"Responda a pergunta com s (sim) ou n (nao):");

Console.WriteLine($"Pergunta sobre o produto:");
string R6 = Console.ReadLine();

Console.WriteLine($"Entrevistado 7");

Console.WriteLine($"Qual o seu sexo: m (masculino) ou f (feminino)");
string S7 = Console.ReadLine();

Console.WriteLine($"Responda a pergunta com s (sim) ou n (nao):");

Console.WriteLine($"Pergunta sobre o produto:");
string R7 = Console.ReadLine();

Console.WriteLine($"Entrevistado 8");

Console.WriteLine($"Qual o seu sexo: m (masculino) ou f (feminino)");
string S8 = Console.ReadLine();

Console.WriteLine($"Responda a pergunta com s (sim) ou n (nao):");

Console.WriteLine($"Pergunta sobre o produto:");
string R8 = Console.ReadLine();

Console.WriteLine($"Entrevistado 9");

Console.WriteLine($"Qual o seu sexo: m (masculino) ou f (feminino)");
string S9 = Console.ReadLine();

Console.WriteLine($"Responda a pergunta com s (sim) ou n (nao):");

Console.WriteLine($"Pergunta sobre o produto:");
string R9 = Console.ReadLine();

Console.WriteLine($"Entrevistado 10");

Console.WriteLine($"Qual o seu sexo: m (masculino) ou f (feminino)");
string S10 = Console.ReadLine();

Console.WriteLine($"Responda a pergunta com s (sim) ou n (nao):");

Console.WriteLine($"Pergunta sobre o produto:");
string R10 = Console.ReadLine();

int RValues = 0;
int RValuen = 0;



if(R1 == "s")
{RValues += 1;
}
if(R2 == "s")
{RValues += 1;
}
if(R3 == "s")
{RValues += 1;
}
if(R4 == "s")
{RValues += 1;
}
if(R5 == "s")
{RValues += 1;
}
if(R6 == "s")
{RValues += 1;
}
if(R7 == "s")
{RValues += 1;
}
if(R8 == "s")
{RValues += 1;
}
if(R9 == "s")
{RValues += 1;
}
if(R10 == "s")
{RValues += 1;
}


if(R1 == "n")
{RValuen += 1;
}
if(R2 == "n")
{RValuen += 1;
}
if(R3 == "n")
{RValuen += 1;
}
if(R4 == "n")
{RValuen += 1;
}
if(R5 == "n")
{RValuen += 1;
}
if(R6 == "n")
{RValuen += 1;
}
if(R7 == "n")
{RValuen += 1;
}
if(R8 == "n")
{RValuen += 1;
}
if(R9 == "n")
{RValuen += 1;
}
if(R10 == "n")
{RValuen += 1;
}

Console.WriteLine($"a quantidade de pessoas que respondeu sim foi de {RValues}");
Console.WriteLine($"a quantidade de pessoas que respondeu nao foi de {RValuen}");

// CONTADOR FEMININO QUE RESPONDEU SIM
int Contfems = 0;

if(S1 == "f" && R1 == "s")
{Contfems += 1;}
if(S2 == "f" && R2 == "s")
{Contfems += 1;}
if(S3 == "f" && R3 == "s")
{Contfems += 1;}
if(S4 == "f" && R4 == "s")
{Contfems += 1;}
if(S5 == "f" && R5 == "s")
{Contfems += 1;}
if(S6 == "f" && R6 == "s")
{Contfems += 1;}
if(S7 == "f" && R7 == "s")
{Contfems += 1;}
if(S8 == "f" && R8 == "s")
{Contfems += 1;}
if(S9 == "f" && R9 == "s")
{Contfems += 1;}
if(S10 == "f" && R10 == "s")
{Contfems += 1;}

Console.WriteLine($"A quantidade de mulheres que respondeu sim foi de {Contfems}");


// CONTAGEM EM PORCENTAGEM DE HOMENS QUE RESPONDERAM NAO

int mValueCalc = 0;

if(S1 == "m" && R1 == "n")
{mValueCalc += 1;}
if(S2 == "m" && R2 == "n")
{mValueCalc += 1;}
if(S3 == "m" && R3 == "n")
{mValueCalc += 1;}
if(S4 == "m" && R4 == "n")
{mValueCalc += 1;}
if(S5 == "m" && R5 == "n")
{mValueCalc += 1;}
if(S6 == "m" && R6 == "n")
{mValueCalc += 1;}
if(S7 == "m" && R7 == "n")
{mValueCalc += 1;}
if(S8 == "m" && R8 == "n")
{mValueCalc += 1;}
if(S9 == "m" && R9 == "n")
{mValueCalc += 1;}
if(S10 == "m" && R10 == "n")
{mValueCalc += 1;}

double porcentagem = (mValueCalc * 100) / 10;

Console.WriteLine($"A porcentagem de homens que responderam nao e de: {porcentagem}%");
