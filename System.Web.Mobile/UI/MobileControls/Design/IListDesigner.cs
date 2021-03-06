//------------------------------------------------------------------------------
// <copyright file="IListDesigner.cs" company="Microsoft">
//     Copyright (c) Microsoft Corporation.  All rights reserved.
// </copyright>                                                                
//------------------------------------------------------------------------------

using System.Windows.Forms;

using System.Web.UI.MobileControls;

namespace System.Web.UI.Design.MobileControls
{
    [Obsolete("The System.Web.Mobile.dll assembly has been deprecated and should no longer be used. For information about how to develop ASP.NET mobile applications, see http://go.microsoft.com/fwlink/?LinkId=157231.")]
    internal interface IListDesigner
    {
        String DataTextField
        {
            get;
            set;
        }

        String DataValueField
        {
            get;
            set;
        }

        String DataSource
        {
            get;
            set;
        }

        String DataMember
        {
            get;
            set;
        }

        MobileListItemCollection Items
        {
            get;
        }

        void OnDataSourceChanged();
    }
}
