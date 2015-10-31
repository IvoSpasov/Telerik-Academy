var Malls;
(function (Malls) {
    var Mall = (function () {
        function Mall(name, location, shops) {
            if (typeof shops === "undefined") { shops = new Array(); }
            this.name = name;
            this.location = location;
            this.shops = shops;
        }
        Mall.prototype.addShop = function (shop) {
            this.shops.push(shop);
        };

        Mall.prototype.removeShop = function (shop) {
            var indexOfShop = this.shops.indexOf(shop);
            if (indexOfShop < 0) {
                throw new Error('Shop to be romoved is not found.');
            }

            var shopToRemove = this.shops[indexOfShop];
            this.shops[indexOfShop] = this.shops[this.shops.length - 1];
            this.shops.pop();
            return shopToRemove;
        };

        Mall.prototype.countShops = function () {
            var shopsCount = this.shops.length;
            return shopsCount;
        };

        Mall.prototype.toString = function () {
            var result = 'Mall info:\nname: ' + this.name + '\nlocation: ' + this.location + '\nnumber of shops: ' + this.countShops();
            return result;
        };
        return Mall;
    })();
    Malls.Mall = Mall;
})(Malls || (Malls = {}));
//# sourceMappingURL=Mall.js.map
