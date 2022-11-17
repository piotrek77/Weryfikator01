# weryfikator

Przykład weryfikatora w Enovie.

Testowane na Enovie w wersji 2204.4.8.

Weryfikator jest typu Warning i jest zapięty na polach Imię i Nazwisko na pracowniku.

Sprawdzane jest czy powyższe pola pasują do regexa: "^\\p{Lu}\\p{Ll}*$"

Więcej wzorców na imię, nazwisko można znaleźć tutaj: https://stackoverflow.com/questions/2385701/regular-expression-for-first-and-last-name