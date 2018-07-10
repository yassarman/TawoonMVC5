using Abp.AutoMapper;
using TaawonMVC.Sessions.Dto;

namespace TaawonMVC.Web.Models.Account
{
    [AutoMapFrom(typeof(GetCurrentLoginInformationsOutput))]
    public class TenantChangeViewModel
    {
        public TenantLoginInfoDto Tenant { get; set; }
    }
}