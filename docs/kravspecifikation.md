# KRAVSPECIFIKATION SOSU POWER 9000
Kravspecifikation opdeles i sybsystems:

Subsystem 01: Opgavehåndtering

Subsystem 02: Medarbejderhåndtering

## Subsystem 01: Opgavehåndtering
**Aktører:**
* **SOSU-medarbejdere**: Løser opgaver hos beboerne.
---
01. SOSU-medarbejderen skal kunne se sin opgaveoversigt for dagens dato.
0. Opgaveoversigten skal sorteres i kronologisk rækkefølge.
0. I opgaveoversigten skal opgaverne have følgende information:
    * Nummer
    * Tid
    * Lokation
    * Navn
    * Fuldført
0. SOSU-medarbejderen skal kunne vælge en opgave fra opgaveoversigten.
0. SOSU-medarbejderen skal kunne se følgende data om beboeren, når en opgave fra opgaveroversigten er valgt:   
   * Navn
   * Adresse
   * Sygdom
   * Medicin
   * Skavanker
   * Yderlige noter
0. SOSU-medarbejderen skal kunne se hvilke delopgaver der er, når en opgave fra opgaveroversigten er valgt.
0. SOSU-medarbejderen skal kunne markere delopgaver som fuldført.
0. SOSU-medarbejderen skal kunne tilføje noter til opgaven.
0. SOSU-medarbejderen skal kunne markere hvilket medicin er givet.
0. SOSU-medarbejderen skal kunne tilføje noter omkring medicin til opgaven.
0. SOSU-medarbejderen skal kunne afslutte en valgt opgave.
0. SOSU-medarbejderen skal retuneres til opgaveoversigten efter at have markeret en opgave som afsluttet.

## Subsystem 02: Medarbejderhåndtering
**Aktører:**
* **Taskplanner**: Håndtere opgaver til SOSU-medarbejdere.
* **Administrator**: Håndtere SOSU-medarbejdere og beboere med info.
---
01. Administrator skal kunne tilføje SOSU-medarbejdere.
02. Administrator skal kunne fjerne SOSU-medarbejdere.
03. Administrator skal kunne tilføje beboere med info.
04. Administrator skal kunne fjerne beboere.
05. Taskplanneren skal kunne oprette og tildele opgaver til SOSU-medarbejderene.

# IKKE_FUNKTIONELLE KRAV
Systemet skal overholde følgende ikke-funktionelle krav:

01. 