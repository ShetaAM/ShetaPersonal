using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Identity;
using ShetaPersonal.Core.Covertor;
using ShetaPersonal.Core.DTO.Admin;
using ShetaPersonal.Core.Generator;
using ShetaPersonal.Core.Security;
using ShetaPersonal.Core.Serevices.Interface;
using ShetaPersonal.Data.Model.Context;
using ShetaPersonal.Data.Model.Entities;

namespace ShetaPersonal.Core.Serevices
{
    public class AdminService : IAdminService
    {
        private DatabaseContext db;

        public AdminService(DatabaseContext db)
        {
            this.db = db;
        }

        public About LoginUser(LoginViewModel login)
        {
            string email = FixedText.FixEmail(login.Email);
            string hashpass = PasswordHelper.EncodePasswordMd5(login.Password);

            return db.Abouts.SingleOrDefault(u => u.Email == email && u.Password == hashpass);
        }

        public int NumberOfRezome()
        {
            return db.Rezomes.Count();
        }

        public int NumberOfMaharat()
        {
            return db.Maharats.Count();
        }

        public int NumberOfGallery()
        {
            return db.Galleries.Count();
        }

        public TahsilatViewModel GetAlltahsilat(int pageid = 1, string Filter = "")
        {
            IQueryable<Tahsilat> result = db.Tahsilats;
            if (!string.IsNullOrEmpty(Filter))
            {
                result = db.Tahsilats.Where(t => t.Daneshgah.Contains(Filter) ||
                                                 t.Reshte.Contains(Filter) ||
                                                 t.gerayesh.Contains(Filter) ||
                                                 t.maghta.Contains(Filter) ||
                                                 t.StartTime.Contains(Filter) ||
                                                 t.EndTime.Contains(Filter));
            }

            var take = 10;
            var skip = (pageid - 1) * take;
            TahsilatViewModel list = new TahsilatViewModel();
            list.CurrentPage = pageid;
            list.PageCount = result.Count() / take;
            list.Tahsilats = result.OrderBy(t => t.TahsilatId).Skip(skip).Take(take).ToList();
            return list;
        }

        public void CreateTahsilat(Tahsilat tahsilat)
        {
            db.Tahsilats.Add(tahsilat);
            db.SaveChanges();
        }

        public Tahsilat GetInfoTahsilatForedit(int tahsilid)
        {
            return db.Tahsilats.SingleOrDefault(t => t.TahsilatId == tahsilid);
        }

        public void EditTahsilat(Tahsilat tahsilat)
        {
            db.Tahsilats.Update(tahsilat);
            db.SaveChanges();
        }

        public void DeteeTahsilat(int tahsilatid)
        {
            Tahsilat tahsilat = db.Tahsilats.Find(tahsilatid);
            db.Tahsilats.Remove(tahsilat);
            db.SaveChanges();
        }

        public SabegheViewModel GetAllTajrobiyat(int pageid = 1, string Filter = "")
        {
            IQueryable<Sabeghe> result = db.Sabeghes;
            if (!string.IsNullOrEmpty(Filter))
            {
                result = db.Sabeghes.Where(t => t.Stitle.Contains(Filter) ||
                                                t.Description.Contains(Filter) ||
                                                t.StartTime.Contains(Filter) ||
                                                t.EndTime.Contains(Filter) ||
                                                t.StartTime.Contains(Filter) ||
                                                t.EndTime.Contains(Filter));
            }

            var take = 10;
            var skip = (pageid - 1) * take;
            SabegheViewModel list = new SabegheViewModel();
            list.CurrentPage = pageid;
            list.PageCount = result.Count() / take;
            list.Sabeghes = result.OrderBy(t => t.SId).Skip(skip).Take(take).ToList();
            return list;
        }

        public void CreateSabeghe(Sabeghe sabeghe)
        {
            db.Sabeghes.Add(sabeghe);
            db.SaveChanges();
        }

        public Sabeghe GetInfoSabeghe(int sabegheid)
        {
            return db.Sabeghes.SingleOrDefault(t => t.SId == sabegheid);
        }

        public void EditSabeghe(Sabeghe sabeghe)
        {
            db.Sabeghes.Update(sabeghe);
            db.SaveChanges();
        }

        public void DeleteSabeghe(int sabegheid)
        {
            Sabeghe sabeghe = db.Sabeghes.Find(sabegheid);
            db.Sabeghes.Remove(sabeghe);
            db.SaveChanges();
        }

        public AboutMeViewModel GetAllAbout(int pageid = 1, string Filter = "")
        {
            IQueryable<About> result = db.Abouts;
            if (!string.IsNullOrEmpty(Filter))
            {
                result = db.Abouts.Where(t => t.FName.Contains(Filter) ||
                                              t.LName.Contains(Filter) ||
                                              t.FNameEN.Contains(Filter) ||
                                              t.LNameEN.Contains(Filter) ||
                                              t.Email.Contains(Filter));
            }

            var take = 10;
            var skip = (pageid - 1) * take;
            AboutMeViewModel list = new AboutMeViewModel();
            list.CurrentPage = pageid;
            list.PageCount = result.Count() / take;
            list.Abouts = result.OrderBy(t => t.UserId).Skip(skip).Take(take).ToList();
            return list;
        }

        public About GetInfoAbout(int aboutid)
        {
            return db.Abouts.SingleOrDefault(a => a.UserId == aboutid);
        }

        public void UpdateAbout(About about, IFormFile ImgProfile)
        {

            if (ImgProfile != null && ImgProfile.IsImage())
            {
                if (about.Profile != null)
                {

                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Site/img/",
                        about.Profile);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }


                }

                about.Profile = NameGenerator.GenerateUniqCode() + Path.GetExtension(ImgProfile.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Site/img/", about.Profile);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    ImgProfile.CopyTo(stream);
                }
            }


            db.Abouts.Update(about);
            db.SaveChanges();
        }

        public MaharathaViewModel GetAllMaharats(int pageid = 1, string Filter = "")
        {
            IQueryable<Maharat> result = db.Maharats;
            if (!string.IsNullOrEmpty(Filter))
            {
                result = db.Maharats.Where(t => t.Title.Contains(Filter));
            }

            var take = 20;
            var skip = (pageid - 1) * take;
            MaharathaViewModel list = new MaharathaViewModel();
            list.CurrentPage = pageid;
            list.PageCount = result.Count() / take;
            list.Maharats = result.OrderBy(t => t.UserId).Skip(skip).Take(take).ToList();
            return list;
        }

        public void CreateMaharat(Maharat maharat)
        {
            db.Maharats.Add(maharat);
            db.SaveChanges();
        }

        public Maharat GetInfoMaharat(int maharatid)
        {
            return db.Maharats.Single(m => m.MId == maharatid);
        }

        public void EditMaharat(Maharat maharat)
        {
            db.Maharats.Update(maharat);
            db.SaveChanges();
        }

        public void DeleteMaharat(int maharatid)
        {
            Maharat maharat = db.Maharats.Find(maharatid);
            db.Maharats.Remove(maharat);
            db.SaveChanges();
        }

        public DaneshViewModel GetAllDanesh(int pageid = 1, string Filter = "")
        {
            IQueryable<Danesh> result = db.Daneshes;
            if (!string.IsNullOrEmpty(Filter))
            {
                result = db.Daneshes.Where(t => t.DaneshName.Contains(Filter) ||
                                                t.Tozihat.Contains(Filter));
            }

            var take = 10;
            var skip = (pageid - 1) * take;
            DaneshViewModel list = new DaneshViewModel();
            list.CurrentPage = pageid;
            list.pagaCount = result.Count() / take;
            list.Daneshes = result.OrderBy(t => t.UserId).Skip(skip).Take(take).ToList();
            return list;
        }

        public void CreateDanesh(Danesh danesh)
        {
            db.Daneshes.Add(danesh);
            db.SaveChanges();
        }

        public Danesh GetInfoDanesh(int danesjid)
        {
            return db.Daneshes.Single(d => d.DId == danesjid);
        }

        public void EditDanesh(Danesh danesh)
        {
            db.Daneshes.Update(danesh);
            db.SaveChanges();
        }

        public void DeleteDanesh(int daneshid)
        {
            Danesh danesh = db.Daneshes.Find(daneshid);
            db.Daneshes.Remove(danesh);
            db.SaveChanges();
        }

        public TamashaViewModel GetAllTamas(int pageid = 1, string Filter = "")
        {
            IQueryable<TamasHa> result = db.TamasHas;
            if (!string.IsNullOrEmpty(Filter))
            {
                result = db.TamasHas.Where(t => t.Email.Contains(Filter) ||
                                                t.Phone.Contains(Filter) ||
                                                t.name.Contains(Filter) ||
                                                t.Massage.Contains(Filter));
            }

            var take = 20;
            var skip = (pageid - 1) * take;
            TamashaViewModel list = new TamashaViewModel();
            list.CurrentPage = pageid;
            list.PageCount = result.Count() / take;
            list.TamasHas = result.OrderBy(t => t.UserId).Skip(skip).Take(take).ToList();
            return list;
        }

        public TamasHa GetInfoTamas(int tamasid)
        {
            return db.TamasHas.Single(t => t.TamasId == tamasid);
        }


        public void DeleteTamas(int tamasid)
        {
            TamasHa tamas = db.TamasHas.Find(tamasid);
            db.TamasHas.Remove(tamas);
            db.SaveChanges();
        }

        public RezomeHaViewModel GetAllRezome(int pageid = 1, string Filter = "")
        {
            IQueryable<Rezome> result = db.Rezomes;
            if (!string.IsNullOrEmpty(Filter))
            {
                result = db.Rezomes.Where(t => t.RezomeTitle.Contains(Filter) ||
                                               t.Description.Contains(Filter));
            }

            var take = 20;
            var skip = (pageid - 1) * take;
            RezomeHaViewModel list = new RezomeHaViewModel();
            list.CurrentPage = pageid;
            list.PageCount = result.Count() / take;
            list.Rezomes = result.OrderBy(t => t.UserId).Skip(skip).Take(take).ToList();
            return list;
        }

        public List<Vaziyat> GetVaziyats()
        {
            return db.Vaziyats.ToList();
        }


        public void CreateRezome(Rezome rezome, IFormFile ImgRezome)
        {
            if (ImgRezome != null && ImgRezome.IsImage())
            {
                rezome.RezomeImage = NameGenerator.GenerateUniqCode() + Path.GetExtension(ImgRezome.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Site/img/",
                    rezome.RezomeImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    ImgRezome.CopyTo(stream);
                }
            }

            db.Rezomes.Add(rezome);
            db.SaveChanges();

        }

        public Rezome GetInfoRezome(int rezomeid)
        {
            return db.Rezomes.Single(r => r.RezomeId == rezomeid);
        }

        public void UpdateRezome(Rezome rezome, IFormFile ImgRezome)
        {
            if (ImgRezome != null && ImgRezome.IsImage())
            {
                if (rezome.RezomeImage != null)
                {

                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Site/img/",
                        rezome.RezomeImage);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }


                }

                rezome.RezomeImage = NameGenerator.GenerateUniqCode() + Path.GetExtension(ImgRezome.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Site/img/",
                    rezome.RezomeImage);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    ImgRezome.CopyTo(stream);
                }
            }

            db.Rezomes.Update(rezome);
            db.SaveChanges();
        }

        public void DeleteRezome(int rezomeid)
        {

            Rezome rezome = db.Rezomes.SingleOrDefault(r => r.RezomeId == rezomeid);
            Rezomedetail detail = db.Rezomedetails.FirstOrDefault(d => d.RezomeId == rezome.RezomeId);
            List<Rezomedetail> details = db.Rezomedetails.Where(d => d.RezomeId == rezome.RezomeId).ToList();

            RezomeTecs tecs = db.RezomeTecses.FirstOrDefault(d => d.RezomeId == rezome.RezomeId);
            List<RezomeTecs> tecses = db.RezomeTecses.Where(d => d.RezomeId == rezome.RezomeId).ToList();

            Gallery gallery = db.Galleries.FirstOrDefault(d => d.RezomeId == rezome.RezomeId);
            List<Gallery> galleries = db.Galleries.Where(d => d.RezomeId == rezome.RezomeId).ToList();


            foreach (var d in details)
            {
                db.Rezomedetails.Remove(detail);
                db.SaveChanges();
            }

            foreach (var t in tecses)
            {
                db.RezomeTecses.Remove(tecs);
                db.SaveChanges();
            }

            foreach (var g in galleries)
            {
                db.Galleries.Remove(gallery);
                db.SaveChanges();
            }

            db.Rezomes.Remove(rezome);
            db.SaveChanges();
        }

        public DetailViewModel GetAllRezomeDetails(int rezomeid, int pageid = 1, string Filter = "")
        {
            IQueryable<Rezomedetail> result = db.Rezomedetails;
            if (!string.IsNullOrEmpty(Filter))
            {
                result = db.Rezomedetails.Where(t => t.DetailCaption.Contains(Filter) ||
                                                     t.DetailValue.Contains(Filter));
            }

            var take = 20;
            var skip = (pageid - 1) * take;
            DetailViewModel list = new DetailViewModel();
            list.CurrentPage = pageid;
            list.PageCount = result.Count() / take;
            list.Rezomedetails = result.Where(d => d.RezomeId == rezomeid).OrderBy(t => t.DetailId).Skip(skip)
                .Take(take).ToList();
            return list;
        }

        public void CreateRezomedetail(Rezomedetail rezomedetail)
        {
            db.Rezomedetails.Add(rezomedetail);
            db.SaveChanges();
        }

        public Rezomedetail GetInfoRezomedetail(int detailid)
        {
            return db.Rezomedetails.Single(d => d.DetailId == detailid);
        }

        public void EditRezomedetail(Rezomedetail rezomedetail)
        {
            db.Rezomedetails.Update(rezomedetail);
            db.SaveChanges();
        }

        public void DeleteRezomedetail(int detailid)
        {
            Rezomedetail detail = db.Rezomedetails.Find(detailid);
            db.Rezomedetails.Remove(detail);
            db.SaveChanges();
        }

        public void savechange()
        {
            db.SaveChanges();
        }

        public TechnologiViewModel GetAllTechnologi(int rezomeid, int pageid = 1, string Filter = "")
        {
            IQueryable<RezomeTecs> result = db.RezomeTecses;
            if (!string.IsNullOrEmpty(Filter))
            {
                result = db.RezomeTecses.Where(t => t.TecTitle.Contains(Filter));
            }

            var take = 20;
            var skip = (pageid - 1) * take;
            TechnologiViewModel list = new TechnologiViewModel();
            list.CurrentPage = pageid;
            list.PageCount = result.Count() / take;
            list.RezomeTecses = result.Where(d => d.RezomeId == rezomeid).OrderBy(t => t.RTId).Skip(skip).Take(take)
                .ToList();
            return list;
        }

        public void CreateTechnologi(RezomeTecs rezomeTecs)
        {
            db.RezomeTecses.Add(rezomeTecs);
            db.SaveChanges();
        }

        public RezomeTecs GetInfoTechnologi(int techid)
        {
            return db.RezomeTecses.Single(d => d.RTId == techid);
        }

        public void EditTechnologi(RezomeTecs rezomeTecs)
        {
            db.RezomeTecses.Update(rezomeTecs);
            db.SaveChanges();
        }

        public void DeleteTechnologi(int techid)
        {
            RezomeTecs rezomeTecs = db.RezomeTecses.Find(techid);
            db.RezomeTecses.Remove(rezomeTecs);
            db.SaveChanges();
        }

        public RGallaryViewModel GetAllGallery(int rezomeid, int pageid = 1, string Filter = "")
        {
            IQueryable<Gallery> result = db.Galleries;
            if (!string.IsNullOrEmpty(Filter))
            {
                result = db.Galleries.Where(t => t.Gallerytitle.Contains(Filter));
            }

            var take = 20;
            var skip = (pageid - 1) * take;
            RGallaryViewModel list = new RGallaryViewModel();
            list.CurrentPage = pageid;
            list.PageCount = result.Count() / take;
            list.Gallery = result.Where(d => d.RezomeId == rezomeid).OrderBy(t => t.GalleryId).Skip(skip).Take(take)
                .ToList();
            return list;
        }

        public void CreateGallery(Gallery gallery, IFormFile ImgGallery)
        {
            if (ImgGallery != null && ImgGallery.IsImage())
            {
                gallery.Image = NameGenerator.GenerateUniqCode() + Path.GetExtension(ImgGallery.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Site/img/", gallery.Image);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    ImgGallery.CopyTo(stream);
                }
            }

            db.Galleries.Add(gallery);
            db.SaveChanges();
        }

        public Gallery GetInfoGallery(int gid)
        {
            return db.Galleries.Single(g => g.GalleryId == gid);
        }

        public void EditGallery(Gallery gallery, IFormFile ImgGallery)
        {
            if (ImgGallery != null && ImgGallery.IsImage())
            {
                if (gallery.Image != null)
                {

                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Site/img/",
                        gallery.Image);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }


                }

                gallery.Image = NameGenerator.GenerateUniqCode() + Path.GetExtension(ImgGallery.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Site/img/", gallery.Image);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    ImgGallery.CopyTo(stream);
                }
            }

            db.Galleries.Update(gallery);
            db.SaveChanges();
        }

        public void DeleteGallery(int gid)
        {
            Gallery gallery = db.Galleries.Find(gid);
            if (gallery.Image != null)
            {
                string deleteimagePath =
                    Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Site/img/", gallery.Image);
                if (File.Exists(deleteimagePath))
                {
                    File.Delete(deleteimagePath);
                }
            }

            db.Galleries.Remove(gallery);
            db.SaveChanges();
        }

        public About Getinfo(string username)
        {
            return db.Abouts.Single(a => a.UserName == username);
        }

        public int GetUserIdByUsername(string username)
        {
            return db.Abouts.Where(a => a.UserName == username).Select(a => a.UserId).Single();
        }

        public void UpdateEmail(About about)
        {
            db.Abouts.Update(about);
            db.SaveChanges();
        }

        public bool isexistUser(string oldpass)
        {
            string hashpass = PasswordHelper.EncodePasswordMd5(oldpass);
            About About = db.Abouts.Single(a => a.Password == hashpass);
            if (About != null)
            {
                return true;
            }

            return false;
        }

        public void UpdataPassword(string username, string password)
        {
            string hashpass = PasswordHelper.EncodePasswordMd5(password);
            About about = Getinfo(username);
            about.Password = hashpass;
            db.Abouts.Update(about);
            db.SaveChanges();
        }

        public SocViewModel GetAllSocials(int pageid = 1, string Filter = "")
        {
            IQueryable<Social> result = db.Socials;
            if (!string.IsNullOrEmpty(Filter))
            {
                result = db.Socials.Where(t => t.SocialName.Contains(Filter));
            }

            var take = 20;
            var skip = (pageid - 1) * take;
            SocViewModel list = new SocViewModel();
            list.CurrentPage = pageid;
            list.pagaCount = result.Count() / take;
            list.Socials = result.OrderBy(t => t.SociaId).Skip(skip).Take(take)
                .ToList();
            return list;
        }

        public void CreateSocial(Social social)
        {
            db.Socials.Add(social);
            db.SaveChanges();
        }

        public Social GetInfoSocial(int socialid)
        {
            return db.Socials.Single(s => s.SociaId == socialid);
        }

        public void EditSocial(Social social)
        {
            db.Socials.Update(social);
            db.SaveChanges();
        }

        public void DeleteSocial(int socialid)
        {
            Social social = db.Socials.Find(socialid);
            db.Socials.Remove(social);
            db.SaveChanges();

        }

        public string GetNameOfSite(int id)
        {
            return db.Settings.Where(s => s.SettingId == id).Select(s => s.SiteName).Single();
        }

        public string GetIcon(int id)
        {
            return db.Settings.Where(s => s.SettingId == id).Select(s => s.SiteIcon).Single();
        }

        public bool IsActiveSite(int id)
        {
            Setting setting = db.Settings.Single(s => s.SettingId == id);

            if (setting.SiteIsActive =="True")
            {
                return true;
            }

            return false;
        }

        public string GetMassagw(int id)
        {
            return db.Settings.Where(s => s.SettingId == id).Select(s => s.NotActiveMassage).Single();
        }

        public Setting GetSetting(int id)
        {
            return db.Settings.Single(s => s.SettingId == id);
        }

        public void UpdateSetting(Setting setting)
        {
            db.Settings.Update(setting);
            db.SaveChanges();
        }
    }
}
