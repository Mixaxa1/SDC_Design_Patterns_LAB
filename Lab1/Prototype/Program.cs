using Prototype;

Sherman sherman1 = new Sherman() { Name = "M4", CrewSize = 4, GunCaliber = 75 };
Sherman sherman2 = (Sherman)sherman1.GetClone();
sherman2.Name = "M4A1";
sherman2.CrewSize = 5;

sherman1.ShowInfo();
sherman2.ShowInfo();

Sherman sherman3 = (Sherman)sherman1.GetClone();
sherman3.ShowInfo();

