﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.1
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Runtime.Serialization

Namespace WCFService
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="Quote", [Namespace]:="http://schemas.datacontract.org/2004/07/WCFQuoteCalculatorService"),  _
     System.SerializableAttribute()>  _
    Partial Public Class Quote
        Inherits Object
        Implements System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
        
        <System.NonSerializedAttribute()>  _
        Private extensionDataField As System.Runtime.Serialization.ExtensionDataObject
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private ChangeField As Double
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private PriceField As Double
        
        <System.Runtime.Serialization.OptionalFieldAttribute()>  _
        Private TickerField As String
        
        <Global.System.ComponentModel.BrowsableAttribute(false)>  _
        Public Property ExtensionData() As System.Runtime.Serialization.ExtensionDataObject Implements System.Runtime.Serialization.IExtensibleDataObject.ExtensionData
            Get
                Return Me.extensionDataField
            End Get
            Set
                Me.extensionDataField = value
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Change() As Double
            Get
                Return Me.ChangeField
            End Get
            Set
                If (Me.ChangeField.Equals(value) <> true) Then
                    Me.ChangeField = value
                    Me.RaisePropertyChanged("Change")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Price() As Double
            Get
                Return Me.PriceField
            End Get
            Set
                If (Me.PriceField.Equals(value) <> true) Then
                    Me.PriceField = value
                    Me.RaisePropertyChanged("Price")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property Ticker() As String
            Get
                Return Me.TickerField
            End Get
            Set
                If (Object.ReferenceEquals(Me.TickerField, value) <> true) Then
                    Me.TickerField = value
                    Me.RaisePropertyChanged("Ticker")
                End If
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
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="WCFService.IQuoteCalculatorService")>  _
    Public Interface IQuoteCalculatorService
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IQuoteCalculatorService/GetQuote", ReplyAction:="http://tempuri.org/IQuoteCalculatorService/GetQuoteResponse")>  _
        Function GetQuote(ByVal ticker As String) As WCFService.Quote
        
        <System.ServiceModel.OperationContractAttribute(AsyncPattern:=true, Action:="http://tempuri.org/IQuoteCalculatorService/GetQuote", ReplyAction:="http://tempuri.org/IQuoteCalculatorService/GetQuoteResponse")>  _
        Function BeginGetQuote(ByVal ticker As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
        
        Function EndGetQuote(ByVal result As System.IAsyncResult) As WCFService.Quote
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IQuoteCalculatorService/GetQuotes", ReplyAction:="http://tempuri.org/IQuoteCalculatorService/GetQuotesResponse")>  _
        Function GetQuotes(ByVal tickers() As String) As System.Collections.ObjectModel.ReadOnlyCollection(Of WCFService.Quote)
        
        <System.ServiceModel.OperationContractAttribute(AsyncPattern:=true, Action:="http://tempuri.org/IQuoteCalculatorService/GetQuotes", ReplyAction:="http://tempuri.org/IQuoteCalculatorService/GetQuotesResponse")>  _
        Function BeginGetQuotes(ByVal tickers() As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult
        
        Function EndGetQuotes(ByVal result As System.IAsyncResult) As System.Collections.ObjectModel.ReadOnlyCollection(Of WCFService.Quote)
    End Interface
    
    Partial Public Class QuoteCalculatorServiceClient
        Inherits System.ServiceModel.ClientBase(Of IQuoteCalculatorService)
        Implements IQuoteCalculatorService
        
        Public Function GetQuoteAsync(ByVal ticker As String) As System.Threading.Tasks.Task(Of WCFService.Quote)
            Return System.Threading.Tasks.Task(Of WCFService.Quote).Factory.FromAsync(AddressOf CType(Me,IQuoteCalculatorService).BeginGetQuote, AddressOf CType(Me,IQuoteCalculatorService).EndGetQuote, ticker, Nothing)
        End Function
        
        Public Function GetQuotesAsync(ByVal tickers() As String) As System.Threading.Tasks.Task(Of System.Collections.ObjectModel.ReadOnlyCollection(Of WCFService.Quote))
            Return System.Threading.Tasks.Task(Of System.Collections.ObjectModel.ReadOnlyCollection(Of WCFService.Quote)).Factory.FromAsync(AddressOf CType(Me,IQuoteCalculatorService).BeginGetQuotes, AddressOf CType(Me,IQuoteCalculatorService).EndGetQuotes, tickers, Nothing)
        End Function
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IQuoteCalculatorServiceChannel
        Inherits WCFService.IQuoteCalculatorService, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class QuoteCalculatorServiceClient
        Inherits System.ServiceModel.ClientBase(Of WCFService.IQuoteCalculatorService)
        Implements WCFService.IQuoteCalculatorService
        
        Public Sub New()
            MyBase.New
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
        
        Public Function GetQuote(ByVal ticker As String) As WCFService.Quote Implements WCFService.IQuoteCalculatorService.GetQuote
            Return MyBase.Channel.GetQuote(ticker)
        End Function
        
        Public Function BeginGetQuote(ByVal ticker As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult Implements WCFService.IQuoteCalculatorService.BeginGetQuote
            Return MyBase.Channel.BeginGetQuote(ticker, callback, asyncState)
        End Function
        
        Public Function EndGetQuote(ByVal result As System.IAsyncResult) As WCFService.Quote Implements WCFService.IQuoteCalculatorService.EndGetQuote
            Return MyBase.Channel.EndGetQuote(result)
        End Function
        
        Public Function GetQuotes(ByVal tickers() As String) As System.Collections.ObjectModel.ReadOnlyCollection(Of WCFService.Quote) Implements WCFService.IQuoteCalculatorService.GetQuotes
            Return MyBase.Channel.GetQuotes(tickers)
        End Function
        
        Public Function BeginGetQuotes(ByVal tickers() As String, ByVal callback As System.AsyncCallback, ByVal asyncState As Object) As System.IAsyncResult Implements WCFService.IQuoteCalculatorService.BeginGetQuotes
            Return MyBase.Channel.BeginGetQuotes(tickers, callback, asyncState)
        End Function
        
        Public Function EndGetQuotes(ByVal result As System.IAsyncResult) As System.Collections.ObjectModel.ReadOnlyCollection(Of WCFService.Quote) Implements WCFService.IQuoteCalculatorService.EndGetQuotes
            Return MyBase.Channel.EndGetQuotes(result)
        End Function
    End Class
End Namespace
