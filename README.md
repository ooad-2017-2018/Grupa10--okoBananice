# Grupa10--CokoBananice
# Pošta
Clanovi tima:
1. Selma Vucijak
2. Faruk Smajlovic
3. Ilma Spahic
## Opis teme
Pošta je ustanova u kojoj se stvaraju velike gužve zbog mnogo interakcije sa ljudima. Upravo zbog toga smo osmislili softversko rješenje koje ce simulirati njen rad, prije svega da bi se olakšala organizacija i ubrzale njene funkcionalnosti.

Potrošacu je omogucena registracija i login na sistem. Od ponudenih opcija, može provjeriti stanje svojih racuna, izmiriti dugove i pratiti trenutnu lokaciju paketa.
Takoder, ponuden im je odabir i kupovina razglednica i markica, koje potom dolaze na njihovu adresu.

S druge strane, uposlenik pošte unosi zahtjev za slanje paketa u sistem, te pošiljaocu paketa prosljeduje informacije o cijeni i šifru za pracenje.
Dalje, uposlenik je u mogucnosti registrovati racun koji potrošac placa, a zatim mijenja stanje na "placen". Ako ga potrošac plati kroz aplikaciju, stanje mu se automatski promijeni.
 
Poštar vidi informacije o svim paketima, može provjeriti u kojem su stanju (tek registrovan, negdje u putu, došao da primaoca). Cim uposlenik registruje paket i poštaru se pojavi na aplikaciji.

## Procesi

###### REGISTRACIJA I LOGIN U SISTEM

Registracija se vrši upisom podataka u formu (ime, prezime, datum rodenja, JMBG, lozinka, email, broj telefona, adresa stanovanja, ID i stanje kartice), medutim korisnik se ne može prijaviti dok ga ne verificira administrator. On dobija email za zahtjev registracije korisnika, te vrši verifikaciju i dodjeljivanje nivoa pristupa korisniku.
Verifikovani korisnik se prijavljuje na sistem unošenjem svog emaila i lozinke u formi za prijavu.


###### POSTAVLJANJE RACUNA
Administrator mjesecno ažurira racune koje potrošaci trebaju platiti što se potom njima pojavljuje na aplikaciji. 

###### PLACANJE RACUNA
Potrošac racune može placati na dva nacina: preko aplikacije ili odlaskom u poštu. 
Ukoliko se potrošaè odluci za placanje raèuna preko aplikacije, ponuðeno mu je da klikom na dugme izabere racun koji želi da plati, nakon cega sistem za naplatu vrši obracun te skida odredeni iznos sa kartice. U slucaju da potrošac nema dovoljno sredstava, sistem ce ga obavijestiti o tome.
Placanjem racuna u pošti, uposlenik mijenja stanje racuna potrošaca.

###### SLANJE PAKETA
Uposlenik prilikom prijema paketa za slanje, registuje paket upisivanjem podataka u formu, gdje se automatski na osnovu težine paketa i tipa, odreduje poštarina i ukupna cijena paketa.
Potrošac prilikom slanja paketa, dobija šifru od uposlenika pomocu koje može vidjeti trenutnu lokaciju paketa.

## Funkcionalnosti

* Moguænost registracije i prijave na sistem
* Moguænost odjave sa sistema
* Moguænost kupovine razglednica i markica
* Moguænost slanja razglednica i markica na kuænu adresu
* Moguænost plaæanja raèuna
* Moguænost pregleda stanja raèuna
* Moguænost praæenja lokacije paketa
* Moguænost podnošenja zahtjeva za slanje paketa
* Moguænost pregleda svih informacija o paketu
* Moguænost registrovanja paketa za slanje
* Moguænost obraèuna poštarine i ukupne cijene paketa



 