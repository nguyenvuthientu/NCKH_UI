namespace UI_projNCKH.Areas.Diary.Models
{
    public class PostDiaryModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}