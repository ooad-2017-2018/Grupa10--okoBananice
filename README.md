# Grupa10-CokoBananice
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

Mogu�a je registracija novih potro�a�a i uposlenika. Za registraciju novog uposlenika potrebno je unijeti: ime, prezime, email, lozinku, datum ro�enja, adresu, tip posla(po�tar, osoba na �alteru), a za novog potro�a�a: ime, prezime, adresu, JMBG, broj telefona, email i lozinku. 
Registrovani korisnik se prijavljuje na sistem uno�enjem svog emaila i lozinke u formi za prijavu.

###### NADZOR SISTEMA
Administrator sistema nadgleda rad sistema, prati zloupotrebu sistema, te eventualno restaurira podatke. 

###### PLACANJE RACUNA

Prilikom prijave na sistem, potro�a� �e biti obavije�ten putem "Messageboxa" o novim ra�unima koje treba platiti. Potro�a� pla�a ra�une odlaskom na po�tu.

###### NAPLACIVANJE




###### SLANJE PAKETA
Uposlenik prilikom prijema paketa za slanje registuje paket upisivanjem podataka u formu, gdje se automatski na osnovu te�ine paketa i tipa, odre�uje po�tarina i ukupna cijena paketa.
Potro�a� prilikom slanja paketa je u mogu�nosti pra�enja paketa tako �to se prijavi na sistem i odabere �eljeni paket.

###### KUPOVINA RAZGLEDNICA I MARKICA

Potro�a� je u mogu�nosti odabira i kupovine razglednica i markica, te slanja istih na odre�enu adresu.


## Funkcionalnosti

* Mogu�nost prijave na sistem
* Mogu�nost registracije novih korisnika sistema
* Mogu�nost kupovine razglednica i markica
* Mogu�nost pla�anja ra�una
* Mogu�nost pregleda stanja ra�una
* Mogu�nost pra�enja lokacije paketa
* Mogu�nost podno�enja zahtjeva za slanje paketa
* Mogu�nost pregleda svih informacija o paketu
* Mogu�nost obra�una po�tarine i ukupne cijene paketa

## Akteri

#### 1. Potro�a�i
Koriste usluge po�te. Omogu�eno im je da se registruju i prijave na sistem, pla�aju svoje ra�une, kupuju razglednice i markice, �alju i prate pakete.

#### 2. Uposlenici

* Osoba za �alterom - Ljudi koji rade u po�ti i vr�e interakciju sa potro�a�ima. Upravljaju zahtjevima za slanje paketa, napla�uju ra�une te potro�a�u mijenaju stanje napla�enog ra�una. Tako�er, uposlenici su zadu�eni za registraciju novih potro�a�a.
* Po�tar - vidi informacije o svim paketima, mo�e provjeriti u kojem su stanju (vrijeme registracije, negdje u putu, do�ao da primaoca). Cim je novi paket registrovan, i po�taru se pojavi na aplikaciji.

#### 3. Administrator
Nadgleda operacije koje se odvijaju u po�ti. Zadu�en je za pra�enje zloupotrebe sistema.

#### 4. Sistem za naplatu
Pri pla�anju ra�una, kupovine, slanja paketa, sistem za naplatu izdaje potro�a�u ra�un koji treba platiti.