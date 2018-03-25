# Grupa10-CokoBananice
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

Moguæa je registracija novih potrošaèa i uposlenika. Za registraciju novog uposlenika potrebno je unijeti: ime, prezime, email, lozinku, datum roðenja, adresu, tip posla(poštar, osoba na šalteru), a za novog potrošaèa: ime, prezime, adresu, JMBG, broj telefona, email i lozinku. 
Registrovani korisnik se prijavljuje na sistem unošenjem svog emaila i lozinke u formi za prijavu.

###### NADZOR SISTEMA
Administrator sistema nadgleda rad sistema, prati zloupotrebu sistema, te eventualno restaurira podatke. 

###### PLACANJE RACUNA

Prilikom prijave na sistem, potrošaè æe biti obaviješten putem "Messageboxa" o novim raèunima koje treba platiti. Potrošaè plaæa raèune odlaskom na poštu.

###### NAPLACIVANJE




###### SLANJE PAKETA
Uposlenik prilikom prijema paketa za slanje registuje paket upisivanjem podataka u formu, gdje se automatski na osnovu težine paketa i tipa, odreðuje poštarina i ukupna cijena paketa.
Potrošaè prilikom slanja paketa je u moguænosti praæenja paketa tako što se prijavi na sistem i odabere željeni paket.

###### KUPOVINA RAZGLEDNICA I MARKICA

Potrošaè je u moguænosti odabira i kupovine razglednica i markica, te slanja istih na odreðenu adresu.


## Funkcionalnosti

* Moguænost prijave na sistem
* Moguænost registracije novih korisnika sistema
* Moguænost kupovine razglednica i markica
* Moguænost plaæanja raèuna
* Moguænost pregleda stanja raèuna
* Moguænost praæenja lokacije paketa
* Moguænost podnošenja zahtjeva za slanje paketa
* Moguænost pregleda svih informacija o paketu
* Moguænost obraèuna poštarine i ukupne cijene paketa

## Akteri

#### 1. Potrošaèi
Koriste usluge pošte. Omoguæeno im je da se registruju i prijave na sistem, plaæaju svoje raèune, kupuju razglednice i markice, šalju i prate pakete.

#### 2. Uposlenici

* Osoba za šalterom - Ljudi koji rade u pošti i vrše interakciju sa potrošaèima. Upravljaju zahtjevima za slanje paketa, naplaæuju raèune te potrošaèu mijenaju stanje naplaæenog raèuna. Takoðer, uposlenici su zaduženi za registraciju novih potrošaèa.
* Poštar - vidi informacije o svim paketima, može provjeriti u kojem su stanju (vrijeme registracije, negdje u putu, došao da primaoca). Cim je novi paket registrovan, i poštaru se pojavi na aplikaciji.

#### 3. Administrator
Nadgleda operacije koje se odvijaju u pošti. Zadužen je za praæenje zloupotrebe sistema.

#### 4. Sistem za naplatu
Pri plaæanju raèuna, kupovine, slanja paketa, sistem za naplatu izdaje potrošaèu raèun koji treba platiti.