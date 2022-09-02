// See https://aka.ms/new-console-template for more information
using klasside_Isik__;
opilane op= new opilane(1, 1, 1, "Tes", 2004, 'n');
tootaja to = new tootaja(1, 2, 850, "Julia", 1995, 'n');
kutsekooliopilane ku = new kutsekooliopilane(2, 3, 2, 50, "Jarik", 2001, 'm');
op.print_info();
to.print_info();
ku.print_info();
op.arvutaVanus();
to.arvutaVanus();
ku.arvutaVanus();
Console.ReadLine();