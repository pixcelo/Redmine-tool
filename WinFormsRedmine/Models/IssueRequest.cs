namespace WinFormsRedmine.Models
{
    public sealed class IssueRequest
    {
        /// <summary>
        /// ID
        /// </summary>
        public string? TicketId { get; set; }

        /// <summary>
        /// ステータス
        /// </summary>
        public string? TicketStatus { get; set; }

        /// <summary>
        /// 担当者
        /// </summary>
        public string? AssignedTo { get; set; }
    }
}
