// See https://aka.ms/new-console-template for more information

//Nel progetto CSharpShop , creare la classe Prodotto che gestisce i prodotti del vostro shop.
//Un prodotto è caratterizzato da:
//codice(numero intero)
//nome
//descrizione
//prezzo
//iva

//Usate opportunamente i livelli di accesso (public, private), i costruttori,
//i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
//alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random.
//Il codice prodotto sia accessibile solo in lettura
//Gli altri attributi siano accessibili sia in lettura che in scrittura
//Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva.
//Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
//Testate poi i vostri oggetti Prodotto, istanziandoli e provando ad interagirci
//con loro per testare tutti i metodi che avete previsto e implementato.

//BONUS:
//create un metodo che restituisca il codice con un pad left di 0 per arrivare
//a 8 caratteri (ad esempio codice 91 diventa 00000091, mentre codice 123445567 resta come è)
//Usando una List, dichiarate una lista dei prodotti di un negozio e inseriteci
//al suo interno qualche prodotto che vi aspettate di trovare nel negozio.
//Stampate poi l’elenco dei vostri prodotti che avete previsto nel negozio.

using CSharpShop;
using System.Runtime.CompilerServices;

//Dichiariazione viariabili
int code;
int iva;
float price;
string name;
string description;



//Assegnazione valori esempio
code = 0;
iva = 22;
price = 12.99f;
name = "I sentieri dei nidi di ragno";
description = "Autore Italo Calvino";



//creazione oggetti.
Prodotto prodObject = new Prodotto( name, description, price, iva);



//Input utente variabili
Console.WriteLine("Inserisci nome, descrizione, prezzo e iva");

name = Console.ReadLine();
description =Console.ReadLine();
price = float.Parse(Console.ReadLine());
iva = int.Parse(Console.ReadLine());




//Set delle variabili nell'oggetto
prodObject.SetName(name);
prodObject.SetDescription(description);
prodObject.SetPrice(price);
prodObject.SetIva(iva);




//Richiedo variabili a classe Prodotto e Stampa
code = prodObject.GetCode();
Console.WriteLine("Il codice creato per il tuo libro è " + code);

Console.WriteLine("Hai inserito i seguenti dati:");

Console.WriteLine(prodObject.GetName());
Console.WriteLine(prodObject.GetDescription());



//Metodo che restituisce codice + nome
prodObject.FullName(name, code);



//Metodo che restituisce il prezzo base
prodObject.BasicPrice(price);
//Console.WriteLine(prodObject.GetPrice());



//Metodo che restituisce il prezzo compreso di IVA.
prodObject.FullPrice(price, iva);
//Console.WriteLine(prodObject.GetIva());


//BONUS

//Metodo che aggiunge tanti zeri fino a 8 caratteri al codice
prodObject.PadLeftCode(code);

//Lista
List<Prodotto> prodsList = new List<Prodotto>();

