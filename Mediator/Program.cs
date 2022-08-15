using Mediator;

ManagerMediator mediator = new ManagerMediator();

Colleague customer = new CustomerColleague(mediator);
Colleague programmer = new ProgrammerColleague(mediator);
Colleague tester = new TesterColleague(mediator);

mediator.Customer = customer;
mediator.Programmer = programmer;
mediator.Tester = tester;

customer.Send("There is an order, it is necessary to make a program");
programmer.Send("The program is ready, it is necessary to test");
tester.Send("The program has been tested and is ready for sale");