
string[] piattiPreferiti = { "Pizza", "Lasagna", "Timballo", "Cassata", "Panzerotto", "Pizza di carne", "Torta al cioccolato", "Fiorentina", "Spaghetti allo scoglio", "Risotto allo zafferano", };

Console.WriteLine("Classifica dei miei piatti preferiti:");

for (var i = 0; i < piattiPreferiti.Length; i++)
{
    Console.WriteLine((i+1) + " - " + piattiPreferiti[i]);
}

//La lunghezza della classifica

Console.WriteLine("La classifica presenta " + piattiPreferiti.Length + " posizioni");

//Prima posizione in classifica

Console.WriteLine("Il primo della classifica dei miei cib1 preferiti è: " + piattiPreferiti[0]);

//Ultima posizione in classifica

Console.WriteLine("L'ultimo della classifica dei miei cib1 preferiti è: " + piattiPreferiti.AsQueryable().Last());




