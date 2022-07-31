using FactoryMethod.Creator;
using FactoryMethod.Creator.ConcreteCreator;
using FactoryMethod.Product;

Developer dev = new PanelDeveloper("Some company");
House house2 = dev.Create();

dev = new WoodDeveloper("Some second company");
House house = dev.Create();

