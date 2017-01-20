




using System.Web.Http;

namespace WebHooks
{
    public static class WebHookConfig
    {
        public static void Register(HttpConfiguration config)
        {

			config.InitializeReceiveSlackWebHooks();
            config.InitializeReceiveGitHubWebHooks();

        }
    }
}
