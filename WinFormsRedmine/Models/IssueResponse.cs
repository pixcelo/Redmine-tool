using Newtonsoft.Json;

namespace WinFormsRedmine.Models
{
    /// <summary>
    /// イシューレスポンス
    /// </summary>
    public sealed class IssueResponse
    {
        public List<Issue>? Issues { get; set; }
    }

    /// <summary>
    /// イシューレスポンス（単体）
    /// </summary>
    public sealed class IssueResponseSingle
    {
        public Issue? Issue { get; set; }
    }

    /// <summary>
    /// イシュー
    /// </summary>
    public class Issue
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// プロジェクト
        /// </summary>
        public Project? Project { get; set; }

        /// <summary>
        /// トラッカー
        /// </summary>
        public Tracker? Tracker { get; set; }

        /// <summary>
        /// ステータス
        /// </summary>
        public Status? Status { get; set; }

        /// <summary>
        /// 優先度
        /// </summary>
        public Priority? Priority { get; set; }

        /// <summary>
        /// 作成者
        /// </summary>
        public Author? Author { get; set; }

        /// <summary>
        /// 担当者
        /// </summary>
        [JsonProperty(PropertyName = "assigned_to")]
        public AssignedTo? AssignedTo { get; set; }

        /// <summary>
        /// 対象バージョン
        /// </summary>
        [JsonProperty(PropertyName = "fixed_version")]
        public FixedVersion? FixedVersion { get; set; }

        /// <summary>
        /// 親チケット
        /// </summary>
        public Parent? Parent { get; set; }

        public string? Subject { get; set; }

        /// <summary>
        /// 説明
        /// </summary>
        public string? Description { get; set; }

        [JsonProperty(PropertyName = "start_date")]
        public string? StartDate { get; set; }

        /// <summary>
        /// 進捗率
        /// </summary>
        [JsonProperty(PropertyName = "done_ratio")]
        public int DoneRatio { get; set; }

        /// <summary>
        /// 予定工数
        /// </summary>
        [JsonProperty(PropertyName = "estimated_hours")]
        public string? EstimatedHours { get; set; }

        /// <summary>
        /// 作業時間
        /// </summary>
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