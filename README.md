# Prime Minister Sorting

This C# program manages a dictionary of prime ministers and their respective years, performs operations like finding the prime minister of a specific year, adding a new prime minister, and sorting the prime ministers by year.

## Main Functionality

- **Prime Ministers Dictionary**: 
  - Initializes a dictionary (`primeMinisters`) to store prime ministers as keys and their corresponding years as values.
  - Example: `{"Atal Bihari Vajpayee": 1998, "Narendra Modi": 2014, "Manmohan Singh": 2004}`.

- **Finding Prime Minister of a Year**:
  - Uses the `GetPrimeMinisterOfYear` method to find and return the prime minister for a specific year.
  - Iterates through the prime ministers dictionary to find a match for the given year.
  - Returns the name of the prime minister if found, otherwise returns "Prime Minister not found".

- **Adding a New Prime Minister**:
  - Adds a new entry to the dictionary for the prime minister of the year 2024 ("Narendra Damodardas Modi").

- **Sorting Prime Ministers by Year**:
  - Uses the `SortPrimeMinistersByYear` method to sort the prime ministers dictionary by year.
  - Extracts the years from the values of the original dictionary, sorts them, and iterates through the sorted years.
  - For each sorted year, finds the corresponding prime minister from the original dictionary and adds it to a new sorted dictionary.

- **Displaying Prime Ministers**:
  - Prints the prime ministers and their respective years, either in the original order or sorted by year.

## Helper Methods

- **GetPrimeMinisterOfYear**:
  - Takes a dictionary of prime ministers and a year as input.
  - Iterates through the dictionary to find and return the prime minister for the given year.

- **SortPrimeMinistersByYear**:
  - Takes a dictionary of prime ministers as input.
  - Sorts the prime ministers by their years, creating a new sorted dictionary based on the sorted years.

