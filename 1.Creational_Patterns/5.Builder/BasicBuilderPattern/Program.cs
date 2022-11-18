using BasicBuilderPattern;

Director director = new Director();

Builder b1 = new ConcreteBuilder1();
Builder b2 = new ConcreteBuilder2();

director.Constract(b1);
Product product = b1.GetResult();
product.Show();

director.Constract(b2);
Product product2 = b2.GetResult();
product2.Show();