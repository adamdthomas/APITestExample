﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.8794
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=2.0.50727.3038.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlType(AnonymousType=true, Namespace="http://schemas.datacontract.org/2004/07/SampleWebAPI.Models")]
[XmlRoot(Namespace="http://schemas.datacontract.org/2004/07/SampleWebAPI.Models", IsNullable=false)]
public partial class ArrayOfProduct {
    
    private ArrayOfProductProduct[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Product")]
    public ArrayOfProductProduct[] Items {
        get {
            return itemsField;
        }
        set {
            itemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "2.0.50727.3038")]
[System.Serializable()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[XmlType(AnonymousType=true, Namespace="http://schemas.datacontract.org/2004/07/SampleWebAPI.Models")]
public partial class ArrayOfProductProduct {
    
    private string descriptionField;
    
    private string idField;
    
    private string nameField;
    
    /// <remarks/>
    public string Description {
        get {
            return descriptionField;
        }
        set {
            descriptionField = value;
        }
    }
    
    /// <remarks/>
    public string Id {
        get {
            return idField;
        }
        set {
            idField = value;
        }
    }
    
    /// <remarks/>
    public string Name {
        get {
            return nameField;
        }
        set {
            nameField = value;
        }
    }
}