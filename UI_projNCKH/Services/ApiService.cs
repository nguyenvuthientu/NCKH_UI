using UI_projNCKH.Models;

namespace UI_projNCKH.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient httpClient;

        public ApiService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public List<SysRolesModel> GetRoleListApi()
        {
            return SampleData.roleList;
        }
    }
}
