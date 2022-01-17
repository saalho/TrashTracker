using System;
using System.Collections.Generic;
using System.Text;
using TrashTracker.Models;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace TrashTracker.ViewModels
{
    public class LogVM : TrashTypeVM
    {
        public string Title { get; set; }
        public string UnitValue { get; set; }
        public LogVM()
        {
            Title = "Jätteen kirjaus";
            UnitValue = "1";
        }
        public string InsertTrash(float weight, string type)
        {
            string message;
            var trash = new Trash { Id = Guid.NewGuid().ToString(), Weight = weight, Type = type, DateTime = DateTime.Now };
            try
            {
                App.Database.AddTrashAsync(trash);
                message = "Kirjaus lisätty onnistuneesti";
            }
            catch
            {
                message = "Kirjauksen lisääminen ei onnistunut";
            }
            return message;
        }
    }
}
