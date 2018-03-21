# Grupa10--CokoBananice
# Po�ta
Clanovi tima:
1. Selma Vu�ijak
2. Faruk Smajlovi�
3. Ilma Spahi�

## Opis teme
Po�ta je ustanova u kojoj se stvaraju velike gu�ve zbog mnogo interakcije sa ljudima. Zbog toga smo osmislili softversko rje�enje koje �e simulirati njen rad, prije svega da bi se olak�ala organizacija i ubrzale njene funkcionalnosti, ali i da bismo modernizovali njene usluge i bili u korak sa vremenom.
Kako bi se to ostvarilo potrebna je aplikacija koja �e istovremeno biti efikasna i jednostavna za kori�tenje. Cilj je olak�ati potro�a�ima pla�anje ra�una, slanje paketa, te kupovinu razglednica i markica. Po�tarima �e sve informacije o paketima i ostaloj po�ti biti na dohvat ruke, �to �e im uveliko olak�ati i ubrzati posao. 
Uposlenicima �e rad biti automatizovan �to �e smanjiti mogu�nost gre�ke.

## Procesi

###### REGISTRACIJA I LOGIN U SISTEM

Mogu�a je registracija novih potro�a�a i uposlenika. Medutim, samo Administrator Po�te mo�e registrovati novog uposlenika, a uposlenici (osobe koje rade za �alterom) mogu registrovati nove potro�a�e. Registracija se obavlja uno�enjem li�nih podataka u formu (ime, prezime, datum ro�enja, JMBG, lozinka, email, broj telefona, adresa stanovanja). Pri registraciji potro�a�a, dodjeljuje mu se ID kartice Po�te, koja sadr�i odre�eni po�etni iznos novca.
Registrovani korisnik se prijavljuje na sistem uno�enjem svog emaila i lozinke u formi za prijavu.

###### POSTAVLJANJE RACUNA
Administrator mjese�no a�urira ra�une koje potro�a�i trebaju platiti �to se potom njima pojavljuje na aplikaciji. 

###### PLACANJE RACUNA
Potro�a� ra�une mo�e pla�ati na dva na�ina: preko aplikacije ili odlaskom u po�tu. 
Ukoliko se potro�a� odlu�i za pla�anje ra�una preko aplikacije, ponu�eno mu je da klikom na dugme izabere ra�un koji �eli da plati.
Pla�anjem ra�una u po�ti, uposlenik mijenja stanje ra�una potro�a�a. 

###### NAPLACIVANJE
Pri svakoj kupovini ili pla�anju ra�una potrebno je umanjiti iznos na kartici Po�te, a to automatski radi sistem za naplatu. U slu�aju da potro�a� na kartici nema dovoljno sredstava, sistem �e ga obavijestiti o tome.

###### POVECANJE SREDSTAVA
U slu�aju da potro�a� �eli pove�ati iznos novca na svojoj kartici, du�an je poslati zahtjev za pove�anjem sredstava kojeg potom odobrava administrator Po�te. 

###### SLANJE PAKETA
Uposlenik prilikom prijema paketa za slanje registuje paket upisivanjem podataka u formu, gdje se automatski na osnovu te�ine paketa i tipa, odre�uje po�tarina i ukupna cijena paketa.
Potro�a� prilikom slanja paketa, dobija �ifru od uposlenika pomo�u koje mo�e vidjeti trenutnu lokaciju paketa.

## Funkcionalnosti

* Mogu�nost prijave na sistem
* Mogu�nost registracije novih korisnika sistema
* Mogu�nost kupovine razglednica i markica
* Mogu�nost pla�anja ra�una
* Mogu�nost pregleda stanja ra�una
* Mogu�nost pra�enja lokacije paketa
* Mogu�nost podno�enja zahtjeva za slanje paketa
* Mogu�nost podno�enja zahtjeva za pove�anje stanja na kartici
* Mogu�nost pregleda svih informacija o paketu
* Mogu�nost obra�una po�tarine i ukupne cijene paketa

## Akteri

###### 1. Potro�a�i
Koriste usluge po�te. Omogu�eno im je da se registruju i prijave na sistem, pla�aju svoje ra�une, kupuju razglednice i markice, �alju i prate pakete. Svaki potro�a� posjeduje karticu Po�te koja mu slu�i za naplatu.

###### 2. Uposlenici

* Osoba za �alterom - Ljudi koji rade u po�ti i vr�e interakciju sa potro�a�ima. Upravljaju zahtjevima za slanje paketa, napla�uju ra�une te potro�a�u mijenaju stanje napla�enog ra�una. Tako�er, uposlenici su zadu�eni za registraciju novih potro�a�a.
* Po�tar - vidi informacije o svim paketima, mo�e provjeriti u kojem su stanju (vrijeme registracije, negdje u putu, do�ao da primaoca). Cim je novi paket registrovan, i po�taru se pojavi na aplikaciji.

###### 3. Administrator
Nadgleda operacije koje se odvijaju u po�ti. Zadu�en je za registraciju novih uposlenika koja uklju�uje dodjeljivanje privilegija. Mjese�no a�urira ra�une potro�a�ima i reguli�e zahtjeve za pove�anjem sredstava na kartici.

###### 4. Sistem za naplatu
Pri pla�anju ra�una, kupovine, slanja paketa, sistem za naplatu automatski potro�a�u smanjuje odre�eni iznos sa kartice. U slu�aju da potro�a� nema dovoljno stanja, sistem �e dati gre�ku te onemogu�iti zavr�etak procesa naplate, dok se sredstva ne obezbijede. 