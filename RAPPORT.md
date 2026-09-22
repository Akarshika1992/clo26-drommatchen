# Rapport

**Kurs:** Grundläggande OOP i C#  
**Uppgift:**  Drömmatchen
**Grupp:**  Akarshika Srivastava
**Datum:**  20/09/26
**GitHub:**  https://github.com/Akarshika1992/clo26-drommatchen/tree/main

---

## Gruppmedlemmar

| Namn        | Lämnade in |
|-------------|-----------|
| [Akarshika] | Zip + RAPPORT.md + REFLEKTION.md |
| [Namn 2]    | REFLEKTION.md |
| [Namn 3]    | REFLEKTION.md |

---

## G — Hur vi löste uppgiften

> Förklara kortfattat hur du löste varje G-krav. En till tre meningar per punkt räcker.  
> Skriv med egna ord — kopiera inte uppgiftsbeskrivningen.

### Klasserna

> 
Jag skapade två klasser: Spelare och Match.

Spelare innehåller information om en spelare. Till exempel namn, nummer och position.

Match innehåller information om matchen. Till exempel hemmalag, bortalag och datum.

Jag använde get och private set på våra properties. Det gör att vi kan läsa informationen, 
men inte ändra den direkt från andra delar av programmet.

### Metoderna

> 
I klassen Match skapade Jag två metoder: Presentera() och AnnounceraMålskytt().

Presentera() visar information om matchen.

AnnounceraMålskytt() tar emot en spelare och skriver ut spelarens nummer, namn och position.

### Main()

> 
I Main() får användaren skriva in information i konsolen.

Användaren skriver in namn, nummer och position för två spelare. Sedan skriver användaren in hemmalag, bortalag och datum.

Efter det skapar programmet objekten Spelare och Match.

Till sist använder programmet metoderna för att visa matchen och målskyttarna.


### Git

> 
Vi använde Git för att spara våra ändringar och gjorde flera commits.

### Kodkvalitet

> 
Jag gjorde koden enkel och använde tydliga namn.
Jag delade upp koden i olika klasser. Användaren kan skriva in spelarens namn, 
nummer och position, och programmet visar informationen.

---

## VG — Motivering

> Fyll i det här avsnittet om du siktar på VG. Lämna tomt = G-bedömning.


### Vad vi lade till

> 
För VG lade jag till Mål i klassen Spelare.

Jag lade också till metoden ÄrMatchhjälte() i klassen Match.

Metoden kollar om en spelare har gjort minst ett mål.

### Varför vi löste det såhär

> 
Jag använde bool eftersom vi bara behöver veta ja eller nej.

Om spelaren har gjort mål blir det true.

Om spelaren inte har gjort mål blir det false.


---

## Git-logg

Klistra in utskriften från `git log --oneline` här:
commit d005fb384568b60c1f34c7b8e8eaf18760d49b89 (HEAD -> main)


```
[klistra in här]
```
