﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace ShetaPersonal.Core.Security
{
    public static class ImgValidator
    {
        public static bool IsImage(this IFormFile file)
        {
            try
            {
                var img = System.Drawing.Image.FromStream(file.OpenReadStream());
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
