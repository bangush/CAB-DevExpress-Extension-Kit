using DevExpress.XtraBars.Ribbon;
using Microsoft.Practices.CompositeUI.UIElements;
using Microsoft.Practices.CompositeUI.Utility;

namespace DevExpress.CompositeUI.UIElements
{
    /// <summary>
    /// A <see cref="IUIElementAdapterFactory"/> that produces adapters for XtraBar-related UI Elements.
    /// </summary>
    public class XtraRibbonBarUIAdapterFactory : IUIElementAdapterFactory
    {
        /// <summary>
        /// Returns a <see cref="IUIElementAdapter"/> for the specified uielement.
        /// </summary>
        /// <param name="uiElement">uiElement for which to return a <see cref="IUIElementAdapter"/></param>
        /// <returns>A <see cref="IUIElementAdapter"/> that represents the specified element</returns>
        public IUIElementAdapter GetAdapter(object uiElement)
        {
            Guard.ArgumentNotNull(uiElement, "uiElement");

            if (uiElement is RibbonControl)
                return new RibbonPageCollectionUIAdapter(((RibbonControl)uiElement).Pages);

            if (uiElement is RibbonStatusBar)
                return new RibbonStatusBarUIAdapter(((RibbonStatusBar)uiElement));

            if (uiElement is RibbonPage)
                return new RibbonPageGroupCollectionUIAdapter(((RibbonPage)uiElement).Groups);

            if (uiElement is RibbonPageGroup)
                return new BarLinksCollectionUIAdapter(((RibbonPageGroup)uiElement).ItemLinks,
                    ((RibbonPageGroup)uiElement).Ribbon.Items);

            if (uiElement is BarItemWrapper)
                return
                        new BarLinksOwnerCollectionUIAdapter(((BarItemWrapper)uiElement).Item, ((BarItemWrapper)uiElement).ItemLinks);

            throw ExceptionFactory.CreateInvalidAdapterElementType(uiElement.GetType(), GetType());
        }

        /// <summary>
        /// Indicates if the specified ui element is supported by the adapter factory.
        /// </summary>
        /// <param name="uiElement">UI Element to evaluate</param>
        /// <returns>Returns true for supported elements, otherwise returns false.</returns>
        public bool Supports(object uiElement)
        {
            return
                uiElement is RibbonStatusBar ||
                uiElement is RibbonControl ||
                uiElement is BarItemWrapper ||
                uiElement is RibbonPage ||
                uiElement is RibbonPageGroup;
        }
    }
}