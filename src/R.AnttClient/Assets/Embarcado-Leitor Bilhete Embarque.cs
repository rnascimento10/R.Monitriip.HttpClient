﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://antt.gov.br/monitriip/v1.0/")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://antt.gov.br/monitriip/v1.0/", IsNullable=false)]
public partial class bilheteEmbarque {
    
    private sbyte idLogField;
    
    private string cnpjEmpresaTransporteField;
    
    private string placaVeiculoField;
    
    private decimal latitudeField;
    
    private decimal longitudeField;
    
    private decimal pdopField;
    
    private System.DateTime dataHoraEventoField;
    
    private long imeiField;
    
    private bilheteEmbarqueBilhete[] bilhetesField;
    
    /// <remarks/>
    public sbyte idLog {
        get {
            return this.idLogField;
        }
        set {
            this.idLogField = value;
        }
    }
    
    /// <remarks/>
    public string cnpjEmpresaTransporte {
        get {
            return this.cnpjEmpresaTransporteField;
        }
        set {
            this.cnpjEmpresaTransporteField = value;
        }
    }
    
    /// <remarks/>
    public string placaVeiculo {
        get {
            return this.placaVeiculoField;
        }
        set {
            this.placaVeiculoField = value;
        }
    }
    
    /// <remarks/>
    public decimal latitude {
        get {
            return this.latitudeField;
        }
        set {
            this.latitudeField = value;
        }
    }
    
    /// <remarks/>
    public decimal longitude {
        get {
            return this.longitudeField;
        }
        set {
            this.longitudeField = value;
        }
    }
    
    /// <remarks/>
    public decimal pdop {
        get {
            return this.pdopField;
        }
        set {
            this.pdopField = value;
        }
    }
    
    /// <remarks/>
    public System.DateTime dataHoraEvento {
        get {
            return this.dataHoraEventoField;
        }
        set {
            this.dataHoraEventoField = value;
        }
    }
    
    /// <remarks/>
    public long imei {
        get {
            return this.imeiField;
        }
        set {
            this.imeiField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("bilhete", IsNullable=false)]
    public bilheteEmbarqueBilhete[] bilhetes {
        get {
            return this.bilhetesField;
        }
        set {
            this.bilhetesField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://antt.gov.br/monitriip/v1.0/")]
public partial class bilheteEmbarqueBilhete {
    
    private string numeroEquipamentoField;
    
    private string numeroBilheteEmbarqueField;
    
    private string identificacaoLinhaField;
    
    private System.DateTime dataPrevistaViagemField;
    
    private System.DateTime horaPrevistaViagemField;
    
    private sbyte codigoDescontoField;
    
    private decimal valorTarifaField;
    
    private decimal percentualDescontoField;
    
    private bool percentualDescontoFieldSpecified;
    
    private string celularPassageiroField;
    
    private string idPontoOrigemViagemField;
    
    private string idPontoDestinoViagemField;
    
    /// <remarks/>
    public string numeroEquipamento {
        get {
            return this.numeroEquipamentoField;
        }
        set {
            this.numeroEquipamentoField = value;
        }
    }
    
    /// <remarks/>
    public string numeroBilheteEmbarque {
        get {
            return this.numeroBilheteEmbarqueField;
        }
        set {
            this.numeroBilheteEmbarqueField = value;
        }
    }
    
    /// <remarks/>
    public string identificacaoLinha {
        get {
            return this.identificacaoLinhaField;
        }
        set {
            this.identificacaoLinhaField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="date")]
    public System.DateTime dataPrevistaViagem {
        get {
            return this.dataPrevistaViagemField;
        }
        set {
            this.dataPrevistaViagemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="time")]
    public System.DateTime horaPrevistaViagem {
        get {
            return this.horaPrevistaViagemField;
        }
        set {
            this.horaPrevistaViagemField = value;
        }
    }
    
    /// <remarks/>
    public sbyte codigoDesconto {
        get {
            return this.codigoDescontoField;
        }
        set {
            this.codigoDescontoField = value;
        }
    }
    
    /// <remarks/>
    public decimal valorTarifa {
        get {
            return this.valorTarifaField;
        }
        set {
            this.valorTarifaField = value;
        }
    }
    
    /// <remarks/>
    public decimal percentualDesconto {
        get {
            return this.percentualDescontoField;
        }
        set {
            this.percentualDescontoField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool percentualDescontoSpecified {
        get {
            return this.percentualDescontoFieldSpecified;
        }
        set {
            this.percentualDescontoFieldSpecified = value;
        }
    }
    
    /// <remarks/>
    public string celularPassageiro {
        get {
            return this.celularPassageiroField;
        }
        set {
            this.celularPassageiroField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string idPontoOrigemViagem {
        get {
            return this.idPontoOrigemViagemField;
        }
        set {
            this.idPontoOrigemViagemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType="integer")]
    public string idPontoDestinoViagem {
        get {
            return this.idPontoDestinoViagemField;
        }
        set {
            this.idPontoDestinoViagemField = value;
        }
    }
}