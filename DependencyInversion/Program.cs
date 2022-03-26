// See https://aka.ms/new-console-template for more information
using DependencyInversion.Concrete;

var product = new SaveProduct(new MongoDbSave());
product.Save();
product = new SaveProduct(new MemorySave());
product.Save();
product = new SaveProduct(new DatabaseSave());
product.Save();