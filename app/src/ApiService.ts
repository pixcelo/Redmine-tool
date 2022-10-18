import ccxt from 'ccxt';
import config from 'config';

export class ApiService {
    exchangeClass: any
    exchange: ccxt.Exchange

    constructor() {
        const exchangeClass = ccxt['bybit'];
        this.exchange =  new exchangeClass({
            'apiKey': config.get('exchange.apiKey'),
            'secret': config.get('exchange.apiSecret'),
            'verbose': false
        });
        // Set only in the testnet
        this.exchange.set_sandbox_mode(true);
    }

    has() {
        console.log(this.exchange.has);
    }

    check() {
        console.log("api", config.get('exchange.apiKey'),)
        console.log("sec", config.get('exchange.apiSecret'),)
    }

    async fetchBalance() {
        const res = await this.exchange.fetchBalance();
        console.log(res);
    }

    async fetchTicker(symbol: string): Promise<ccxt.Ticker> {
        const ticker: ccxt.Ticker = await this.exchange.fetchTicker(symbol);
        return ticker.info;
    }
}
