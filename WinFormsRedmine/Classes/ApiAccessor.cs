using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using WinFormsRedmine.Models;

namespace WinFormsRedmine.Classes
{
    /// <summary>
    /// APIアクセサ
    /// </summary>
    public interface IApiAccessor
    {
        /// <summary>
        /// イシュー一覧を取得する
        /// </summary>
        /// <param name="issueRequest"></param>
        /// <see href="https://www.redmine.org/projects/redmine/wiki/Rest_api#google_vignette"/>
        /// <returns></returns>
        Task<List<Issue>> FetchIssues(IssueRequest issueRequest);

        /// <summary>
        /// イシューを取得する
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Issue?> FetchIssue(string id);
    }
    
    public sealed class ApiAccessor : IApiAccessor
    {        
        private static readonly HttpClient httpClient = new HttpClient();
        private readonly string? baseUrl;
        private readonly string? apiKey;

        public ApiAccessor()
        {
            var configurationRoot = new ConfigurationBuilder()
                .AddUserSecrets("e397cc54-ecd1-4af6-953c-c638a5aa028b")
                .Build();

            this.baseUrl = configurationRoot["BaseUrl"];
            this.apiKey = configurationRoot["ApiKey"];
        }

        /// <remarks>
        /// <see href="https://www.redmine.org/projects/redmine/wiki/Rest_Issues"/>
        /// </remarks>
        public async Task<List<Issue>> FetchIssues(IssueRequest issueRequest)
        {
            var url = $"{this.baseUrl}/redmine/issues.json";
            var requestUrl = $"{url}?assigned_to_id=me";
            if (issueRequest.TicketStatusId != "0")
            {
                requestUrl += "&status_id=" + issueRequest.TicketStatusId;
            }
            requestUrl += $"&key={ this.apiKey}";

            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var issueResponse = JsonConvert.DeserializeObject<IssueResponse>(responseBody);
            return issueResponse?.Issues;
        }

        public async Task<Issue?> FetchIssue(string id)
        {
            var url = $"{this.baseUrl}/redmine/issues/{id}.json";
            var requestUrl = $"{url}?assigned_to_id=me&key={apiKey}";

            HttpResponseMessage response = await httpClient.GetAsync(requestUrl);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();

            var issueResponse = JsonConvert.DeserializeObject<IssueResponseSingle>(responseBody);
            return issueResponse?.Issue;
        }

    }
}
