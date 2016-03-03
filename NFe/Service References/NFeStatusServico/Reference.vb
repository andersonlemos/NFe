﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On


Namespace NFeStatusServico
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"), _
     System.ServiceModel.ServiceContractAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe/wsdl/NfeStatusServico2", ConfigurationName:="NFeStatusServico.NfeStatusServico2Soap")> _
    Public Interface NfeStatusServico2Soap

        'CODEGEN: Generating message contract since the operation nfeStatusServicoNF2 is neither RPC nor document wrapped.
        <System.ServiceModel.OperationContractAttribute(Action:="http://www.portalfiscal.inf.br/nfe/wsdl/NfeStatusServico2/nfeStatusServicoNF2", ReplyAction:="*"), _
         System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults:=True)> _
        Function nfeStatusServicoNF2(ByVal request As NFeStatusServico.nfeStatusServicoNF2Request) As NFeStatusServico.nfeStatusServicoNF2Response

        <System.ServiceModel.OperationContractAttribute(Action:="http://www.portalfiscal.inf.br/nfe/wsdl/NfeStatusServico2/nfeStatusServicoNF2", ReplyAction:="*")> _
        Function nfeStatusServicoNF2Async(ByVal request As NFeStatusServico.nfeStatusServicoNF2Request) As System.Threading.Tasks.Task(Of NFeStatusServico.nfeStatusServicoNF2Response)
    End Interface

    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.34281"), _
     System.SerializableAttribute(), _
     System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.ComponentModel.DesignerCategoryAttribute("code"), _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe/wsdl/NfeStatusServico2")> _
    Partial Public Class nfeCabecMsg
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged

        Private cUFField As String

        Private versaoDadosField As String

        Private anyAttrField() As System.Xml.XmlAttribute

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=0)> _
        Public Property cUF() As String
            Get
                Return Me.cUFField
            End Get
            Set(value As String)
                Me.cUFField = value
                Me.RaisePropertyChanged("cUF")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Order:=1)> _
        Public Property versaoDados() As String
            Get
                Return Me.versaoDadosField
            End Get
            Set(value As String)
                Me.versaoDadosField = value
                Me.RaisePropertyChanged("versaoDados")
            End Set
        End Property

        '''<remarks/>
        <System.Xml.Serialization.XmlAnyAttributeAttribute()> _
        Public Property AnyAttr() As System.Xml.XmlAttribute()
            Get
                Return Me.anyAttrField
            End Get
            Set(value As System.Xml.XmlAttribute())
                Me.anyAttrField = value
                Me.RaisePropertyChanged("AnyAttr")
            End Set
        End Property

        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged

        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class

    <System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"), _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced), _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=False)> _
    Partial Public Class nfeStatusServicoNF2Request

        <System.ServiceModel.MessageHeaderAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe/wsdl/NfeStatusServico2")> _
        Public nfeCabecMsg As NFeStatusServico.nfeCabecMsg

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe/wsdl/NfeStatusServico2", Order:=0)> _
        Public nfeDadosMsg As System.Xml.XmlNode

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal nfeCabecMsg As NFeStatusServico.nfeCabecMsg, ByVal nfeDadosMsg As System.Xml.XmlNode)
            MyBase.New()
            Me.nfeCabecMsg = nfeCabecMsg
            Me.nfeDadosMsg = nfeDadosMsg
        End Sub
    End Class

    <System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"), _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced), _
     System.ServiceModel.MessageContractAttribute(IsWrapped:=False)> _
    Partial Public Class nfeStatusServicoNF2Response

        <System.ServiceModel.MessageHeaderAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe/wsdl/NfeStatusServico2")> _
        Public nfeCabecMsg As NFeStatusServico.nfeCabecMsg

        <System.ServiceModel.MessageBodyMemberAttribute([Namespace]:="http://www.portalfiscal.inf.br/nfe/wsdl/NfeStatusServico2", Order:=0)> _
        Public nfeStatusServicoNF2Result As System.Xml.XmlNode

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal nfeCabecMsg As NFeStatusServico.nfeCabecMsg, ByVal nfeStatusServicoNF2Result As System.Xml.XmlNode)
            MyBase.New()
            Me.nfeCabecMsg = nfeCabecMsg
            Me.nfeStatusServicoNF2Result = nfeStatusServicoNF2Result
        End Sub
    End Class

    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")> _
    Public Interface NfeStatusServico2SoapChannel
        Inherits NFeStatusServico.NfeStatusServico2Soap, System.ServiceModel.IClientChannel
    End Interface

    <System.Diagnostics.DebuggerStepThroughAttribute(), _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")> _
    Partial Public Class NfeStatusServico2SoapClient
        Inherits System.ServiceModel.ClientBase(Of NFeStatusServico.NfeStatusServico2Soap)
        Implements NFeStatusServico.NfeStatusServico2Soap

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal endpointConfigurationName As String)
            MyBase.New(endpointConfigurationName)
        End Sub

        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As String)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub

        Public Sub New(ByVal endpointConfigurationName As String, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(endpointConfigurationName, remoteAddress)
        End Sub

        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub

        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)> _
        Function NFeStatusServico_NfeStatusServico2Soap_nfeStatusServicoNF2(ByVal request As NFeStatusServico.nfeStatusServicoNF2Request) As NFeStatusServico.nfeStatusServicoNF2Response Implements NFeStatusServico.NfeStatusServico2Soap.nfeStatusServicoNF2
            Return MyBase.Channel.nfeStatusServicoNF2(request)
        End Function

        Public Function nfeStatusServicoNF2(ByRef nfeCabecMsg As NFeStatusServico.nfeCabecMsg, ByVal nfeDadosMsg As System.Xml.XmlNode) As System.Xml.XmlNode
            Dim inValue As NFeStatusServico.nfeStatusServicoNF2Request = New NFeStatusServico.nfeStatusServicoNF2Request()
            inValue.nfeCabecMsg = nfeCabecMsg
            inValue.nfeDadosMsg = nfeDadosMsg
            Dim retVal As NFeStatusServico.nfeStatusServicoNF2Response = CType(Me, NFeStatusServico.NfeStatusServico2Soap).nfeStatusServicoNF2(inValue)
            nfeCabecMsg = retVal.nfeCabecMsg
            Return retVal.nfeStatusServicoNF2Result
        End Function

        <System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)> _
        Function NFeStatusServico_NfeStatusServico2Soap_nfeStatusServicoNF2Async(ByVal request As NFeStatusServico.nfeStatusServicoNF2Request) As System.Threading.Tasks.Task(Of NFeStatusServico.nfeStatusServicoNF2Response) Implements NFeStatusServico.NfeStatusServico2Soap.nfeStatusServicoNF2Async
            Return MyBase.Channel.nfeStatusServicoNF2Async(request)
        End Function

        Public Function nfeStatusServicoNF2Async(ByVal nfeCabecMsg As NFeStatusServico.nfeCabecMsg, ByVal nfeDadosMsg As System.Xml.XmlNode) As System.Threading.Tasks.Task(Of NFeStatusServico.nfeStatusServicoNF2Response)
            Dim inValue As NFeStatusServico.nfeStatusServicoNF2Request = New NFeStatusServico.nfeStatusServicoNF2Request()
            inValue.nfeCabecMsg = nfeCabecMsg
            inValue.nfeDadosMsg = nfeDadosMsg
            Return CType(Me, NFeStatusServico.NfeStatusServico2Soap).nfeStatusServicoNF2Async(inValue)
        End Function
    End Class
End Namespace
