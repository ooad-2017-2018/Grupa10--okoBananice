# Grupa10--CokoBananice
# Po�ta
Clanovi tima:
1. Selma Vu�ijak
2. Faruk Smajlovi�
3. Ilma Spahi�

## Opis teme
Po�ta je ustanova u kojoj se stvaraju velike gu�ve zbog mnogo interakcije sa ljudima. Upravo zbog toga smo osmislili softversko rje�enje koje �e simulirati njen rad, prije svega da bi se olak�ala organizacija i ubrzale njene funkcionalnosti.

Potro�a�u je omogu�ena registracija i login na sistem. Od ponu�enih opcija, mo�e provjeriti stanje svojih ra�una, izmiriti dugove i pratiti trenutnu lokaciju paketa.
Tako�er, ponu�en im je odabir i kupovina razglednica i markica, koje potom dolaze na njihovu adresu.

S druge strane, uposlenik po�te unosi zahtjev za slanje paketa u sistem, te po�iljaocu paketa proslje�uje informacije o cijeni i �ifru za pra�enje.
Dalje, uposlenik je u mogu�nosti registrovati ra�un koji potro�a� pla�a, a zatim mijenja stanje na "pla�en". Ako ga potro�a� plati kroz aplikaciju, stanje mu se automatski promijeni.
 
Po�tar vidi informacije o svim paketima, mo�e provjeriti u kojem su stanju (tek registrovan, negdje u putu, do�ao da primaoca). Cim uposlenik registruje paket i po�taru se pojavi na aplikaciji.

## Procesi

###### REGISTRACIJA I LOGIN U SISTEM

Registracija se vr�i upisom podataka u formu (ime, prezime, datum ro�enja, JMBG, lozinka, email, broj telefona, adresa stanovanja, ID i stanje kartice), me�utim korisnik se ne mo�e prijaviti dok ga ne verificira administrator. On dobija email za zahtjev registracije korisnika, te vr�i verifikaciju i dodjeljivanje nivoa pristupa korisniku.
Verifikovani korisnik se prijavljuje na sistem uno�enjem svog emaila i lozinke u formi za prijavu.

###### POSTAVLJANJE RACUNA
Administrator mjese�no a�urira ra�une koje potro�a�i trebaju platiti �to se potom njima pojavljuje na aplikaciji. 

###### PLACANJE RACUNA
Potro�a� ra�une mo�e pla�ati na dva na�ina: preko aplikacije ili odlaskom u po�tu. 
Ukoliko se potro�a� odlu�i za pla�anje ra�una preko aplikacije, ponu�eno mu je da klikom na dugme izabere ra�un koji �eli da plati, nakon �ega sistem za naplatu vr�i obra�un te skida odre�eni iznos sa kartice. U slu�aju da potro�a� nema dovoljno sredstava, sistem �e ga obavijestiti o tome.
Pla�anjem ra�una u po�ti, uposlenik mijenja stanje ra�una potro�a�a.

###### SLANJE PAKETA
Uposlenik prilikom prijema paketa za slanje, registuje paket upisivanjem podataka u formu, gdje se automatski na osnovu te�ine paketa i tipa, odre�uje po�tarina i ukupna cijena paketa.
Potro�a� prilikom slanja paketa, dobija �ifru od uposlenika pomo�u koje mo�e vidjeti trenutnu lokaciju paketa.

## Funkcionalnosti

* Mogu�nost registracije i prijave na sistem
* Mogu�nost kupovine razglednica i markica
* Mogu�nost pla�anja ra�una
* Mogu�nost pregleda stanja ra�una
* Mogu�nost pra�enja lokacije paketa
* Mogu�nost podno�enja zahtjeva za slanje paketa
* Mogu�nost pregleda svih informacija o paketu
* Mogu�nost obra�una po�tarine i ukupne cijene paketa
* Mogu�nost verifikacije novih korisnika sistema




 