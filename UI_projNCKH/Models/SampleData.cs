namespace UI_projNCKH.Models
{
    static class SampleData
    {
        public static List<SysRolesModel> roleList = new List<SysRolesModel>() {
            new SysRolesModel {
                RoleID = 1,
                Name = "Quản trị hệ thống",
                Code = "Admin"
            },
            new SysRolesModel {
                RoleID = 2,
                Name = "Tư vấn tài chính",
                Code = "AGC"
            },
            new SysRolesModel {
                RoleID = 3,
                Name = "Trưởng nhóm kinh doanh",
                Code = "Lead"
            }
        };
    }
}

