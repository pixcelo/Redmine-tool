import express from 'express';
import { ApiService } from './ApiService';

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

const apiService = new ApiService();
apiService.has();
