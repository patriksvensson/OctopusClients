using Octopus.Client;

namespace Octopus.Cli.Repositories
{
    class OctopusRepositoryFactory : IOctopusRepositoryFactory
    {
        public IOctopusRepository CreateRepository(OctopusServerEndpoint endpoint)
        {
            return new OctopusRepository(endpoint);
        }

        public IOctopusRepository CreateRepository(OctopusServerEndpoint endpoint, OctopusClientOptions options)
        {
            return new OctopusRepository(endpoint, options);
        }
    }
}