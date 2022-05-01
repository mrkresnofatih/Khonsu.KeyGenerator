# Khonsu.KeyGenerator

This Nuget Package is just a simple unique string-type Id generator for database document Id generation.
A simple case of this library is displayed below:

```
var khonsu = new KhonsuKeyGen(new HashSet<string>
{ "XTR", "SGD", "TYK" });

var newId1 = khonsu.Generate("XTR"); // New Id
var newId2 = khonsu.Generate("EFR"); // throws KhonsuKeyGenerationException(): prefix not registered;
```

## How To Install

```
dotnet add package Khonsu.KeyGenerator --version 1.0.0
```