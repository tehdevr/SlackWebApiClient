using System.Threading.Tasks;
using SlackWebApiClient.Blocks;
using SlackWebApiClient.Models;

namespace SlackWebApiClient.Interfaces.Methods
{
    public interface IViews
    {
		Task<ViewsOpenResponse> Open(
			string triggerID,
			ModalView modalView);
    }
}