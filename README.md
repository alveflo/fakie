# fakie
Simple data faker with star wars themed data.

## Status
- [x] Names
- - [x] SurName
- - [x] LastName
- - [x] FullName
- [ ] Address
- - [ ] ZipCode
- - [ ] City
- - [ ] Street
- - [ ] StreetNumber
- [ ] Internet
- - [ ] Email
- - [ ] Website
- [ ] Company
- - [ ] Name
- - [ ] CatchPhrase

## Api
### Fakie.Name
```csharp
// returns random surname e.g. Luke
var surName = Fakie.Name.SurName;

// returns random lastname e.g. Kenobi
var lastName = Fakie.Name.LastName;

// returns random lastname e.g. Leia Ackbar
var fullName = Fakie.Name.FullName;
```

## License
The MIT License
