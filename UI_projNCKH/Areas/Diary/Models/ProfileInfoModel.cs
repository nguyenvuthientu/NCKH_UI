namespace UI_projNCKH.Areas.Diary.Models
{
    public class ProfileInfoModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}