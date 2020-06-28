using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ShetaPersonal.Core.DTO;
using ShetaPersonal.Core.Serevices.Interface;
using ShetaPersonal.Data.Model.Context;
using ShetaPersonal.Data.Model.Entities;

namespace ShetaPersonal.Core.Serevices
{
    public class Service : IService
    {
        private DatabaseContext db;

        public Service(DatabaseContext db)
        {
            this.db = db;
        }

        public AboutViewModel GetAboutMe(int userid)
        {
            About about = db.Abouts.Find(userid);
            AboutViewModel aboutview = new AboutViewModel()
            {
                FName = about.FName,
                LName = about.LName,
                FNameEN = about.FNameEN,
                LNameEN = about.LNameEN,
                Profile = about.Profile,
                birthday = about.BirthDay,
                AboutMe = about.AboutMe
            };

            return aboutview;
        }

        public List<Sabeghe> GetSabeghe(int userid)
        {
            List<Sabeghe> sabeghes = db.Sabeghes.Where(s => s.UserId == userid).ToList();
            return sabeghes;
        }

        public List<Tahsilat> GetTahsilats(int userid)
        {
            List<Tahsilat> tahsilats = db.Tahsilats.Where(s => s.UserId == userid).ToList();
            return tahsilats;
        }

        public MaharatViewModel GetMaharatAndDanesh(int userid)
        {
            List<Maharat> maharats = db.Maharats.Where(m => m.UserId == userid).ToList();
            List<Danesh> daneshes = db.Daneshes.Where(d => d.UserId == userid).ToList();
            MaharatViewModel list = new MaharatViewModel()
            {
                maharats = maharats,
                Daneshes = daneshes
            };
            return list;
        }

        public RezomeViewModel GetAllRezome(int userid)
        {
            Rezome rezome = db.Rezomes.FirstOrDefault(r => r.UserId == userid);
            List<Rezome> rezomeha = db.Rezomes.Where(r => r.UserId == userid).ToList();
            List<RezomeTecs> tecnolos = db.RezomeTecses.ToList();




            RezomeViewModel list = new RezomeViewModel()
            {
                Rezomes = rezomeha,
                RezomeTecses = tecnolos,
                vaziyatId = 1,
                vaziyat ="nv"
            };
            return list;
        }

        public Vaziyat GetVaziyatTitle(int vaziyatid)
        {
            return db.Vaziyats.Single(v => v.VaziyatId == vaziyatid);
        }

        public void CreateTamas(TamasHa tamas)
        {
            db.TamasHas.Add(tamas);
            db.SaveChanges();
        }

        public TamasViewModel GetTamas(int userid)
        {
            About about = db.Abouts.Find(userid);
            List<Social> socials = db.Socials.Where(s => s.UserId == userid).ToList();
            TamasViewModel list=new TamasViewModel()
            {
                MyPhone = about.PhoneNumber,
                MyEmail = about.Email,
                Socials = socials
            };
            return list;
        }

        public string getVaziyatByvaziyatId(int id)
        {
            return db.Vaziyats.Where(v => v.VaziyatId == id).Select(v => v.Title).Single();
        }

        public ShoewRezomeViewModel GetRezomeInformation(int rezomeid)
        {
            Rezome rezome = db.Rezomes.SingleOrDefault(r => r.RezomeId == rezomeid);
            List<Rezomedetail> rezomedetails = db.Rezomedetails.Where(r => r.RezomeId == rezomeid).ToList();
            List<Gallery> galleries = db.Galleries.Where(r => r.RezomeId == rezomeid).ToList();
            ShoewRezomeViewModel list=new ShoewRezomeViewModel()
            {
                Rezome = rezome,
                Rezomedetails = rezomedetails,
                Galleries = galleries
            };
            return list;
        }
    }
}
