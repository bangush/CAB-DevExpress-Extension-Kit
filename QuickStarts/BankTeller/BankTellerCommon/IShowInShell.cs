using Microsoft.Practices.CompositeUI.SmartParts;

namespace BankTellerCommon
{
	public interface IShowInShell
	{
		void Show(IWorkspace navbarWorkspace, IWorkspace content);
	}
}