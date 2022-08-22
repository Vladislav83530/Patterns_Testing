using Observer;

Stock stock = new Stock();
Bank bank = new Bank("PrivatBank", stock);
Broker broker = new Broker("Petro Petrovich", stock);

stock.Market();

broker.StopTrade();

stock.Market();
