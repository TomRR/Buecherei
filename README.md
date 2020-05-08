# Buecherei
Ausleihe von Medien in einer Bücherei


**Ziel der Übung:** abgeleitete Klassen erstellen und neben der eigentlichen Vererbung eine virtuelle Methode in einer Basisklasse erstellen und diese in einer abgeleiteten Klasse überschreiben.

### Ausleihen von Medien in einer Bücherei (Vererbung & Polymorphismus)

Es soll eine kleine Konsolenanwendung geschrieben werden, mit der verschiedene Medien (in diesem Beispiel Videos und Software) in einer Bücherei ausgeliehen werden können.

* [X] 1. Erstellen Sie eine BasisKlasse AusleihbaresMedium. Diese Klasse enthält die Attribute istAusgeliehen und ausgeliehenBis, sowie die read only Eigenschaft Ausleihfrist, welche fest den Wert 30 zurückliefert. Zusätzlich stellt sie die Methoden bool KannAusgeliehenWerden(DateTime bis) und void AusleihenBis(DateTime bis) zur Verfügung. Die erste Methode überprüft ob das Medium bereits ausgeliehen ist und ob die von Ausleihfrist gelieferte Frist überschritten wurde. Die zweite Methode setzt die beiden Attribute entsprechend, wenn Ausleihen möglich ist.

* [X] 2. Um die Methoden und die Klasse zu testen, erstellen Sie eine Instanz der Klasse AusleihbaresMedium in Main. Rufen Sie die Methode KannAusgeliehenWerden mit verschiedenen Werten auf (heute + 15 Tage, heute + 30 Tage und heute + 31 Tage). Der Datentyp DateTime bietet dafür hilfreiche Eigenschaften und Methoden an.

* [X] 3. Leiten Sie eine Klasse Video von AusleihbaresMedium ab. Diese Klasse hat lediglich eine Eigenschaft vom Datentyp string mit dem Namen Produzent. Sonst macht sie nichts weiter! Testen Sie auch eine Instanz dieser Klasse in Main und beobachten Sie, ob sie tatsächlich die gleichen Methoden wie AusleihbaresMedium anbietet und ob sich diese Methoden auch gleich verhalten.

* [X] 4. Leiten Sie eine Klasse Software von AusleihbaresMedium ab. Eine Software darf in der Bücherei max. 1 Woche ausgeliehen werden. Erweitern Sie also die Eigenschaft Ausleihfrist so, dass sie in der abgeleiteten Klasse Software überschrieben wird und 7 Tage zurrückgibt. Testen Sie die Klasse in dem Sie eine Instanz von ihr in Main anlegen und die Methoden aufrufen.

* [X] 5. Erstellen Sie nun in Main eine List<AusleihbaresMedium> in der Sie Instanzen von Video und Software speichern. Damit haben Sie bereits einen wichtigen Teil von Polymorphismus umgesetzt. Da Sie in der vorherigen Teilaufgabe eine virtuelle Methode an der Basisklasse definiert haben und diese in einer abgeleiteten Klasse überschrieben haben, können Sie nun auch den weiteren Aspekt von Polymorphismus sehen. Erweitern Sie Main so, dass Sie über ihre Liste iterieren (foreach) und für jeden Eintrag KannAusgeliehenWerden mit unterschiedlicher Ausleihfrist aufrufen (z.B. heute + 5 Tage, heute + 9 Tage, heute + 27 Tage und heute + 50 Tage). Wenn Sie sich jedesmal ausgeben lassen, ob ihren Medium ausgeliehen werden kann, werden Sie sehen, dass (sofern vorhanden) automatisch die Implementierung der Methode der abgeleiteten Klasse verwendet wird.
  
* [X] 6. **(BONUS)** Leiten Sie eine weitere Klasse Buch von AusleihbaresMedium ab. Diese Klasse hat eine zusätzliche Eigenschaft vom Typ bool mit dem Namen InReparatur. Befindet sich ein Buch in Reparatur, kann es nicht mehr ausgeliehen werden. Ändern Sie die Klassen AusleihbaresMediumund Buch so, dass KannAusgeliehenWerden dieses Verhalten darstellt. Testen sie Ihre Änderungen in Main.
