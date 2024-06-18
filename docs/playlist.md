# Playliste til eksamen

01. Præsenter casen aka. systembeskrivelsen.

00. Præsenter udviklingen af casen:
    - Systembeskrivelse
        Systembeskrivelsen beskriver formålet og omfanget af systemet. Det inkluderer typisk en introduktion til, hvad systemet skal gøre, dets primære funktioner, og hvem der er de primære brugere af systemet.

    - Kravspecifikation
        Kravspecifikationen definerer detaljeret, hvad systemet skal kunne gøre og hvilke egenskaber det skal have. Det inkluderer ofte funktionelle krav (hvad systemet skal gøre) og ikke-funktionelle krav (ydeevne, sikkerhed, osv.).

    - UML Analyse
        UML (Unified Modeling Language) analyse anvendes til at beskrive systemets struktur og adfærd. Det inkluderer typisk brug af diagrammer som Use Case-diagrammer til at beskrive systemets funktionelle krav og klasse-diagrammer til at vise strukturen af klasser og deres relationer.

    - ER Class Diagram
        ER (Entity-Relationship) Class Diagram anvendes til at modellere databasestrukturen for systemet. Det viser entiteterne i systemet, deres attributter og relationerne mellem dem.

    - Projektstyring på GitHub
        Projektstyring på GitHub involverer brugen af værktøjer som GitHub Projects og Issues til at organisere, prioritere og følge op på arbejdsopgaver og ændringer i projektet. Det hjælper med at holde styr på opgaver, kommunikation og status for udviklingen af projektet.

    
00. Præsenter Backend:
    - .Api
    - .Entities
    - .DataAccess
    - Database
    - .CareApp

00. Koncepter og fagtermer:
    - Entity Framework:
        Entity Framework (EF) er et Object-Relational Mapping (ORM) værktøj, som gør det nemmere at arbejde med databaser. Det oversætter database-tabeller til .NET-klasser og gør det muligt at manipulere data som objekter uden at skrive SQL-kode.

        - CRUD-operationer:
            CRUD står for 'Create, Read, Update, Delete'. Det refererer til de fire grundlæggende operationer, der kan udføres på data i en database: oprette, læse, opdatere og slette data.

        - Migrations:
            Migrations hjælper med at holde database-strukturen synkroniseret med modelklasserne i koden. De kan oprette, opdatere og fjerne database-tabeller og kolonner, når datamodellen ændres.
            
            01. Add-Migration NewMigration 
            00. Update-Database

        - Generic Repository:
        Generic Repository er en genanvendelig skabelon, der hjælper dig med at håndtere dataadgang og CRUD-operationer på en konsistent og effektiv måde for forskellige typer af data.

    - Constructors: 
        Constructors er metoder, der kaldes ved objektets oprettelse. De initialiserer objektets felter og tilstand.

    - Mutation: 
        Mutationer er ændringer i et objekts tilstand, f.eks. ved at ændre værdierne af dets felter, efter at det er blevet oprettet.

    - Objekter:
        Objekter er instanser af klasser. De repræsenterer konkrete eller abstrakte ting med egenskaber (attributter) og metoder (funktioner).

    - Indkapsling: 
        Indkapsling skjuler dataene i et objekt og tillader kun adgang via offentligt definerede metoder. Dette beskytter data og sikrer, at de kun ændres på kontrollerede måder.
      
    - Komposition/Aggrgation: 
        - Komposition betyder, at et objekt indeholder og ejer andre objekter, som ikke kan eksistere uden det overordnede objekt.
        - Aggregation betyder, at et objekt indeholder referencer til andre objekter, som kan eksistere uafhængigt.
      
    - Nedarvning:
        Nedarvning er, hvor en klasse kan arve egenskaber og metoder fra en anden klasse. Det gør det muligt at genbruge kode og skabe en hierarkisk struktur af klasser.

    - Polymorfi: 
        Polymorfi refererer til evnen til at behandle objekter af forskellige klasser ens, baseret på en fælles overklasse (forælder som de arver fra). Dette kan ses i vores IRepository, som fungerer som vores overklasse, hvor vores Repository skal implementere overklassens metoder.

        - Virtual og Override:
        En virtuel metode i en overklasse kan overskrives af en metode i en underklasse (barn) med override.
      
    - Abstrakte typer:
        Abstrakte klasser og grænseflader (interfaces) kan ikke instansieres direkte. De definerer fælles egenskaber og metoder, som skal implementeres af underklasser. Abstrakte klasser kan have implementerede metoder, mens grænseflader kun kan have metode-signaturer (IRepository).
      
    - Generics <<T>T>:
        Generics gør det muligt at skrive fleksibel og genbrugelig kode, der kan tilpasses til forskellige datatyper.
      
    - Constructor chaining:
        Constructor chaining er, hvor en constructor kalder en anden constructor i samme klasse eller i en overklasse for at genbruge kode og undgå duplikering.
      
    - Seperation of concerns:
        SoC er et designprincip, der handler om at adskille et program i forskellige sektioner, hver med en bestemt ansvarlighed. Det gør koden mere overskuelig, vedligeholdelsesvenlig og testbar.

    - Dependency Injection:
        Dependency Injection er, hvor afhængigheder bliver leveret til en klasse i stedet for, at klassen selv opretter dem (Controllers).

    - Inversion of Control:
        Inversion of Control er et designprincip, der vender kontrollen over afhængigheder om, så de leveres til klasserne fra en ekstern kilde, hvilket resulterer i løsere kobling og bedre modularitet (Program).
      
    - Inception, Elaboration, Construction og Testing:
        - Inception: Udarbejdelse af en kravspecifikation, identifikation af entiteter og oprettelse af et analyse diagram.
        - Elaboration: Udarbejdelse af designdiagrammer, opsætning af GitHub Projects og oprettelse af issues.
        - Construction: Opbygning af backend og UI/UX.
        - Testing: Udførelse af brugertest, fejlrettelse og sikring af, at programmet lever op til kravspecifikationen.
      
    - Versionstyring med GitHub: 
        GitHub bruges til at holde styr på projektets ændringer og til at holde et overblik med GitHub Projects.

    - UI/UX:
        UI (User Interface) refererer til designet af en applikations grænseflade, mens UX (User Experience) refererer til den overordnede oplevelse og tilfredshed, som brugerne får ved at interagere med applikationen.
    
    - .NET MAUI:
        MAUI (Multi-platform App UI) er et framework til at bygge native mobile og desktop apps med .NET. Det gør det muligt at skrive en enkelt kodebase, der kan køre på forskellige platforme som iOS, Android, Windows og macOS.
      
    - MVVM:
        MVVM (Model-View-ViewModel) er et arkitekturdesignmønster, der adskiller logikken i en applikation fra UI. Modellen repræsenterer data, ViewModelen indeholder logikken og håndterer brugerinteraktion, og Viewen er den visuelle repræsentation af dataene.
      
    - XAML:
        XAML (Extensible Application Markup Language) er et markup-sprog i .NET til at designe brugergrænseflader.