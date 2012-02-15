﻿// -----------------------------------------------------------------------
// <copyright file="HeaderControl.cs" company="DotSpatial Team">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Reflection;

namespace DotSpatial.Controls.Header
{
    /// <summary>
    /// HeaderControl which takes care of implementing RemoveItems.
    /// </summary>
    public abstract class HeaderControl : IHeaderControl
    {
        /// <summary>
        /// The key of the home root item.
        /// </summary>
        public const string HomeRootItemKey = "kHome";

        /// <summary>
        /// The key of the Application Menu item.
        /// </summary>
        public const string ApplicationMenuKey = "kApplicationMenu";

        /// <summary>
        /// Used as the group caption for icons that should appear near the ribbon
        /// maximize/minimize chevron.
        /// </summary>
        public const string HeaderHelpItemKey = "kHeaderHelpItemKey";

        /// <summary>
        /// A key to use for the root container of any extensions that do not provider a root key.
        /// </summary>
        protected const string ExtensionsRootKey = "kExtensions";
        readonly Dictionary<string, string> _items = new Dictionary<string, string>();

        #region IHeaderControl Members

        /// <summary>
        /// Removes all items the plugin created by calling Remove() individually for each.
        /// </summary>
        /// <remarks>Should only be called by the plugin (from the plugin assembly).</remarks>
        public virtual void RemoveAll()
        {
            string assemblyName = Assembly.GetCallingAssembly().FullName;
            // create a copy of the enumeration so that we can remove items from the original collection.
            var toRemove = _items.Where(i => i.Value == assemblyName).ToArray();
            foreach (var item in toRemove)
            {
                this.Remove(item.Key);
            }
        }

        /// <summary>
        /// This will add a new item that will appear on the standard toolbar or ribbon control.
        /// </summary>
        /// <remarks>Should only be called by the plugin (from the plugin assembly).</remarks>
        public virtual void Add(HeaderItem item)
        {
            Contract.Requires(item != null, "item is null.");

            string assemblyName = Assembly.GetCallingAssembly().FullName;

            if (_items.ContainsKey(item.Key))
                throw new ArgumentException(String.Format("The key \"{0}\" was already added by {1}. The key may only be used by one HeaderItem.", item.Key, assemblyName));

            RecordItemAdd(item.Key, assemblyName);

            // Bypass static type checking until runtime.
            dynamic test = item;
            // The correct overload of Add will be called below as the specifc type of item is determined at runtime.
            // See http://msdn.microsoft.com/en-us/library/dd264736.aspx
            Add(test);
        }

        /// <summary>
        /// Remove item from the standard toolbar or ribbon control. Also removes groups or parents when all
        /// items have been removed from them.
        /// </summary>
        /// <param name="key">The string itemName to remove from the standard toolbar or ribbon control</param>
        /// <remarks>
        /// If passed a root item the behavior is not defined. The root item should never be empty because
        /// it will be removed when all of its child items are removed.
        /// </remarks>
        public virtual void Remove(string key)
        {
            _items.Remove(key);
        }

        /// <summary>
        /// Selects the root, making it the active root.
        /// </summary>
        /// <param name="key">The key.</param>
        public abstract void SelectRoot(string key);

        /// <summary>
        /// Occurs when a root item is selected
        /// </summary>
        public event EventHandler<RootItemEventArgs> RootItemSelected;

        #endregion

        /// <summary>
        /// Adds the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        public abstract void Add(SimpleActionItem item);

        /// <summary>
        /// Adds the menu container item.
        /// </summary>
        /// <param name="item">The item.</param>
        public abstract void Add(MenuContainerItem item);

        /// <summary>
        /// Adds the specified root item.
        /// </summary>
        /// <param name="item">The root item.</param>
        /// <remarks>The RootItem should not be visible until it contains other items.</remarks>
        public abstract void Add(RootItem item);

        /// <summary>
        /// Adds a combo box style item
        /// </summary>
        /// <param name="item">The item.</param>
        public abstract void Add(DropDownActionItem item);

        /// <summary>
        /// Adds a visible separator.
        /// </summary>
        /// <param name="item">The item.</param>
        public abstract void Add(SeparatorItem item);

        /// <summary>
        /// Adds the specified textbox item.
        /// </summary>
        /// <param name="item">The item.</param>
        public abstract void Add(TextEntryActionItem item);

        /// <summary>
        /// Adds the item to dictionary so that it can be removed later.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="assemblyFullName">Full name of the assembly.</param>
        protected void RecordItemAdd(string key, string assemblyFullName)
        {
            Contract.Requires(!String.IsNullOrEmpty(assemblyFullName), "assemblyFullName is null or empty.");
            Contract.Requires(!String.IsNullOrEmpty(key), "key is null or empty.");

            _items.Add(key, assemblyFullName);
        }

        /// <summary>
        /// Occurs when a root item is selected by the user.
        /// This event also occurs after the SelectRoot method is called.
        /// </summary>
        /// <param name="key">The key of the new selected root item</param>
        protected void OnRootItemSelected(string key)
        {
            if (RootItemSelected != null)
                RootItemSelected(this, new RootItemEventArgs(key));
        }
    }
}