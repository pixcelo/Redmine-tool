namespace WinFormsRedmine.Models
{
    public sealed class IssueRequest
    {
        /// <summary>
        /// ID
        /// </summary>
        public string? TicketId { get; set; }

        /// <summary>
        /// ステータスID
        /// </summary>
        public string? TicketStatusId { get; set; }

        /// <summary>
        /// 担当者
        /// </summary>
        public string? AssignedTo { get; set; }
    }
}
