// (c) Copyright Microsoft Corporation.
// This source is subject to the Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993] for details.
// All other rights reserved.

using System.Diagnostics.CodeAnalysis;

namespace WpfAppTemplate.Controls.AutoCompleteBox
{
    /// <summary>
    /// Represents the method that will handle the
    /// <see cref="E:EDF.MDM.UI.Common.Controls.AutoCompleteBox.AutoCompleteBox.Populating" />
    /// event of a <see cref="T:EDF.MDM.UI.Common.Controls.AutoCompleteBox.AutoCompleteBox" />
    /// control.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="e">A
    /// <see cref="T:EDF.MDM.UI.Common.Controls.AutoCompleteBox.PopulatingEventArgs" /> that
    /// contains the event data.</param>
    /// <QualityBand>Stable</QualityBand>
    [SuppressMessage("Microsoft.Design", "CA1003:UseGenericEventHandlerInstances", Justification = "There is no generic RoutedEventHandler.")]
    public delegate void PopulatingEventHandler(object sender, PopulatingEventArgs e);
}