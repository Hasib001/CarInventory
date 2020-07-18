Option Strict On

Public Class Car
#Region "Properties"


    Private Count As Integer = 0
    Private IdentificationNumber As Integer = 0
    Private Make As String = String.Empty
    Private Model As String = String.Empty
    Private Year As Integer = 0
    Private Price As Decimal = 0
    Private Newstatus As Boolean = False

#End Region

#Region "constructor"
    ''' <summary>
    ''' create a new car using default value
    ''' </summary>
    Public Sub New()
        IdentificationNumber = Count
        Count += 1


    End Sub

    ''' <summary>
    ''' create a new car using provided value
    ''' </summary>
    ''' <param name="make"></param>
    ''' <param name="model"></param>
    ''' <param name="year"></param>
    ''' <param name="price"></param>
    ''' <param name="newstatus"></param>
    Public Sub New(make As String, model As String, year As String, price As String, newstatus As Boolean)
        IdentificationNumber = Count
        Count += 1
        Me.Make = make
        Me.Model = model
        Me.Year = Convert.ToInt32(year)

        Me.Price = Convert.ToDecimal(price)
        Me.Newstatus = newstatus

    End Sub

#End Region

#Region "Methods"
    Public Property CarMake() As String
        Get
            Return Make

        End Get
        Set(ByVal value As String)
            Make = value

        End Set


    End Property

    Public Property CarModel() As String
        Get
            Return Model
        End Get
        Set(ByVal value As String)
            Model = value
        End Set
    End Property

    Public Property CarYear() As Integer
        Get
            Return Year

        End Get
        Set(ByVal value As Integer)
            Year = value

        End Set
    End Property

    Public Property CarPrice() As Decimal
        Get
            Return Price
        End Get
        Set(ByVal value As Decimal)
            Price = value

        End Set
    End Property


    Public Property CarNewStatus() As Boolean
        Get
            Return Newstatus
        End Get
        Set(ByVal value As Boolean)
            Newstatus = value

        End Set
    End Property

    Public ReadOnly Property CarIdentificationNumber() As Integer
        Get
            Return IdentificationNumber
        End Get
    End Property

    Public ReadOnly Property CarCount() As Integer
        Get
            Return Count
        End Get
    End Property
#End Region

End Class