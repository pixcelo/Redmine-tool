import express from 'express';
import multer from 'multer';
import { v4 as uuid } from 'uuid';
import { ApiService } from './apiService';

const app: express.Express = express();
app.use(multer().none());
app.use(express.static('public'));
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

const todoList: Array<object> = [];
// const todoList = [
//     { title: 'JavaScript', done: true },
//     { title: 'Node.js', done: false },
//     { title: 'Web API', done: false }
// ];

// // Route
// // https://expressjs.com/ja/4x/api.html#app.METHOD
app.get('/api/v1/list', (req, res) => {
  res.json(todoList);
});

app.post('/api/v1/add', (req, res) => {
  // Get data from client
  const todoData = req.body;
  const todoTitle = todoData.title;

  const id = uuid();

  const todoItem = {
      id,
      title: todoTitle,
      done: false
  };

  todoList.push(todoItem);
  console.log('Add: ' + JSON.stringify(todoItem));

  res.json(todoItem);
});
