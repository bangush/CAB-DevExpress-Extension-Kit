using Microsoft.Practices.CompositeUI.UIElements;
using Microsoft.Practices.CompositeUI.Utility;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.CompositeUI.UIElements
{
    /// <summary>
    /// A <see cref="IUIElementAdapterFactory"/> that produces adapters for XtraNavBar-related UI Elements.
    /// </summary>
    public class EditorButtonCollectionUIAdapterFactory : IUIElementAdapterFactory
    {
        /// <summary>
        /// Returns a <see cref="IUIElementAdapter"/> for the specified uielement.
        /// </summary>
        /// <param name="uiElement">uiElement for which to return a <see cref="IUIElementAdapter"/></param>
        /// <returns>A <see cref="IUIElementAdapter"/> that represents the specified element</returns>
        public IUIElementAdapter GetAdapter(object uiElement)
        {
            Guard.ArgumentNotNull(uiElement, "uiElement");

            if (uiElement is EditorButtonCollection)
                return new EditorButtonCollectionUIAdapter((EditorButtonCollection)uiElement);
            
            throw ExceptionFactory.CreateInvalidAdapterElementType(uiElement.GetType(), GetType());
        }

        /// <summary>
        /// Indicates if the specified ui element is supported by the adapter factory.
        /// </summary>
        /// <param name="uiElement">UI Element to evaluate</param>
        /// <returns>Returns true for supported elements, otherwise returns false.</returns>
        public bool Supports(object uiElement)
        {
            return uiElement is EditorButtonCollection;
        }
    }
}