interface IMall {
    name: string;
    location: string;
    shops: IShop[];
    addShop(shop: IShop): void;
    removeShop(shop: IShop): IShop;

    toString();
} 