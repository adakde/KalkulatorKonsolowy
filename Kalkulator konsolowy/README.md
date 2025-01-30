# Kalkulator Konsolowy w C#

Prosty kalkulator konsolowy z obs³ug¹ podstawowych operacji matematycznych oraz histori¹ obliczeñ.

## Funkcje
- Dodawanie
- Odejmowanie
- Mno¿enie
- Dzielenie
- Potêgowanie
- Reszta z dzielenia (modulo)
- Historia operacji (zapis i podgl¹d)
- Obs³uga b³êdów (np. dzielenie przez zero)
- Kolorowe komunikaty

## Wymagania
- [.NET 6 SDK](https://dotnet.microsoft.com/download)

## Jak uruchomiæ
1. Sklonuj repozytorium:
   ```bash
   git clone https://github.com/adakde/KalkulatorKonsolowy.git
PrzejdŸ do folderu projektu:

bash
Copy
cd KalkulatorKonsolowy/Kalkulator konsolowy
Uruchom program:

bash
Copy
dotnet run
Przyk³adowe u¿ycie
Copy
Witaj w kalkulatorze konsolowym!

Wybierz opcje:
1. Dodawanie
2. Odejmowanie
3. Mno¿enie
4. Dzielenie
5. Modulo
6. Potêgowanie
7. Wyjdz
8. Poka¿ historiê

Twój wybór: 6
Podaj pierwsz¹ liczbê: 2
Podaj drug¹ liczbê: 8
Wynik: 256
Struktura logów
Wszystkie operacje s¹ zapisywane w pliku logs.txt w formacie:

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

### Jak dodaæ plik do repozytorium:
1. Utwórz nowy plik `README.md` w g³ównym folderze projektu
2. Wklej powy¿sz¹ zawartoœæ
3. Wykonaj komendy w terminalu:
```bash
git add README.md
git commit -m "Dodano profesjonalny plik README"
git push