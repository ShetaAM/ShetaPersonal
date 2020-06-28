using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;
using ShetaPersonal.Core.DTO.Admin;
using ShetaPersonal.Data.Model.Entities;
using AboutViewModel = ShetaPersonal.Core.DTO.AboutViewModel;

namespace ShetaPersonal.Core.Serevices.Interface
{
    public interface IAdminService
    {
        About LoginUser(LoginViewModel login);

        #region ControlPanel

        int NumberOfRezome();
        int NumberOfMaharat();
        int NumberOfGallery();
        #endregion

        #region Tahsilat

        TahsilatViewModel GetAlltahsilat(int pageid = 1, string Filter = "");
        void CreateTahsilat(Tahsilat tahsilat);
        Tahsilat GetInfoTahsilatForedit(int tahsilid);
        void EditTahsilat(Tahsilat tahsilat);
        void DeteeTahsilat(int tahsilatid);

        #endregion

        #region Sabeghe

        SabegheViewModel GetAllTajrobiyat(int pageid = 1, string Filter = "");
        void CreateSabeghe(Sabeghe sabeghe);
        Sabeghe GetInfoSabeghe(int sabegheid);
        void EditSabeghe(Sabeghe sabeghe);
        void DeleteSabeghe(int sabegheid);

        #endregion

        #region About

        AboutMeViewModel GetAllAbout(int pageid = 1, string Filter = "");
        About GetInfoAbout(int aboutid);
        void UpdateAbout(About about, IFormFile ImgProfile);

        #endregion

        #region Maharat

        MaharathaViewModel GetAllMaharats(int pageid = 1, string Filter = "");
        void CreateMaharat(Maharat maharat);
        Maharat GetInfoMaharat(int maharatid);
        void EditMaharat(Maharat maharat);
        void DeleteMaharat(int maharatid);

        #endregion

        #region Danesh

        DaneshViewModel GetAllDanesh(int pageid = 1, string Filter = "");
        void CreateDanesh(Danesh danesh);
        Danesh GetInfoDanesh(int danesjid);
        void EditDanesh(Danesh danesh);
        void DeleteDanesh(int daneshid);

        #endregion

        #region Tamasha

        TamashaViewModel GetAllTamas(int pageid = 1, string Filter = "");
        TamasHa GetInfoTamas(int tamasid);
        void DeleteTamas(int tamasid);

        #endregion

        #region Rezome

        RezomeHaViewModel GetAllRezome(int pageid = 1, string Filter = "");

        List<Vaziyat> GetVaziyats();
        void CreateRezome(Rezome rezome, IFormFile ImgRezome);
        Rezome GetInfoRezome(int rezomeid);
        void UpdateRezome(Rezome rezome, IFormFile ImgRezome);
        void DeleteRezome(int rezomeid);

        #endregion

        #region Rezomedetail

        DetailViewModel GetAllRezomeDetails(int rezomeid, int pageid = 1, string Filter = "");
        void CreateRezomedetail(Rezomedetail rezomedetail);
        Rezomedetail GetInfoRezomedetail(int detailid);
        void EditRezomedetail(Rezomedetail rezomedetail);
        void DeleteRezomedetail(int detailid);
        void savechange();

        #endregion

        #region Technologi

        TechnologiViewModel GetAllTechnologi(int rezomeid, int pageid = 1, string Filter = "");
        void CreateTechnologi(RezomeTecs rezomeTecs);
        RezomeTecs GetInfoTechnologi(int techid);
        void EditTechnologi(RezomeTecs rezomeTecs);
        void DeleteTechnologi(int techid);

        #endregion


        #region Gallery

        RGallaryViewModel GetAllGallery(int rezomeid, int pageid = 1, string Filter = "");
        void CreateGallery(Gallery gallery, IFormFile ImgGallery);
        Gallery GetInfoGallery(int gid);
        void EditGallery(Gallery gallery, IFormFile ImgGallery);
        void DeleteGallery(int gid);

        #endregion


        #region Profile

        About Getinfo(string username);

        int GetUserIdByUsername(string username);
        void UpdateEmail(About about);


        bool isexistUser(string oldpass);
        void UpdataPassword(string username, string password);


        #endregion

        #region Socials

        SocViewModel GetAllSocials(int pageid = 1, string Filter = "");
        void CreateSocial(Social social);
        Social GetInfoSocial(int socialid);
        void EditSocial(Social social);
        void DeleteSocial(int socialid);

        #endregion

        #region Setting

        string GetNameOfSite(int id);
        string GetIcon(int id);
        bool IsActiveSite(int id);
        string GetMassagw(int id);

        Setting GetSetting(int id);
        void UpdateSetting(Setting setting);

        #endregion
    }
}
