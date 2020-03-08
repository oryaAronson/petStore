﻿Public Class Pet
    Private _id As Integer
    Private _name As String
    Private _price As Double
    Private _image As String

    Public Sub New()


    End Sub

    Public Sub New(id As Integer, name As String, price As Double, image As String)
        Me._id = id
        Me._name = name
        Me._price = price
        Me._image = image
    End Sub

    Public Sub New(collection As FormCollection)
        Me._id = collection("ID")
        Me._name = collection("Name")
        Me._image = collection("Image")
        Me._price = collection("Price")
    End Sub

    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property
    Public Property Image() As String
        Get
            Return _image
        End Get
        Set(ByVal value As String)
            _image = value
        End Set
    End Property
    Public Property Price() As Double
        Get
            Return _price
        End Get
        Set(ByVal value As Double)
            _price = value
        End Set
    End Property
End Class


