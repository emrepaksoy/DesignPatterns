using BasicCompositePattern;

Composite root = new Composite("root");
root.Add(new Leaf("Leaf A"));
root.Add(new Leaf("Leaf B"));
Composite comp = new Composite("Composite X");
comp.Add(new Leaf("Leaf XA"));
comp.Add(new Leaf("Leaf XB"));
root.Add(comp);
root.Add(new Leaf("Leaf C"));

root.Display(1);