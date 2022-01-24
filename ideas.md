# Jegyzetek
**A Note App elkészítésének a jegyzetei.**

## 2022.01.24.
Videó a jegyzethez: `2022-01-24-tanacsok.webm` Itt található:
CL2122_E_13A_Projektmunka/Jegyzet App Projekt/Fájlok/note-app

### Adatbázis
Karakterszám: Max mennyi karakter. Jó ötlet lehet. Adatbázisban viszont valószínűleg nincsen szükség ezt tárolni, csa a frontenden, HA vissza szeretnénk jelezni a felhasználónak, hogy:
összesen hány karaktert írhat/még hány karakter van hátra.

"Mentes" tábla nem feltétlenül kell. Inkább menjenek ezek az "adatok_jegyzetekrol"-be.
- Pláne nem: Első mentés VAGY LÉTREHOZÁS.
- Maximum: Utolsó mentés??? "Dokumentum utolsó mentésének az időpontja."

"Jegyzetek" jó csak áttenni az "Adatok_jegyzetekrol"-be. A "mentes"-t is.

Titkosítás.

1 tábla: téma/címkék.

### Ötletek
Topic: téma. Egyelőre lenyiló ablakból, előre hard code-olt timákból kiválasztani. Később saját 1 (vagy több) címkét beírni.

Megosztás email címre. Ez ok. Max teljes név idővel. Email annak aki még nincsen regisztrálva.

Publikus: sokadig lépés.

Nyomtatás, export PDF-be: 
talán

WORD feltöltés:
Nem valószínű. Sima szöveget írnak be az emberek. Nehéz lenne .docx-et konvertálni plaintext-re.

### Projekt
Fontossági sorrend:
1. Embereknek saját privát jegyzet.
2. Megosztás másokkal.
3. Publikus jegyzetek.
4. Témák.