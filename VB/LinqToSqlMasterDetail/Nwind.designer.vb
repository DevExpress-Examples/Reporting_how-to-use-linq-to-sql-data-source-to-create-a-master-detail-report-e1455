﻿'INSTANT VB TODO TASK: There is no equivalent to #pragma directives in VB.NET:
'#pragma warning disable 1591
'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.3053
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------


Imports Microsoft.VisualBasic
	Imports System.Data.Linq
	Imports System.Data.Linq.Mapping
	Imports System.Data
	Imports System.Collections.Generic
	Imports System.Reflection
	Imports System.Linq
	Imports System.Linq.Expressions
	Imports System.ComponentModel
	Imports System
Namespace LinqToSqlMasterDetail


	<System.Data.Linq.Mapping.DatabaseAttribute(Name:="Northwind")> _
	Partial Public Class NwindDataContext
		Inherits System.Data.Linq.DataContext

		Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()

	#Region "Extensibility Method Definitions"
	Partial Private Sub OnCreated()
	End Sub
	Partial Private Sub InsertOrder(ByVal instance As Order)
	End Sub
	Partial Private Sub UpdateOrder(ByVal instance As Order)
	End Sub
	Partial Private Sub DeleteOrder(ByVal instance As Order)
	End Sub
	Partial Private Sub InsertOrder_Detail(ByVal instance As Order_Detail)
	End Sub
	Partial Private Sub UpdateOrder_Detail(ByVal instance As Order_Detail)
	End Sub
	Partial Private Sub DeleteOrder_Detail(ByVal instance As Order_Detail)
	End Sub
	#End Region

		Public Sub New()
			MyBase.New(My.Settings.Default.NorthwindConnectionString, mappingSource)
			OnCreated()
		End Sub

		Public Sub New(ByVal connection As String)
			MyBase.New(connection, mappingSource)
			OnCreated()
		End Sub

		Public Sub New(ByVal connection As System.Data.IDbConnection)
			MyBase.New(connection, mappingSource)
			OnCreated()
		End Sub

		Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
			MyBase.New(connection, mappingSource)
			OnCreated()
		End Sub

		Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
			MyBase.New(connection, mappingSource)
			OnCreated()
		End Sub

		Public ReadOnly Property Orders() As System.Data.Linq.Table(Of Order)
			Get
				Return Me.GetTable(Of Order)()
			End Get
		End Property

		Public ReadOnly Property Order_Details() As System.Data.Linq.Table(Of Order_Detail)
			Get
				Return Me.GetTable(Of Order_Detail)()
			End Get
		End Property
	End Class

	<Table(Name:="dbo.Orders")> _
	Partial Public Class Order
		Implements INotifyPropertyChanging, INotifyPropertyChanged

		Private Shared emptyChangingEventArgs As New PropertyChangingEventArgs(String.Empty)

		Private _OrderID As Integer

		Private _CustomerID As String

		Private _EmployeeID? As Integer

		Private _OrderDate? As System.DateTime

		Private _RequiredDate? As System.DateTime

		Private _ShippedDate? As System.DateTime

		Private _ShipVia? As Integer

		Private _Freight? As Decimal

		Private _ShipName As String

		Private _ShipAddress As String

		Private _ShipCity As String

		Private _ShipRegion As String

		Private _ShipPostalCode As String

		Private _ShipCountry As String

		Private _Order_Details As EntitySet(Of Order_Detail)

	#Region "Extensibility Method Definitions"
	Partial Private Sub OnLoaded()
	End Sub
	Partial Private Sub OnValidate(ByVal action As System.Data.Linq.ChangeAction)
	End Sub
	Partial Private Sub OnCreated()
	End Sub
	Partial Private Sub OnOrderIDChanging(ByVal value As Integer)
	End Sub
	Partial Private Sub OnOrderIDChanged()
	End Sub
	Partial Private Sub OnCustomerIDChanging(ByVal value As String)
	End Sub
	Partial Private Sub OnCustomerIDChanged()
	End Sub
	Partial Private Sub OnEmployeeIDChanging(ByVal value? As Integer)
	End Sub
	Partial Private Sub OnEmployeeIDChanged()
	End Sub
	Partial Private Sub OnOrderDateChanging(ByVal value? As System.DateTime)
	End Sub
	Partial Private Sub OnOrderDateChanged()
	End Sub
	Partial Private Sub OnRequiredDateChanging(ByVal value? As System.DateTime)
	End Sub
	Partial Private Sub OnRequiredDateChanged()
	End Sub
	Partial Private Sub OnShippedDateChanging(ByVal value? As System.DateTime)
	End Sub
	Partial Private Sub OnShippedDateChanged()
	End Sub
	Partial Private Sub OnShipViaChanging(ByVal value? As Integer)
	End Sub
	Partial Private Sub OnShipViaChanged()
	End Sub
	Partial Private Sub OnFreightChanging(ByVal value? As Decimal)
	End Sub
	Partial Private Sub OnFreightChanged()
	End Sub
	Partial Private Sub OnShipNameChanging(ByVal value As String)
	End Sub
	Partial Private Sub OnShipNameChanged()
	End Sub
	Partial Private Sub OnShipAddressChanging(ByVal value As String)
	End Sub
	Partial Private Sub OnShipAddressChanged()
	End Sub
	Partial Private Sub OnShipCityChanging(ByVal value As String)
	End Sub
	Partial Private Sub OnShipCityChanged()
	End Sub
	Partial Private Sub OnShipRegionChanging(ByVal value As String)
	End Sub
	Partial Private Sub OnShipRegionChanged()
	End Sub
	Partial Private Sub OnShipPostalCodeChanging(ByVal value As String)
	End Sub
	Partial Private Sub OnShipPostalCodeChanged()
	End Sub
	Partial Private Sub OnShipCountryChanging(ByVal value As String)
	End Sub
	Partial Private Sub OnShipCountryChanged()
	End Sub
	#End Region

		Public Sub New()
			Me._Order_Details = New EntitySet(Of Order_Detail)(New Action(Of Order_Detail)(AddressOf Me.attach_Order_Details), New Action(Of Order_Detail)(AddressOf Me.detach_Order_Details))
			OnCreated()
		End Sub

		<Column(Storage:="_OrderID", AutoSync:=AutoSync.OnInsert, DbType:="Int NOT NULL IDENTITY", IsPrimaryKey:=True, IsDbGenerated:=True)> _
		Public Property OrderID() As Integer
			Get
				Return Me._OrderID
			End Get
			Set(ByVal value As Integer)
				If (Me._OrderID <> value) Then
					Me.OnOrderIDChanging(value)
					Me.SendPropertyChanging()
					Me._OrderID = value
					Me.SendPropertyChanged("OrderID")
					Me.OnOrderIDChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_CustomerID", DbType:="NChar(5)")> _
		Public Property CustomerID() As String
			Get
				Return Me._CustomerID
			End Get
			Set(ByVal value As String)
				If (Me._CustomerID <> value) Then
					Me.OnCustomerIDChanging(value)
					Me.SendPropertyChanging()
					Me._CustomerID = value
					Me.SendPropertyChanged("CustomerID")
					Me.OnCustomerIDChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_EmployeeID", DbType:="Int")> _
		Public Property EmployeeID() As Integer?
			Get
				Return Me._EmployeeID
			End Get
			Set(ByVal value? As Integer)
				If (Not Me._EmployeeID.Equals(value)) Then
					Me.OnEmployeeIDChanging(value)
					Me.SendPropertyChanging()
					Me._EmployeeID = value
					Me.SendPropertyChanged("EmployeeID")
					Me.OnEmployeeIDChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_OrderDate", DbType:="DateTime")> _
		Public Property OrderDate() As System.DateTime?
			Get
				Return Me._OrderDate
			End Get
			Set(ByVal value? As System.DateTime)
				If (Not Me._OrderDate.Equals(value)) Then
					Me.OnOrderDateChanging(value)
					Me.SendPropertyChanging()
					Me._OrderDate = value
					Me.SendPropertyChanged("OrderDate")
					Me.OnOrderDateChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_RequiredDate", DbType:="DateTime")> _
		Public Property RequiredDate() As System.DateTime?
			Get
				Return Me._RequiredDate
			End Get
			Set(ByVal value? As System.DateTime)
				If (Not Me._RequiredDate.Equals(value)) Then
					Me.OnRequiredDateChanging(value)
					Me.SendPropertyChanging()
					Me._RequiredDate = value
					Me.SendPropertyChanged("RequiredDate")
					Me.OnRequiredDateChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_ShippedDate", DbType:="DateTime")> _
		Public Property ShippedDate() As System.DateTime?
			Get
				Return Me._ShippedDate
			End Get
			Set(ByVal value? As System.DateTime)
				If (Not Me._ShippedDate.Equals(value)) Then
					Me.OnShippedDateChanging(value)
					Me.SendPropertyChanging()
					Me._ShippedDate = value
					Me.SendPropertyChanged("ShippedDate")
					Me.OnShippedDateChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_ShipVia", DbType:="Int")> _
		Public Property ShipVia() As Integer?
			Get
				Return Me._ShipVia
			End Get
			Set(ByVal value? As Integer)
				If (Not Me._ShipVia.Equals(value)) Then
					Me.OnShipViaChanging(value)
					Me.SendPropertyChanging()
					Me._ShipVia = value
					Me.SendPropertyChanged("ShipVia")
					Me.OnShipViaChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_Freight", DbType:="Money")> _
		Public Property Freight() As Decimal?
			Get
				Return Me._Freight
			End Get
			Set(ByVal value? As Decimal)
				If (Not Me._Freight.Equals(value)) Then
					Me.OnFreightChanging(value)
					Me.SendPropertyChanging()
					Me._Freight = value
					Me.SendPropertyChanged("Freight")
					Me.OnFreightChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_ShipName", DbType:="NVarChar(40)")> _
		Public Property ShipName() As String
			Get
				Return Me._ShipName
			End Get
			Set(ByVal value As String)
				If (Me._ShipName <> value) Then
					Me.OnShipNameChanging(value)
					Me.SendPropertyChanging()
					Me._ShipName = value
					Me.SendPropertyChanged("ShipName")
					Me.OnShipNameChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_ShipAddress", DbType:="NVarChar(60)")> _
		Public Property ShipAddress() As String
			Get
				Return Me._ShipAddress
			End Get
			Set(ByVal value As String)
				If (Me._ShipAddress <> value) Then
					Me.OnShipAddressChanging(value)
					Me.SendPropertyChanging()
					Me._ShipAddress = value
					Me.SendPropertyChanged("ShipAddress")
					Me.OnShipAddressChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_ShipCity", DbType:="NVarChar(15)")> _
		Public Property ShipCity() As String
			Get
				Return Me._ShipCity
			End Get
			Set(ByVal value As String)
				If (Me._ShipCity <> value) Then
					Me.OnShipCityChanging(value)
					Me.SendPropertyChanging()
					Me._ShipCity = value
					Me.SendPropertyChanged("ShipCity")
					Me.OnShipCityChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_ShipRegion", DbType:="NVarChar(15)")> _
		Public Property ShipRegion() As String
			Get
				Return Me._ShipRegion
			End Get
			Set(ByVal value As String)
				If (Me._ShipRegion <> value) Then
					Me.OnShipRegionChanging(value)
					Me.SendPropertyChanging()
					Me._ShipRegion = value
					Me.SendPropertyChanged("ShipRegion")
					Me.OnShipRegionChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_ShipPostalCode", DbType:="NVarChar(10)")> _
		Public Property ShipPostalCode() As String
			Get
				Return Me._ShipPostalCode
			End Get
			Set(ByVal value As String)
				If (Me._ShipPostalCode <> value) Then
					Me.OnShipPostalCodeChanging(value)
					Me.SendPropertyChanging()
					Me._ShipPostalCode = value
					Me.SendPropertyChanged("ShipPostalCode")
					Me.OnShipPostalCodeChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_ShipCountry", DbType:="NVarChar(15)")> _
		Public Property ShipCountry() As String
			Get
				Return Me._ShipCountry
			End Get
			Set(ByVal value As String)
				If (Me._ShipCountry <> value) Then
					Me.OnShipCountryChanging(value)
					Me.SendPropertyChanging()
					Me._ShipCountry = value
					Me.SendPropertyChanged("ShipCountry")
					Me.OnShipCountryChanged()
				End If
			End Set
		End Property

		<Association(Name:="Order_Order_Detail", Storage:="_Order_Details", ThisKey:="OrderID", OtherKey:="OrderID")> _
		Public Property Order_Details() As EntitySet(Of Order_Detail)
			Get
				Return Me._Order_Details
			End Get
			Set(ByVal value As EntitySet(Of Order_Detail))
				Me._Order_Details.Assign(value)
			End Set
		End Property

		Public Event PropertyChanging As PropertyChangingEventHandler Implements INotifyPropertyChanging.PropertyChanging

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

		Protected Overridable Sub SendPropertyChanging()
			If (Me.PropertyChangingEvent IsNot Nothing) Then
				RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
			End If
		End Sub

		Protected Overridable Sub SendPropertyChanged(ByVal propertyName As String)
			If (Me.PropertyChangedEvent IsNot Nothing) Then
				RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
			End If
		End Sub

		Private Sub attach_Order_Details(ByVal entity As Order_Detail)
			Me.SendPropertyChanging()
			entity.Order = Me
		End Sub

		Private Sub detach_Order_Details(ByVal entity As Order_Detail)
			Me.SendPropertyChanging()
			entity.Order = Nothing
		End Sub
	End Class

	<Table(Name:="dbo.[Order Details]")> _
	Partial Public Class Order_Detail
		Implements INotifyPropertyChanging, INotifyPropertyChanged

		Private Shared emptyChangingEventArgs As New PropertyChangingEventArgs(String.Empty)

		Private _OrderID As Integer

		Private _ProductID As Integer

		Private _UnitPrice As Decimal

		Private _Quantity As Short

		Private _Discount As Single

		Private _Order As EntityRef(Of Order)

	#Region "Extensibility Method Definitions"
	Partial Private Sub OnLoaded()
	End Sub
	Partial Private Sub OnValidate(ByVal action As System.Data.Linq.ChangeAction)
	End Sub
	Partial Private Sub OnCreated()
	End Sub
	Partial Private Sub OnOrderIDChanging(ByVal value As Integer)
	End Sub
	Partial Private Sub OnOrderIDChanged()
	End Sub
	Partial Private Sub OnProductIDChanging(ByVal value As Integer)
	End Sub
	Partial Private Sub OnProductIDChanged()
	End Sub
	Partial Private Sub OnUnitPriceChanging(ByVal value As Decimal)
	End Sub
	Partial Private Sub OnUnitPriceChanged()
	End Sub
	Partial Private Sub OnQuantityChanging(ByVal value As Short)
	End Sub
	Partial Private Sub OnQuantityChanged()
	End Sub
	Partial Private Sub OnDiscountChanging(ByVal value As Single)
	End Sub
	Partial Private Sub OnDiscountChanged()
	End Sub
	#End Region

		Public Sub New()
			Me._Order = Nothing
			OnCreated()
		End Sub

		<Column(Storage:="_OrderID", DbType:="Int NOT NULL", IsPrimaryKey:=True)> _
		Public Property OrderID() As Integer
			Get
				Return Me._OrderID
			End Get
			Set(ByVal value As Integer)
				If (Me._OrderID <> value) Then
					If Me._Order.HasLoadedOrAssignedValue Then
						Throw New System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException()
					End If
					Me.OnOrderIDChanging(value)
					Me.SendPropertyChanging()
					Me._OrderID = value
					Me.SendPropertyChanged("OrderID")
					Me.OnOrderIDChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_ProductID", DbType:="Int NOT NULL", IsPrimaryKey:=True)> _
		Public Property ProductID() As Integer
			Get
				Return Me._ProductID
			End Get
			Set(ByVal value As Integer)
				If (Me._ProductID <> value) Then
					Me.OnProductIDChanging(value)
					Me.SendPropertyChanging()
					Me._ProductID = value
					Me.SendPropertyChanged("ProductID")
					Me.OnProductIDChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_UnitPrice", DbType:="Money NOT NULL")> _
		Public Property UnitPrice() As Decimal
			Get
				Return Me._UnitPrice
			End Get
			Set(ByVal value As Decimal)
				If (Me._UnitPrice <> value) Then
					Me.OnUnitPriceChanging(value)
					Me.SendPropertyChanging()
					Me._UnitPrice = value
					Me.SendPropertyChanged("UnitPrice")
					Me.OnUnitPriceChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_Quantity", DbType:="SmallInt NOT NULL")> _
		Public Property Quantity() As Short
			Get
				Return Me._Quantity
			End Get
			Set(ByVal value As Short)
				If (Me._Quantity <> value) Then
					Me.OnQuantityChanging(value)
					Me.SendPropertyChanging()
					Me._Quantity = value
					Me.SendPropertyChanged("Quantity")
					Me.OnQuantityChanged()
				End If
			End Set
		End Property

		<Column(Storage:="_Discount", DbType:="Real NOT NULL")> _
		Public Property Discount() As Single
			Get
				Return Me._Discount
			End Get
			Set(ByVal value As Single)
				If (Me._Discount <> value) Then
					Me.OnDiscountChanging(value)
					Me.SendPropertyChanging()
					Me._Discount = value
					Me.SendPropertyChanged("Discount")
					Me.OnDiscountChanged()
				End If
			End Set
		End Property

		<Association(Name:="Order_Order_Detail", Storage:="_Order", ThisKey:="OrderID", OtherKey:="OrderID", IsForeignKey:=True)> _
		Public Property Order() As Order
			Get
				Return Me._Order.Entity
			End Get
			Set(ByVal value As Order)
				Dim previousValue As Order = Me._Order.Entity
				If ((previousValue IsNot value) OrElse (Me._Order.HasLoadedOrAssignedValue = False)) Then
					Me.SendPropertyChanging()
					If (previousValue IsNot Nothing) Then
						Me._Order.Entity = Nothing
						previousValue.Order_Details.Remove(Me)
					End If
					Me._Order.Entity = value
					If (value IsNot Nothing) Then
						value.Order_Details.Add(Me)
						Me._OrderID = value.OrderID
					Else
						Me._OrderID = Nothing
					End If
					Me.SendPropertyChanged("Order")
				End If
			End Set
		End Property

		Public Event PropertyChanging As PropertyChangingEventHandler Implements INotifyPropertyChanging.PropertyChanging

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

		Protected Overridable Sub SendPropertyChanging()
			If (Me.PropertyChangingEvent IsNot Nothing) Then
				RaiseEvent PropertyChanging(Me, emptyChangingEventArgs)
			End If
		End Sub

		Protected Overridable Sub SendPropertyChanged(ByVal propertyName As String)
			If (Me.PropertyChangedEvent IsNot Nothing) Then
				RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
			End If
		End Sub
	End Class
End Namespace
'INSTANT VB TODO TASK: There is no equivalent to #pragma directives in VB.NET:
'#pragma warning restore 1591
