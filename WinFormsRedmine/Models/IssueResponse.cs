using Newtonsoft.Json;

namespace WinFormsRedmine.Models
{
    public sealed class IssueResponse
    {
        public Issue? Issue { get; set; }
    }

    public class Issue
    {
        public int Id { get; set; }

        public Project? Project { get; set; }

        public Tracker? Tracker { get; set; }

        public Status? Status { get; set; }

        public Priority? Priority { get; set; }

        public Author? Author { get; set; }

        [JsonProperty(PropertyName = "assigned_to")]
        public AssignedTo? AssignedTo { get; set; }

        [JsonProperty(PropertyName = "fixed_version")]
        public FixedVersion? FixedVersion { get; set; }

        public Parent? Parent { get; set; }

        public string? Subject { get; set; }

        public string? Description { get; set; }

        [JsonProperty(PropertyName = "start_date")]
        public string? StartDate { get; set; }

        [JsonProperty(PropertyName = "done_ratio")]
        public int DoneRatio { get; set; }

        [JsonProperty(PropertyName = "estimated_hours")]
        public string? EstimatedHours { get; set; }

        [JsonProperty(PropertyName = "spent_hours")]
        public string? SpentHours { get; set; }

        [JsonProperty(PropertyName = "custom_fields")]
        public List<CustomField>? CustomFields { get; set; }

        [JsonProperty(PropertyName = "created_on")]
        public string? CreatedOn { get; set; }

        [JsonProperty(PropertyName = "updated_on")]
        public string? UpdatedOn { get; set; }
    }

    public class Project
    {
        public int Id { get; set; }

        public string? Name { get; set; }
    }

    public class Tracker
    {
        public int Id { get; set; }

        public string? Name { get; set; }
    }

    public class Status
    {
        public int Id { get; set; }

        public string? Name { get; set; }
    }

    public class Priority
    {
        public int Id { get; set; }

        public string? Name { get; set; }
    }

    public class Author
    {
        public int Id { get; set; }

        public string? Name { get; set; }
    }

    public class AssignedTo
    {
        public int Id { get; set; }

        public string? Name { get; set; }
    }

    public class FixedVersion
    {
        public int Id { get; set; }

        public string? Name { get; set; }
    }

    public class Parent
    {
        public int Id { get; set; }
    }

    public class CustomField
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Value { get; set; }
    }
}