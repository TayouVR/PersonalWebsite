using System.Text.RegularExpressions;
using Markdig;

namespace PersonalWebsite
{
    public static class MarkdownHelper
    {
        private static readonly MarkdownPipeline Pipeline = new MarkdownPipelineBuilder().UseAdvancedExtensions().Build();

        public static string ConvertMarkdown(string markdown)
        {
            if (string.IsNullOrEmpty(markdown)) return "";
            return Markdown.ToHtml(markdown, Pipeline);
        }

        public static string StripHtml(string input)
        {
            if (string.IsNullOrEmpty(input)) return "";
            return Regex.Replace(input, "<.*?>", string.Empty);
        }

        public static string GetRawGitHubUrl(string url)
        {
            if (string.IsNullOrEmpty(url)) return url;
            if (url.Contains("github.com") && url.Contains("/blob/"))
            {
                return url.Replace("github.com", "raw.githubusercontent.com").Replace("/blob/", "/");
            }
            return url;
        }
    }
}
