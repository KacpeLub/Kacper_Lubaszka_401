Obecności: Nie mam wpisanej obecności na jednych zajęciach, ale i tak na nich byłem obecny.

Prace domowe: Mam co nieco ale u siebie na komputerze - lokalnie.


____ZADANIE 9____
Proszę opisać wzorce projektowe i napisać jakie mają zastosowanie w .NET Core:
Kompozyt
Obserwator
Strategia
Metoda Wytwórcza
Dekorator

Wzorzec Kompozyt (Composite):
Wzorzec Kompozyt jest używany w celu tworzenia hierarchii obiektów w strukturze drzewiastej. 
Pozwala traktować zarówno pojedyncze obiekty, jak i grupy obiektów w jednolity sposób. 
W .NET Core wzorzec Kompozyt może być wykorzystany, na przykład, do implementacji drzewa UI, 
gdzie zarówno pojedyncze elementy, jak i grupy elementów (np. przyciski, panele, formularze) 
są traktowane w podobny sposób.

Wzorzec Obserwator (Observer):
Wzorzec Obserwator służy do tworzenia mechanizmu powiadamiania o zmianach w obiektach. 
Gdy jeden obiekt zmienia swój stan, inne obiekty, które na niego "obserwują", są informowane 
o tych zmianach. W .NET Core wzorzec Obserwator może być zastosowany do realizacji asynchronicznego 
komunikowania się między różnymi komponentami aplikacji, na przykład w przypadku zdarzeń 
lub powiadomień systemowych.

Wzorzec Strategia (Strategy):
Wzorzec Strategia pozwala na dynamiczną zmianę algorytmu lub strategii, którą obiekt używa do 
wykonywania określonych operacji. Jest szczególnie przydatny w przypadku, gdy chcemy mieć możliwość 
zmiany zachowania obiektu w czasie działania programu. W .NET Core wzorzec Strategia może być stosowany, 
na przykład, w warstwie biznesowej aplikacji, gdzie różne strategie mogą być używane w zależności od 
kontekstu lub warunków działania.

Metoda Wytwórcza (Factory Method):
Metoda Wytwórcza jest wzorcem projektowym, który definiuje interfejs dla tworzenia obiektów, 
ale pozwala na konkretne klasy na przesunięcie odpowiedzialności za tworzenie instancji na podklasy. 
W .NET Core wzorzec Metoda Wytwórcza może być wykorzystany, na przykład, w przypadku tworzenia różnych 
typów obiektów w zależności od określonych warunków. Może również być używany w przypadku, gdy chcemy 
odizolować proces tworzenia obiektu od kodu, który z niego korzysta.

Dekorator (Decorator):
Wzorzec Dekorator pozwala na dynamiczne rozszerzanie funkcjonalności istniejących obiektów, 
dodając nowe zachowania bez konieczności modyfikacji oryginalnego kodu. W .NET Core wzorzec 
Dekorator może być używany, na przykład, w przypadku tworzenia różnych w