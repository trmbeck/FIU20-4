# Syntax

## Regelwerk für
   + Schreibweisen
   + Bezeichnungen
   + Formulierungen
   des Programmcodes

## Schlüsselwörter und Bezeichner
   + Name der Schlüsselwörter dürfen nicht verwendet werden
   + Alle UnicodeZeichen
   	 - Es sollten nur Buchstaben (`A-Z` und `a-z`), die Ziffern `0-9` und der
   	  Unterstrich "`_`" verwendet werden
   + Leerzeichen und Sonderzeichen sind nicht erlaubt
   + Bezeichner beginnt mit einem Buchstaben oder dem Unterstrich
   + Groß- und Kleinschreibung wird unterschieden (case sensitive)

## Aufbau eines Programms

```csharp
namespace MeinErstesProgramm
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello World!");

        }
    }
}
```

   + Startklasse: Program
   + Methode Main(): Einstiegspunkt des Programms
   + Block/Anweisungsblock: Zusammengehörende Anweisungen


## Programmcode dokumentieren

   + Kommentare erleichter die Funktionsweise des Programms nachzuvollziehen
   + Kommentare sollte NICHT Programmcode beschreiben, welcher sich aus der Syntax
     ableiten/ablesen lässt
   + Kommentare werden direkt im Programmcode geschrieben und vom
     Compiler/Interpreter ignoriert
   + Kommentare haben eine Kennzeichnung: // oder /*...*/
   + C# kennt Dokumentationskommentare: /// --> kann zur Erzeugung einer xml-Datei
     genutzt werden

## Anweisungen (Statements)

   + Eine Anweisung wird durch ein Semikolon (;) abgeschlossen
   + Eine Anweisung kann mittel Anweisungsblock aus mehreren Anweisungen bestehen
   	 ```csharp
     { // Anweisungsblock öffnen
   		Anweisung1;
   		Anweisung2;
   		Anweisung3;
   	 } // Anweisungsblock schließen
   + Es können mehrere Anweisung in einer Zeile geschrieben werden
