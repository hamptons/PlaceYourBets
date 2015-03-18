Public Class FixtureList

    Public Property stock() As List(Of Fixture)
        Get
            Return m_stock
        End Get
        Set(value As List(Of Fixture))
            m_stock = value
        End Set
    End Property
    Private m_stock As List(Of Fixture)
    Public Property success() As Integer
        Get
            Return m_success
        End Get
        Set(value As Integer)
            m_success = value
        End Set
    End Property
    Private m_success As Integer

End Class
