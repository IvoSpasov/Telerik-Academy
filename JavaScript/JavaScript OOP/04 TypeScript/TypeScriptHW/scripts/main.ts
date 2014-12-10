module Malls {
    var pesho = new Employee('Petur', 'Petrov', Sex.male, 500, 26);
    console.log(pesho.toString());

    var massimoDutti = new ClothesShop('Massimo Dutti', 2, ClothesShopsType.elegant);
    console.log(massimoDutti.toString());
    massimoDutti.addEmployee(pesho);
    console.log(massimoDutti.toString());
    

    var serdika = new Mall('Serdika', 'bulevard "Sitnyakovo" 48');
    console.log(serdika.toString());
    serdika.addShop(massimoDutti);
    console.log(serdika.toString());

    var ccs = new Mall('css', 'sofia', [massimoDutti]);
    console.log(ccs.toString());

    ClothesShop.greetCustomers();
}