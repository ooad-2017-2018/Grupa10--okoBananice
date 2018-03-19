# Grupa10--CokoBananice
# Pošta
Clanovi tima:
1. Selma Vuèijak
2. Faruk Smajloviæ
3. Ilma Spahiæ

## Opis teme
Pošta je ustanova u kojoj se stvaraju velike gužve zbog mnogo interakcije sa ljudima. Upravo zbog toga smo osmislili softversko rješenje koje æe simulirati njen rad, prije svega da bi se olakšala organizacija i ubrzale njene funkcionalnosti.

Potrošaèu je omoguæena registracija i login na sistem. Od ponuðenih opcija, može provjeriti stanje svojih raèuna, izmiriti dugove i pratiti trenutnu lokaciju paketa.
Takoðer, ponuðen im je odabir i kupovina razglednica i markica, koje potom dolaze na njihovu adresu.

S druge strane, uposlenik pošte unosi zahtjev za slanje paketa u sistem, te pošiljaocu paketa prosljeðuje informacije o cijeni i šifru za praæenje.
Dalje, uposlenik je u moguænosti registrovati raèun koji potrošaè plaæa, a zatim mijenja stanje na "plaæen". Ako ga potrošaè plati kroz aplikaciju, stanje mu se automatski promijeni.
 
Poštar vidi informacije o svim paketima, može provjeriti u kojem su stanju (tek registrovan, negdje u putu, došao da primaoca). Cim uposlenik registruje paket i poštaru se pojavi na aplikaciji.

## Procesi

###### REGISTRACIJA I LOGIN U SISTEM

Registracija se vrši upisom podataka u formu (ime, prezime, datum roðenja, JMBG, lozinka, email, broj telefona, adresa stanovanja, ID i stanje kartice), meðutim korisnik se ne može prijaviti dok ga ne verificira administrator. On dobija email za zahtjev registracije korisnika, te vrši verifikaciju i dodjeljivanje nivoa pristupa korisniku.
Verifikovani korisnik se prijavljuje na sistem unošenjem svog emaila i lozinke u formi za prijavu.

###### POSTAVLJANJE RACUNA
Administrator mjeseèno ažurira raèune koje potrošaèi trebaju platiti što se potom njima pojavljuje na aplikaciji. 

###### PLACANJE RACUNA
Potrošaè raèune može plaæati na dva naèina: preko aplikacije ili odlaskom u poštu. 
Ukoliko se potrošaè odluèi za plaæanje raèuna preko aplikacije, ponuðeno mu je da klikom na dugme izabere raèun koji želi da plati, nakon èega sistem za naplatu vrši obraèun te skida odreðeni iznos sa kartice. U sluèaju da potrošaè nema dovoljno sredstava, sistem æe ga obavijestiti o tome.
Plaæanjem raèuna u pošti, uposlenik mijenja stanje raèuna potrošaèa.

###### SLANJE PAKETA
Uposlenik prilikom prijema paketa za slanje, registuje paket upisivanjem podataka u formu, gdje se automatski na osnovu težine paketa i tipa, odreðuje poštarina i ukupna cijena paketa.
Potrošaè prilikom slanja paketa, dobija šifru od uposlenika pomoæu koje može vidjeti trenutnu lokaciju paketa.

## Funkcionalnosti

* Moguænost registracije i prijave na sistem
* Moguænost kupovine razglednica i markica
* Moguænost plaæanja raèuna
* Moguænost pregleda stanja raèuna
* Moguænost praæenja lokacije paketa
* Moguænost podnošenja zahtjeva za slanje paketa
* Moguænost pregleda svih informacija o paketu
* Moguænost obraèuna poštarine i ukupne cijene paketa
* Moguænost verifikacije novih korisnika sistema




 