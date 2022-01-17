using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrashTracker.Models;

namespace TrashTracker.ViewModels
{
    public class HistoryVM
    {
        public string Title { get; set; }
        public List<Trash> AllTrash { get; set; }
        public string Mixed { get; set; }
        public string Metal { get; set; }
        public string Glass { get; set; }
        public string Plastic { get; set; }
        public string Paper { get; set; }
        public string Cardboard { get; set; }
        
        public HistoryVM()
        {
            Title = "Roskahistoria";
            AllTrash = App.Database.GetAllTrashAsync().Result;
            Mixed = TotalTypeWeight("Sekajäte", AllTrash);
            Metal = TotalTypeWeight("Metalli", AllTrash);
            Glass = TotalTypeWeight("Lasi", AllTrash);
            Plastic = TotalTypeWeight("Muovi", AllTrash);
            Paper = TotalTypeWeight("Paperi", AllTrash);
            Cardboard = TotalTypeWeight("Kartonki", AllTrash);
        }

        //Total weight for a waste type in kilograms
        private string TotalTypeWeight(string type, List<Trash> allTrash)
        {
            float weight = 0;
            for (int i = 0; i < allTrash.Count; i++)
            {
                if (allTrash[i].Type == type)
                    weight += allTrash[i].Weight;
            }
            string result = type + ": " + weight/1000 + " kg";
            return result;
        }

    }
}
