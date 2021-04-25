using System.Threading.Tasks;

namespace Noneb.Ui.Runtime.Core.View
{
    public interface IViewRestoreHandler
    {
        Task OnViewRestore();
    }
}