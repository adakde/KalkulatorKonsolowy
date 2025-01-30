# Kalkulator Konsolowy w C#

Prosty kalkulator konsolowy z obs�ug� podstawowych operacji matematycznych oraz histori� oblicze�.

## Funkcje
- Dodawanie
- Odejmowanie
- Mno�enie
- Dzielenie
- Pot�gowanie
- Reszta z dzielenia (modulo)
- Historia operacji (zapis i podgl�d)
- Obs�uga b��d�w (np. dzielenie przez zero)
- Kolorowe komunikaty

## Wymagania
- [.NET 6 SDK](https://dotnet.microsoft.com/download)

## Jak uruchomi�
1. Sklonuj repozytorium:
   ```bash
   git clone https://github.com/adakde/KalkulatorKonsolowy.git
Przejd� do folderu projektu:

bash
Copy
cd KalkulatorKonsolowy/Kalkulator konsolowy
Uruchom program:

bash
Copy
dotnet run
Przyk�adowe u�ycie
Copy
Witaj w kalkulatorze konsolowym!

Wybierz opcje:
1. Dodawanie
2. Odejmowanie
3. Mno�enie
4. Dzielenie
5. Modulo
6. Pot�gowanie
7. Wyjdz
8. Poka� histori�

Tw�j wyb�r: 6
Podaj pierwsz� liczb�: 2
Podaj drug� liczb�: 8
Wynik: 256
Struktura log�w
Wszystkie operacje s� zapisywane w pliku logs.txt w formacie:

Copy
Operacja: 6
 Dane: 2, 8
 Wynik: 256

Autor
@adakde

Licencja
MIT

Copy

---

### Jak doda� plik do repozytorium:
1. Utw�rz nowy plik `README.md` w g��wnym folderze projektu
2. Wklej powy�sz� zawarto��
3. Wykonaj komendy w terminalu:
```bash
git add README.md
git commit -m "Dodano profesjonalny plik README"
git push