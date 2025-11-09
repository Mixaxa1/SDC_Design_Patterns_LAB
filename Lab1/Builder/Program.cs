using Builder;

Director chairDirector = new Director();
MetalChariBuilder builderM = new MetalChariBuilder();
WoodenChariBuilder builderW = new WoodenChariBuilder();

chairDirector.BuildChair(builderW);
var chair1 = builderW.GetChair();
chair1.ShowInfo();

chairDirector.BuildStool(builderW);
var chair2 = builderW.GetChair();
chair2.ShowInfo();

chairDirector.BuildStool(builderM);
var chair3 = builderM.GetChair();
chair3.ShowInfo();