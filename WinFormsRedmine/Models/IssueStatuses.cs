namespace WinFormsRedmine.Models
{
    public class IssueStatuses
    {
        public List<IssueStatus> List { get; set; }

        public IssueStatuses()
        {
            this.List = new List<IssueStatus>()
            {
                new IssueStatus() { Id = 0, Name = "" },
                new IssueStatus() { Id = 1, Name = "New" },
                new IssueStatus() { Id = 12, Name = "Assigned" },
                new IssueStatus() { Id = 9, Name = "Developing" },
                new IssueStatus() { Id = 7, Name = "Resolved" },
                new IssueStatus() { Id = 5, Name = "Closed" },
                new IssueStatus() { Id = 14, Name = "Pending" },
                new IssueStatus() { Id = 10, Name = "#Checked" },
                new IssueStatus() { Id = 13, Name = "Approved" },
            };
        }
    }

    public class IssueStatus
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
