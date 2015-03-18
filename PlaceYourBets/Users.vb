Public Class Users

    Public Property user() As String
        Get
            Return m_user
        End Get
        Set(value As String)
            m_user = value
        End Set
    End Property
    Private m_user As String
    Public Property submitted() As Integer
        Get
            Return m_submitted
        End Get
        Set(value As Integer)
            m_submitted = value
        End Set
    End Property
    Private m_submitted As Integer
    Public Property correct() As Double
        Get
            Return m_correct
        End Get
        Set(value As Double)
            m_correct = value
        End Set
    End Property
    Private m_correct As Double
    Public Property UserID() As Integer
        Get
            Return m_UserID
        End Get
        Set(value As Integer)
            m_UserID = value
        End Set
    End Property
    Private m_UserID As Integer
End Class
