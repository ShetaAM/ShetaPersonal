using System;
using System.Collections.Generic;
using System.Text;
using ShetaPersonal.Core.DTO;
using ShetaPersonal.Data.Model.Entities;

namespace ShetaPersonal.Core.Serevices.Interface
{
    public interface IService
    {
        AboutViewModel GetAboutMe(int userid);
        List<Sabeghe> GetSabeghe(int userid);
        List<Tahsilat> GetTahsilats(int userid);
        MaharatViewModel GetMaharatAndDanesh(int userid);

        RezomeViewModel GetAllRezome(int userid);

        Vaziyat GetVaziyatTitle(int vaziyatid);
        void CreateTamas(TamasHa tamas);

        TamasViewModel GetTamas(int userid);

        String getVaziyatByvaziyatId(int id);

        ShoewRezomeViewModel GetRezomeInformation(int rezomeid);
    }
}
