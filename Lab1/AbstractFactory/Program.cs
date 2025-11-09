using AbstractFactory;

var client1 = new Client(new ChainmailArmory());
client1.CheckArmor();

var client2 = new Client(new LeatherArmory());
client2.CheckArmor();