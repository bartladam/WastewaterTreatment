using WastewaterTreatment;

Console.Title = "Wastewater treatment plant";
SewageWater water = new SewageWater(2000, 1500, 32, 1500000);

Console.WriteLine("Gravel: {0} g/l\nFiltration: {1} g/l\nSand {2} g/l\nOrganic: {3} mg/l", water.amountGravel, water.largerParticles, water.amountSand, water.organicPollutants);
SewageSludge sludge = new SewageSludge();
WastewaterTreatmentPlant treatmentPlant = new WastewaterTreatmentPlant(
    new PreliminaryTreatment(new GravelTrap(100), new Filtration(100), new SandTrap(98, new SedimentationTank())),
    new PrimaryTreatments(60, new SedimentationTank(), sludge),
    new SecondaryTreatment(94, new AerationTank(100), sludge, new SettlingTank()));
treatmentPlant.Treatment(water);
Console.WriteLine();
Console.WriteLine("Gravel: {0} g/l\nFiltration: {1} g/l\nSand: {2} g/l\nOrganic: {3} mg/l", water.amountGravel, water.largerParticles, water.amountSand, water.organicPollutants);

Console.WriteLine("Sewage sludge: {0} mg",sludge);
Console.ReadKey();