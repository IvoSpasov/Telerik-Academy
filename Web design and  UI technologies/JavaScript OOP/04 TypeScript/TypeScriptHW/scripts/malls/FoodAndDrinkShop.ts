module Malls {
    export class FoodAndDrinkShop extends Shop implements IFoodAndDrinkShop, IShop {
        constructor(public name: string, public numberOfAvailableTables: number, public type: FoodAndDrinkShopType) {
            super(name)
        }

        toString(): string {
            var result = super.toString() + '\nnumber of available tebles: ' + this.numberOfAvailableTables;
            return result;
        }
    }
} 