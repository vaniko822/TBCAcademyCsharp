using System;

Person[] personArray = new Person[3];

Home firstHome = new Home("Address1", "Belgrade");
Person firstPerson = new Person("Novak", 36, "131415", firstHome);
personArray[0] = firstPerson;

Home secondHome = new Home("Address2", "Tbilisi");
Person secondPerson = new Person("Khvicha", 22, "123456", secondHome);
personArray[1] = secondPerson;

Home thirdHome = new Home("Address3", "Argentina");
Person thirdPerson = new Person("Lionel", 35, "101112", thirdHome);
personArray[2] = thirdPerson;