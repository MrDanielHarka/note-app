# Jegyzetek

**A Note App elkészítésének a jegyzetei.**

## 2022.03.17

Dokumentáció jegyzetek

- hasonló tavalyihoz (bármit is jelent az)
- talán nem kell annyira mélyre menni mint tavaly
- fejlesztői dokumentáció
- felhaszálói dokumentáció
- tesztelési jegyzőkönyv
- felhasznált irodalom lábjegyzék
  - forrásmegjelölés
  - szabadalom vagy jogtiszta vagy open source
  - dátummal
  - gyanús ha semmi nincsen (pl. Ng-Book, Angular.io etc.)
- képek: mit ábrázol, kép sorszám, source
- felhasználó/user === megrendelő
- telepítés user szempontjából
  - biztonsági mentésből adatbázis feltöltése phpmyadmin-ba
- hardverkövetelmény: mondjuk XAMPP követelményei
- eset diagram!
- 3 teszt eset. Mondjuk: minden jó adat, csak email jó, email se jó

## 2022.03.16.

Prioritások:

- design
- pw hash
- jegyzet megosztás más userekkel

## 2022.03.03.

- Technikai dokumentáció
- KKK-ban szerepel hogy mi legyen a dokumentációban
- szoftver célja
- egyes elemek technikailag hogyan működnek
- hardver követelmény
- szoftver követelmény
- be kell mutatni röviden mit hogyan kell használni:
  - felhasználói kézikönyv
- tesztelés
- how does it work?
- how was it made?
- https://infotanarium.hu/archivum/13

## 2022.03.02.

- Honlap előre legyártott template is lehet. (Valószínűleg nem az lesz.)
- Fejlesztői, tesztelési dokumentáció
  - bevezetés, szoftver bemutatása, keretrendszer, további tervek
  - Screenshots, wireframe, Józsi adatbázis képe
  - Desktop app screenshots
- Try catch if (hibaüzenet) errno 1062 => akkor etc.
- Inner join
- Hashing
- Cookie / localstorage

## 2022.02.28.

- Lehetséges, hogy két héttel a vizsga előtt be kell "adni" a munkát. GitHub repo jó.
- Nem feltétlenül kötelező a kész munkát megmutatni a vizsgán, elég a prezentációban képekkel.
- Lehetőség viszont van rá és biztosan pozitív, hogy ha a bemutató közben megmutatjuk a kész munkát.

## 2022.02.22.

**Prezentáció infók**

Teljes hossz: 30 perc

### Slide 1 & 2. | Magyar | 5 perc

Rövid bemutatkozás magunkról

- C++ korábban
- Js korábban

Rövid bemutatkozás projektről

- micsoda
- miért ezt
- mi volt a cél

### Slide 3 & 4. | Angol | 5 perc

Projekt bemutatása 3. slide

Projektben szerepünk 4. slide

- feladatok
- nehézségek
- ki mit csinált

### Slide 5 - max 16. | Magyar | 20 perc

- Feladatok, lépések, miért ebben, miért ezt, pl. Miért JS, miért NodeJS, miért Angular
- Elakadás, váltás, problémák, elgondolás újragondolása/megváltoztatása
- Projekt felépülése, részei, funkciók
- Felhasználók lehetőségei
- Asztali + webes (+ reszponzív)
- Hogyan kapcsolódik, miért ezt választottuk
- Lezárás (utolsó 2 slide)

### Dátumok

Március 28-29 PPT leadás és átolvasás a tanárral. Kb. 1 óra.

Április 25, 26 live premier az osztály felének bemutatva.

### Egyéb random info

Március 28-29. szeretnék minden csoporttal online találkozni külön-külön, hogy átnézzük az elkészített prezentációt és megbeszéljük, egyeztessük annak tartalmi és formai részeit. Időpontokat egyeztessetek egymással, ki milyen időpontban jön. Körülbelül 1 órával kell számolni!

Április 25-én és 26-án pedig két részre osztva az osztályt számítok mindenki részvételére. Itt élesben elő kell adni a prezentációt a többiek előtt mintha vizsgáznánk. A beosztást, ki melyik csapat melyik nap jön (1. fele 25, második fele 26) egyeztessétek egymással és az eredményt kérem majd legkésőbb április 11-ig eljuttatni hozzám.

## 2022.02.07.

### Teendők jövő szerdára

- NodeJS
- nodemon
- express
- mySQL module !

### Érdekesség

package.json-ban scripts:  
"dev": "nodemon index.js"

### Fontos

Password ne varchar típusú legyen. (Valószínűleg ASH vagy SHA.)

### Ötletek

- Elfelejtett jelszó / új jelszó beállítása
- Főoldalon a kép carousel alatt szövegdoboz, amiben el tud kezdeni gépelni.
- Ha rámegy a mentésre, akkor popup, hogy regisztráljon vagy lépjen be.
- Mindenhol automatikus mentés a szövegdobozoknál. Trigger: onInput.

[ email ]
[ password ]
[register] [login]

Bejelentkezve: Jobb lenti sarokban take note.

- Az átirányít a "saját jegyzetek" oldalra (ha éppen nem ott van a user).
- Létrehoz egy új szövegdobozt az oldal tetején.

Footer: An open source cross-platform note taking app, by Jozsef & Daniel.

## 2022.02.02.

Nem feltétlenül kell email és felhasználónév is.  
Kulcsmező lehet id vagy az email vagy a felhasználónév.  
Viszont nem javasolt, hogy az legyen a kulcsmező, mert akkor többet nem lehet azt megváltoztatni.  
Valószínűleg kell legyen auto increment mint kulcsmező.  
Mellette lehet email cím.

## 2022.01.24.

Videó a jegyzethez: `2022-01-24-tanacsok.webm` Itt található:\
CL2122_E_13A_Projektmunka/Jegyzet App Projekt/Fájlok/note-app

### Adatbázis

Karakterszám: Max mennyi karakter. Jó ötlet lehet. Adatbázisban viszont valószínűleg nincsen szükség ezt tárolni, csa a frontenden, HA vissza szeretnénk jelezni a felhasználónak, hogy:
összesen hány karaktert írhat/még hány karakter van hátra.

"Mentes" tábla nem feltétlenül kell. Inkább menjenek ezek az "adatok_jegyzetekrol"-be.

- Pláne nem: Első mentés VAGY létrehozás
- Maximum: Utolsó mentés??? "Dokumentum utolsó mentésének az időpontja."

"Jegyzetek" jó csak áttenni az "Adatok_jegyzetekrol"-be. A "mentes"-t is.

Titkosítás.

1 tábla: téma/címkék.

### Ötletek

Topic: téma. Egyelőre lenyíló ablakból, előre hardcode-olt témákból kiválasztani. Később saját 1 (vagy több) címkét beírni.

Megosztás email címre. Ez ok. Max teljes név idővel. Email annak aki még nincsen regisztrálva.

Publikus jegyzetek: sokadik lépés.

Nyomtatás, export PDF-be:
talán

WORD feltöltés:
Nem valószínű. Sima szöveget írnak be az emberek. Nehéz lenne .docx-et konvertálni plaintext-re.

### Projekt

Fontossági sorrend:

1. Felhasználóknak saját, privát jegyzet.
2. Publikus jegyzetek.
3. Megosztás másokkal.
4. Kategória/témák/címkék.

## 2022.01.10.

awesome-note.com
super-duper-note.web.app

### Frontpage

awesome-note/super-duper-note

(Online) notes for ...

(Online) notesz...

profession/foglalkozás = {
developers 3 laptop
recruiters
couriers
teachers
everbody/anybody

fejlesztőknek
toborzóknak
futároknak
tanároknak
mindenkinek/bárkinek

recruiters/toborzók = Adél
teachers/tanárok = Eszter
}

Képek rólunk.
Kék, lila/pink/orange, piros, lila/pink/orange

Some public notes

| Peter B. | Girl 1. | Daniel H. | Girl 2. |

TOP LEFT - [Logo/app-text]
MIDDLE - [Search public notes]
RIGHT - [Register] [Login]

### User page

Left sidebar:

- Everything (extra)
- Just mine
- Shared (extra)
- Archived (extra)

### Extras

- Search notes
- Share notes

---

Text field autosave.
"Note saved" snackbar? "Autosave button?" (Tells user notes are autosaved.)
