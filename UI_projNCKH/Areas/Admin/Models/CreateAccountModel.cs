namespace UI_projNCKH.Areas.Admin.Models
{
    public class CreateAccountModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}