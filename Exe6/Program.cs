
using System.Threading.Channels;

ProcessarObjetos(1, "Maria", 3.45m, new Teste(), null);



static void ProcessarObjetos(params object[] objetos) {
	foreach (var obj in objetos)
	{
		if(obj == null)
		{
            Console.WriteLine("Valor null -- tipo: null");
		} else
		{
            Console.WriteLine($"Valor {obj} -- tipo: {obj.GetType()}");
		}
	}
};

class Teste
{
    public override string ToString()
    {
        return "Objeto da classe Teste";
    }
}