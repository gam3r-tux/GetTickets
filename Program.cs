namespace cTickets;

/**
** Programa: Generador de 1000 numeros de turnos/tickets para una linea de espera (fila)
** Entrada: none
** Salida: archivo de texto con los numeros de tickets
** Fecha: 23/05/2024
** Autor: Jose Ramos
**/

class Program
{
    static void Main(string[] args)
    {
        DateTime d1 = DateTime.Now;
        string sFecha = d1.ToString("yyyyMMdd");
        string path = @"c:\proyectos\Archivo1_" + sFecha + ".txt";
        string frm = "000";
        Random rnd = new Random();
        string sNumTicket = String.Empty;
        int num = 0;
        string[] aLetra = { "A", "B", "C", "D", "E" };

		if (File.Exists(path)) {
            File.Delete(path);
        }

        for (int i = 0; i < 999; i++) {
            num = rnd.Next(0,5);

            sNumTicket = aLetra[num] + "-" + i.ToString(frm);

            File.AppendAllText(path, sNumTicket);
            File.AppendAllText(path, Environment.NewLine);
        }
        DateTime d2 = DateTime.Now;
        var seg = System.Math.Abs((d1 - d2).TotalSeconds);

        Console.WriteLine($"Terminado en {Math.Round(seg, 4)} segundos");
    }
}
