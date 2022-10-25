import express from 'express';
import { ApiService } from './apiService';

const app: express.Express = express();
app.set('view engine', 'ejs');
app.set('views', __dirname + '/views');
app.use(express.json());
app.use(express.urlencoded({ extended: true }));

//CROS対応（というか完全無防備：本番環境ではだめ絶対）
app.use(
  (req: express.Request, res: express.Response, next: express.NextFunction) => {
    res.header("Access-Control-Allow-Origin", "*");
    res.header("Access-Control-Allow-Methods", "*");
    res.header("Access-Control-Allow-Headers", "*");
    next();
  }
);

// Listener
app.listen(3000, () => {
  console.log('Start on ', app.listen().address());
});

const apiService = new ApiService();
//apiService.has();
//apiService.check();
let info: object;
let res: string;
(async () => {
  info = await apiService.fetchTicker('BTCUSD');
  //console.log(info)
  res = await apiService.fetchOhlc('BTCUSDT');
  //console.log(Object.keys(res))
  //console.log(res);
})();
//apiService.fetchBalance();
// const res = apiService.fetchKline('BTSUSD');
// console.log(res)

app.get('/', (req, res) => {
  const data = {
    'title': 'Base',
    'data': res
  }
  res.render('index', data);
});
