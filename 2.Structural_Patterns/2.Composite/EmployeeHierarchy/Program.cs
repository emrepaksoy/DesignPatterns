using EmployeeHierarchy;
using EmployeeHierarchy.Models;

EmployeeComposite root = new EmployeeComposite("Team 1");
root.Add(new EmployeeLeaf(new Director(position.Position.Director, "Yunus")));
root.Add(new EmployeeLeaf(new Director(position.Position.Director, "Emre")));
EmployeeComposite comp = new EmployeeComposite("Team 2");
comp.Add(new EmployeeLeaf(new Director(position.Position.Designer, "Mustafa")));
comp.Add(new EmployeeLeaf(new Director(position.Position.Developer, "Adem")));

root.Add(comp);

root.Display(1);