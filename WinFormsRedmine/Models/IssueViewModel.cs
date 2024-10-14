namespace WinFormsRedmine.Models
{
    public sealed class IssueViewModel
    {
        public string Id { get; set; }

        public string? TrackerName { get; set; }

        public string? Subject { get; set; }

        public string? StatusName { get; set; }

        public string? AssignedName { get; set; }

        public string? FixedVersion { get; set; }

        public string? Description { get; set; }

        public string? SprintTeamName { get; set; }

        public string? TargetVersion { get; set; }

        public IssueViewModel(Issue issue)
        {
            this.Id = "#" + issue.Id;
            this.TrackerName = issue.Tracker?.Name;
            this.Subject = issue.Subject;
            this.StatusName = issue.Status?.Name;
            this.AssignedName = issue.AssignedTo?.Name;
            this.FixedVersion = issue.FixedVersion?.Name;
            this.Description = issue.Description;

            this.SprintTeamName = issue?.CustomFields?.Where(x => x.Name == "スプリントチーム").FirstOrDefault()?.Value;
            this.TargetVersion = issue?.CustomFields?.Where(x => x.Name == "対象バージョン").FirstOrDefault()?.Value;
        }
    }
}
