# Hackathon_Team4_19_21
Work in progress....<br/>
Per informazioni: edoardo.zanotti.studio@fitstic-edu.com

<ul>
  <li>USER STORIES (Google Fogli) => https://tinyurl.com/ya9hvhvd</li>
  <li>SCHEMA E-R DATABASE (PDF)   => https://tinyurl.com/yapf5cgd</li>
  <li>BACHECA TRELLO (Riservato membri #Team4) => https://trello.com/b/DAswZ3JP/team4
</ul>


<h2><b>Info teamwork</b></h2>
<b>Developers</b>: Francesco Bolognesi, Edoardo Zanotti <br/>
<b>Periodo</b>: dal 25 maggio al 25 giugno 2020 <br/>
<b>Organizzazione</b>: Trello <br/>
<b>IDE</b>: Visual Studio 2019 (prima versione di pressoché totale compatibilità allo sviluppo Blazor)<br/>
<br/>
Grazie a <i><a href="https://iorestoacasa.work/">IoRestoACasa.work</i></a> (GitHub: https://github.com/iorestoacasa-work) e <i><a href="https://www.riminilug.it/"> RiminiLUG</i></a><br/> per la piattaforma multimediale utilizzata durante le attività del team in remoto.
<br/>
<h2><b>Finalità</b></h2>
Gestire la mole di dati inerenti una scuola, la sua organizzazione, gli iscritti e la gestione delle valutazioni.
<br/>
<h2><b>Requisiti tecnologici</b></h2>
<b>Framework</b>: Blazor (.NET Microsoft) <br/>
<b>Front-end </b>: Bootstrap HTML <br/>
<b>Back-end </b>: C# e Razor <br/>
<b>Libreria DBMS</b>: SQLite <br/>
<br/>
<h2><b>Struttura della soluzione</b></h2>

<b>wwwroot</b><br/> 
contine il foglio di stile .css comune al progetto e, se necessario, è possibile caricare<br/> librerie esterne in alternativa all Content Delivery Network (tag <link> ) e le funzioni Java Script (attenzione alla compatibilità con Blazor!);
<br/>

  


<b>Areas > Identity</b><br/>
pagine in scaffolding per gestire login e
registrazione tramite Microsoft Identity; <br/>

<b>Data</b><br/>
Contiene le strutture delle classe C# per la creazione tramite EntityFramework delle tabelle del database. Inoltre è presente il file ApplicationDbContext che contiente i tipo e nome delle tabelle e le operazioni programmate alla successiva migration (commit);
  <br/>
<b>Shared</b><br/>
file .razor condivisi e visibili a tutta la soluzione con la finalità di gestire e programmare l’interfaccia e la struttura grafica di base (LoginDispay, MainLayout, InfoBar);	

<b>Pages</b><br/>
file contenenti la stuttura HTML e gli script lato server in Razor - che utilizza la sintassi C# - di tutte le pagine navigabili dall’utente, definiti per la programmazione di pagine web dinamiche  asincorone.
<br/>

<b>mydb.db</b><br/>
continete la stuttura e le tabelle del database.
SQLIte è comodo per piccoli progetti condivisi perché query, tabelle e report vengono incorporati tutti in un unico file semplice da gestire.
<br/>
<br/>


<h2><b>Descrizione </b></h2>
Operazioni disponibili per ogni sezione:
<br/>
<ul>
  <li>All’accesso è necessario registrarsi o effettuare il login; </li>
   <li> Si accede alla dashboard generale </li>
   <li>Si accede alla sezione desiderata dalla intuitiva dashboard </li>
   <li> Per ogni sezione sarà possibile effettuare operazioni di tipo CRUD (Create, Read, Update, Delete) che, per filinalità didattiche, saranno consentite a tutti gli utenti con i medesimi privilegi </li>
 </ul>
 <br/>
 <b>Dalla sezione Partecipanti è possibile:</b>
 <ul>
  <li> inserire  aggiornare ed eliminare le informazioni anagrafiche riguardanti gli studenti </li>
  <li> iscrivere uno studente ad uno specifico corso </li>
  </ul>
  <br/>
<b>Dalla sezione Personale è possibile:</b>
<ul>
  <li>visualizzare le informazioni riguardanti gli operatori suddivise in tre intuitive sezioni collassabili;</li>
  <li>inserire, aggiornare ed eliminare le informazioni anagrafiche riguardanti gli operatori (tutor - coordinatori - docenti) </li>
  </ul>
  <br/>
  <b>Dalla sezione Corsi è possibile:</b>
<ul>
  <li>aggiungere nuovo corso </li>
  <li>modificare le informazioni su i corsi già esistenti quindi modificare le date di inizio-fine, inserire o eliminare moduli</li>
  <li>assegnari i voti ad ogni studente per ogni modulo</li>
  <li>visualizzare un semplice report con le valutazioni e alcune statistiche</li>
</ul>
<br/>
<li><b>Dalla sezione Moduli è possibile:</b></li>
  <ul>
    <li>visualizzare in una intuitiva tabella nome/docente/tutor del modulo e se è attualmente attivo o no </li>
    <li>aggiungere / eliminare moduli </li>
    <li>modificare le informazioni su moduli già esistenti quindi modificare le date di inizio-fine e docente/tutor assegnati;</li>
  </ul>
 </ul>
 



