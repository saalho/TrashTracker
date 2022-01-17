using TrashTracker.Models;
using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace TrashTracker.ViewModels
{
    public class TrashTypeVM
    {
        public ObservableCollection<TrashType> TrashTypes { get; set; }
        public TrashTypeVM()
        {
            TrashTypes = new ObservableCollection<TrashType>()
            {
                new TrashType{Id = Guid.NewGuid().ToString(), Name = "Sekajäte", Description = "Polttokelpoinen yleisjäte, pienet tekstiilit kuten rikkinäiset vaatteet, multa, kierrätettäväksi sopimattomat lasit, muovit, kartongit"},
                new TrashType{Id = Guid.NewGuid().ToString(), Name = "Metalli", Description = "Puhtaat metallit kuten tölkit, alumiinifolio, metalliastiat. Ei: sähkölaitteet, paristot"},
                new TrashType{Id = Guid.NewGuid().ToString(), Name = "Lasi", Description = "Lasipullot, lasipurkit. Ei: juomalasit, kristalli, hehkulamput, ikkuna- tai peililasit."},
                new TrashType{Id = Guid.NewGuid().ToString(), Name = "Muovi", Description = "Puhtaat pakkausmuovit kuten styrox, shampoopullot, elintarvikepakkaukset. Ei: PVC, kovat muovit"},
                new TrashType{Id = Guid.NewGuid().ToString(), Name = "Paperi", Description = "Puhtaat ja kuivat paperit kuten sanomalehdet, kirjeet, pehmeäkantiset kirjat. Ei: paperikassit, lahjapaperit"},
                new TrashType{Id = Guid.NewGuid().ToString(), Name = "Kartonki", Description = "Puhtaat pahvit ja kartongit kuten maitotölkit, pizzalaatikot, paperikassit"}
            };

        }

    }
}