Imports System.Net

Public Class Fixture
    Public Property ID() As String
        Get
            Return m_ID
        End Get
        Set(value As String)
            m_ID = Value
        End Set
    End Property
    Private m_ID As String
    Public Property Home_Team() As String
        Get
            Return m_Home_Team
        End Get
        Set(value As String)
            m_Home_Team = Value
        End Set
    End Property
    Private m_Home_Team As String
    Public Property Away_Team() As String
        Get
            Return m_Away_Team
        End Get
        Set(value As String)
            m_Away_Team = Value
        End Set
    End Property
    Private m_Away_Team As String
    Public Property League() As String
        Get
            Return m_League
        End Get
        Set(value As String)
            m_League = Value
        End Set
    End Property
    Private m_League As String
    Public Property [Date]() As String
        Get
            Return m_Date
        End Get
        Set(value As String)
            m_Date = Value
        End Set
    End Property
    Private m_Date As String
    Public Property Kick_Off() As String
        Get
            Return m_Kick_Off
        End Get
        Set(value As String)
            m_Kick_Off = Value
        End Set
    End Property
    Private m_Kick_Off As String
    Public Property Prediction As Integer
        Get
            Return m_prediction
        End Get
        Set(value As Integer)
            m_prediction = value
        End Set
    End Property
    Private m_prediction As String
End Class
