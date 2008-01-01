using DevExpress.XtraNavBar;
using Microsoft.Practices.CompositeUI.UIElements;
using Microsoft.Practices.CompositeUI.Utility;

namespace CABDevExpress.Adapters
{
	/// <summary>
	/// An adapter that wraps a <see cref="NavGroupCollection"/> for use as an <see cref="IUIElementAdapter"/>.
	/// </summary>
	public class NavBarGroupCollectionUIAdapter : UIElementAdapter<NavBarGroup>
	{
		private readonly NavGroupCollection navGroupCollection;

		/// <summary>
		/// Initializes a new instance of the <see cref="NavBarGroupCollectionUIAdapter"/> class.
		/// </summary>
		/// <param name="collection"></param>
		public NavBarGroupCollectionUIAdapter(NavGroupCollection collection)
		{
			Guard.ArgumentNotNull(collection, "NavGroupCollection");
			navGroupCollection = collection;
		}

		/// <summary>
		/// See <see cref="UIElementAdapter{TUIElement}.Add(TUIElement)"/> for more information.
		/// </summary>
		protected override NavBarGroup Add(NavBarGroup uiElement)
		{
			navGroupCollection.Insert(GetInsertingIndex(uiElement), uiElement);
			return uiElement;
		}

		/// <summary>
		/// See <see cref="UIElementAdapter{TUIElement}.Remove(TUIElement)"/> for more information.
		/// </summary>
		protected override void Remove(NavBarGroup uiElement)
		{
			Guard.ArgumentNotNull(uiElement, "NavBarGroup");
			Guard.ArgumentNotNull(uiElement.NavBar, "NavBarGroup.NavBar");
			Guard.ArgumentNotNull(uiElement.NavBar.Groups, "NavBarGroup.NavBar.Groups");

			uiElement.NavBar.Groups.Remove(uiElement);
			//TODO I would like to know why this doesn't use navGroupCollection.Remove(uiElement);
		}

		/// <summary>
		/// When overridden in a derived class, returns the correct index for the item being added. By default,
		/// it will return the length of the navGroupCollection.
		/// </summary>
		/// <param name="uiElement"></param>
		/// <returns></returns>
		protected virtual int GetInsertingIndex(object uiElement)
		{
			return navGroupCollection.Count;
		}
	}
}