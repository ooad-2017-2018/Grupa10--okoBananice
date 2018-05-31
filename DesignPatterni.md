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
promijeni stanje, drugi zainteresirani objekti se obavještavaju..
Ovaj patter nismo koristili u nasem projektu, ali smo ga mogli koristiti prilikom implementacije funkcionalnosti pracenja paketa, ukoliko je paket stigao na adresu da korisnik dobije obavjestenje.

# 6. Interpreter Pattern
Interpreter pattern služi za evaluiranje gramatike nekog jezika i jezickih izraza. 
Obicno se koriste TeminalExpression i CompoundExpression klase koje služe za rekurzivno rješavanje problema interpretacije nekog jezickog izraza gdje je CompoundExpression neki dio pravila koji poziva drugo pravilo za obradu izraza, dok je TerminalExpression bazni slucaj za neko pravilo.
Nismo koristili ovaj pattern u nasem projektu. Mozemo ga iskoristiti za provjeravanje validnosti JMBG broja i datuma rodjenja, ili provjere duzine passworda.

# 7. Adapter Pattern
Osnovna namjena Adapter paterna je da omoguæi širu upotrebu veæ postojeæih klasa. Adapter patern kreira novu adapter klasu koja služi kao posrednik izmeðu
originalne klase i željenog interfejsa.  Tim postupkom se dobija željena funkcionalnost bez izmjena na originalnoj klasi i bez ugrožavanja integriteta cijele aplikacije.
Nismo koristili ovaj pattern unutar našeg projekta zbog veæ dobro osmišljenih klasa koje ne zahtijevaju promjene.

# 8. Proxy Pattern
Namjena Proxy paterna je da omoguæi pristup i kontrolu pristupa stvarnim objektima. Proxy je obièno mali javni surogat objekat koji predstavlja kompleksni objekat èija aktivizacija se postiže na osnovu
postavljenih pravila. Proxy patern rješava probleme kada se objekt ne može instancirati direktno.  Ovaj pattern nije iskoristen, ali se mogao iskoristiti za restrikciju brisanja potrošaèa svima osim administratoru sistema.

# 9. Bridge Pattern
Osnovna namjena Bridge paterna je da omoguæi odvajanje apstrakcije i implementacije neke klase tako da ta klasa može posjedovati više razlièitih apstrakcija i više razlièitih implementacija za pojedine
apstrakcije. Nismo koristili ovaj patter unutar našeg projekta, ali smo ga mogli iskoristiti za razmjenu poruka izmeðu korisnika i sistema.