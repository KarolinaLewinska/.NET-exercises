# C# ćwiczenia

**Pętle i tablice:** <br/>
1. Napisz program wyświetlający w porządku malejącym liczby od 100 do 1 podzielne przez trzy, ale niepodzielne przez 2. Zadanie wykonaj za pomocą trzech rodzajów pętli (for, while, do..while). <br/>

2. Utwórz tablicę liczb typu int zaprezentowaną poniżej. Wypełnij kolejne komórki wartościami malejącymi od 10 do 1. Do utworzenia tablicy i wypełnienia jej danymi wykorzystaj pętlę typu for. <br/>

3. Utwórz tablicę dwuwymiarową, w której liczba komórek w kolejnych rzędach będzie równa dziesięciu kolejnym wartościom ciągu Fibonacciego, poczynając od elementu o wartości 1 (1, 1, 2, 3, 5 itd.). Wartość każdej komórki powinna być jej numerem w danym wierszu w kolejności malejącej (czyli dla wiersza o długości pięciu komórek kolejne wartości to 5, 4, 3, 2, 1). Zawartość tablicy wyświetl na ekranie.<br/>

**Przeciążanie konstruktorów, wyjątki:** <br/>
1. Napisz klasę zawierającą dwa pola: pierwsze typu double i drugie typu char(np. liczba i znak). Dopisz pięć przeciążonych konstruktorów: pierwszy przyjmujący jeden argument typu double, drugi przyjmujący jeden argument typu char, trzeci przyjmujący dwa argumenty — pierwszy typu double, drugi typu char — i czwarty przyjmujący również dwa argumenty typu typu double. Czwarty konstruktor niech liczy NWD Euklidesa. Piąty konstruktor (przyjmuje tablice int) Sito Erastotenesa – liczby pierwsze. Użyj  słowo kluczowe this. Wywołaj konstruktory w metodzie main(), wypisz stan zmiennych każdego konstruktora.<br/>

2. Napisz przykładowy program, w którym zostaną wygenerowane dwa różne wyjątki (ArithmeticException, Exception). Wyświetl na ekranie dwa systemowe komunikaty.<br/>

3. Napisz program, który pobierze od użytkownika tablice 10 liczb całkowitych. Przekaz tablicę do konstruktora, który posortuje tablicę metodą bąbelkową, i zwróci tablicę do metody main(). Wykorzystaj konstrukcję try – catch (np. przekroczenie zakresu tablicy).<br/>

**Operacje wejścia i wyjścia:**
1. Napisz program, który będzie realizował tzw. szyfr Cezara (modyfikacja o 1) działający na znakach wprowadzanych bezpośrednio z klawiatury. Naciśnięcie klawisza odpowiadającego literze ma powodować pojawianie się litery o podany przez użytkownika kluczu. Możesz ograniczyć się do przekodowywania tylko małych liter z alfabetu łacińskiego. (q lub escape kończy działanie).<br/>

2. Napisz program rozwiązujący równania kwadratowe, w którym parametry A, B i C będą wprowadzane przez użytkownika z klawiatury.<br/>

3. Napisz program, który umożliwi użytkownikowi wprowadzenie wiersza tekstu zawierającego liczby całkowite oddzielone znakiem separatora (np. przecinkiem). Program powinien następnie wyświetlić liczy pierwsze.<br/>


**Operacje na plikach:**
1. Napisz  program, który w wierszu poleceń będzie przyjmował nazwę katalogu  oraz nazwę pliku, będzie tworzył katalog i plik, a w pliku umieści posortowaną tablicę 10elementową liczb całkowitych algorytmem quicksort, wartości tablicy pobierze z pliku.

2. Napisz program usuwający plik lub katalog o nazwie przekazanej z wiersza poleceń. Program powinien zapytać użytkownika o potwierdzenie chęci wykonania tej operacji. 

3. Napisz program wyświetlający sumaryczną wielkość plików zawartych w katalogu o nazwie przekazanej z wiersza poleceń.

4. Napisz program, obliczający przybliżoną wartość liczby PI z wykorzystaniem metody Monte Carlo, a następnie uzyskaną wartość zapisać do dowolnego pliku.

**Interfejsy, typy uogólnione:**
1. Napisz klasę która dziedziczy z interfejsu (który zawiera opis właściwości dwóch liczb oraz definicję metody NWW). Następnie w nowej klasie (metodzie main()) zaimplementuj algorytm NWW.
2. Sortowanie przez wstawianie z dynamicznym powiększaniem się tablicy.

