# Grupa10--CokoBananice
# Po�ta
Clanovi tima:
1. Selma Vucijak
2. Faruk Smajlovic
3. Ilma Spahic
## Opis teme
Po�ta je ustanova u kojoj se stvaraju velike gu�ve zbog mnogo interakcije sa ljudima. Upravo zbog toga smo osmislili softversko rje�enje koje ce simulirati njen rad, prije svega da bi se olak�ala organizacija i ubrzale njene funkcionalnosti.

Potro�acu je omogucena registracija i login na sistem. Od ponudenih opcija, mo�e provjeriti stanje svojih racuna, izmiriti dugove i pratiti trenutnu lokaciju paketa.
Takoder, ponuden im je odabir i kupovina razglednica i markica, koje potom dolaze na njihovu adresu.

S druge strane, uposlenik po�te unosi zahtjev za slanje paketa u sistem, te po�iljaocu paketa prosljeduje informacije o cijeni i �ifru za pracenje.
Dalje, uposlenik je u mogucnosti registrovati racun koji potro�ac placa, a zatim mijenja stanje na "placen". Ako ga potro�ac plati kroz aplikaciju, stanje mu se automatski promijeni.
 
Po�tar vidi informacije o svim paketima, mo�e provjeriti u kojem su stanju (tek registrovan, negdje u putu, do�ao da primaoca). Cim uposlenik registruje paket i po�taru se pojavi na aplikaciji.

## Procesi

###### REGISTRACIJA I LOGIN U SISTEM

Registracija se vr�i upisom podataka u formu (ime, prezime, datum rodenja, JMBG, lozinka, email, broj telefona, adresa stanovanja, ID i stanje kartice), medutim korisnik se ne mo�e prijaviti dok ga ne verificira administrator. On dobija email za zahtjev registracije korisnika, te vr�i verifikaciju i dodjeljivanje nivoa pristupa korisniku.
Verifikovani korisnik se prijavljuje na sistem uno�enjem svog emaila i lozinke u formi za prijavu.


###### POSTAVLJANJE RACUNA
Administrator mjesecno a�urira racune koje potro�aci trebaju platiti �to se potom njima pojavljuje na aplikaciji. 

###### PLACANJE RACUNA
Potro�ac racune mo�e placati na dva nacina: preko aplikacije ili odlaskom u po�tu. 
Ukoliko se potro�a� odluci za placanje ra�una preko aplikacije, ponu�eno mu je da klikom na dugme izabere racun koji �eli da plati, nakon cega sistem za naplatu vr�i obracun te skida odredeni iznos sa kartice. U slucaju da potro�ac nema dovoljno sredstava, sistem ce ga obavijestiti o tome.
Placanjem racuna u po�ti, uposlenik mijenja stanje racuna potro�aca.

###### SLANJE PAKETA
Uposlenik prilikom prijema paketa za slanje, registuje paket upisivanjem podataka u formu, gdje se automatski na osnovu te�ine paketa i tipa, odreduje po�tarina i ukupna cijena paketa.
Potro�ac prilikom slanja paketa, dobija �ifru od uposlenika pomocu koje mo�e vidjeti trenutnu lokaciju paketa.

## Funkcionalnosti

* Mogu�nost registracije i prijave na sistem
* Mogu�nost odjave sa sistema
* Mogu�nost kupovine razglednica i markica
* Mogu�nost slanja razglednica i markica na ku�nu adresu
* Mogu�nost pla�anja ra�una
* Mogu�nost pregleda stanja ra�una
* Mogu�nost pra�enja lokacije paketa
* Mogu�nost podno�enja zahtjeva za slanje paketa
* Mogu�nost pregleda svih informacija o paketu
* Mogu�nost registrovanja paketa za slanje
* Mogu�nost obra�una po�tarine i ukupne cijene paketa



 