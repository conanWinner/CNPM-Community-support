﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace CNPM_Community_support.Module.ORMDataModel1
{

    [DefaultProperty("Username")]
    public partial class User : DevExpress.Persistent.BaseImpl.BaseObject
    {
        string fUsername;
        [Size(20)]
        public string Username
        {
            get { return fUsername; }
            set { SetPropertyValue<string>(nameof(Username), ref fUsername, value); }
        }
        string fPassword;
        public string Password
        {
            get { return fPassword; }
            set { SetPropertyValue<string>(nameof(Password), ref fPassword, value); }
        }
        string fSdt;
        [Size(12)]
        public string Sdt
        {
            get { return fSdt; }
            set { SetPropertyValue<string>(nameof(Sdt), ref fSdt, value); }
        }
        string fCCCD;
        [Size(12)]
        public string CCCD
        {
            get { return fCCCD; }
            set { SetPropertyValue<string>(nameof(CCCD), ref fCCCD, value); }
        }
        [Association(@"BieumauReferencesUser"), Aggregated]
        public XPCollection<Bieumau> Bieumaus { get { return GetCollection<Bieumau>(nameof(Bieumaus)); } }
    }

}
