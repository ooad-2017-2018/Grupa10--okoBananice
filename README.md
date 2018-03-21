# Grupa10--CokoBananice
# Pošta
Clanovi tima:
1. Selma Vuèijak
2. Faruk Smajloviæ
3. Ilma Spahiæ

## Opis teme
Pošta je ustanova u kojoj se stvaraju velike gužve zbog mnogo interakcije sa ljudima. Zbog toga smo osmislili softversko rješenje koje æe simulirati njen rad, prije svega da bi se olakšala organizacija i ubrzale njene funkcionalnosti, ali i da bismo modernizovali njene usluge i bili u korak sa vremenom.
Kako bi se to ostvarilo potrebna je aplikacija koja æe istovremeno biti efikasna i jednostavna za korištenje. Cilj je olakšati potrošaèima plaæanje raèuna, slanje paketa, te kupovinu razglednica i markica. Poštarima æe sve informacije o paketima i ostaloj pošti biti na dohvat ruke, što æe im uveliko olakšati i ubrzati posao. 
Uposlenicima æe rad biti automatizovan što æe smanjiti moguænost greške.

## Procesi

###### REGISTRACIJA I LOGIN U SISTEM

Moguæa je registracija novih potrošaèa i uposlenika. Medutim, samo Administrator Pošte može registrovati novog uposlenika, a uposlenici (osobe koje rade za šalterom) mogu registrovati nove potrošaèe. Registracija se obavlja unošenjem liènih podataka u formu (ime, prezime, datum roðenja, JMBG, lozinka, email, broj telefona, adresa stanovanja). Pri registraciji potrošaèa, dodjeljuje mu se ID kartice Pošte, koja sadrži odreðeni poèetni iznos novca.
Registrovani korisnik se prijavljuje na sistem unošenjem svog emaila i lozinke u formi za prijavu.

###### POSTAVLJANJE RACUNA
Administrator mjeseèno ažurira raèune koje potrošaèi trebaju platiti što se potom njima pojavljuje na aplikaciji. 

###### PLACANJE RACUNA
Potrošaè raèune može plaæati na dva naèina: preko aplikacije ili odlaskom u poštu. 
Ukoliko se potrošaè odluèi za plaæanje raèuna preko aplikacije, ponuðeno mu je da klikom na dugme izabere raèun koji želi da plati.
Plaæanjem raèuna u pošti, uposlenik mijenja stanje raèuna potrošaèa. 

###### NAPLACIVANJE
Pri svakoj kupovini ili plaæanju raèuna potrebno je umanjiti iznos na kartici Pošte, a to automatski radi sistem za naplatu. U sluèaju da potrošaè na kartici nema dovoljno sredstava, sistem æe ga obavijestiti o tome.

###### POVECANJE SREDSTAVA
U sluèaju da potrošaè želi poveæati iznos novca na svojoj kartici, dužan je poslati zahtjev za poveæanjem sredstava kojeg potom odobrava administrator Pošte. 

###### SLANJE PAKETA
Uposlenik prilikom prijema paketa za slanje registuje paket upisivanjem podataka u formu, gdje se automatski na osnovu težine paketa i tipa, odreðuje poštarina i ukupna cijena paketa.
Potrošaè prilikom slanja paketa, dobija šifru od uposlenika pomoæu koje može vidjeti trenutnu lokaciju paketa.

## Funkcionalnosti

* Moguænost prijave na sistem
* Moguænost registracije novih korisnika sistema
* Moguænost kupovine razglednica i markica
* Moguænost plaæanja raèuna
* Moguænost pregleda stanja raèuna
* Moguænost praæenja lokacije paketa
* Moguænost podnošenja zahtjeva za slanje paketa
* Moguænost podnošenja zahtjeva za poveæanje stanja na kartici
* Moguænost pregleda svih informacija o paketu
* Moguænost obraèuna poštarine i ukupne cijene paketa

## Akteri

###### 1. Potrošaèi
Koriste usluge pošte. Omoguæeno im je da se registruju i prijave na sistem, plaæaju svoje raèune, kupuju razglednice i markice, šalju i prate pakete. Svaki potrošaè posjeduje karticu Pošte koja mu služi za naplatu.

###### 2. Uposlenici

* Osoba za šalterom - Ljudi koji rade u pošti i vrše interakciju sa potrošaèima. Upravljaju zahtjevima za slanje paketa, naplaæuju raèune te potrošaèu mijenaju stanje naplaæenog raèuna. Takoðer, uposlenici su zaduženi za registraciju novih potrošaèa.
* Poštar - vidi informacije o svim paketima, može provjeriti u kojem su stanju (vrijeme registracije, negdje u putu, došao da primaoca). Cim je novi paket registrovan, i poštaru se pojavi na aplikaciji.

###### 3. Administrator
Nadgleda operacije koje se odvijaju u pošti. Zadužen je za registraciju novih uposlenika koja ukljuèuje dodjeljivanje privilegija. Mjeseèno ažurira raèune potrošaèima i reguliše zahtjeve za poveæanjem sredstava na kartici.

###### 4. Sistem za naplatu
Pri plaæanju raèuna, kupovine, slanja paketa, sistem za naplatu automatski potrošaèu smanjuje odreðeni iznos sa kartice. U sluèaju da potrošaè nema dovoljno stanja, sistem æe dati grešku te onemoguæiti završetak procesa naplate, dok se sredstva ne obezbijede. 