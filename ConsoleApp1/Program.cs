using Negozio;
using System.Collections.Generic;

Shop negozioBologna = new Shop("Negozio Bologna", "Bologna", "Italia", "Via Zanardi", 33, "Pino La Lavatrice");

Shop negozioMilano = new Shop("Negozio Milano", "Milano", "Italia", "Via Aldo Rossi", 8, "Jerry Cardinale");



Prodotti prodottoBologna1 = new Prodotti("Mocio Vileda", "Pulizia", "Panno per pulire a terra", 29);
Prodotti prodottoBologna2 = new Prodotti("Sgrassatore", "Pulizia", "Spray per pulire", 4);

Prodotti prodottoMilano1 = new Prodotti("Maglia Milan", "Sport", "Maglia del Milan", 109);
Prodotti prodottoMilano2 = new Prodotti("Gol di Giroud", "Sport", "Gol per andare in semifinale di Champions League", 43);

List<Prodotti> prodottiNegozioBologna = new List<Prodotti> { prodottoBologna1, prodottoBologna2 };
List<Prodotti> prodottiNegozioMilano = new List<Prodotti> { prodottoMilano1, prodottoMilano2 };

negozioBologna.productToAdd(prodottiNegozioBologna);
negozioMilano.productToAdd(prodottiNegozioMilano);

Console.WriteLine(negozioBologna.ShopInfoList());
Console.WriteLine(negozioMilano.ShopInfoList());

