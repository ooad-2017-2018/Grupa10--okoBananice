## Design Patterns

# 1. Singleton - Kreacijski pattern
Uloga Singleton paterna je da osigura da se klasa moze instancirati samo jednom i da osigura globalni pristup kreiranoj instanci klase.
Postoji vise objekata koje je potrebno samo jednom instancirati i nad kojim je potrebna jedinstvena kontrola pristupa.
Pattern smo iskoristili u nasem projektu kod klase za rad sa bazom jer nam je potrebna samo jedna klasa u citavom projektu.

# 2. Factory Method - Kreacijski pattern
Uloga Factory Method patterna je da omoguci kreiranje objekata na nacin da podklase odluce koju klasu instancirati. Razlicite podklase mogu na razlicite nacine implementirati interfejs. Factory Method cesto se primjenjuje jer dopusta projektu da blisko slijedi SOLID principe. 
Factory Method instancira odgovarajucu podklasu(izvedenu klasu) preko posebne metode na osnovu informacije od strane klijenta ili na osnovu tekuceg stanja.
Ovaj pattern nismo koristili u nasem projektu, ali smo ga mogli iskoristiti prilikom registracije uposlenika obzirom da imamo dvije vrste uposlenika, osobu za salterom i postara.

# 3. Command - Pattern ponasanja
Razdvaja klijenta koji zahtjeva operaciju i omogucava slanje zahtjeva razlicitim primateljima. Komanda, to je objekt koji zna primaoca i poziva njegovu metodu.
Primalac(reciever) kada se pozove metoda execute() u komandi, izvrsava. Pozivatelj zna kako izvrsiti komandu, ali ne zna nista o konkretnoj komadi, zna samo o njenom interfejsu.
Objekti pozivatelja i primaoca se trze u klijent objektu, a klijent odlucuje sta se iz primaoca salje komandi, a koje komande se dodjeljuju pozivatelju, odlucuje koje 
komande se izvrsavaju u kojem trenutku. Da bi izvrsio komandu, mora proslijediti komandu pozivatelju.
Ovaj tip patterna nismo iskoristili u nasem projektu, ali smo mogli prilikom odjavljivanja korisnika.

# 4. Decorator pattern- Strukturalni pattern
Osnovna namjena Decorator patterna je da omoguci dinamicko dodavanje novih elemenata i ponasanja (funkcionalnosti) postojecim
objektima. Objekat pri tome ne zna da je uradjena dekoracija sto je veoma korisno za iskoristljivost i ponovnu upotrebu 
komponenti softverskog sistema. Ovaj tip patterna nismo iskoristili u nasem projektu. Mogli smo ga iskoristiti prilikom registracije. Ukoliko se registruje uposlenik, da se doda odabir tipa posla: Osoba za salterom ili postar.

# 5. Observer Pattern
Uloga Observer paterna je da uspostavi relaciju izmedu objekata tako kada jedan objekat 
promijeni stanje, drugi zainteresirani objekti se obavje�tavaju..
Ovaj patter nismo koristili u nasem projektu, ali smo ga mogli koristiti prilikom implementacije funkcionalnosti pracenja paketa, ukoliko je paket stigao na adresu da korisnik dobije obavjestenje.

# 6. Interpreter Pattern
Interpreter pattern slu�i za evaluiranje gramatike nekog jezika i jezickih izraza. 
Obicno se koriste TeminalExpression i CompoundExpression klase koje slu�e za rekurzivno rje�avanje problema interpretacije nekog jezickog izraza gdje je CompoundExpression neki dio pravila koji poziva drugo pravilo za obradu izraza, dok je TerminalExpression bazni slucaj za neko pravilo.
Nismo koristili ovaj pattern u nasem projektu. Mozemo ga iskoristiti za provjeravanje validnosti JMBG broja i datuma rodjenja, ili provjere duzine passworda.

# 7. Adapter Pattern
Osnovna namjena Adapter paterna je da omogu�i �iru upotrebu ve� postoje�ih klasa. Adapter patern kreira novu adapter klasu koja slu�i kao posrednik izme�u
originalne klase i �eljenog interfejsa.  Tim postupkom se dobija �eljena funkcionalnost bez izmjena na originalnoj klasi i bez ugro�avanja integriteta cijele aplikacije.
Nismo koristili ovaj pattern unutar na�eg projekta zbog ve� dobro osmi�ljenih klasa koje ne zahtijevaju promjene.

# 8. Proxy Pattern
Namjena Proxy paterna je da omogu�i pristup i kontrolu pristupa stvarnim objektima. Proxy je obi�no mali javni surogat objekat koji predstavlja kompleksni objekat �ija aktivizacija se posti�e na osnovu
postavljenih pravila. Proxy patern rje�ava probleme kada se objekt ne mo�e instancirati direktno.  Ovaj pattern nije iskoristen, ali se mogao iskoristiti za restrikciju brisanja potro�a�a svima osim administratoru sistema.

# 9. Bridge Pattern
Osnovna namjena Bridge paterna je da omogu�i odvajanje apstrakcije i implementacije neke klase tako da ta klasa mo�e posjedovati vi�e razli�itih apstrakcija i vi�e razli�itih implementacija za pojedine
apstrakcije. Nismo koristili ovaj patter unutar na�eg projekta, ali smo ga mogli iskoristiti za razmjenu poruka izme�u korisnika i sistema.