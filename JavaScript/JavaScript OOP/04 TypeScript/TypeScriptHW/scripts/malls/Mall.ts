module Malls {
    export class Mall implements IMall {

        constructor(public name: string, public location: string, public shops: IShop[]= new Array<Shop>()) {
        }

        addShop(shop: IShop): void {
            this.shops.push(shop);
        }

        removeShop(shop: IShop): IShop {
            var indexOfShop = this.shops.indexOf(shop);
            if (indexOfShop < 0) {
                throw new Error('Shop to be romoved is not found.');
            }

            var shopToRemove = this.shops[indexOfShop];
            this.shops[indexOfShop] = this.shops[this.shops.length - 1];
            this.shops.pop();
            return shopToRemove;
        }

        countShops(): number {
            var shopsCount = this.shops.length;
            return shopsCount;
        }

        toString(): string {
            var result = 'Mall info:\nname: ' + this.name + '\nlocation: ' + this.location + '\nnumber of shops: ' + this.countShops();
            return result;
        }
    }
}