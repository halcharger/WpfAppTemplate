﻿// (c) Copyright Microsoft Corporation.
// This source is subject to the Microsoft Public License (Ms-PL).
// Please see http://go.microsoft.com/fwlink/?LinkID=131993] for details.
// All other rights reserved.

using System.Collections;
using System.Windows;

namespace WpfAppTemplate.Controls.AutoCompleteBox
{
    /// <summary>
    /// Provides data for the
    /// <see cref="E:EDF.MDM.UI.Common.Controls.AutoCompleteBox.AutoCompleteBox.Populated" />
    /// event.
    /// </summary>
    /// <QualityBand>Stable</QualityBand>
    public class PopulatedEventArgs : RoutedEventArgs
    {
        /// <summary>
        /// Gets the list of possible matches added to the drop-down portion of
        /// the <see cref="T:EDF.MDM.UI.Common.Controls.AutoCompleteBox.AutoCompleteBox" />
        /// control.
        /// </summary>
        /// <value>The list of possible matches added to the
        /// <see cref="T:EDF.MDM.UI.Common.Controls.AutoCompleteBox.AutoCompleteBox" />.</value>
        public IEnumerable Data { get; private set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:EDF.MDM.UI.Common.Controls.AutoCompleteBox.PopulatedEventArgs" />.
        /// </summary>
        /// <param name="data">The list of possible matches added to the
        /// drop-down portion of the
        /// <see cref="T:EDF.MDM.UI.Common.Controls.AutoCompleteBox.AutoCompleteBox" /> control.</param>
        public PopulatedEventArgs(IEnumerable data)
        {
            Data = data;
        }

#if !SILVERLIGHT
                /// <summary>
        /// Initializes a new instance of the
        /// <see cref="T:EDF.MDM.UI.Common.Controls.AutoCompleteBox.PopulatedEventArgs" />.
        /// </summary>
        /// <param name="data">The list of possible matches added to the
        /// drop-down portion of the
        /// <see cref="T:EDF.MDM.UI.Common.Controls.AutoCompleteBox.AutoCompleteBox" /> control.</param>
        /// <param name="routedEvent">The routed event identifier for this instance.</param>
        public PopulatedEventArgs(IEnumerable data, RoutedEvent routedEvent)
            : base(routedEvent)
        {
            Data = data;
        }
#endif
    }
}