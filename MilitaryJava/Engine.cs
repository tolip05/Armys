using MilitaryJava.Implementation;
using MilitaryJava.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryJava
{
   public class Engine
    {
        Dictionary<int ,ISoldier> army =
            new Dictionary<int, ISoldier>();
        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] tokens = input.Split();
                int id = int.Parse(tokens[1]);
                string firstName = tokens[2];
                string lastName = tokens[3];

                switch (tokens[0])
                {
                    case "Private":
                        if (!army.ContainsKey(id))
                        {
                            army.Add(id, new PrivateImpl(id,firstName,lastName,decimal.Parse(tokens[4])));
                        }
                        break;
                    case "LieutenantGeneral":
                        List<IPrivate> privates = new List<IPrivate>();
                        for (int i = 5; i < tokens.Length; i++)
                        {
                            int idSoldier = int.Parse(tokens[i]);
                            var isoldier = army[idSoldier];
                            privates.Add((IPrivate)isoldier);
                        }

                        if (!army.ContainsKey(id))
                        {
                            army.Add(id, new LieutenantGeneralImpl(id, firstName, lastName, decimal.Parse(tokens[4]), privates));
                        }
                        break;
                    case "Engineer":
                        ISpecialistSoldier engineer =
                            new EngineerImpl(id,firstName,lastName,decimal.Parse(tokens[4]),tokens[5],ParseRepair(tokens));
                        if (engineer.GetCorps() != null)
                        {
                            if (!army.ContainsKey(id))
                            {
                                army.Add(id,engineer);
                            }
                        }
                        break;
                    case "Commando":
                        ISpecialistSoldier soldier =
                            new ComandoImpl(id,firstName,lastName,decimal.Parse(tokens[4]),tokens[5],ParseMission(tokens));
                        if (!army.ContainsKey(id))
                        {
                            army.Add(id,soldier);
                        }
                        break;
                    case "Spy":
                        if (!army.ContainsKey(id))
                        {
                            army.Add(id, new SpyImpl(id, firstName, lastName, int.Parse(tokens[4])));
                        }
                        break;
                    default:
                        break;
                }


                input = Console.ReadLine();
            }
            string debug = "";
            foreach (var item in army)
            {
                Console.WriteLine(item.Value.ToString());
            }
        }

        private ICollection<IMission> ParseMission(string[] tokens)
        {
            ICollection<IMission> missions = new List<IMission>();
            for (int i = 6; i < tokens.Length; i += 2)
            {
                IMission mision = 
                    new MissionImpl(tokens[i],tokens[i + 1]);
                if (mision.GetState() != null)
                {
                    missions.Add(mision);
                }
            }
            return missions;
        }

        private ICollection<IRepair> ParseRepair(string[] tokens)
        {
            ICollection<IRepair> repairs = new List<IRepair>();
            for (int i = 6; i < tokens.Length; i+=2)
            {
                repairs.Add(new RepairImpl(tokens[i],int.Parse(tokens[i + 1])));
            }
            return repairs;
        }
    }
}
