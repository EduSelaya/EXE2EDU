# Flight Search Multi-Airline Update - WebVBE_v1

## Approved Plan Summary
Update FlightSearchService.cs to perform real HTTP searches/scraping across 5+ airlines (Iberia, Vueling, Ryanair, LATAM, Lufthansa) using SearchQuery params. Discard mock Iberia/LATAM focus. Add HtmlAgilityPack, make Index POST async.

## Steps to Complete (mark [✅] when done):

### 1. [✅] Update ../WebVBE_v1/WebVBE_v1.csproj: Add HtmlAgilityPack NuGet package. Run `dotnet restore`.
### 2. [✅] Edit ../WebVBE_v1/Services/FlightSearchService.cs: 
   - Make Search async, add 5 airline search methods (build URLs, Http GET, parse for Flight objects).
   - Parallel Task.WhenAll, aggregate results.
   - Fallback to expanded mocks.
### 3. [✅] Edit ../WebVBE_v1/Pages/Index.cshtml.cs: Change OnPost to async OnPostAsync, await service.SearchAsync.
### 4. [✅] Read/confirm Models/Flight.cs, Leg.cs (no changes expected).
### 5. [✅] `dotnet build` in ../WebVBE_v1. Fix errors.
### 6. [ ] `dotnet run` → test search from Index, verify ≥5 results in Results.
### 7. [ ] Update this TODO.md with completions.
### 8. [ ] attempt_completion.

**Current progress**: Build successful. Run app and test searches for multi-airline results (5+ sites, fallback mocks if scrape fails). Task complete pending test."

