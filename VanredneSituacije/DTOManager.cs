using FluentNHibernate.Conventions;
using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VanredneSituacije.DTO;
using VanredneSituacije.Entitet;

namespace VanredneSituacije
{
    public static class DTOManager
    {
        #region Zaposleni

        public static async Task<IList<DTOZaposleni>> ZaposleniVratii()
        {
            var zaposleni = new List<DTOZaposleni>();
            try
            {

                ISession sesija = DataLayer.GetSession();
                if (sesija == null)
                {
                    throw new SessionException("Greska pri kreiranju sesije");
                }
                var koords = await sesija.Query<Koordinator>().ToListAsync();
                var operatives = await sesija.Query<OperativniRadnik>().ToListAsync();
                var analysts = await sesija.Query<Analiticar>().ToListAsync();

                foreach (var koo in koords)
                {
                    zaposleni.Add(new DTOKoordinator(koo));
                }
                foreach (var opr in operatives)
                {
                    zaposleni.Add(new DTOOperativniRadnik(opr));
                }
                foreach (var an in analysts)
                {
                    zaposleni.Add(new DTOAnaliticar(an));
                }

                sesija.Close();

            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return zaposleni;
        }


        #endregion
        #region Analiticar


        public static async Task<DTOAnaliticar> AnaliticarVratii(string maticniBroj)
        {
            DTOAnaliticar a = new DTOAnaliticar();
            try
            {
                ISession sesija = DataLayer.GetSession();
                if (sesija == null)
                {
                    throw new SessionException("Greska u kreiranju sesije");
                }
                Analiticar analiticar = await sesija.LoadAsync<Analiticar>(maticniBroj);
                if (a == null)
                {
                    throw new KeyNotFoundException("Nema analiticara sa ovim id-em");
                }
                a.Ime = analiticar.Ime;
                a.Prezime = analiticar.Prezime;
                a.JMBG = analiticar.JMBG;

                a.BrojTelefona = analiticar.BrojTelefona;
                a.AdresaStan = analiticar.AdresaStan;
                a.Pol = analiticar.Pol;

                a.Email = analiticar.Email;
                a.DatumRodj = analiticar.DatumRodj;
                a.DatumZap = a.DatumZap;

                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return a;


        }

        public static async Task AnaliticarIzmenii(DTOAnaliticar analiticar, string maticniBroj)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                if (sesija == null)
                {
                    throw new SessionException("Greska u kreiranju sesije");
                }
                Analiticar a = await sesija.LoadAsync<Analiticar>(maticniBroj);
                a.Ime = analiticar.Ime;
                a.Prezime = analiticar.Prezime;
                a.JMBG = maticniBroj;
                a.Email = analiticar.Email;
                a.AdresaStan = analiticar.AdresaStan;
                a.Pol = analiticar.Pol;
                a.BrojTelefona = analiticar.BrojTelefona;
                a.DatumRodj = analiticar.DatumRodj;
                a.DatumZap = analiticar.DatumZap;


                await sesija.UpdateAsync(a);
                await sesija.FlushAsync();
                sesija.Close();


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
        }


        public static async Task AnaliticarObrisii(string maticniBroj)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                if (sesija == null)
                {
                    throw new SessionException("Greska u kreiranju sesije");
                }
                Analiticar analiticar = await sesija.LoadAsync<Analiticar>(maticniBroj);
                if (analiticar == null)
                {
                    throw new KeyNotFoundException("Nema analiticara sa tim maticnim brojem");
                }
                await sesija.DeleteAsync(analiticar);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }

        public static async Task<IList<DTOAnaliticar>> AnaliticariVratii()
        {
            List<DTOAnaliticar> analiticari = new List<DTOAnaliticar>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                if (sesija == null)
                {
                    throw new SessionException("Greska u kreiranju sesije");
                }
                analiticari = await sesija.Query<Analiticar>()
                                .Select(a => new DTOAnaliticar(a))
                                .ToListAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return analiticari;
        }

        public static async Task AnaliticarDodajj(DTOAnaliticar analiticar)
        {

            try
            {
                ISession sesija = DataLayer.GetSession();
                if (sesija == null)
                {
                    throw new SessionException("Greska u kreiranju sesije");
                }
                Analiticar a = new Analiticar();
                a.Ime = analiticar.Ime;
                a.Prezime = analiticar.Prezime;
                a.JMBG = analiticar.JMBG;
                a.Email = analiticar.Email;
                a.AdresaStan = analiticar.AdresaStan;
                a.DatumZap = analiticar.DatumZap;
                a.DatumRodj = analiticar.DatumRodj;
                a.Pol = analiticar.Pol;
                a.BrojTelefona = analiticar.BrojTelefona;
                IstorijaUloga istorija = new IstorijaUloga
                {
                    Zaposleni = a,
                    Uloga = a.GetType().Name,
                    DatumPoc = DateTime.Now,
                    DatumKraj = null


                };

                await sesija.SaveAsync(a);

                await sesija.SaveAsync(istorija);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception();
            }
        }
        #endregion
        #region Koordinator
        public static async Task KoordinatorIzmenii(DTOKoordinator koordinator, string maticniBroj)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Koordinator k = await sesija.LoadAsync<Koordinator>(maticniBroj);
                k.JMBG = maticniBroj;
                k.Ime = koordinator.Ime;
                k.Prezime = koordinator.Prezime;
                k.DatumRodj = koordinator.DatumRodj;
                k.Pol = koordinator.Pol;
                k.BrojTelefona = koordinator.BrojTelefona;
                k.Email = koordinator.Email;
                k.DatumZap = koordinator.DatumZap;
                k.BrTimova = koordinator.BrTimova;


                DTOIstorijaDodajj istorija = new DTOIstorijaDodajj
                {
                    DatumPoc = DateTime.Now,
                    DatumKraj = null,
                    JMBGZap = k.JMBG,
                    Uloga = k.GetType().ToString()

                };

                await DTOManager.IstorijaDodajj(istorija);

                await sesija.UpdateAsync(k);
                await sesija.FlushAsync();
                sesija.Close();


            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task KoordinatorObrisii(string maticniBroj)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                if (sesija == null)
                {
                    throw new SessionException("Greska u kreiranju sesije");
                }
                Koordinator koordinator = await sesija.LoadAsync<Koordinator>(maticniBroj);

                await sesija.DeleteAsync(koordinator);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task KoordinatorDodajj(DTOKoordinator kordinator)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Koordinator k = new Koordinator();
                k.Ime = kordinator.Ime;
                k.Prezime = kordinator.Prezime;
                k.JMBG = kordinator.JMBG;

                k.AdresaStan = kordinator.AdresaStan;
                k.BrTimova = kordinator.BrTimova;
                k.Pol = kordinator.Pol;
                k.BrojTelefona = kordinator.BrojTelefona;
                k.Email = kordinator.Email;
                k.DatumRodj = kordinator.DatumRodj;
                k.DatumZap = kordinator.DatumZap;
                IstorijaUloga istorija = new IstorijaUloga();
                istorija.Zaposleni = k;
                istorija.Uloga = k.GetType().Name;
                istorija.DatumPoc = DateTime.Now;
                istorija.DatumKraj = null;
                await sesija.SaveAsync(k);
                await sesija.SaveAsync(istorija);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task<IList<DTOKoordinator>> KoordinatorVratii()
        {
            List<DTOKoordinator> koordinatori = new List<DTOKoordinator>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                if (sesija == null)
                {
                    throw new SessionException("Greska u kreiranju sesije");
                }
                koordinatori = await sesija.Query<Koordinator>()
                                .Select(s => new DTOKoordinator(s))
                                .ToListAsync();


                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return koordinatori;
        }

        public static async Task<DTOKoordinator> KoordinatorVratiPoJMBG(string maticniBroj)
        {
            DTOKoordinator k = new DTOKoordinator();
            try
            {
                ISession sesija = DataLayer.GetSession();
                if (sesija == null)
                {
                    throw new SessionException("Greska u kreiranju sesije");
                }
                DTOKoordinator koordinator = await sesija.LoadAsync<DTOKoordinator>(maticniBroj);
                if (koordinator == null)
                {
                    throw new KeyNotFoundException("Nema koordinatora sa ovim id-em");
                }
                k.JMBG = koordinator.JMBG;
                k.Ime = koordinator.Ime;
                k.Prezime = koordinator.Prezime;
                k.DatumRodj = koordinator.DatumRodj;
                k.Pol = koordinator.Pol;
                k.BrojTelefona = koordinator.BrojTelefona;
                k.Email = koordinator.Email;
                k.AdresaStan = koordinator.AdresaStan;
                k.DatumZap = koordinator.DatumZap;
                k.BrTimova = koordinator.BrTimova;

                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return k;
        }
        #endregion
        #region IstorijaUloga
        public static async Task IstorijaObrisii(int istorijaId)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                IstorijaUloga istorija = await sesija.LoadAsync<IstorijaUloga>(istorijaId);

                await sesija.DeleteAsync(istorija);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task IstorijaDodajj(DTOIstorijaDodajj istorija)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                IstorijaUloga iu = new IstorijaUloga();
                iu.Uloga = istorija.Uloga;
                iu.Zaposleni = await sesija.LoadAsync<Zaposleni>(istorija.JMBGZap);
                if (istorija.DatumKraj <= istorija.DatumPoc)
                {
                    throw new Exception("Datum je neodgovarajuci");
                }
                iu.DatumPoc = istorija.DatumPoc;
                iu.DatumKraj = istorija.DatumKraj;

                await sesija.SaveAsync(iu);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception();
            }
        }
        public static async Task IstorijaIzmenii(DTOIstorijaDodajj istorija, int istorijaId)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                IstorijaUloga iu = await sesija.LoadAsync<IstorijaUloga>(istorijaId);

                iu.Zaposleni = await sesija.LoadAsync<Zaposleni>(istorija.JMBGZap);
                iu.DatumPoc = istorija.DatumPoc;
                iu.DatumKraj = istorija.DatumKraj;
                iu.Uloga = istorija.Uloga;
                await sesija.UpdateAsync(iu);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task<IList<DTOIstorijaUloga>> IstorijaVratii()
        {
            List<DTOIstorijaUloga> iu = new List<DTOIstorijaUloga>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                iu = await sesija.Query<IstorijaUloga>()
                                .Select(i => new DTOIstorijaUloga
                                {
                                    Id = i.Id,
                                    Uloga = i.Uloga,
                                    JMBGZap = i.Zaposleni.JMBG,
                                    DatumPoc = i.DatumPoc,
                                    DatumKraj = i.DatumKraj
                                })
                                .ToListAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {

            }
            return iu;
        }
        public static async Task IstorijaObrisiPoJMBG(string maticniBroj)
        {
            List<IstorijaUloga> iu = new List<IstorijaUloga>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                iu = await sesija.Query<IstorijaUloga>()
                            .Fetch(i => i.Zaposleni)
                            .Where(i => i.Zaposleni.JMBG == maticniBroj)
                            .ToListAsync();

                foreach (IstorijaUloga istorija in iu)
                {
                    await sesija.DeleteAsync(istorija);
                }
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static IList<DTOIstorijaDodajj> IstorijaVratiiu()
        {
            List<DTOIstorijaDodajj> iu = new List<DTOIstorijaDodajj>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                iu = sesija.Query<IstorijaUloga>()
                                .Select(x => new DTOIstorijaDodajj
                                {

                                    Uloga = x.Uloga,
                                    JMBGZap = x.Zaposleni.JMBG,
                                    DatumPoc = x.DatumPoc,
                                    DatumKraj = x.DatumKraj
                                })
                                .ToList();
                sesija.Close();
            }
            catch (Exception ex)
            {
            }
            return iu;
        }
        public static async Task<DTOIstorijaUloga> IstorijaVratiiU(int istorijaId)
        {
            DTOIstorijaUloga iu = null;
            try
            {
                ISession sesija = DataLayer.GetSession();
                IstorijaUloga istorija = await sesija.LoadAsync<IstorijaUloga>(istorijaId);
                iu = new DTOIstorijaUloga(istorija);
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return iu;
        }

        public static async Task<IList<DTOIstorijaUloga>> IstorijaVratiPoJMBG(string maticniBroj)
        {
            List<DTOIstorijaUloga> iu = new List<DTOIstorijaUloga>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                iu = await sesija.Query<IstorijaUloga>()
                                 .Fetch(i => i.Zaposleni)
                                 .Where(i => i.Zaposleni.JMBG == maticniBroj)
                                .Select(i => new DTOIstorijaUloga(i))
                                .ToListAsync();

                sesija.Close();
            }

            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return iu;
        }
        #endregion
        #region Intervenise
        public static async Task<IList<DTOVratiIntervenise>> UcestvovanjaVratii()
        {
            List<DTOVratiIntervenise> i = new List<DTOVratiIntervenise>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                i = await sesija.Query<Intervenise>()
                          .Select(i => new DTOVratiIntervenise(i))
                          .ToListAsync();

                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }

            return i;
        }
        public static async Task InterveniseObrisii(int interveniseId)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Intervenise intervenise = await sesija.LoadAsync<Intervenise>(interveniseId);
                await sesija.DeleteAsync(intervenise);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task InterveniseIzmenii(DTODodajIntervenise intervenise, int interveniseId)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Intervenise i = await sesija.LoadAsync<Intervenise>(interveniseId);

                i.IdInterventnee = await sesija.LoadAsync<InterventnaJedinica>(intervenise.IdInterventnee);
                i.IdVanrednee = await sesija.LoadAsync<VanrednaSituacija>(intervenise.IdVanredneSituacije);
                i.IdIntervencijee = await sesija.LoadAsync<Intervencija>(intervenise.IdIntervencijee);

                await sesija.UpdateAsync(i);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task InterveniseDodajj(DTODodajIntervenise intervenise)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Intervenise i = new Intervenise();
                i.IdInterventnee = await sesija.LoadAsync<InterventnaJedinica>(intervenise.IdInterventnee);
                i.IdVanrednee = await sesija.LoadAsync<VanrednaSituacija>(intervenise.IdVanredneSituacije);
                i.IdIntervencijee = await sesija.LoadAsync<Intervencija>(intervenise.IdIntervencijee);

                await sesija.SaveAsync(i);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task<DTOVratiIntervenise> InterveniseVratii(int interveniseId)
        {
            DTOVratiIntervenise i = new DTOVratiIntervenise();
            try
            {
                ISession sesija = DataLayer.GetSession();
                if (sesija == null)
                {
                    throw new SessionException("Greska u kreiranju sesije");
                }
                Intervenise intervenise = await sesija.LoadAsync<Intervenise>(interveniseId);

                i = new DTOVratiIntervenise(intervenise);
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return i;
        }

        public static async Task<IList<DTOVratiIntervenise>> VanrednaUcestvovanjaVratii(int situacijaId)
        {
            List<DTOVratiIntervenise> i = new List<DTOVratiIntervenise>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                if (sesija == null)
                {
                    throw new SessionException("Greska u kreiranju sesije");
                }
                var intervenise = await sesija.Query<Intervenise>()
                                 .Fetch(i => i.IdInterventnee)
                                 .Where(i => i.IdVanrednee.Id == situacijaId)
                                 .ToListAsync();
                foreach (var interv in intervenise)
                {
                    i.Add(new DTOVratiIntervenise(interv));
                }
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return i;

        }

        public static async Task<IList<DTOVratiIntervenise>> IntervencijaUcestvovanjaVratii(int id)
        {
            List<DTOVratiIntervenise> i = new List<DTOVratiIntervenise>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                if (sesija == null)
                {
                    throw new SessionException("Greska u kreiranju sesije");
                }
                var intervenise = await sesija.Query<Intervenise>()
                                 .Fetch(i => i.IdInterventnee)
                                 .Where(i => i.IdIntervencijee.Id == id)
                                 .ToListAsync();
                foreach (var interv in intervenise)
                {
                    i.Add(new DTOVratiIntervenise(interv));
                }
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return i;

        }

        public static async Task<IList<DTOVratiIntervenise>> UcestvovanjaVratiiJedinice(int jedinicaId)
        {
            List<DTOVratiIntervenise> i = new List<DTOVratiIntervenise>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                if (sesija == null)
                {
                    throw new SessionException("Greska u kreiranju sesije");
                }
                var intervenise = await sesija.Query<Intervenise>()
                                 .Fetch(i => i.IdInterventnee)
                                 .Where(i => i.IdInterventnee.Jedinstveni_Broj == jedinicaId)
                                 .ToListAsync();
                foreach (var interv in intervenise)
                {
                    i.Add(new DTOVratiIntervenise(interv));
                }
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return i;

        }
        #endregion
        #region Softveri
        public static async Task<IList<DTOSoftveri>> SoftveriVratii()
        {
            List<DTOSoftveri> s = new List<DTOSoftveri>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                s = await sesija.Query<Softveri>()
                          .Fetch(a => a.Analiticar)
                          .Select(a => new DTOSoftveri(a))
                          .ToListAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return s;
        }
        public static async Task SoftveriDodajj(DTOSoftveriDodajj softver)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Softveri s = new Softveri();
                s.Analiticar = await sesija.LoadAsync<Analiticar>(softver.JMBGAnaliticaraa);

                s.Naziv = softver.Naziv;
                await sesija.SaveAsync(s);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task SoftveriObrisii(int id)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Softveri softver = await sesija.LoadAsync<Softveri>(id);

                await sesija.DeleteAsync(softver);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }

        public static async Task SoftverIzmenii(DTOSoftveriDodajj softver, int softverId)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Softveri s = await sesija.LoadAsync<Softveri>(softverId);
                s.Analiticar = await sesija.LoadAsync<Analiticar>(softver.JMBGAnaliticaraa);
                s.Naziv = softver.Naziv;
                await sesija.UpdateAsync(s);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }

        public static async Task<DTOSoftveri> SoftverVratiPoID(int softverId)
        {
            DTOSoftveri s = new DTOSoftveri();
            try
            {
                ISession sesija = DataLayer.GetSession();
                Softveri softver = await sesija.LoadAsync<Softveri>(softverId);
                s.Id = softver.Id;
                s.JMBGAnaliticara = softver.Analiticar.JMBG;
                s.Naziv = softver.Naziv;
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return s;
        }

        public static async Task<IList<DTOSoftveri>> SoftverVratiPoJMBG(string maticniBroj)
        {
            List<DTOSoftveri> s = new List<DTOSoftveri>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                if (sesija == null)
                {
                    throw new SessionException("Greska u kreiranju sesije");
                }
                s = await sesija.Query<Softveri>()
                            .Fetch(a => a.Analiticar)
                            .Where(a => a.Analiticar.JMBG == maticniBroj)
                            .Select(a => new DTOSoftveri(a))
                            .ToListAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return s;
        }
        #endregion
        #region Ekspertize
        public static async Task<DTOEkspertize> EkspertizaVratii(int idEkspertize)
        {
            DTOEkspertize e = new DTOEkspertize();
            try
            {
                ISession sesija = DataLayer.GetSession();
                Ekspertize ekspertiza = await sesija.LoadAsync<Ekspertize>(idEkspertize);
                e = new DTOEkspertize(ekspertiza);
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return e;
        }
        public static async Task EkspertizaDodajj(DTOEkspertizaIzmenii ekspertiza)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Ekspertize e = new Ekspertize();
                e.Analiticar = await sesija.LoadAsync<Analiticar>(ekspertiza.JMBGAnaliticara);

                e.Oblast = ekspertiza.Oblast;
                await sesija.SaveAsync(e);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task EkspertizaObrisii(int ekspertizaId)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Ekspertize ekspertiza = await sesija.LoadAsync<Ekspertize>(ekspertizaId);

                await sesija.DeleteAsync(ekspertiza);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task EkspertizaIzmenii(DTOEkspertizaIzmenii ekspertiza, int idEkspertize)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Ekspertize e = await sesija.LoadAsync<Ekspertize>(idEkspertize);

                e.Analiticar = await sesija.LoadAsync<Analiticar>(ekspertiza.JMBGAnaliticara);

                e.Oblast = ekspertiza.Oblast;
                await sesija.UpdateAsync(e);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }

        public static async Task<IList<DTOEkspertize>> EkspertizeVratii()
        {
            List<DTOEkspertize> ekspertize = new List<DTOEkspertize>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                ekspertize = await sesija.Query<Ekspertize>()
                               .Fetch(a => a.Analiticar)
                               .Select(a => new DTOEkspertize(a))
                               .ToListAsync();

                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return ekspertize;
        }

        public static async Task<IList<DTOEkspertize>> EkspertizeVratiPoJMBG(string maticniBroj)
        {
            List<DTOEkspertize> ekspertize = new List<DTOEkspertize>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                ekspertize = await sesija.Query<Ekspertize>()
                               .Fetch(a => a.Analiticar)
                               .Where(a => a.Analiticar.JMBG == maticniBroj)
                               .Select(a => new DTOEkspertize(a))
                               .ToListAsync();

                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return ekspertize;
        }
        #endregion
        #region Saradnja
        public static async Task SaradnjaIzmenii(DTOSaradnjaDodajj saradnja, int saradnjaId)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Saradnja s = await sesija.LoadAsync<Saradnja>(saradnjaId);

                s.Uloga = saradnja.Uloga;
                s.Sektor = await sesija.LoadAsync<Sluzba>(saradnja.SektorID);
                s.Vanredna_Sit = await sesija.LoadAsync<VanrednaSituacija>(saradnja.IDVanSituacije);

                await sesija.UpdateAsync(s);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task SaradnjaDodajj(DTOSaradnjaDodajj saradnja)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Saradnja s = new Saradnja();
                s.Uloga = saradnja.Uloga;
                s.Sektor = await sesija.LoadAsync<Sluzba>(saradnja.SektorID);
                s.Vanredna_Sit = await sesija.LoadAsync<VanrednaSituacija>(saradnja.IDVanSituacije);
                await sesija.SaveAsync(s);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }

        public static async Task SaradnjaObrisii(int saradnjaId)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Saradnja saradnja = await sesija.LoadAsync<Saradnja>(saradnjaId);

                await sesija.DeleteAsync(saradnja);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task<IList<DTOVanrednaSituacija>> VanredneSaradnjaSaSluzbomVratii(int id)
        {
            List<DTOVanrednaSituacija> v = new List<DTOVanrednaSituacija>();
            try
            {
                ISession sesija = DataLayer.GetSession();

                var s = await sesija.Query<Saradnja>()
                               .Where(v => v.Sektor.SektorrId == id)
                               .Fetch(v => v.Vanredna_Sit)
                               .ToListAsync();

                foreach (var saradnja in s)
                {
                    v.Add(new DTOVanrednaSituacija(saradnja.Vanredna_Sit));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }

            return v;

        }
        public static async Task<IList<DTOSaradnjeVratiPoId>> SaradnjeVratii()
        {
            List<DTOSaradnjeVratiPoId> s = new List<DTOSaradnjeVratiPoId>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                s = await sesija.Query<Saradnja>()
                         .Fetch(v => v.Vanredna_Sit)
                         .Fetch(v => v.Sektor)
                         .Select(v => new DTOSaradnjeVratiPoId(v))
                         .ToListAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return s;
        }

        public static async Task<DTOSaradnja> SaradnjeVratiPoId(int saradnjaId)
        {
            DTOSaradnja s = new DTOSaradnja();
            try
            {
                ISession sesija = DataLayer.GetSession();
                Saradnja saradnja = await sesija.LoadAsync<Saradnja>(saradnjaId);


                s = new DTOSaradnja(saradnja);
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return s;
        }
        public static async Task<IList<DTOSluzba>> SluzbeUVanrednojVratii(int situacijaId)
        {
            List<DTOSluzba> s = new List<DTOSluzba>();
            try
            {
                ISession sesija = DataLayer.GetSession();

                var sa = await sesija.Query<Saradnja>()
                               .Where(v => v.Vanredna_Sit.Id == situacijaId)
                               .Fetch(v => v.Sektor)
                               .ToListAsync();

                foreach (var saradnja in sa)
                {
                    s.Add(new DTOSluzba(saradnja.Sektor));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }

            return s;

        }
        #endregion
        #region Specijalizacije
        public static async Task<DTOSpecijalizacije> VratiSpecijalizaciju(int specijalizaijaId)
        {
            DTOSpecijalizacije s = new DTOSpecijalizacije();
            try
            {
                ISession sesija = DataLayer.GetSession();
                Specijalizacije specijalizacija = await sesija.LoadAsync<Specijalizacije>(specijalizaijaId);
                s = new DTOSpecijalizacije(specijalizacija);
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return s;
        }
        public static async Task ObrisiSpecijalizaciju(int idSpecijalizacije)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Specijalizacije specijalizacija = await sesija.LoadAsync<Specijalizacije>(idSpecijalizacije);
                await sesija.DeleteAsync(specijalizacija);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task DodajSpecijalizaciju(DTODodajSpecijalizaciju specijalizacija)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Specijalizacije s = new Specijalizacije();

                s.Kordinator = await sesija.LoadAsync<Koordinator>(specijalizacija.JMBG_Kordinator);

                s.Tip = specijalizacija.Tip;
                await sesija.SaveAsync(s);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }

        public static async Task IzmeniSpecijalizaciju(DTODodajSpecijalizaciju specijalizacija, int idSpecijalizacije)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Specijalizacije s = await sesija.LoadAsync<Specijalizacije>(idSpecijalizacije);
                s.Kordinator = await sesija.LoadAsync<Koordinator>(specijalizacija.JMBG_Kordinator);

                s.Tip = specijalizacija.Tip;
                await sesija.UpdateAsync(s);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }

        }
        public static async Task<IList<DTOSpecijalizacije>> VratiSpecijalizacije()
        {
            List<DTOSpecijalizacije> specijalizacije = new List<DTOSpecijalizacije>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                specijalizacije = await sesija.Query<Specijalizacije>()
                                    .Fetch(k => k.Kordinator)
                                    .Select(k => new DTOSpecijalizacije(k))
                                    .ToListAsync();

            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }

            return specijalizacije;
        }

        public static async Task<IList<DTOSpecijalizacije>> VratiSpecijalizacijeKoordinatora(string maticniBroj)
        {
            List<DTOSpecijalizacije> specijalizacije = new List<DTOSpecijalizacije>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                specijalizacije = await sesija.Query<Specijalizacije>()
                                    .Where(k => k.Kordinator.JMBG == maticniBroj)
                                    .Fetch(k => k.Kordinator)
                                    .Select(k => new DTOSpecijalizacije(k))
                                    .ToListAsync();

            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return specijalizacije;
        }
        #endregion
        #region OperativniRadnik
        public static async Task<DTOOperativniRadnik> VratiOperativnogRadnika(string maticniBroj)
        {
            DTOOperativniRadnik radnik = null;
            try
            {
                ISession sesija = DataLayer.GetSession();
                OperativniRadnik opRadnik = await sesija.LoadAsync<OperativniRadnik>(maticniBroj);
                radnik = new DTOOperativniRadnik(opRadnik);
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return radnik;
        }
        public static async Task ObrisiOperativnogRadnika(string maticniBroj)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                OperativniRadnik radnik = await sesija.LoadAsync<OperativniRadnik>(maticniBroj);
                if (radnik == null)
                {
                    throw new KeyNotFoundException("Nema operativnog radnika sa ovim id-em");
                }
                InterventnaJedinica interventna = await sesija.LoadAsync<InterventnaJedinica>(radnik.InterventnaJedinica.Jedinstveni_Broj);
                interventna.Radnici.Remove(radnik);
                interventna.BrojClanova--;
                await sesija.UpdateAsync(interventna);
                await sesija.DeleteAsync(radnik);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task DodajOperativnogRadnik(DTODodajOperativnogRadnika opRadnik)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                OperativniRadnik radnik = new OperativniRadnik();
                radnik.Ime = opRadnik.Ime;
                radnik.Prezime = opRadnik.Prezime;
                radnik.JMBG = opRadnik.JMBG;
                radnik.Email = opRadnik.Email;
                radnik.AdresaStan = opRadnik.AdresaStan;
                radnik.DatumZap = opRadnik.DatumZap;
                radnik.DatumRodj = opRadnik.DatumRodj;
                radnik.Pol = opRadnik.Pol;
                radnik.BrojTelefona = opRadnik.BrojTelefona;
                radnik.Broj_Sati = opRadnik.Broj_Sati;
                radnik.Fizicka_Spremnost = opRadnik.Fizicka_Spremnost;
                if (opRadnik.InterventnaJedinica != null || opRadnik.InterventnaJedinica > 0)
                {
                    InterventnaJedinica interventna = await sesija.GetAsync<InterventnaJedinica>(opRadnik.InterventnaJedinica);
                    radnik.InterventnaJedinica = interventna;
                    if (interventna != null)
                    {
                        interventna.BrojClanova++;

                        await sesija.UpdateAsync(interventna);
                    }
                }
                else
                    radnik.InterventnaJedinica = null;
                IstorijaUloga istorija = new IstorijaUloga
                {
                    Zaposleni = radnik,
                    Uloga = radnik.GetType().Name,
                    DatumPoc = DateTime.Now,
                    DatumKraj = null
                };
                await sesija.SaveAsync(radnik);
                await sesija.SaveAsync(istorija);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task IzmeniOperativnog(DTODodajOperativnogRadnika opRadnik, string maticniBroj)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                OperativniRadnik radnik = await sesija.LoadAsync<OperativniRadnik>(maticniBroj);
                radnik.Ime = opRadnik.Ime;
                radnik.Prezime = opRadnik.Prezime;
                radnik.JMBG = maticniBroj;
                radnik.Broj_Sati = opRadnik.Broj_Sati;
                radnik.Fizicka_Spremnost = opRadnik.Fizicka_Spremnost;
                radnik.Pol = opRadnik.Pol;
                radnik.BrojTelefona = opRadnik.BrojTelefona;
                radnik.Email = opRadnik.Email;
                radnik.AdresaStan = opRadnik.AdresaStan;
                radnik.DatumZap = opRadnik.DatumZap;
                radnik.DatumRodj = opRadnik.DatumRodj;

                InterventnaJedinica interventna = radnik.InterventnaJedinica;
                InterventnaJedinica novaInterventna = await sesija.GetAsync<InterventnaJedinica>(opRadnik.InterventnaJedinica);
                if (radnik.InterventnaJedinica.Jedinstveni_Broj != opRadnik.InterventnaJedinica && interventna != null && novaInterventna != null)
                {
                    novaInterventna.BrojClanova++;
                    interventna.BrojClanova--;
                    radnik.InterventnaJedinica = novaInterventna;
                    await sesija.SaveOrUpdateAsync(novaInterventna);
                    await sesija.SaveOrUpdateAsync(interventna);
                }
                else if (interventna == null && novaInterventna != null)
                {
                    novaInterventna.BrojClanova++;
                    radnik.InterventnaJedinica = novaInterventna;
                    await sesija.SaveOrUpdateAsync(novaInterventna);
                }
                else if (interventna != null && novaInterventna == null)
                {
                    interventna.BrojClanova--;
                    radnik.InterventnaJedinica = null;
                    await sesija.SaveOrUpdateAsync(interventna);
                }
                await sesija.UpdateAsync(radnik);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }

        public static async Task<IList<DTOOperativniRadnik>> VratiOperativneRadnike()
        {
            List<DTOOperativniRadnik> opRadnici = new List<DTOOperativniRadnik>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                opRadnici = await sesija.Query<OperativniRadnik>()
                        .Fetch(r => r.InterventnaJedinica)
                        .Select(r => new DTOOperativniRadnik(r))
                        .ToListAsync();

                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return opRadnici;
        }

        public static async Task<IList<DTOOperativniRadnik>> VratiOperativneRadnikeIzJedincie(int id)
        {
            List<DTOOperativniRadnik> opRadnici = new List<DTOOperativniRadnik>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                opRadnici = sesija.Query<OperativniRadnik>()
                      .Fetch(r => r.InterventnaJedinica)
                      .Where(r => r.InterventnaJedinica.Jedinstveni_Broj == id)
                      .ToList()
                      .Select(r => new DTOOperativniRadnik(r))
                      .ToList();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return opRadnici;
        }
        #endregion
        #region Oprema
        public static async Task<IList<DTOPregledLicneZastite>> VratiLicnuOpremuJedinice(int id)
        {
            List<DTOPregledLicneZastite> o = new List<DTOPregledLicneZastite>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                o = await sesija.Query<LicnaZastita>()
                            .Fetch(l => l.Jedinica)
                            .Where(l => l.Jedinica.Jedinstveni_Broj == id)
                            .Select(l => new DTOPregledLicneZastite(l))
                            .ToListAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return o;
        }
        public static async Task<IList<DTOPregledOpreme>> VratiSvuOpremuJedinice(int jedinicaId)
        {
            List<DTOPregledOpreme> o = new List<DTOPregledOpreme>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                var z = await sesija.Query<Zaliha>()
                .Fetch(s => s.Jedinica)
                .Where(s => s.Jedinica.Jedinstveni_Broj == jedinicaId)
                .ToListAsync();
                var t = await sesija.Query<Tehnicka>()
                           .Fetch(j => j.Jedinica)
                           .Where(j => j.Jedinica.Jedinstveni_Broj == jedinicaId)
                           .ToListAsync();
                var l = await sesija.Query<LicnaZastita>()
                           .Fetch(j => j.Jedinica)
                           .Where(j => j.Jedinica.Jedinstveni_Broj == jedinicaId)
                           .ToListAsync();
                var m = await sesija.Query<Medicinska>()
                           .Fetch(j => j.Jedinica)
                           .Where(j => j.Jedinica.Jedinstveni_Broj == jedinicaId)
                           .ToListAsync();
                foreach (var oprema in t)
                {
                    o.Add(new DTOPregledTehnicke(oprema));
                }
                foreach (var oprema in z)
                {
                    o.Add(new DTOPregledZalihe(oprema));
                }
                foreach (var oprema in l)
                {
                    o.Add(new DTOPregledLicneZastite(oprema));
                }
                foreach (var oprema in m)
                {
                    o.Add(new DTOPregledMedicinske(oprema));
                }
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return o;
        }
        public static async Task<IList<DTODodajOpremu>> VratiSvuOpremu()
        {
            List<DTODodajOpremu> o = new List<DTODodajOpremu>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                var t = await sesija.Query<Tehnicka>()
                        .Fetch(j => j.Jedinica)
                        .ToListAsync();
                var z = await sesija.Query<Zaliha>()
                           .Fetch(j => j.Jedinica)
                           .ToListAsync();
                var l = await sesija.Query<LicnaZastita>()
                           .Fetch(j => j.Jedinica)
                           .ToListAsync();
                var m = await sesija.Query<Medicinska>()
                           .Fetch(j => j.Jedinica)
                           .ToListAsync();
                foreach (var oprema in t)
                {
                    o.Add(new DTODodajTehnicku(oprema));
                }
                foreach (var oprema in z)
                {
                    o.Add(new DTODodajZalihe(oprema));
                }
                foreach (var oprema in l)
                {
                    o.Add(new DTODodajLicnuZastitu(oprema));
                }
                foreach (var oprema in m)
                {
                    o.Add(new DTODodajMedicinsku(oprema));
                }
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return o;
        }
        #region LicnaZastita
        public static async Task DodajLicnuZastitu(DTODodajLicnuZastitu licna)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                LicnaZastita zastita = new LicnaZastita();
                zastita.DatumNabavke = licna.DatumNabavke;
                zastita.Serijski_Broj = licna.Serijski_Broj;
                zastita.Naziv = licna.Naziv;
                zastita.Status = licna.Status;
                zastita.Tip = licna.Tip;
                zastita.Jedinica = await sesija.LoadAsync<InterventnaJedinica>(licna.JedinicaID);
                await sesija.SaveAsync(zastita);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task ObrisiLicnuZastitu(string broj)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                LicnaZastita licna = await sesija.LoadAsync<LicnaZastita>(broj);
                await sesija.DeleteAsync(licna);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task IzmeniLicnuZastitu(DTODodajLicnuZastitu licna, string broj)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                LicnaZastita zastita = await sesija.LoadAsync<LicnaZastita>(broj);
                zastita.Naziv = licna.Naziv;
                zastita.Status = licna.Status;
                zastita.Serijski_Broj = broj;
                zastita.DatumNabavke = licna.DatumNabavke;
                zastita.Tip = licna.Tip;
                zastita.Jedinica = await sesija.LoadAsync<InterventnaJedinica>(licna.JedinicaID);
                await sesija.UpdateAsync(zastita);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task<IList<DTODodajLicnuZastitu>> VratiOpremuLicneZastite()
        {
            List<DTODodajLicnuZastitu> o = new List<DTODodajLicnuZastitu>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                o = await sesija.Query<LicnaZastita>()
                           .Fetch(lz => lz.Jedinica)
                           .Select(lz => new DTODodajLicnuZastitu(lz))
                           .ToListAsync();

                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return o;
        }

        public static async Task<DTODodajLicnuZastitu> VratiLicnuZastitu(string broj)
        {
            DTODodajLicnuZastitu zastita = null;
            try
            {
                ISession sesija = DataLayer.GetSession();
                LicnaZastita licna = await sesija.LoadAsync<LicnaZastita>(broj);

                zastita = new DTODodajLicnuZastitu(licna);
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return zastita;
        }
        #endregion
        #region MedicinskaOprema
        public static async Task<IList<DTOPregledMedicinske>> VratiMedicinskuOpremuJedinice(int id)
        {
            List<DTOPregledMedicinske> o = new List<DTOPregledMedicinske>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                o = await sesija.Query<Medicinska>()
                            .Fetch(j => j.Jedinica)
                            .Where(j => j.Jedinica.Jedinstveni_Broj == id)
                            .Select(j => new DTOPregledMedicinske(j))
                            .ToListAsync();

                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return o;
        }
        public static async Task DodajMedicinskuOpremu(DTODodajMedicinsku oprema)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Medicinska medicinska = new Medicinska();
                medicinska.Naziv = oprema.Naziv;
                medicinska.Status = oprema.Status;
                medicinska.Serijski_Broj = oprema.Serijski_Broj;
                medicinska.Tip = oprema.Tip;
                medicinska.DatumNabavke = oprema.DatumNabavke;
                medicinska.Jedinica = await sesija.LoadAsync<InterventnaJedinica>(oprema.JedinicaID);
                await sesija.SaveAsync(medicinska);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task ObrisiMedicinskuOpremu(string broj)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Medicinska medicinska = await sesija.LoadAsync<Medicinska>(broj);
                await sesija.DeleteAsync(medicinska);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task IzmeniMedicinskuOpremu(string broj, DTODodajMedicinsku oprema)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Medicinska medicinska = await sesija.LoadAsync<Medicinska>(broj);
                medicinska.Status = oprema.Status;
                medicinska.DatumNabavke = oprema.DatumNabavke;
                medicinska.Serijski_Broj = broj;
                medicinska.Naziv = oprema.Naziv;
                medicinska.Tip = oprema.Tip;
                medicinska.Jedinica = await sesija.LoadAsync<InterventnaJedinica>(oprema.JedinicaID);
                await sesija.UpdateAsync(medicinska);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task<IList<DTODodajMedicinsku>> VratiMedicinskuZastitu()
        {
            List<DTODodajMedicinsku> medicinska = new List<DTODodajMedicinsku>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                medicinska = await sesija.Query<Medicinska>()
                            .Fetch(j => j.Jedinica)
                            .Select(j => new DTODodajMedicinsku(j))
                            .ToListAsync();

                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return medicinska;
        }
        public static async Task<DTODodajMedicinsku> VratiMedicinskuOpremu(string broj)
        {
            DTODodajMedicinsku medicinska = new DTODodajMedicinsku();
            try
            {
                ISession sesija = DataLayer.GetSession();
                Medicinska oprema = await sesija.LoadAsync<Medicinska>(broj);
                medicinska.JedinicaID = oprema.Jedinica.Jedinstveni_Broj;
                medicinska.Status = oprema.Status;
                medicinska.DatumNabavke = oprema.DatumNabavke;
                medicinska.Serijski_Broj = oprema.Serijski_Broj;
                medicinska.Naziv = oprema.Naziv;
                medicinska.Tip = oprema.Tip;
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return medicinska;
        }
        #endregion
        #region TehnickaOprema
        public static async Task<IList<DTOPregledTehnicke>> VratiTehnickuOpremuJedinice(int id)
        {
            List<DTOPregledTehnicke> o = new List<DTOPregledTehnicke>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                o = await sesija.Query<Tehnicka>()
                           .Fetch(j => j.Jedinica)
                           .Where(j => j.Jedinica.Jedinstveni_Broj == id)
                           .Select(j => new DTOPregledTehnicke(j))
                           .ToListAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return o;
        }
        public static async Task DodajTehnickuOpremu(DTODodajTehnicku oprema)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Tehnicka tehnicka = new Tehnicka();
                tehnicka.Serijski_Broj = oprema.Serijski_Broj;
                tehnicka.Naziv = oprema.Naziv;
                tehnicka.Status = oprema.Status;
                tehnicka.DatumNabavke = oprema.DatumNabavke;
                tehnicka.Jedinica = await sesija.LoadAsync<InterventnaJedinica>(oprema.JedinicaID);
                tehnicka.Tip = oprema.Tip;
                await sesija.SaveAsync(tehnicka);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task ObrisiTehnickuOpremu(string broj)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Tehnicka tehnicka = await sesija.LoadAsync<Tehnicka>(broj);
                await sesija.DeleteAsync(tehnicka);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task IzmeniTehnickuOpremu(DTODodajTehnicku oprema, string broj)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Tehnicka tehnicka = await sesija.LoadAsync<Tehnicka>(broj);
                tehnicka.Naziv = oprema.Naziv;
                tehnicka.Status = oprema.Status;
                tehnicka.Serijski_Broj = broj;
                tehnicka.Tip = oprema.Tip;
                tehnicka.DatumNabavke = oprema.DatumNabavke;
                tehnicka.Jedinica = await sesija.LoadAsync<InterventnaJedinica>(oprema.JedinicaID);
                await sesija.UpdateAsync(tehnicka);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }

        public static async Task<IList<DTODodajTehnicku>> VratiTehnickuZastitu()
        {
            List<DTODodajTehnicku> o = new List<DTODodajTehnicku>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                o = await sesija.Query<Tehnicka>()
                           .Fetch(s => s.Jedinica)
                           .Select(l => new DTODodajTehnicku(l))
                           .ToListAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return o;
        }

        public static async Task<DTODodajTehnicku> VratiTehnickuOpremu(string broj)
        {
            DTODodajTehnicku tehnicka = null;
            try
            {
                ISession sesija = DataLayer.GetSession();
                Tehnicka oprema = await sesija.LoadAsync<Tehnicka>(broj);

                tehnicka = new DTODodajTehnicku(oprema);
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return tehnicka;
        }
        #endregion
        #region Zaliha
        public static async Task<IList<DTOPregledZalihe>> VratiZaliheJedinice(int id)
        {
            List<DTOPregledZalihe> o = new List<DTOPregledZalihe>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                o = await sesija.Query<Zaliha>()
                            .Fetch(j => j.Jedinica)
                            .Where(j => j.Jedinica.Jedinstveni_Broj == id)

                            .Select(z => new DTOPregledZalihe(z))
                            .ToListAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return o;
        }
        public static async Task DodajZalihe(DTODodajZalihe zaliha)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Zaliha z = new Zaliha
                {
                    Naziv = zaliha.Naziv,
                    Status = zaliha.Status,
                    DatumNabavke = zaliha.DatumNabavke,
                    Serijski_Broj = zaliha.Serijski_Broj,

                    Jedinica = await sesija.GetAsync<InterventnaJedinica>(zaliha.JedinicaID),
                    Kolicina = zaliha.Kolicina,
                    Tip = zaliha.Tip
                };
                await sesija.SaveAsync(z);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }

        public static async Task ObrisiZalihe(string broj)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Zaliha zaliha = await sesija.LoadAsync<Zaliha>(broj);
                await sesija.DeleteAsync(zaliha);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task IzmeniZalihe(DTODodajZalihe zaliha, string broj)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Zaliha z = await sesija.LoadAsync<Zaliha>(broj);
                if (zaliha == null)
                {
                    throw new KeyNotFoundException("Zao na je ne postoji zaliha sa ovim serijskim brojem");
                }
                z.Naziv = zaliha.Naziv;
                z.Status = zaliha.Status;
                z.DatumNabavke = zaliha.DatumNabavke;
                z.Serijski_Broj = broj;
                z.Tip = zaliha.Tip;
                z.Kolicina = zaliha.Kolicina;
                z.Jedinica = await sesija.GetAsync<InterventnaJedinica>(zaliha.JedinicaID);
                await sesija.UpdateAsync(z);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task<IList<DTODodajZalihe>> VratiZalihe()
        {
            List<DTODodajZalihe> o = new List<DTODodajZalihe>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                o = await sesija.Query<Zaliha>()
                           .Fetch(j => j.Jedinica)
                            .Select(j => new DTODodajZalihe(j))
                           .ToListAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return o;
        }
        public static async Task<DTODodajZalihe> VratiZalihe(string broj)
        {
            DTODodajZalihe z = null;
            try
            {
                ISession sesija = DataLayer.GetSession();
                Zaliha zaliha = await sesija.LoadAsync<Zaliha>(broj);
                z = new DTODodajZalihe(zaliha);
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return z;
        }
        #endregion

        #endregion
        #region PredstavnikSluzbe
        public static async Task<DTOPredstavnikSluzbe> VratiPredstacnikaJedinice(int id)
        {
            DTOPredstavnikSluzbe p = new DTOPredstavnikSluzbe();
            try
            {
                ISession sesija = DataLayer.GetSession();
                Sluzba s = await sesija.LoadAsync<Sluzba>(id);
                PredstavnikSluzbe predstavnik = s.Predstavnik;
                p = await DTOManager.VratiPredstavnika(predstavnik.JMBG);
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return p;
        }

        public static async Task IzmeniPredstavnika(DTOPredstavnikSluzbe predstavnik, string maticniBroj)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                PredstavnikSluzbe p = await sesija.LoadAsync<PredstavnikSluzbe>(maticniBroj);
                p.Pozicija = predstavnik.Pozicija;
                p.Telefon = predstavnik.Telefon;
                p.Email = predstavnik.Email;
                p.JMBG = maticniBroj;
                p.Ime = predstavnik.Ime;
                p.Prezime = predstavnik.Prezime;
                await sesija.UpdateAsync(p);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task DodajPredstavnika(DTOPredstavnikSluzbe p)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                PredstavnikSluzbe predstavnik = new PredstavnikSluzbe();
                predstavnik.JMBG = p.JMBG;
                predstavnik.Ime = p.Ime;
                predstavnik.Prezime = p.Prezime;
                predstavnik.Pozicija = p.Pozicija;
                predstavnik.Telefon = p.Telefon;
                predstavnik.Email = p.Email;
                await sesija.SaveAsync(predstavnik);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task ObrisiPredstavnika(string maticniBroj)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                PredstavnikSluzbe predstavnik = await sesija.LoadAsync<PredstavnikSluzbe>(maticniBroj);
                await sesija.DeleteAsync(predstavnik);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task<IList<DTOPredstavnikSluzbe>> VratiPredstavnike()
        {
            List<DTOPredstavnikSluzbe> p = new List<DTOPredstavnikSluzbe>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                p = await sesija.Query<PredstavnikSluzbe>()
                                .Select(p => new DTOPredstavnikSluzbe(p))
                                .ToListAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return p;
        }

        public static async Task<DTOPredstavnikSluzbe> VratiPredstavnika(string maticniBroj)
        {
            DTOPredstavnikSluzbe p = new DTOPredstavnikSluzbe();
            try
            {
                ISession sesija = DataLayer.GetSession();
                PredstavnikSluzbe predstavnik = await sesija.LoadAsync<PredstavnikSluzbe>(maticniBroj);
                p = new DTOPredstavnikSluzbe(predstavnik);
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return p;
        }
        #endregion
        #region Sluzba
        public static async Task<IList<DTOSluzba>> VratiSveSluzbeKojeSaradjujuSaVS(int situacijaId)
        {
            List<DTOSluzba> s = new List<DTOSluzba>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                var saradnje = await sesija.Query<Saradnja>()
                             .Where(v => v.Vanredna_Sit.Id == situacijaId)
                             .Fetch(v => v.Vanredna_Sit)
                             .ToListAsync();
                s = saradnje.Select(v => new DTOSluzba(v.Sektor))
                                            .Distinct()
                                            .ToList();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return s;
        }
        public static async Task IzmeniSluzbu(DTODodajSluzbu sluzba, int sluzbaId)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Sluzba s = await sesija.LoadAsync<Sluzba>(sluzbaId);
                s.TipSektora = sluzba.TipSektora;
                s.Predstavnik = await sesija.LoadAsync<PredstavnikSluzbe>(sluzba.JMBG_Predstavnik);
                await sesija.UpdateAsync(s);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task<IList<DTOVratiSluzbu>> VratiSluzbe()
        {
            List<DTOVratiSluzbu> s = new List<DTOVratiSluzbu>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                s = await sesija.Query<Sluzba>()
                       .Fetch(p => p.Predstavnik)
                       .Select(p => new DTOVratiSluzbu(p))
                       .ToListAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return s;
        }
        public static async Task DodajSluzbu(DTODodajSluzbu sluzba)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Sluzba s = new Sluzba();
                s.TipSektora = sluzba.TipSektora;
                s.Predstavnik = await sesija.GetAsync<PredstavnikSluzbe>(sluzba.JMBG_Predstavnik);
                await sesija.SaveAsync(s);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task ObrisiSluzbu(int id)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Sluzba sluzba = await sesija.LoadAsync<Sluzba>(id);
                await sesija.DeleteAsync(sluzba);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task<DTOSluzba> VratiSluzbu(int id)
        {
            DTOSluzba s = new DTOSluzba();
            try
            {
                ISession sesija = DataLayer.GetSession();
                Sluzba sluzba = await sesija.LoadAsync<Sluzba>(id);
                s.SektorrId = sluzba.SektorrId;
                s.TipSektora = sluzba.TipSektora;
                DTOPredstavnikSluzbe predstavnik = new DTOPredstavnikSluzbe();
                predstavnik = await DTOManager.VratiPredstavnika(sluzba.Predstavnik.JMBG);
                s.Predstavnik = predstavnik;
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return s;
        }

        public static async Task<IList<DTOVanrednaSituacija>> VratiSveVanredneUKojimaSaradjujeSektor(int id)
        {
            List<DTOVanrednaSituacija> v = new List<DTOVanrednaSituacija>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                var saradnje = await sesija.Query<Saradnja>()
                             .Where(s => s.Sektor.SektorrId == id)
                             .Fetch(s => s.Sektor)
                             .ToListAsync();
                v = saradnje.Select(s => new DTOVanrednaSituacija(s.Vanredna_Sit))
                                            .Distinct()
                                            .ToList();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return v;
        }
        #endregion
        #region Sertifikati
        public static async Task<DTOSertifikat> VratiSertifikat(string maticniBroj, string naziv, string institucija)
        {
            DTOSertifikat s = new DTOSertifikat();
            try
            {
                ISession sesija = DataLayer.GetSession();
                IdSertifikata idSertifikata = new IdSertifikata
                {
                    OperativniRadnik = await sesija.LoadAsync<OperativniRadnik>(maticniBroj),
                    Institucija = institucija,
                    Naziv = naziv

                };
                Sertifikati sertifikat = await sesija.LoadAsync<Sertifikati>(idSertifikata);
                s.DatumVazenja = sertifikat.DatumVazenja;
                s.DatumIzdavanja = sertifikat.DatumIzdavanja;
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return s;
        }
        public static async Task ObrisiSertifikat(DTODodajIdSertifikata sertifikatId)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                IdSertifikata idSertifikata = new IdSertifikata
                {
                    OperativniRadnik = await sesija.LoadAsync<OperativniRadnik>(sertifikatId.JMBGRadnika),
                    Institucija = sertifikatId.Institucija,
                    Naziv = sertifikatId.Naziv
                };
                Sertifikati sertifikat = await sesija.LoadAsync<Sertifikati>(idSertifikata);
                await sesija.DeleteAsync(sertifikat);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task DodajSertifikat(DTOSertifikat sertifikat)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Sertifikati s = new Sertifikati();
                OperativniRadnik radnik = await sesija.LoadAsync<OperativniRadnik>(sertifikat.Id.JMBGRadnika);
                IdSertifikata sertifikatId = new IdSertifikata
                {
                    Naziv = sertifikat.Id.Naziv,
                    Institucija = sertifikat.Id.Institucija,
                    OperativniRadnik = radnik

                };
                s.Id = sertifikatId;
                if (sertifikat.DatumIzdavanja > DateTime.Now)
                    throw new Exception("Upisite drugi datum");
                if (sertifikat.DatumVazenja == null)
                {
                    s.DatumVazenja = null;
                    s.DatumIzdavanja = sertifikat.DatumIzdavanja;
                }
                else
                {
                    if (s.DatumVazenja <= sertifikat.DatumIzdavanja)
                        throw new Exception("Upisite drugi datum.");
                    s.DatumVazenja = sertifikat.DatumVazenja;
                    s.DatumIzdavanja = sertifikat.DatumIzdavanja;
                }
                await sesija.SaveOrUpdateAsync(s);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task IzmeniSertifikat(DTOSertifikat idSertifikata)
        {
            try
            {
                using (ISession sesija = DataLayer.GetSession())
                {
                    
                    IdSertifikata sertifikatId = new IdSertifikata
                    {
                        OperativniRadnik = await sesija.LoadAsync<OperativniRadnik>(idSertifikata.Id.JMBGRadnika),
                        Naziv = idSertifikata.Id.Naziv,
                        Institucija = idSertifikata.Id.Institucija
                    };

                   
                    Sertifikati sertifikat = await sesija.LoadAsync<Sertifikati>(sertifikatId);

                   
                    sertifikat.DatumIzdavanja = idSertifikata.DatumIzdavanja;
                    sertifikat.DatumVazenja = idSertifikata.DatumVazenja;

                    await sesija.UpdateAsync(sertifikat);
                    await sesija.FlushAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task<IList<DTOVratiSertifikat>> VratiSertifikate()
        {
            List<DTOVratiSertifikat> s = new List<DTOVratiSertifikat>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                s = await sesija.Query<Sertifikati>()

                                .Select(i => new DTOVratiSertifikat(i))
                                .ToListAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return s;
        }
        public static async Task<IList<DTOVratiSertifikat>> VratiSertifikateZaposlenog(string maticniBroj)
        {
            List<DTOVratiSertifikat> s = new List<DTOVratiSertifikat>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                s = sesija.Query<Sertifikati>()

                                .Where(i => i.Id.OperativniRadnik.JMBG == maticniBroj)
                                .ToList()
                                .Select(i => new DTOVratiSertifikat(i))
                                .ToList();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }

            return s;
        }
        #endregion
        #region Angazovano
        public static async Task<IList<DTOIntervencija>> VratiIntervencijeUKojimajeUcestvovaloVozilo(string registracija)
        {
            List<DTOIntervencija> i = new List<DTOIntervencija>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                var angazovano = await sesija.Query<Angazovano>()
                                .Where(v => v.Vozilo.Registarska_Oznaka == registracija)
                                .ToListAsync();
                foreach (var a in angazovano)
                {
                    i.Add(new DTOIntervencija(a.Intervencija));
                }
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return i;
        }

        public static async Task<IList<DTOAngazovano>> VratiUcestvovanjeVozilaUKojimajeUcestvovalo(string registracija)
        {
            List<DTOAngazovano> a = new List<DTOAngazovano>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                var angazovano = await sesija.Query<Angazovano>()
                                .Fetch(i => i.Intervencija)
                                .Where(i => i.Vozilo.Registarska_Oznaka == registracija)
                                .ToListAsync();
                foreach (var ang in angazovano)
                {
                    a.Add(new DTOAngazovano(ang));
                }
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return a;
        }
        public static async Task DodajUcestvovanje(DTODodajAngazovano angazovano)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Angazovano a = new Angazovano();
                a.Vozilo = await sesija.LoadAsync<Vozilo>(angazovano.VoziloReg);
                a.Intervencija = await sesija.LoadAsync<Intervencija>(angazovano.IntervencijaID);
                if (angazovano.DatumPoc >= DateTime.Now)
                {
                    a.DatumPoc = DateTime.Now;
                    a.DatumKraj = null;
                }
                else
                    a.DatumPoc = angazovano.DatumPoc;
                if (angazovano.DatumKraj <= angazovano.DatumPoc)
                {
                    throw new Exception("Promeniti datum");
                }
                else
                    a.DatumKraj = a.DatumKraj;
                await sesija.SaveAsync(a);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task ObrisiUcestvovanje(int angazovanoId)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Angazovano angazovano = await sesija.LoadAsync<Angazovano>(angazovanoId);
                await sesija.DeleteAsync(angazovano);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task IzmeniUcestvovanje(DTODodajAngazovano angazovano, int angazovanoId)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Angazovano a = await sesija.LoadAsync<Angazovano>(angazovanoId);
                a.Vozilo = await sesija.LoadAsync<Vozilo>(angazovano.VoziloReg);
                a.Intervencija = await sesija.LoadAsync<Intervencija>(angazovano.IntervencijaID);
                a.DatumKraj = angazovano.DatumKraj;
                a.DatumPoc = angazovano.DatumPoc;
                await sesija.UpdateAsync(a);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }

        public static async Task<IList<DTOVratiAngazovano>> VratiUcestvovanja()
        {
            List<DTOVratiAngazovano> a = new List<DTOVratiAngazovano>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                a = await sesija.Query<Angazovano>()
                            .Fetch(a => a.Vozilo)
                            .Fetch(a => a.Intervencija)
                            .Select(a => new DTOVratiAngazovano(a))
                            .ToListAsync();

                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }

            return a;
        }
        public static async Task<DTOVratiAngazovano> VratiUcestvovanje(int angazovanoId)
        {
            DTOVratiAngazovano a = new DTOVratiAngazovano();
            try
            {
                ISession sesija = DataLayer.GetSession();
                Angazovano angazovano = await sesija.LoadAsync<Angazovano>(angazovanoId);
                a = new DTOVratiAngazovano(angazovano);
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }

            return a;
        }

        public static async Task<IList<DTOAngazovano>> VratiUcestvovanjaVozilaU(int id)
        {
            List<DTOAngazovano> a = new List<DTOAngazovano>();
            try
            {
                ISession sesija = DataLayer.GetSession();

                var angazovano = await sesija.Query<Angazovano>()
                                .Fetch(v => v.Vozilo)
                                .Where(v => v.Intervencija.Id == id)
                                .ToListAsync();
                foreach (var ang in angazovano)
                {
                    a.Add(new DTOAngazovano(ang));
                }
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }

            return a;
        }
        public static async Task<IList<DTOVozilo>> VratiUcestvovanjaVozilaUIntervencijama(int id)
        {
            List<DTOVozilo> v = new List<DTOVozilo>();
            try
            {
                ISession sesija = DataLayer.GetSession();

                var angazovano = await sesija.Query<Angazovano>()
                                .Fetch(s => s.Vozilo)
                                .Where(s => s.Intervencija.Id == id)
                                .ToListAsync();
                foreach (var vozilo in angazovano)
                {
                    v.Add(new DTOVozilo(vozilo.Vozilo));
                }
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return v;
        }
        #endregion
        #region VanrednaSituacija
        public static async Task IzmeniVanrednuSituaciju(DTODodajVanrednuSituaciju vanrednaSituacija, int idSituacije)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                VanrednaSituacija situacija = await sesija.LoadAsync<VanrednaSituacija>(idSituacije);
                situacija.Broj_Ugrozenih_Osoba = vanrednaSituacija.Broj_Ugrozenih_Osoba;
                situacija.Opstina = vanrednaSituacija.Opstina;
                situacija.Nivo_Opasnosti = vanrednaSituacija.Nivo_Opasnosti;
                situacija.Lokacija = vanrednaSituacija.Lokacija;
                situacija.Tip = vanrednaSituacija.Tip;
                situacija.Opis = vanrednaSituacija.Opis;
                situacija.DatumPoc = vanrednaSituacija.DatumPoc;
                situacija.DatumKraj = vanrednaSituacija.DatumKraj;
                situacija.Prijava_ID = await sesija.GetAsync<Prijava>(vanrednaSituacija.IdPrijave);
                await sesija.UpdateAsync(situacija);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task DodajVanrednuSituaciju(DTODodajVanrednuSituaciju vanrednaSituacija)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                VanrednaSituacija situacija = new VanrednaSituacija();
                if (vanrednaSituacija.DatumPoc >= DateTime.Now)
                {
                    situacija.DatumPoc = DateTime.Now;
                    situacija.DatumKraj = null;
                }
                else situacija.DatumPoc = vanrednaSituacija.DatumPoc;
                if (vanrednaSituacija.DatumKraj <= vanrednaSituacija.DatumPoc)
                {
                    throw new Exception("Lose izabran datum");
                }
                else situacija.DatumKraj = vanrednaSituacija.DatumKraj;
                situacija.Opis = vanrednaSituacija.Opis;
                situacija.Prijava_ID = await sesija.GetAsync<Prijava>(vanrednaSituacija.IdPrijave);
                situacija.Broj_Ugrozenih_Osoba = vanrednaSituacija.Broj_Ugrozenih_Osoba;
                situacija.Nivo_Opasnosti = vanrednaSituacija.Nivo_Opasnosti;
                situacija.Opstina = vanrednaSituacija.Opstina;
                situacija.Tip = vanrednaSituacija.Tip;
                situacija.Lokacija = vanrednaSituacija.Lokacija;
                await sesija.SaveOrUpdateAsync(situacija);
                await sesija.FlushAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task obrisiVanrednuSituaciju(int idVanredneSituacije)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                VanrednaSituacija situacija = await sesija.LoadAsync<VanrednaSituacija>(idVanredneSituacije);
                await sesija.DeleteAsync(situacija);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task<DTOVanrednaSituacija> VratiVanrednuSituaciju(int idSituacije)
        {
            DTOVanrednaSituacija v = null;

            try
            {
                ISession sesija = DataLayer.GetSession();
                VanrednaSituacija situacija = await sesija.LoadAsync<VanrednaSituacija>(idSituacije);
                v = new DTOVanrednaSituacija(situacija);
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return v;
        }
        public static async Task<IList<DTOVanrednaSituacija>> VratiVanredneSituacije()
        {
            List<DTOVanrednaSituacija> situacija = new List<DTOVanrednaSituacija>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                situacija = await sesija.Query<VanrednaSituacija>()
                    .Fetch(p => p.Prijava_ID)
                    .Select(p => new DTOVanrednaSituacija(p))
                    .ToListAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return situacija;
        }
        #endregion
        #region IntervetnaJedinica
        public static async Task<DTOVratiSpecijalnuInterventnuJedinicu> VratiSpecijalnuJedinicu(int idSpecijalne)
        {
            DTOVratiSpecijalnuInterventnuJedinicu specijalna = null;
            try
            {
                ISession sesija = DataLayer.GetSession();
                SpecijalnaInterventnaJedinica interventna = await sesija.LoadAsync<SpecijalnaInterventnaJedinica>(idSpecijalne);
                specijalna = new DTOVratiSpecijalnuInterventnuJedinicu(interventna);
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return specijalna;
        }
        public static async Task<IList<DTOVratiInterventnuJedinicu>> VratiSveJedinice()
        {
            List<DTOVratiInterventnuJedinicu> interventne = new List<DTOVratiInterventnuJedinicu>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                var specijalne = await sesija.Query<SpecijalnaInterventnaJedinica>()
                   .Fetch(i => i.Komandir)
                   .ToListAsync();
                var opste = await sesija.Query<OpstaInterventnaJedinica>()
                    .Fetch(i => i.Komandir)
                    .ToListAsync();
                foreach (var i in specijalne)
                {
                    interventne.Add(new DTOVratiSpecijalnuInterventnuJedinicu(i));
                }
                foreach (var i in opste)
                {
                    interventne.Add(new DTOVratiOpstuInterventnuJedinicu(i));
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return interventne;
        }
        public static async Task DodajOpstuIntervetnuJedinicu(DTOOsnovnaOpstaInterventnaJedinica interventna)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                OpstaInterventnaJedinica interventnaJedinica = new OpstaInterventnaJedinica();
                interventnaJedinica.Baza = interventna.Baza;
                interventnaJedinica.Naziv = interventna.Naziv;
                interventnaJedinica.Komandir = await sesija.GetAsync<OperativniRadnik>(interventna.JMBGKomandira);
                OperativniRadnik komanduje = await sesija.GetAsync<OperativniRadnik>(interventna.JMBGKomandira);
                await sesija.SaveOrUpdateAsync(interventnaJedinica);
                if (komanduje != null)
                {
                    komanduje.InterventnaJedinica = interventnaJedinica;
                    await sesija.SaveOrUpdateAsync(komanduje);
                }
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw new Exception();
            }
        }

        public static async Task ObrisiOpstuInterventnuJedinicu(int idOpste)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                OpstaInterventnaJedinica interventna = await sesija.LoadAsync<OpstaInterventnaJedinica>(idOpste);
                await sesija.DeleteAsync(interventna);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task IzmeniOpstuInterventnuJedinicu(DTOOsnovnaOpstaInterventnaJedinica opsta, int idOpste)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                OpstaInterventnaJedinica interventnaJedinica = await sesija.LoadAsync<OpstaInterventnaJedinica>(idOpste);
                if (interventnaJedinica == null)
                    throw new Exception("Nema jedinice sa tim id-em");
                interventnaJedinica.Baza = opsta.Baza;
                interventnaJedinica.Naziv = opsta.Naziv;
                var komanduje = await sesija.GetAsync<OperativniRadnik>(opsta.JMBGKomandira);
                if (komanduje == null)
                    throw new Exception("Nema komandira sa tim maticnim brojem");
                if (komanduje.InterventnaJedinica != null &&
                    komanduje.InterventnaJedinica.Jedinstveni_Broj != interventnaJedinica.Jedinstveni_Broj)
                {
                    var staraJedinica = komanduje.InterventnaJedinica;
                    staraJedinica.Komandir = null;
                    await sesija.UpdateAsync(staraJedinica);
                    komanduje.InterventnaJedinica = null;
                    await sesija.UpdateAsync(komanduje);
                    await sesija.FlushAsync();
                }
                if (interventnaJedinica.Komandir != null && interventnaJedinica.Komandir.JMBG != komanduje.JMBG)
                {
                    var stariKomandir = interventnaJedinica.Komandir;
                    stariKomandir.InterventnaJedinica = null;
                    await sesija.UpdateAsync(stariKomandir);
                }
                interventnaJedinica.Komandir = komanduje;
                komanduje.InterventnaJedinica = interventnaJedinica;
                await sesija.SaveOrUpdateAsync(komanduje);
                await sesija.UpdateAsync(interventnaJedinica);
                await sesija.FlushAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task<IList<DTOVratiOpstuInterventnuJedinicu>> VratiOpstejedinice()
        {
            List<DTOVratiOpstuInterventnuJedinicu> opste = new List<DTOVratiOpstuInterventnuJedinicu>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                opste = await sesija.Query<OpstaInterventnaJedinica>()
                   .Fetch(j => j.Komandir)
                   .Select(j => new DTOVratiOpstuInterventnuJedinicu(j))
                   .ToListAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return opste;
        }

        public static async Task<DTOVratiOpstuInterventnuJedinicu> VratiOpstuJedinicu(int idOpste)
        {
            DTOVratiOpstuInterventnuJedinicu opsta = null;
            try
            {
                ISession sesija = DataLayer.GetSession();
                OpstaInterventnaJedinica interventna = await sesija.LoadAsync<OpstaInterventnaJedinica>(idOpste);
                if (interventna == null)
                {
                    throw new KeyNotFoundException("Nema jedinice sa tim id-em");
                }
                opsta = new DTOVratiOpstuInterventnuJedinicu(interventna);
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return opsta;
        }
        public static async Task DodajSpecijalnuIntervetnuJedinicu(DTOOsnovnaSpecijalnaInterventnaJedinica osnovna)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                SpecijalnaInterventnaJedinica specijalna = new SpecijalnaInterventnaJedinica();
                specijalna.Naziv = osnovna.Naziv;
                specijalna.Komandir = await sesija.GetAsync<OperativniRadnik>(osnovna.JMBGKomandira);
                OperativniRadnik komanduje = await sesija.GetAsync<OperativniRadnik>(osnovna.JMBGKomandira);
                specijalna.TipSpecijalneJedinice = osnovna.TipSpecijalneJedinice;
                specijalna.Baza = osnovna.Baza;
                await sesija.SaveOrUpdateAsync(specijalna);
                if (komanduje != null)
                {
                    komanduje.InterventnaJedinica = specijalna;
                    await sesija.SaveOrUpdateAsync(komanduje);
                    specijalna.BrojClanova++;
                }
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task ObrisiSpecijalnuInterventnuJedinicu(int idSpecijalne)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                SpecijalnaInterventnaJedinica specijalna = await sesija.LoadAsync<SpecijalnaInterventnaJedinica>(idSpecijalne);
                await sesija.DeleteAsync(specijalna);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task izmeniSpecijalnuInterventnuJedinicu(DTOOsnovnaSpecijalnaInterventnaJedinica osnovna, int idSpecijalne)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                SpecijalnaInterventnaJedinica specijalna = await sesija.LoadAsync<SpecijalnaInterventnaJedinica>(idSpecijalne);
                if (specijalna == null)
                    throw new Exception("Nema jedinice sa tim id-em");
                specijalna.Baza = osnovna.Baza;
                specijalna.TipSpecijalneJedinice = osnovna.TipSpecijalneJedinice;
                specijalna.Naziv = osnovna.Naziv;
                var komanduje = await sesija.GetAsync<OperativniRadnik>(osnovna.JMBGKomandira);
                if (komanduje == null) throw new Exception("Nema komandira sa tim maticnim brojem");
                if (komanduje.InterventnaJedinica != null && komanduje.InterventnaJedinica.Jedinstveni_Broj != specijalna.Jedinstveni_Broj)
                {
                    var jedinicaPre = komanduje.InterventnaJedinica;
                    jedinicaPre.Komandir = null;
                    await sesija.UpdateAsync(jedinicaPre);
                    komanduje.InterventnaJedinica = null;
                    await sesija.UpdateAsync(komanduje);
                    await sesija.FlushAsync();
                }
                if (specijalna.Komandir != null && specijalna.Komandir.JMBG != komanduje.JMBG)
                {
                    var komandirPre = specijalna.Komandir;
                    komandirPre.InterventnaJedinica = null;
                    await sesija.UpdateAsync(komandirPre);
                }
                specijalna.Komandir = komanduje;
                komanduje.InterventnaJedinica = specijalna;
                await sesija.SaveOrUpdateAsync(komanduje);
                await sesija.UpdateAsync(specijalna);
                await sesija.FlushAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task<IList<DTOVratiSpecijalnuInterventnuJedinicu>> VratiSpecijalneJedinice()
        {
            List<DTOVratiSpecijalnuInterventnuJedinicu> specijalne = new List<DTOVratiSpecijalnuInterventnuJedinicu>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                specijalne = await sesija.Query<SpecijalnaInterventnaJedinica>()
                   .Fetch(s => s.Komandir)
                   .Select(s => new DTOVratiSpecijalnuInterventnuJedinicu(s))
                   .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return specijalne;
        }
        #endregion
        #region Intervencija
        public static async Task<IList<DTOIntervencija>> VratiIntervencije()
        {
            List<DTOIntervencija> intervencije = new List<DTOIntervencija>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                intervencije = await sesija.Query<Intervencija>()
                                  .Select(s => new DTOIntervencija(s))
                                  .ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return intervencije;
        }

        public static async Task<DTOIntervencija> VratiIntervencijuu(int intervencijaId)
        {
            DTOIntervencija intervencija = new DTOIntervencija();
            try
            {
                ISession sesija = DataLayer.GetSession();
                Intervencija i = await sesija.LoadAsync<Intervencija>(intervencijaId);
                intervencija.Status = i.Status.ToString();
                intervencija.Broj_Spasenih = i.Broj_Spasenih;
                intervencija.Resursi = i.Resursi;
                intervencija.Datum_I_Vreme = i.Datum_I_Vreme;
                intervencija.Lokacija = i.Lokacija;
                intervencija.Uspesnost = i.Uspesnost;
                intervencija.Broj_Povredjenih = i.Broj_Povredjenih;
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return intervencija;
        }
        public static async Task DodajIntervenciju(DTOOsnovnaIntervencija intervencija)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Intervencija i = new Intervencija();
                i.Resursi = intervencija.Resursi;
                i.Broj_Povredjenih = intervencija.Broj_Povredjenih;
                i.Uspesnost = intervencija.Uspesnost;
                i.Status = intervencija.Status;
                i.Datum_I_Vreme = intervencija.Datum_I_Vreme;
                i.Lokacija = intervencija.Lokacija;
                i.Broj_Spasenih = intervencija.Broj_Spasenih;
                await sesija.SaveAsync(i);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }

        public static async Task ObrisiIntervenciju(int intervencijaId)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Intervencija intervencija = await sesija.LoadAsync<Intervencija>(intervencijaId);
                await sesija.DeleteAsync(intervencija);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task IzmeniIntervenciju(DTOOsnovnaIntervencija intervencija, int idOsnovne)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Intervencija i = await sesija.LoadAsync<Intervencija>(idOsnovne);
                i.Datum_I_Vreme = intervencija.Datum_I_Vreme;
                i.Id = idOsnovne;
                i.Broj_Povredjenih = intervencija.Broj_Povredjenih;
                i.Uspesnost = intervencija.Uspesnost;
                i.Lokacija = intervencija.Lokacija;
                i.Status = intervencija.Status;
                i.Broj_Spasenih = intervencija.Broj_Spasenih;
                i.Resursi = intervencija.Resursi;
                await sesija.UpdateAsync(i);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }

        #endregion
        #region Prijava
        public static async Task<DTOPrijava> VratiPrijavu(int id)
        {
            DTOPrijava p = null;
            try
            {
                ISession sesija = DataLayer.GetSession();
                Prijava prijava = await sesija.LoadAsync<Prijava>(id);
                if (prijava == null)
                {
                    throw new KeyNotFoundException("Nema prijave sa tim id-em");
                }
                p = new DTOPrijava(prijava);
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return p;
        }
        public static async Task DodajPrijavu(DTODodajPrijavu prijava)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Prijava nova = new Prijava();
                nova.Opis = prijava.Opis;
                nova.JMBG_Dispecer = prijava.JMBG_Dispecer;
                nova.Prioritet = prijava.Prioritet;
                nova.Datum_I_Vreme = prijava.Datum_I_Vreme;
                nova.Tip = prijava.Tip;
                nova.Ime_Prijavioca = prijava.Ime_Prijavioca;
                nova.Kontakt = prijava.Kontakt;
                nova.Lokacija = prijava.Lokacija;
                await sesija.SaveOrUpdateAsync(nova);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task ObrisiPrijavu(int prijavaId)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Prijava prijava = await sesija.LoadAsync<Prijava>(prijavaId);
                await sesija.DeleteAsync(prijava);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }

        public static async Task IzmeniPrijavu(DTODodajPrijavu prijava, int prijavaId)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                if (sesija == null)
                {
                    throw new SessionException("Greska u kreiranju sesije");
                }
                Prijava nova = await sesija.LoadAsync<Prijava>(prijavaId);
                nova.Datum_I_Vreme = prijava.Datum_I_Vreme;
                nova.Tip = prijava.Tip;
                nova.Ime_Prijavioca = prijava.Ime_Prijavioca;
                nova.Kontakt = prijava.Kontakt;
                nova.Lokacija = prijava.Lokacija;
                nova.Opis = prijava.Opis;
                nova.JMBG_Dispecer = prijava.JMBG_Dispecer;
                nova.Prioritet = prijava.Prioritet;
                await sesija.UpdateAsync(nova);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task<IList<DTOPrijava>> VratiPrijave()
        {
            List<DTOPrijava> prijave = new List<DTOPrijava>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                prijave = await sesija.Query<Prijava>().
                             Select(s => new DTOPrijava(s))
                            .ToListAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return prijave;
        }
        #endregion
        #region Vozilo
        public static async Task<IList<DTOVozilo>> VratiSvaVozila()
        {
            var vozila = new List<DTOVozilo>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                var jeeps = await sesija.Query<Dzip>()
                                .ToListAsync();
                var trucks = await sesija.Query<Kamion>()
                                   .ToListAsync();
                var san = await sesija.Query<Sanitetsko>()
                                    .ToListAsync();
                var spec = await sesija.Query<Specijalno>()
                                   .ToListAsync();

                foreach (var v in jeeps)
                {
                    vozila.Add(new DTODzip(v));
                }
                foreach (var v in spec)
                {
                    vozila.Add(new DTOSpecijalno(v));
                }
                foreach (var v in san)
                {
                    vozila.Add(new DTOSanitetsko(v));
                }
                foreach (var v in trucks)
                {
                    vozila.Add(new DTOKamion(v));
                }
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return vozila;
        }

        public static async Task ObrisiVozilo(string registracija)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Vozilo vozilo = await sesija.LoadAsync<Vozilo>(registracija);
                await sesija.DeleteAsync(vozilo);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        #endregion
        #region Specijalno
        public static async Task<DTOSpecijalno> VratiSpecijalnoVozilo(string registracija)
        {
            DTOSpecijalno vozilo = new DTOSpecijalno();
            try
            {
                ISession sesija = DataLayer.GetSession();
                Specijalno specijalno = await sesija.LoadAsync<Specijalno>(registracija);
                vozilo.Status = specijalno.Status;
                vozilo.Lokacija = specijalno.Lokacija;
                vozilo.Registarska_Oznaka = specijalno.Registarska_Oznaka;
                vozilo.Namena = specijalno.Namena;
                vozilo.Proizvodjac = specijalno.Proizvodjac;
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return vozilo;
        }


        public static async Task ObrisiSpecijalnoVozilo(string registracija)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Specijalno specijalno = await sesija.LoadAsync<Specijalno>(registracija);
                if (specijalno == null)
                {
                    throw new KeyNotFoundException("Nema vozila sa ovom oznakom");
                }
                await sesija.DeleteAsync(specijalno);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task DodajSpecijalnoVozilo(DTODodajSpecijalno vozilo)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Specijalno v = new Specijalno();
                v.Status = vozilo.Status;
                v.Lokacija = vozilo.Lokacija;
                v.Namena = vozilo.Namena;
                v.Proizvodjac = vozilo.Proizvodjac;
                v.Registarska_Oznaka = vozilo.Registarska_Oznaka;
                await sesija.SaveAsync(v);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task IzmeniSpecijalnaVozila(DTODodajSpecijalno vozilo, string oznaka)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Specijalno specijalno = await sesija.LoadAsync<Specijalno>(oznaka);
                specijalno.Status = vozilo.Status;
                specijalno.Lokacija = vozilo.Lokacija;
                specijalno.Namena = vozilo.Namena;
                specijalno.Registarska_Oznaka = oznaka;
                specijalno.Proizvodjac = vozilo.Proizvodjac;
                await sesija.UpdateAsync(specijalno);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task<IList<DTOSpecijalno>> VratiSpecijalnaVozila()
        {
            List<DTOSpecijalno> specijalna = new List<DTOSpecijalno>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                specijalna = await sesija.Query<Specijalno>()
                           .Select(v => new DTOSpecijalno(v))
                           .ToListAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return specijalna;
        }

        #endregion
        #region Sanitetsko
        public static async Task<DTOSanitetsko> VratiSanitetkoVozilo(string oznaka)
        {
            DTOSanitetsko sanitetsko = new DTOSanitetsko();
            try
            {
                ISession sesija = DataLayer.GetSession();
                Sanitetsko vozilo = await sesija.LoadAsync<Sanitetsko>(oznaka);
                if (vozilo == null)
                {
                    throw new KeyNotFoundException("Nema ovog sanitetskog vozila");
                }
                sanitetsko.Status = vozilo.Status;
                sanitetsko.Lokacija = vozilo.Lokacija;
                sanitetsko.Registarska_Oznaka = vozilo.Registarska_Oznaka;
                sanitetsko.Proizvodjac = vozilo.Proizvodjac;
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return sanitetsko;
        }
        public static async Task ObrisiSanitetskoVozilo(string oznaka)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Vozilo sanitetsko = await sesija.LoadAsync<Sanitetsko>(oznaka);
                if (sanitetsko == null)
                {
                    throw new KeyNotFoundException("Nemamo tu registarsku oznaku");
                }
                await sesija.DeleteAsync(sanitetsko);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task DodajSanitetskaVozilo(DTODodajSanitetsko vozilo)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Sanitetsko sanitetsko = new Sanitetsko();
                sanitetsko.Status = vozilo.Status;
                sanitetsko.Lokacija = vozilo.Lokacija;
                sanitetsko.Registarska_Oznaka = vozilo.Registarska_Oznaka;
                sanitetsko.Proizvodjac = vozilo.Proizvodjac;
                await sesija.SaveAsync(sanitetsko);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task IzmeniSanitetskoVozilo(DTOIzmeniSanitetsko vozilo, string oznaka)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Sanitetsko sanitetsko = await sesija.LoadAsync<Sanitetsko>(oznaka);
                sanitetsko.Status = vozilo.Status;
                sanitetsko.Lokacija = vozilo.Lokacija;
                sanitetsko.Proizvodjac = vozilo.Proizvodjac;
                await sesija.UpdateAsync(sanitetsko);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task<IList<DTOSanitetsko>> VratiSanitetskaVozila()
        {
            List<DTOSanitetsko> sanitetska = new List<DTOSanitetsko>();
            try
            {
                ISession sesija = DataLayer.GetSession();

                sanitetska = await sesija.Query<Sanitetsko>()
                        .Select(v => new DTOSanitetsko(v))
                        .ToListAsync();

                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return sanitetska;
        }
        #endregion
        #region Dzip
        public static async Task<DTODzip> VratiDzip(string registracija)
        {
            DTODzip dzip = new DTODzip();
            try
            {
                ISession sesija = DataLayer.GetSession();
                Dzip vozilo = await sesija.LoadAsync<Dzip>(registracija);
                dzip.Status = vozilo.Status;
                dzip.Lokacija = vozilo.Lokacija;
                dzip.Registarska_Oznaka = vozilo.Registarska_Oznaka;
                dzip.Proizvodjac = vozilo.Proizvodjac;
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return dzip;
        }
        public static async Task ObrisiDzip(string registracija)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Dzip dzip = await sesija.LoadAsync<Dzip>(registracija);
                await sesija.DeleteAsync(dzip);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task DodajDzip(DTODodajDzip vozilo)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Dzip dzip = new Dzip();
                dzip.Lokacija = vozilo.Lokacija;
                dzip.Proizvodjac = vozilo.Proizvodjac;
                dzip.Status = vozilo.Status;
                dzip.Registarska_Oznaka = vozilo.Registarska_Oznaka;
                await sesija.SaveAsync(dzip);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }

        public static async Task IzmeniDzip(DTODodajDzip v, string oznaka)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Dzip vozilo = await sesija.LoadAsync<Dzip>(oznaka);
                vozilo.Status = v.Status;
                vozilo.Lokacija = v.Lokacija;
                vozilo.Registarska_Oznaka = oznaka;
                vozilo.Proizvodjac = v.Proizvodjac;
                await sesija.UpdateAsync(vozilo);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task<IList<DTODzip>> VratiDzipove()
        {
            List<DTODzip> dzipovi = new List<DTODzip>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                dzipovi = await sesija.Query<Dzip>()
                        .Select(v => new DTODzip(v))
                        .ToListAsync();

                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return dzipovi;
        }

        #endregion
        #region Kamion
        public static async Task<DTOKamion> VratiKamion(string registracija)
        {
            DTOKamion kamion = new DTOKamion();
            try
            {
                ISession sesija = DataLayer.GetSession();
                Kamion vozilo = await sesija.LoadAsync<Kamion>(registracija);
                kamion.Status = vozilo.Status;
                kamion.Lokacija = vozilo.Lokacija;
                kamion.Registarska_Oznaka = vozilo.Registarska_Oznaka;
                kamion.Proizvodjac = vozilo.Proizvodjac;
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return kamion;
        }
        public static async Task DodajKamion(DTODodajKamion vozilo)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Kamion v = new Kamion();
                v.Status = vozilo.Status;
                v.Lokacija = vozilo.Lokacija;
                v.Registarska_Oznaka = vozilo.Registarska_Oznaka;
                v.Proizvodjac = vozilo.Proizvodjac;
                await sesija.SaveAsync(v);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }

        public static async Task ObrisiKamion(string registracija)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Kamion kamion = await sesija.LoadAsync<Kamion>(registracija);
                await sesija.DeleteAsync(kamion);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task IzmeniKamion(DTODodajKamion vozilo, string oznaka)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Kamion kamion = await sesija.LoadAsync<Kamion>(oznaka);
                kamion.Proizvodjac = vozilo.Proizvodjac;
                kamion.Status = vozilo.Status;
                kamion.Registarska_Oznaka = oznaka;
                kamion.Lokacija = vozilo.Lokacija;
                await sesija.UpdateAsync(kamion);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task<IList<DTOKamion>> VratiKamione()
        {
            List<DTOKamion> kamioni = new List<DTOKamion>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                kamioni = await sesija.Query<Kamion>()
                            .Select(k => new DTOKamion(k))
                            .ToListAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return kamioni;
        }
        #endregion
        #region EvidencijaServis
        public static async Task<DTOEvidencijaServis> VratiServis(int servisId)
        {
            DTOEvidencijaServis evidencija = new DTOEvidencijaServis();
            try
            {
                ISession sesija = DataLayer.GetSession();
                EvidencijaServis servis = await sesija.LoadAsync<EvidencijaServis>(servisId);
                evidencija = new DTOEvidencijaServis(servis);
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return evidencija;
        }
        public static async Task ObrisiServis(int servisId)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                EvidencijaServis evidencija = await sesija.LoadAsync<EvidencijaServis>(servisId);
                await sesija.DeleteAsync(evidencija);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task DodajServis(DTODodajEvidencijuServis servis)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                EvidencijaServis evidencija = new EvidencijaServis();
                evidencija.Vozilo = await sesija.LoadAsync<Vozilo>(servis.RegistarskaOznakaVozila);
                evidencija.Datum = servis.Datum;
                evidencija.TipServisa = servis.TipServisa;
                await sesija.SaveAsync(evidencija);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task IzmeniServis(DTODodajEvidencijuServis servis, int servisId)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                EvidencijaServis evidencija = sesija.Load<EvidencijaServis>(servisId);
                evidencija.Vozilo = sesija.Load<Vozilo>(servis.RegistarskaOznakaVozila);
                evidencija.Datum = servis.Datum;
                evidencija.TipServisa = servis.TipServisa;
                await sesija.UpdateAsync(evidencija);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task<IList<DTOEvidencijaServis>> VratiServise()
        {
            List<DTOEvidencijaServis> evidencija = new List<DTOEvidencijaServis>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                evidencija = await sesija.Query<EvidencijaServis>()
                            .Fetch(e => e.Vozilo)
                            .Select(e => new DTOEvidencijaServis(e))
                            .ToListAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return evidencija;
        }
        public static async Task<IList<DTOEvidencijaServis>> VratiServiseVozila(string oznaka)
        {
            List<DTOEvidencijaServis> evidencija = new List<DTOEvidencijaServis>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                evidencija = await sesija.Query<EvidencijaServis>()
                           .Fetch(e => e.Vozilo)
                           .Where(e => e.Vozilo.Registarska_Oznaka == oznaka)
                           .Select(e => new DTOEvidencijaServis(e))
                           .ToListAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return evidencija;
        }
        #endregion
        #region Dodeljen
        public static async Task<IList<DTOVozilo>> VratiDodeljenaVozilaRadniku(string maticniBroj)
        {
            List<DTOVozilo> v = new List<DTOVozilo>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                var dodeljen = await sesija.Query<Dodeljen>()
                                .Where(r => r.Radnik.JMBG == maticniBroj)
                                .Fetch(r => r.Vozilo)
                                .ToListAsync();
                foreach (var d in dodeljen)
                {
                    v.Add(new DTOVozilo(d.Vozilo));
                }
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return v;
        }
        public static async Task<IList<DTOVozilo>> VratiDodeljivanjaJedinic(int id)
        {
            List<DTOVozilo> v = new List<DTOVozilo>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                var dodeljen = await sesija.Query<Dodeljen>()
                                .Where(d => d.Jedinica.Jedinstveni_Broj == id)
                                .Fetch(d => d.Vozilo)
                                .ToListAsync();
                foreach (var d in dodeljen)
                {
                    v.Add(new DTOVozilo(d.Vozilo));
                }
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return v;
        }
        public static async Task DodajDodeljivanje(DTODodajDodeljen d)
        {
            try
            {
                ISession sess = DataLayer.GetSession();
                bool haveJedinica = d.IdJedinica.HasValue;
                bool haveRadnik = !string.IsNullOrWhiteSpace(d.JMBGRadnik);
                if (haveJedinica && haveRadnik)
                    throw new Exception("Nije moguce da radnik i jedinica imaju vrednosti u ovoj tabeli");
                if (!haveJedinica && !haveRadnik)
                    throw new Exception("Morate navesti ili jedinicu ili radnika.");

                Dodeljen dodeljivanje = new Dodeljen();

                var vozilo = await sess.LoadAsync<Vozilo>(d.RegVozilo);
                dodeljivanje.Vozilo = vozilo;
                InterventnaJedinica? Jedinica = null;
                OperativniRadnik? Radnik = null;
                if (haveJedinica)
                {
                    Jedinica = await sess.GetAsync<InterventnaJedinica>(d.IdJedinica!.Value);
                    if (Jedinica == null)
                        throw new Exception("Interventna jedinica ne postoji.");
                }
                else
                {
                    Radnik = await sess.GetAsync<OperativniRadnik>(d.JMBGRadnik!.Trim());
                    if (Radnik == null)
                        throw new Exception("Operativni radnik sa zadatim JMBG ne postoji.");
                }
                if (vozilo.Status == StatusVozila.U_kvaru)
                    throw new Exception("Zao nam je ali vozilo se ne moze dodeliti jer je u kvaru");

                if (vozilo is Dzip && d.IdJedinica.HasValue)
                    throw new Exception("Zao nam je nije moguce dodeliti ovaj tip vozila jedinici");

                dodeljivanje.Radnik = Radnik;
                dodeljivanje.Jedinica = Jedinica;
                if (d.DatumDo <= d.DatumOd)
                    throw new Exception("Zao nam je ali ne mozete upisati ovu vrednost");
                dodeljivanje.DatumOd = d.DatumOd;
                dodeljivanje.DatumDo = d.DatumDo;
                await sess.SaveAsync(dodeljivanje);
                await sess.FlushAsync();
                sess.Close();
            }
            catch (Exception ec)
            {
                throw new Exception("Zao nam je doslo je do greske!", ec);
            }
        }
        public static async Task ObrisiDodeljivanje(int dodeljenId)
        {
            try
            {
                ISession sesija = DataLayer.GetSession();
                Dodeljen dodeljen = await sesija.LoadAsync<Dodeljen>(dodeljenId);
                await sesija.DeleteAsync(dodeljen);
                await sesija.FlushAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task IzmeniDodeljujeSe(DTODodajDodeljen dodeljen, int dodeljenId)
        {

            try
            {
                using (var sesija = DataLayer.GetSession())
                {
                    var d = await sesija.GetAsync<Dodeljen>(dodeljenId);
                    if (d == null)
                        throw new Exception($"Dodeljivanje sa ID {dodeljenId} ne postoji u bazi.");

                    if (string.IsNullOrEmpty(dodeljen.RegVozilo))
                        throw new Exception("Registarska oznaka vozila je prazna!");

                    var v = await sesija.LoadAsync<Vozilo>(dodeljen.RegVozilo);
                    if (v.Status == StatusVozila.U_kvaru)
                        throw new Exception("Vozilo je u kvaru!");

                    d.Vozilo = v;

                  
                    InterventnaJedinica? interventna = null;
                    if (dodeljen.IdJedinica.HasValue)
                    {
                        interventna = await sesija.LoadAsync<InterventnaJedinica>(dodeljen.IdJedinica.Value);
                    }

                  
                    OperativniRadnik? operativni = null;
                    if (!string.IsNullOrEmpty(dodeljen.JMBGRadnik))
                    {
                        operativni = await sesija.LoadAsync<OperativniRadnik>(dodeljen.JMBGRadnik);
                    }

                    if (v is Dzip && dodeljen.IdJedinica.HasValue)
                        throw new Exception("Džip ne može biti dodeljen jedinici!");

                    if (dodeljen.IdJedinica.HasValue && !string.IsNullOrEmpty(dodeljen.JMBGRadnik))
                        throw new Exception("Ne mogu istovremeno biti postavljeni i jedinica i radnik!");

                    
                    d.Jedinica = interventna;
                    d.Radnik = operativni;
                    d.DatumOd = dodeljen.DatumOd;
                    d.DatumDo = dodeljen.DatumDo;

                    await sesija.UpdateAsync(d);
                    await sesija.FlushAsync();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
        }
        public static async Task<IList<DTOVratiDodeljen>> VratiSvaDodeljivanja()
        {
            List<DTOVratiDodeljen> d = new List<DTOVratiDodeljen>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                d = await sesija.Query<Dodeljen>()

                              .Select(d => new DTOVratiDodeljen(d))
                              .ToListAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return d;
        }

        public static async Task<DTOVratiDodeljen> VratiDodeljivanje(int dodeljenId)
        {
            DTOVratiDodeljen dodeljen = new DTOVratiDodeljen();
            try
            {
                ISession sesija = DataLayer.GetSession();
                Dodeljen d = await sesija.LoadAsync<Dodeljen>(dodeljenId);
                dodeljen = new DTOVratiDodeljen(d);
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return dodeljen;
        }
        public static async Task<IList<DTODodeljen>> VratiDodeljivanjaVozila(string oznaka)
        {
            List<DTODodeljen> d = new List<DTODodeljen>();
            try
            {
                ISession sesija = DataLayer.GetSession();
                d = await sesija.Query<Dodeljen>()
                             .Fetch(d => d.Radnik)
                             .Fetch(d => d.Jedinica)
                             .Where(d => d.Vozilo.Registarska_Oznaka == oznaka)
                             .Select(d => new DTODodeljen(d))
                             .ToListAsync();
                sesija.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Greska u try blocku", ex);
            }
            return d;
        }
        #endregion
    }
}