// See https://aka.ms/new-console-template for more information
using klasside_Isik__;
opilane op= new opilane(1, 2, 3, "Tes", 2004, 'n');
tootaja to = new tootaja(1, 2, 80, "Julia", 1995, 'n');
kutsekooliopilane ku = new kutsekooliopilane(2, 3, 2, 50, "Jarik", 2001, 'm');
op.print_info();
to.print_info();
ku.print_info();
op.arvutaVanus();
to.arvutaVanus();
ku.arvutaVanus();
op.muudaNimi("Tasia");
op.print_info();
to.arvutaSissetulek(800, 20);
op.arvutaSissetulek(60, 20);
Console.ReadLine();