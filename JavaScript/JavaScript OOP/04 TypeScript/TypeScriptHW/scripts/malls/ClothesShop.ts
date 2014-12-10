module Malls {
    export class ClothesShop extends Shop implements IClothesShop, IShop {
        constructor(public name: string, public numberOfFittingRooms: number, public type: ClothesShopsType) {
            super(name)
        }

        toString(): string {
            var result = super.toString() + '\nnumber of fitting rooms: ' + this.numberOfFittingRooms;
            return result;
        }
    }
} 