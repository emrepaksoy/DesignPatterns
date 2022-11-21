

using DocumentOperations;

Document document = new Document();
ICommand openCommand = new OpenCommand(document);
ICommand saveCommand = new SaveCommand(document);
ICommand closeCommand = new CloseCommand(document);
Options menu = new Options(openCommand, saveCommand, closeCommand);
menu.clickOpen();
menu.clickSave();
menu.clickClose();
