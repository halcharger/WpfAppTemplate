﻿// (c) Copyright Microsoft Corporation.
// This source is subject to the Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993] for details.
// All other rights reserved.

namespace WpfAppTemplate.Controls.AutoCompleteBox
{
    /// <summary>
    /// Represents methods that handle various routed events that track property
    /// values changing.  Typically the events denote a cancellable action.
    /// </summary>
    /// <typeparam name="T">
    /// The type of the value for the dependency property that is changing.
    /// </typeparam>
    /// <param name="sender">
    /// The object where the initiating property is changing.
    /// </param>
    /// <param name="e">Event data for the event.</param>
    /// <QualityBand>Preview</QualityBand>
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances", Justification = "To match pattern of RoutedPropertyChangedEventHandler<T>")]
    public delegate void RoutedPropertyChangingEventHandler<T>(object sender, RoutedPropertyChangingEventArgs<T> e);
}