using System;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars;
using DevExpress.Utils;

using Microsoft.Practices.CompositeUI.UIElements;
using Microsoft.Practices.CompositeUI.Utility;

namespace DevExpress.CompositeUI.UIElements
{
    /// <summary>
    /// An adapter that wraps a <see cref="Bars"/> for use as an <see cref="IUIElementAdapter"/>.
    /// </summary>
    public class RibbonStatusBarUIAdapter : UIElementAdapter<BarItem>
    {
        private RibbonStatusBar ribbonStatusBar;

        /// <summary>
        /// Initializes a new instance of the <see cref="BarsUIAdapter"/> class.
        /// </summary>
        /// <param name="bars"></param>
        public RibbonStatusBarUIAdapter(RibbonStatusBar RibbonStatusBar)
        {
            Guard.ArgumentNotNull(RibbonStatusBar, "RibbonStatusBar");
            ribbonStatusBar = RibbonStatusBar;
        }

        /// <summary>
        /// See <see cref="UIElementAdapter{TUIElement}.Add(TUIElement)"/> for more information.
        /// </summary>
        protected override BarItem Add(BarItem uiElement)
        {
            if (uiElement == null)
                throw new InvalidOperationException();

            ribbonStatusBar.Ribbon.Items.Add(uiElement);
            ribbonStatusBar.ItemLinks.Add(uiElement);
            return uiElement;
        }

        /// <summary>
        /// See <see cref="UIElementAdapter{TUIElement}.Remove(TUIElement)"/> for more information.
        /// </summary>
        protected override void Remove(BarItem uiElement)
        {
            if (ribbonStatusBar.Ribbon != null)
                ribbonStatusBar.Ribbon.Items.Remove(uiElement);
        }

        /// <summary>
        /// When overridden in a derived class, returns the correct index for the item being added. By default,
        /// it will return the length of the Status Items.
        /// </summary>
        /// <param name="uiElement"></param>
        /// <returns></returns>
        protected virtual int GetInsertingIndex(object uiElement)
        {
            return ribbonStatusBar.ItemLinks.Count;
        }

        /// <summary>
        /// Returns the internal RibbonStatusBar links mananged by the <see cref="RibbonStatusBarUIAdapter"/>
        /// </summary>
        protected BarItemLinkCollection InternalCollection
        {
            get
            {
                return ribbonStatusBar.ItemLinks;
            }
            set
            {
                //ribbonStatusBar.ItemLinks = value; }
            }
        }
    }
}