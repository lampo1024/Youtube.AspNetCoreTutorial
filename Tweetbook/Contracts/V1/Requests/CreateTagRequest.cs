using System.ComponentModel.DataAnnotations;

namespace Tweetbook.Contracts.V1.Requests
{
    public class CreateTagRequest
    {
        public string TagName { get; set; }
    }
}