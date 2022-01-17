using Microsoft.Extensions.Configuration;
using System.Collections.Generic;

namespace ClassLibrary
{
    public class Addition : IAddition
    {
        private readonly IConfiguration _configuration;
        public Addition(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public int DoSum(int a, int b) => a + b;

        public List<string> JsonReposStaticValues()
        {
            var readme = _configuration.GetSection("readme");
            var apiKey = readme.GetSection("apiKey").Value;

            var userId = readme.GetSection("group").GetSection("apiKey").Value;
            var userName = readme.GetSection("group").GetSection("label").Value;
            var userEmail = readme.GetSection("group").GetSection("email").Value;

            var options = readme.GetSection("options");
            var allowList = options.GetSection("allowList").Value;
            var denyList = options.GetSection("denyList");
            foreach (IConfigurationSection section in denyList.GetChildren())
            {
                var denyKeyword = section.Value;
            }
            bool development = bool.Parse(options.GetSection("development").Value);
            int bufferLength = int.Parse(options.GetSection("bufferLength").Value);
            var baseLogUrl = options.GetSection("baseLogUrl").Value;

            return new List<string>{ 
                apiKey,
                userId,
                userName,
                userEmail,
                allowList,
                denyList.ToString(),
                development.ToString(),
                bufferLength.ToString(),
                baseLogUrl
            };
        }
    }
}
