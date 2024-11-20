Se cere implementarea unui program C# care gestionează activitatea unui laborator de robotică. Laboratorul organizează competiții pentru echipele de roboți, iar pentru participarea la fiecare competiție se înregistrează echipele, roboții acestora și scorurile obținute pe parcursul competiției.

Sarcini:
- Definirea modelului OOP:
    - Să se creeze clasele necesare pentru a reprezenta echipele de robotică, roboții acestora și scorurile obținute.
    - Fiecare echipă are un nume, un robot asociat și o listă de membri. Fiecare robot are un tip și un punctaj maxim ce poate fi obținut într-o competiție.
    - Fiecare competiție are un nume și o dată, iar echipele care participă trebuie să fie înregistrate pentru a putea concura.
  - Gestionarea echipelor și roboților:
    - Să se creeze câte un obiect pentru fiecare echipă de robotică, fiecare având un nume și o listă de membri. Fiecare echipă va avea asociat un robot.
    - Fiecare robot va avea un tip și un punctaj maxim. Se va calcula scorul fiecărei echipe în competiție pe baza punctajului robotului.
- Calcularea scorurilor:
    - Scorul obținut de o echipă într-o competiție se calculează pe baza performanței robotului. Dacă robotul obține punctaje în intervalul valid (0 - punctaj maxim), se calculează scorul final.
- Participarea la competiții:
    - Se va permite înscrierea echipelor într-o competiție, iar competițiile vor fi reprezentate printr-o listă de echipe participante.
    - Fiecare echipă va avea asociat un scor final în competiție. Scorurile vor fi afișate pentru fiecare echipă, iar echipele vor fi ordonate după scorul obținut.
- Validarea datelor:
    - Se vor valida datele introduse pentru echipe și membri: numele echipei, numele membrilor, vârsta acestora și scorurile obținute în competiții.
- Disponibilitatea echipelor:
    - Disponibilitatea echipelor pentru a participa la o competiție se va face printr-un serviciu extern, care primește numărul echipei și returnează un boolean ce indică dacă echipa este eligibilă pentru competiție.

Notă:
- Fiecare echipă trebuie să aibă cel puțin 2 membri pentru a putea participa la competiție.
- Fiecare echipă trebuie să aibă un robot înregistrat pentru a putea participa.
- Punctajele obținute de roboți trebuie să fie validate și să nu depășească punctajul maxim specificat.
- Validare: Aplicația trebuie să valideze corect datele introduse și să gestioneze erorile în mod corespunzător.

Bonus: Disponibilitatea locurilor pentru participarea echipelor în competiție va fi verificată printr-un serviciu extern care poate arunca excepții, cum ar fi: competiția nu există, serviciul este indisponibil sau echipa nu este eligibilă pentru competiție.