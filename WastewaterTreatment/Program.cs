using WastewaterTreatment;

SewageWater water = new SewageWater(2000, 1500, 32, 15000);

Console.WriteLine("Gravel: {0}\nFiltration: {1}\nSand {2}\nOrganic: {3}", water.amountGravel, water.largerParticles, water.amountSand, water.organicPolutants);
SewageSludge sludge = new SewageSludge();
WastewaterTreatmentPlant treatmentPlant = new WastewaterTreatmentPlant(
    new PreliminaryTreatment(new GravelTrap(100), new Filtration(100), new SandTrap(100, new SedimentationTank())),
    new PrimaryTreatments(60, new SedimentationTank(), sludge),
    new SecondaryTreatment(94, new AerationTank(100), sludge, new SettlingTank()));
treatmentPlant.Treatment(water);
Console.WriteLine();
Console.WriteLine("Gravel: {0}\nFiltration: {1}\nSand {2}\nOrganic: {3}", water.amountGravel, water.largerParticles, water.amountSand, water.organicPolutants);

Console.WriteLine("Sewage sludge: {0}",sludge);