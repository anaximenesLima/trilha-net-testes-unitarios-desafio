using TestesUnitarios.Desafio.Console.Services;

ValidacoesLista va = new ValidacoesLista();
var lista = new List<int> { 5, -1, -8, 9 };
var res = va.RemoverNumerosNegativos(lista);
foreach (int item in res)
{
    Console.Write(item + " ");
    
}
Console.WriteLine();

var contem = va.ListaContemDeterminadoNumero(lista, 3);
if (contem)
{
    Console.WriteLine("Contem!");
}
else
{
    Console.WriteLine("nao contem!!");
}
Console.WriteLine();

var mult = va.MultiplicarNumerosLista(lista, 2);
foreach (int item in mult)
{
    Console.WriteLine(item);
}
Console.WriteLine();

var maior = va.RetornarMaiorNumeroLista(lista);
Console.WriteLine(maior);


ValidacoesString Val = new ValidacoesString();
var texto =  "Matriz";

int resut = Val.RetornarQuantidadeCaracteres(texto);
Console.WriteLine(resut);

texto = "Esse é um texto qualquer";
var textoProcurado = "qualquer";

bool c = Val.ContemCaractere(texto, textoProcurado);
Console.WriteLine(c);







Console.ReadLine();


