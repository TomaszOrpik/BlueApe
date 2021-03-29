# BlueApe

Aplikacja do tworzenia stron internetowych zaprogramowana w technologii Web Assembly.

# Wprowadzenie

BlueApe to aplikacja FullStackowa, której główną funkcjonalnością jest tworzenie własnych blogów przez użytkowników. Aplikacja jest zaprogramowana głównie w językach C# i JavaScript. Użytkownik dzięki generatorowi blogów może stworzyć w pełni funkcjonalny blog z własną bazą danych, podstronami i stylami. Strony wygenerowane w ten sposób mogą być umieszczone na serwerze i później edytowane przez edytor lub własny kod w JavaScript.  
<kbd>![blog selection](https://user-images.githubusercontent.com/54088860/112734998-8dd71600-8f49-11eb-8010-10d9d0150b5e.jpg)</kbd>

### Spis Treści

**[1 BlueApe API](#1-blueape-api)**  
[1.1 Informacje Ogólne](#11-informacje-ogolne)  
[1.2 Technologie](#12-technologie)  
[1.3 Odnośniki do zasobów](#13-odnosniki-do-zasobow)  
[1.4 Instalacja](#14-instalacja)  

**[2 File Creator](#2-file-creator)**  
[2.1 Informacje Ogólne](#21-informacje-ogolne)  
[2.2 Technologie](#22-technologie)  
[2.3 Odnośniki do zasobów](#23-odnosniki-do-zasobow)  
[2.4 Instalacja](#24-instalacja)  

**[3 BlueApe UI](#3-blueape-ui)**  
[3.1 Informacje Ogólne](#31-informacje-ogolne)  
[3.2 Technologie](#32-technologie)  
[3.3 Funkcjonalność](#33-funkcjonalnosc)  
[3.4 Instalacja](#34-instalacja)  

**[4 BlueApe Template](#4-blueape-template)**  
[4.1 Informacje Ogólne](#41-informacje-ogolne)  
[4.2 Technologie](#42-technologie)  
[4.3 API](#43-api)  
[4.4 Instalacja](#44-instalacja)  
[4.5 Publikowanie](#45-publikowanie)  

**[5 Inne](#5-inne)**  
[5.1 Zgłoś problemy i ulepszenia](#51-zglos-problemy-i-ulepszenia)  
[5.2 Licencja](#52-licencja)  
[5.3 Kontakt](#53-kontakt)  

# 1 BlueApe API

### 1.1 Informacje Ogólne

Napisane w C# api stworzone by zarządzać blogami i kontami użytkowników. Korzystając z technologii ASP.NET WebAPI, aplikacja łączy się z bazą danych w technologii MongoDB, gdzie przechowuje wszystkie dane otrzymane z aplikacji BlueApeUI. Korzystając z Entity Framework i Identity Framework, api weryfikuje użytkoników próbujących połączyć się z aplikacją front-endową na podstawie ich obecności w bazie danych i czaie zalogowania przy pomocy technologii Json Web Token.

### 1.2 Technologie

Api jest zaprogramowane w technologii .NET Core 5 ASP.NET WebApi, w języku C#. Główne biblioteki i frameworki wykorzystywane przez aplikację:
* Microsoft.AspNetCore.Identity
* Microsoft.AspNetCore.Identity.MongoDB
* Microsoft.AspNetCore.Authentication.JwtBearer
* Microsoft.EntityFrameworkCore
* Microsoft.OpenApi
* System.IO
* System.Linq
* System.Text
* System.Reflection

### 1.3 Odnośniki do zasobów

Odnośniki wygenerowane przez aplikację:
| Zasób      | Wymagane        |Wynik        |
|:--------------|:--------------------|:-------------|
| Get `api/v1/Blogs/LookForBlog/:name` | Nazwa | Zwraca `true` jeżeli blog istnieje w bazie danych, w innym przypadku zwraca `false` |
| Get `api/v1/Blogs/GetUserBlogs:/name` | Nazwa Użytkownika | Zwraca z bazy danych wszystkie blogi stworzone przez wybranego użytkownika |
| Post `api/v1/Blogs/CreateBlog` | BlogDocument | Tworzy w bazie danych nową kolekcję nazwą według przesłanych danych bloga z wszystkimi przekazanymi wartościami, a w kolekcji użytkowników, nowego z możliwością zapisania/odczytania danych zapisanego bloga |
| Get `api/v1/Blogs/GetBlogData/:name` | Nazwa | Pobiera z bazy danych, dane bloga o przekazanej nazwie |
| Put `api/v1/Blogs/UpdateBlogData` | BlogDocument | Uaktualnia przekazane dane bloga w kolekcji |
| Delete `api/v1/Blogs/DeleteBlog/:name` | Nazwa | Usuwa z bazy danych bloga o określonej nazwie |
| Get `api/v1/Blogs/LookForPost/:blogName/:postName` | Nazwa bloga, Nazwa postu | Szuka w danych określonego bloga, postu o przekazanej nazwie, jeżeli taki istnieje zwraca `true` w innym przypadku `false` |
| Get `api/v1/Blogs/getPostData/:blogName/:postName` | Nazwa bloga, Nazwa postu | Zwraca z kolekcji bloga o wskazanej nazwie, dane postu powiązanego z przekazaną nazwą |
| Get `api/v1/Blogs/GetPageData/:blogName/:pageName` | nazwa bloga, Nazwa strony | Zwraca z kolekcji bloga o wskazanej nazwie, dane strony powiązanej z przekazaną nazwą |
| Post `api/v1/Blogs/AddPostData` | BlogDocument | Uaktualnia dane przekazanego bloga w powiązanej kolekcji |
| Post `api/v1/Blogs/AddPageData` | BlogDocument | Uaktualnia dane przekazanego bloga w powiązanej kolekcji |
| Put `api/v1/Blogs/UpdatePostData` | BlogDocument | Uaktualnia dane przekazanego bloga w powiązanej kolekcji |
| Put `api/v1/Blogs/UpdatePageData` | BlogDocument | Uaktualnia dane przekazanego bloga w powiązanej kolekcji |
| Delete `api/v1/Blogs/DeletePostData/:blogName/:postName` | Nazwa bloga, Nazwa postu | Usuwa post o przekazanej nazwie ze wskazanego bloga |
| Delete `api/v1/Blogs/DeletePageData/:blogName/:pageName` | Nazwa bloga, Nazwa strony | Usuwa stronę o przekazanej nazwie ze wskazanego bloga |
| Get `api/v1/Users/UserData` | JwtToken | Autoryzuje użytkownika |
| Post `api/v1/Users/Register` | userModel | Dodaje przekazanego użytkownika do bazy danych |
| Post `api/v1/Users/Login` | userModel | Sprawdza czy przekazany użytkownik istnieje w bazie danych, następnie weryfikuje token, następnie zwraca `OK` |

### 1.4 Instalacja

By działać prawidłowo aplikacja wykorzystuje [.net Core 5](https://dotnet.microsoft.com/download/dotnet/5.0) i [Visual Studio 2019](https://visualstudio.microsoft.com/pl/downloads/)
* Pobierz repozytorium
* Twórz plik z solucją BlueApe
* Debuguj lub Zbuduj w Visual Studio BlueApeAPI

# 2 File Creator

### 2.1 Informacje Ogólne

Node.js + Express.js API wykorzystywane by zarządzać danymi bezpośrednio na serwerze. Główną funkcją aplikacji jest generowanie odnosników do łatwego zarządzania obrazami i wygenerowanymi danymi blogów. Dzięki dużym możliwościom w zarządzaniu plikami frameworku node.js, aplikacja może zapisywać pliki wysyłane z front-endu na serwerze, zwracać adresy plików i zarządzać danymi zapisywanymi i pobieranymi z serwera.

### 2.2 Technologie

Api jest zaprogramowane w node.js + express.js za pomocą języka JavaScript. Biblioteki i frameworki wykorzystywane przez api:
* fs-extra
* body-parser
* express-fileupload
* cors
* adm-zip
* mongodb
* nodemon

### 2.3 Odnośniki do zasobów

Odnośniki wykorzystywane przez aplikację:
| Zasób      | Wymagania        |Wynik        |
|:--------------|:--------------------|:-------------|
| Get `/` | Brak | Wyświetla stronę główną aplikacji |
| Get `/config/:name` | Nazwa bloga | generuje plik json z danymi bloga o przesłanej nazwie z bazy danych |
| Get `/staticPage/:name` | Nazwa bloga | Generuje repozytorium z blogiem w technologii next.js z api pobierającym dane z pliku json |
| Get `/dynamicPage/:name` | Nazwa bloga | Generuje repozytorium z blogiem w technologii next.js z api pobierającym dane z pliku bazy danych |
| Post `/saveImage` | Nazwa pliku, ciąg znaków base64 | Zapisuje ciąg znaków base64 na serwerze i zwraca link do wygenerowanego pliku png |
| Delete `/deleteImage/:name` | Nazwa pliku | Usuwa z serwera plik png o przekazanej nazwie |
| Post `/saveJpgImage` | Nazwa pliku, ciąg znaków base64 | Zapisuje ciąg znaków base64 na serwerze i zwraca link do wygenerowanego pliku jpg |
| Delete `/deleteJpgImage/:name` | Nazwa pliku | Usuwa z serwera plik png o przekazanej nazwie |

### 2.4 Instalacja

By działać prawidłowo aplikacja wymaga zainstalowanego [node.js](https://nodejs.org/en/):
* Pobierz repozytorium
* uruchom `npm install`
* Rozpocznij serwer za pomocą `npm run start`

# 3 BlueApe UI

### 3.1 Informacje Ogólne

Stworzona w technologii Blazor Web Assembly za pomocą języka C#, aplikacja do tworzenia i zarządzania blogami. Dzięki technologii WASM aplikacja jest łatwa w dostępie z możliwością zainstalowania na różnych urządzeniach. Również jest ona zabezpieczona przez technologie MS Identity i JSON Web Token. Posiada interfejs użytkownika z funkcją podglądu na żywo zaprojektowanego bloga, co sprawia, że tworzenie jest bardzo intuicyjne. Gdy projekt jest gotowy, użytkownik może zarządzać materiałami za pomocą wbudowanego edytora stron/postów. W ten sposób stworzone strony są łatwe w eksporcie do formy statycznej bez backendu lub z własną kolekcją w bazie danych MongoDB z wybranymi stylami i unikalnym użytkownikiem mającym dostęp do tych danych. Wyeksportowane strony są gotowe do publikacji na platformie [Vercel](https://vercel.com/).

### 3.2 Technologie

Aplikacja jest zaprogramowana w technologii .NET Core 5 Blazor Web Assembly za pomocą języka C#. Frameworki i technologie wykorzystywane w aplikacji:
* Microsoft.AspNetCore.Authorization
* Microsoft.JSInterop
* Radzen.Blazor
* Blazored.LocalStorage
* Blazored.TextEditor

### 3.3 Funkcjonalność

Główna funkcjonalność aplikacji:
* System logowania/rejestracji z automatycznym wylogowanie m, bazując na Tokenie Json Web Token
<kbd>![loginPage](https://user-images.githubusercontent.com/54088860/112735038-d42c7500-8f49-11eb-9dae-2cc925ec03a5.jpg)</kbd>
* Łatwy dostęp do zaprojektowanych blogów
<kbd>![blog selection](https://user-images.githubusercontent.com/54088860/112734998-8dd71600-8f49-11eb-8010-10d9d0150b5e.jpg)</kbd>
* Wybór styli z dynamicznie generowanym podglądem
<kbd>![webCreation](https://user-images.githubusercontent.com/54088860/112735092-4735eb80-8f4a-11eb-8a19-39d381cc01d0.gif)</kbd>
* Edycja stron/postów za pomocą wbudowanego edytora HTML
<kbd>![pageCreation](https://user-images.githubusercontent.com/54088860/112735102-56b53480-8f4a-11eb-9523-f7104095390a.gif)</kbd>
* Pobieranie zaprojektowanych blogów jednym kliknięciem
<kbd>![blogExport](https://user-images.githubusercontent.com/54088860/112735109-67fe4100-8f4a-11eb-86ab-3bbeab2ebac5.gif)</kbd>

### 3.4 Instalacja

By działać prawidłowo aplikacja wymaga [.NET Core 5](https://dotnet.microsoft.com/download/dotnet/5.0), [Visual Studio 2019](https://visualstudio.microsoft.com/pl/downloads/) i [node.js](https://nodejs.org/en/)
* Pobierz repozytorium
* W folderze FileCreator wykonaj komendę `npm install`
* W folderze FileCreator wykonaj komendę `npm run start`
* Debuguj lub zbuduj aplikację BlueApeAPI
* Debuguj lub zbuduj aplikację BlueApeUI

# 4 BlueAPe Template

### 4.1 informacje Ogólne

Działająca samodzielnie strona wygenerowana za pomocą aplikacji BlueApe. Jest ona stworzona w języku JavaScript i korzysa z frameworku Next.js do działania. W zależności od preferencji użytkownika aplikacja posiada własną kolekcję w bazie danych MongoDB lub statystyczne dane w pliku Json i jest łatwa w publikacji przez platformę [Vercel](https://vercel.com/).
<kbd>![templateImage](https://user-images.githubusercontent.com/54088860/112735080-2c637700-8f4a-11eb-9c39-425457c3a200.jpg)</kbd>

### 4.2 Technologie

Aplikacja jest stworzona w języku JSX. Frameworki i biblioteki wykorzystywane przez nią:
* React
* React-dom
* next.js
* bootstrap 5
* mongodb
* swr
* unfetch

### 4.3 API

Strona posiada funkcjonalność api pod adresem `/api/blogData`. Posiada ono inną funkcjonalność w zależności od statycznego/dynamicznego trybu generowania danych wybranego przez użytkownika:
* w trybie statycznym - aplikacja generuje plik BlogDocument.json w którym jest zapisana kolekcja bloga z bazy danych, api w tym trybie pobiera dane z tego pliku
* w trybie dynamicznym - api łączy się z kolekcją mongoDB stworzoną specjalnie dla strony, w celu bezpieczeństwa aplikacja korzysta z wygenerowanego konta z unikalną nazwą użytkownika i hasłem, by być pewnym, że dane bloga będę dostępne tylko przez korzystającą z nich stronę

### 4.4 Instalacja

By działać prawidłowo aplikacja wymaga [node.js](https://nodejs.org/en/) zainstalowanego:
* Stwórz i pobierz aplikację prze narzędzie BlueApe
* Uruchom komendę `npm install`
* Uruchom komendę `npm run build`
* Rozpocznij serwer komendą `npm run start` lub `npm run dev`

### 4.5 Publikowanie

By opublikować wygenerowaną stronę:
* Utwórz repozytorium GitHub
* Zaloguj się do platformy [Vercel](https://vercel.com/) i opublikuj stronę poprzez połączenie jej z repozytorium Github
* Dokładniejsza instrukcja dostępna [tutaj](https://nextjs.org/learn/basics/deploying-nextjs-app/github)


# 5 Inne

### 5.1 Zgłoś problemy i ulepszenia

Możesz zgłosić problemy i wysłać pomysły na ulepszenia [tutaj](https://github.com/TomaszOrpik/BlueApe/issues)

### 5.2 Licencja

Aplikacja działa na zasadach GENERAL PUBLIC LICENSE by poznać szczegóły [sprawdź plik ze szczegółami](https://github.com/TomaszOrpik/BlueApe/blob/main/LICENSE)

### 5.3 Kontakt

Zapraszam do [kontaktu ze mną!](https://github.com/TomaszOrpik)
