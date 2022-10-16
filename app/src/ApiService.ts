import ccxt from 'ccxt';
import config from 'config';

export class ApiService {
    exchangeClass: any
    exchange: any

    constructor() {
        const exchangeClass = ccxt['bybit'];
        this.exchange =  new exchangeClass({
            'apiKey': config.get('exchange.apiKey'),
            'secret': config.get('exchange.apiSecret')
        });
    }

    has() {
        console.log(this.exchange.has);
    }

}
