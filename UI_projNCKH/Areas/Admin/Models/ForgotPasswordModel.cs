namespace UI_projNCKH.Areas.Admin.Models
{
    public class ForgotPasswordModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}