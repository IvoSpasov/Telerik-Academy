var __extends = this.__extends || function (d, b) {
    for (var p in b) if (b.hasOwnProperty(p)) d[p] = b[p];
    function __() { this.constructor = d; }
    __.prototype = b.prototype;
    d.prototype = new __();
};
var Malls;
(function (Malls) {
    var ClothesShop = (function (_super) {
        __extends(ClothesShop, _super);
        function ClothesShop(name, numberOfFittingRooms, type) {
            _super.call(this, name);
            this.name = name;
            this.numberOfFittingRooms = numberOfFittingRooms;
            this.type = type;
        }
        ClothesShop.prototype.toString = function () {
            var result = _super.prototype.toString.call(this) + '\nnumber of fitting rooms: ' + this.numberOfFittingRooms;
            return result;
        };
        return ClothesShop;
    })(Malls.Shop);
    Malls.ClothesShop = ClothesShop;
})(Malls || (Malls = {}));
//# sourceMappingURL=ClothesShop.js.map
