export class Samochod{
    private _nazwa:string;
    private _url:string;
    private _ranking:number;
    private _nieocenione:boolean;

    public constructor(n:string, u:string)
    {
        this._nazwa = n;
        this._url = u;
        this._ranking = 0;
        this._nieocenione = true;
    }

    //Tu są takie szprytne gettery, to ciekawy szczegół. Patrz na nazwy
    public get nazwa()
    { return this._nazwa; }

    public get url()
    { return this._url; }

    public get ranking()
    { return this._ranking; }

    public get nieocenione()
    { return this._nieocenione; }

    public set ranking(value:number)
    { 
        this._ranking += value;
        if(this._ranking > 10)
        { this._ranking = 10; }
        else if (this._ranking < 0)
        { this._ranking = 0; }
    }

    public set nieocenione(value:boolean)
    { this._nieocenione = value; }

    public set nazwa(value:string)
    { this._nazwa = value; }
}