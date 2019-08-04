using Swashbuckle.AspNetCore.Filters;
using Tweetbook.Contracts.V1.Requests;

namespace Tweetbook.SwaggerExamples.Requests
{
    public class CreateTagRequestExample : IExamplesProvider<CreateTagRequest>
    {
        public CreateTagRequest GetExamples()
        {
            return new CreateTagRequest
            {
                TagName = "new tag"
            };
        }
    }
}