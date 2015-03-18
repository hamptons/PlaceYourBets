Imports System.Net
Imports Newtonsoft.Json

Public Class FixtureBuilder

    Public Function getFixtures()
        Dim client = New WebClient()
        Dim reply = client.DownloadString("http://www.predictresults.co.uk/pradeep/SamH.php")

        'Dim fileReader As String
        'fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\hamptons\Google Drive\PlaceYourBets\JSONexample - fixtures.txt")
        'Dim f = JsonConvert.DeserializeObject(Of FixtureList)(fileReader)

        Dim f = JsonConvert.DeserializeObject(Of FixtureList)(reply)

        Return f.stock
    End Function

    Public Function getBet()
        Dim client = New WebClient()
        Dim reply = client.DownloadString("http://www.predictresults.co.uk/pradeep/PYBPredictions.php")

        'Dim fileReader As String
        'fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\hamptons\Google Drive\PlaceYourBets\JSONexample - predictions.txt")
        'Dim f = JsonConvert.DeserializeObject(Of FixtureList)(fileReader)

        Dim f = JsonConvert.DeserializeObject(Of FixtureList)(reply)

        Return f.stock
    End Function

    Public Function getUsers()
        Dim client = New WebClient
        Dim reply = client.DownloadString("http://www.predictresults.co.uk/pradeep/PYBUsers.php")
        Dim f = JsonConvert.DeserializeObject(Of UserList)(reply)

        'Dim fileReader As String
        'fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\hamptons\Google Drive\PlaceYourBets\JSONexample - users.txt")
        'Dim f = JsonConvert.DeserializeObject(Of UserList)(fileReader)

        Dim list As New List(Of String)

        For Each user As Users In f.stock
            list.Add(user.user)
        Next

        Return list

    End Function

    Public Function getScores()
        Dim client = New WebClient
        Dim reply = client.DownloadString("http://www.predictresults.co.uk/pradeep/UserStats.php")
        Dim f = JsonConvert.DeserializeObject(Of UserList)(reply)

        'Dim fileReader As String
        'fileReader = My.Computer.FileSystem.ReadAllText("C:\Users\hamptons\Google Drive\PlaceYourBets\JSONexample - users.txt")
        'Dim f = JsonConvert.DeserializeObject(Of UserList)(fileReader)

        Return f.stock
    End Function

    Public Function usersSubmitted()
        Dim client = New WebClient
        Dim reply = client.DownloadString("http://www.predictresults.co.uk/pradeep/WhoBet.php")
        Dim f = JsonConvert.DeserializeObject(Of UserList)(reply)

        Dim list As New List(Of String)

        For Each user As Users In f.stock
            list.Add(user.user)
        Next

        Return list

    End Function

    Public Function getUsersAndIds()
        Dim client = New WebClient
        Dim reply = client.DownloadString("http://www.predictresults.co.uk/pradeep/PYBUsers.php")
        Dim f = JsonConvert.DeserializeObject(Of UserList)(reply)

        Dim dictionary As New Dictionary(Of String, Integer)

        For Each user As Users In f.stock
            dictionary.Add(user.user, user.UserID)
        Next

        Return dictionary

    End Function

    Public Function getIds()
        Dim client = New WebClient
        Dim reply = client.DownloadString("http://www.predictresults.co.uk/pradeep/PYBUsers.php")
        Dim f = JsonConvert.DeserializeObject(Of UserList)(reply)

        Dim list As New List(Of Integer)

        For Each user As Users In f.stock
            list.Add(user.UserID)
        Next

        Return list

    End Function

    Public Function getPRUsers()
        Dim client = New WebClient
        Dim reply = client.DownloadString("http://www.predictresults.co.uk/pradeep/PRUsers.php")
        Dim f = JsonConvert.DeserializeObject(Of UserList)(reply)

        Dim list As New List(Of String)

        For Each user As Users In f.stock
            list.Add(user.user)
        Next

        Return list
    End Function



End Class
