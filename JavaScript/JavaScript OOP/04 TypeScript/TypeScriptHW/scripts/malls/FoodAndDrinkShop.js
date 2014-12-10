var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var Malls;
(function (Malls) {
    var FoodAndDrinkShop = (function (_super) {
        __extends(FoodAndDrinkShop, _super);
        function FoodAndDrinkShop(name, numberOfAvailableTables, type) {
            _super.call(this, name);
            this.name = name;
            this.numberOfAvailableTables = numberOfAvailableTables;
            this.type = type;
        }
        FoodAndDrinkShop.prototype.toString = function () {
            var result = _super.prototype.toString.call(this) + '\nnumber of available tebles: ' + this.numberOfAvailableTables;
            return result;
        };
        return FoodAndDrinkShop;
    })(Malls.Shop);
    Malls.FoodAndDrinkShop = FoodAndDrinkShop;
})(Malls || (Malls = {}));
//# sourceMappingURL=FoodAndDrinkShop.js.map
