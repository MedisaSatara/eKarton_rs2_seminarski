using AutoMapper;
using eKarton.Databases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eKarton.Service
{
    public class Recommender:IRecommender
    {
        private readonly ekartonRContext Context;
        private readonly IMapper _mapper;

        private int PreporucenBroj = 2;

        public Recommender(ekartonRContext context, IMapper mapper)
        {
            Context = context;
            _mapper = mapper;
        }

        Dictionary<int, List<Databases.OcjenaDoktora>> ocjeneDoktora = new Dictionary<int, List<Databases.OcjenaDoktora>>();

        public List<Model.Models.Doktor> GetSlicneDoktore(int doktorId)
        {
            var ocjene = Context.OcjenaDoktoras.AsQueryable().ToList();
            var tmp = LoadSimilar(doktorId);

            var konacna = _mapper.Map<List<Model.Models.Doktor>>(tmp);

            //prepravka
            var ocjeneDoktoraList = Context.OcjenaDoktoras.AsQueryable().ToList();


            
            //dodavanje prosjecjenocj
            foreach (var item in konacna)
            {
                decimal suma = 0; int brojac = 0;
                foreach (var ocj in ocjene)
                {
                    if (item.DoktorId == ocj.DoktorId)
                    {
                        brojac++;
                        suma += ocj.Ocjena;
                    }
                }
                if (brojac > 0)
                {
                    suma /= brojac;
                    item.prosjecnaOcjena = Math.Round(suma, 2);
                }
                else
                {
                    item.prosjecnaOcjena = 0;
                }
            }
            if (konacna.Count() == 0 || konacna == null)
            {
                var lista = Context.Doktors.OrderBy(x => Guid.NewGuid()).Take(3);
                konacna = _mapper.Map<List<Model.Models.Doktor>>(lista);
                
                //dodavanje prosjecne ocjene
                foreach (var item in konacna)
                {
                    decimal suma = 0; int brojac = 0;
                    foreach (var ocj in ocjene)
                    {
                        if (item.DoktorId == ocj.DoktorId)
                        {
                            brojac++;
                            suma += ocj.Ocjena;
                        }
                    }
                    if (brojac > 0)
                    {
                        suma /= brojac;
                        item.prosjecnaOcjena = Math.Round(suma, 2);
                    }
                    else
                    {
                        item.prosjecnaOcjena = 0;
                    }
                }
            }
            return konacna;
        }

        private List<Databases.Doktor> LoadSimilar(int doktorId)
        {
            LoadDifVehicles(doktorId);
            List<Databases.OcjenaDoktora> ratingsOfThis = Context.OcjenaDoktoras.Where(e => e.DoktorId == doktorId).ToList();

            List<Databases.OcjenaDoktora> ratings1 = new List<Databases.OcjenaDoktora>();
            List<Databases.OcjenaDoktora> ratings2 = new List<Databases.OcjenaDoktora>();
            List<Databases.Doktor> recommendedVehicles = new List<Databases.Doktor>();


            foreach (var item in ocjeneDoktora)
            {
                
                double similarity = GetSimilarity(ratings1, ratings2);
                if (similarity > 0.5)
                {
                    recommendedVehicles.Add(Context.Doktors.Where(x => x.DoktorId == item.Key)
                        //.Include(x => x.VrstaArtikla)
                        //.Include(x => x.VehicleModel.Manufacturer)
                        .FirstOrDefault());
                }
                ratings1.Clear();
                ratings2.Clear();
            }
            return recommendedVehicles;
        }

        private double GetSimilarity(List<Databases.OcjenaDoktora> ratings1, List<Databases.OcjenaDoktora> ratings2)
        {
            if (ratings1.Count != ratings2.Count)
            {
                return 0;
            }

            double x = 0, y1 = 0, y2 = 0;
            for (int i = 0; i < ratings1.Count; i++)
            {
                x += ratings1[i].Ocjena * ratings2[i].Ocjena;
                y1 += ratings1[i].Ocjena * ratings1[i].Ocjena;
                y2 += ratings2[i].Ocjena * ratings2[i].Ocjena;
            }
            y1 = Math.Sqrt(y1);
            y2 = Math.Sqrt(y2);

            double y = y1 * y2;
            if (y == 0)
                return 0;
            return x / y;
        }

        private void LoadDifVehicles(int vehicleId)
        {
            var artikalVelicina = Context.Doktors.Find(vehicleId);
            List<Databases.Doktor> allVehicles = Context.Doktors.Where(e => e.DoktorId != vehicleId).ToList();
            List<Databases.OcjenaDoktora> ratings = new List<Databases.OcjenaDoktora>();
            foreach (var item in allVehicles)
            {
                ratings = Context.OcjenaDoktoras.Where(e => e.DoktorId == item.DoktorId).ToList();
                if (ratings.Count > 0)
                    ocjeneDoktora.Add(item.DoktorId, ratings);
            }
        }
    }
}
