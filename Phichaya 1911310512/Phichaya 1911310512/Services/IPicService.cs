using Phichaya_1911310512.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace Phichaya_1911310512.Services
{
    public interface IPicService
    {
        Task<PicDetail> getPic();  

    }
}
