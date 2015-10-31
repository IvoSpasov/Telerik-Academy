var Malls;
(function (Malls) {
    var pesho = new Malls.Employee('Petur', 'Petrov', 0 /* male */, 500, 26);
    console.log(pesho.toString());

    var massimoDutti = new Malls.ClothesShop('Massimo Dutti', 2, 2 /* elegant */);
    console.log(massimoDutti.toString());
    massimoDutti.addEmployee(pesho);
    console.log(massimoDutti.toString());

    var serdika = new Malls.Mall('Serdika', 'bulevard "Sitnyakovo" 48');
    console.log(serdika.toString());
    serdika.addShop(massimoDutti);
    console.log(serdika.toString());

    var ccs = new Malls.Mall('css', 'sofia', [massimoDutti]);
    console.log(ccs.toString());

    Malls.ClothesShop.greetCustomers();
})(Malls || (Malls = {}));
//# sourceMappingURL=main.js.map
