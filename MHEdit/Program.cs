﻿using System;
using System.IO;

namespace MHEdit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(args.Length >= 4)
            {
                if (args[0].Equals("P2G"))
                {
                    if (args[1].Equals("-d"))
                    {
                        var outMelee = Controllers.P2G.GetMelee(args[2]);
                        var outGunner = Controllers.P2G.GetGunner(args[2]);
                        var outHelms = Controllers.P2G.GetHelms(args[2]);
                        var outChests = Controllers.P2G.GetChests(args[2]);
                        var outArms = Controllers.P2G.GetArms(args[2]);
                        var outWaists = Controllers.P2G.GetWaists(args[2]);
                        var outLegs = Controllers.P2G.GetLegs(args[2]);

                        try
                        {
                            Directory.CreateDirectory(args[3]);
                            File.WriteAllText($"{args[3]}\\Melee.json", outMelee);
                            File.WriteAllText($"{args[3]}\\Gunner.json", outGunner);
                            File.WriteAllText($"{args[3]}\\Helmets.json", outHelms);
                            File.WriteAllText($"{args[3]}\\Chestplates.json", outChests);
                            File.WriteAllText($"{args[3]}\\Armguards.json", outArms);
                            File.WriteAllText($"{args[3]}\\Waistpieces.json", outWaists);
                            File.WriteAllText($"{args[3]}\\Leggings.json", outLegs);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }
                    else if (args[1].Equals("-i"))
                    {
                        try
                        {
                            string meleeIn = File.ReadAllText($"{args[2]}\\Melee.json");
                            string gunnerIn = File.ReadAllText($"{args[2]}\\Gunner.json");
                            string headIn = File.ReadAllText($"{args[2]}\\Helmets.json");
                            string chestIn = File.ReadAllText($"{args[2]}\\Chestplates.json");
                            string armsIn = File.ReadAllText($"{args[2]}\\Armguards.json");
                            string waistIn = File.ReadAllText($"{args[2]}\\Waistpieces.json");
                            string legIn = File.ReadAllText($"{args[2]}\\Leggings.json");
                            Controllers.P2G.SaveMelee(args[3], meleeIn);
                            Controllers.P2G.SaveGunner(args[3], gunnerIn);
                            Controllers.P2G.SaveHeads(args[3], headIn);
                            Controllers.P2G.SaveChests(args[3], chestIn);
                            Controllers.P2G.SaveArms(args[3], armsIn);
                            Controllers.P2G.SaveWaists(args[3], waistIn);
                            Controllers.P2G.SaveLegs(args[3], legIn);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }
                else if (args[0].Equals("NAFU"))
                {
                    Controllers.P2G.meleeOffset = Helpers.P2GHelpers.meleeOffsetNA;
                    Controllers.P2G.gunnerOffset = Helpers.P2GHelpers.gunnerOffsetNA;
                    Controllers.P2G.headOffset = Helpers.P2GHelpers.headOffsetNA;
                    Controllers.P2G.chestOffset = Helpers.P2GHelpers.chestOffsetNA;
                    Controllers.P2G.armOffset = Helpers.P2GHelpers.armOffsetNA;
                    Controllers.P2G.waistOffset = Helpers.P2GHelpers.waistOffsetNA;
                    Controllers.P2G.legOffset = Helpers.P2GHelpers.legOffsetNA;
                    if (args[1].Equals("-d"))
                    {
                        var outMelee = Controllers.P2G.GetMelee(args[2]);
                        var outGunner = Controllers.P2G.GetGunner(args[2]);
                        var outHelms = Controllers.P2G.GetHelms(args[2]);
                        var outChests = Controllers.P2G.GetChests(args[2]);
                        var outArms = Controllers.P2G.GetArms(args[2]);
                        var outWaists = Controllers.P2G.GetWaists(args[2]);
                        var outLegs = Controllers.P2G.GetLegs(args[2]);

                        try
                        {
                            Directory.CreateDirectory(args[3]);
                            File.WriteAllText($"{args[3]}\\Melee.json", outMelee);
                            File.WriteAllText($"{args[3]}\\Gunner.json", outGunner);
                            File.WriteAllText($"{args[3]}\\Helmets.json", outHelms);
                            File.WriteAllText($"{args[3]}\\Chestplates.json", outChests);
                            File.WriteAllText($"{args[3]}\\Armguards.json", outArms);
                            File.WriteAllText($"{args[3]}\\Waistpieces.json", outWaists);
                            File.WriteAllText($"{args[3]}\\Leggings.json", outLegs);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }
                    else if (args[1].Equals("-i"))
                    {
                        try
                        {
                            string meleeIn = File.ReadAllText($"{args[2]}\\Melee.json");
                            string gunnerIn = File.ReadAllText($"{args[2]}\\Gunner.json");
                            string headIn = File.ReadAllText($"{args[2]}\\Helmets.json");
                            string chestIn = File.ReadAllText($"{args[2]}\\Chestplates.json");
                            string armsIn = File.ReadAllText($"{args[2]}\\Armguards.json");
                            string waistIn = File.ReadAllText($"{args[2]}\\Waistpieces.json");
                            string legIn = File.ReadAllText($"{args[2]}\\Leggings.json");
                            Controllers.P2G.SaveMelee(args[3], meleeIn);
                            Controllers.P2G.SaveGunner(args[3], gunnerIn);
                            Controllers.P2G.SaveHeads(args[3], headIn);
                            Controllers.P2G.SaveChests(args[3], chestIn);
                            Controllers.P2G.SaveArms(args[3], armsIn);
                            Controllers.P2G.SaveWaists(args[3], waistIn);
                            Controllers.P2G.SaveLegs(args[3], legIn);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }
                else if (args[0].Equals("EUFU"))
                {
                    Controllers.P2G.meleeOffset = Helpers.P2GHelpers.meleeOffsetEU;
                    Controllers.P2G.gunnerOffset = Helpers.P2GHelpers.gunnerOffsetEU;
                    Controllers.P2G.headOffset = Helpers.P2GHelpers.headOffsetEU;
                    Controllers.P2G.chestOffset = Helpers.P2GHelpers.chestOffsetEU;
                    Controllers.P2G.armOffset = Helpers.P2GHelpers.armOffsetEU;
                    Controllers.P2G.waistOffset = Helpers.P2GHelpers.waistOffsetEU;
                    Controllers.P2G.legOffset = Helpers.P2GHelpers.legOffsetEU;
                    if (args[1].Equals("-d"))
                    {
                        var outMelee = Controllers.P2G.GetMelee(args[2]);
                        var outGunner = Controllers.P2G.GetGunner(args[2]);
                        var outHelms = Controllers.P2G.GetHelms(args[2]);
                        var outChests = Controllers.P2G.GetChests(args[2]);
                        var outArms = Controllers.P2G.GetArms(args[2]);
                        var outWaists = Controllers.P2G.GetWaists(args[2]);
                        var outLegs = Controllers.P2G.GetLegs(args[2]);

                        try
                        {
                            Directory.CreateDirectory(args[3]);
                            File.WriteAllText($"{args[3]}\\Melee.json", outMelee);
                            File.WriteAllText($"{args[3]}\\Gunner.json", outGunner);
                            File.WriteAllText($"{args[3]}\\Helmets.json", outHelms);
                            File.WriteAllText($"{args[3]}\\Chestplates.json", outChests);
                            File.WriteAllText($"{args[3]}\\Armguards.json", outArms);
                            File.WriteAllText($"{args[3]}\\Waistpieces.json", outWaists);
                            File.WriteAllText($"{args[3]}\\Leggings.json", outLegs);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }
                    else if (args[1].Equals("-i"))
                    {
                        try
                        {
                            string meleeIn = File.ReadAllText($"{args[2]}\\Melee.json");
                            string gunnerIn = File.ReadAllText($"{args[2]}\\Gunner.json");
                            string headIn = File.ReadAllText($"{args[2]}\\Helmets.json");
                            string chestIn = File.ReadAllText($"{args[2]}\\Chestplates.json");
                            string armsIn = File.ReadAllText($"{args[2]}\\Armguards.json");
                            string waistIn = File.ReadAllText($"{args[2]}\\Waistpieces.json");
                            string legIn = File.ReadAllText($"{args[2]}\\Leggings.json");
                            Controllers.P2G.SaveMelee(args[3], meleeIn);
                            Controllers.P2G.SaveGunner(args[3], gunnerIn);
                            Controllers.P2G.SaveHeads(args[3], headIn);
                            Controllers.P2G.SaveChests(args[3], chestIn);
                            Controllers.P2G.SaveArms(args[3], armsIn);
                            Controllers.P2G.SaveWaists(args[3], waistIn);
                            Controllers.P2G.SaveLegs(args[3], legIn);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.ToString());
                        }
                    }
                }
            }
        }
    }
}
