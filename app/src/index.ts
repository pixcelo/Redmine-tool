import express from 'express';
import config from 'config';
import { Greeter } from './greeter';
import { Fetcher } from './fetcher';

const app: express.Express = express();
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
// Get request
app.get('/', function (req, res) {
  res.send('test page');
});

//console.log(users);
let greeter = new Greeter('Hello, world');
greeter.greet('Tom');

//let fetcher = new Fetcher();
//fetcher.fetchUrl('https://nodejs.org/api/documentation.json');

const _config = config.get('exchange.apiKey');
console.log(_config);
