Public Class ClubBadges

    Public Function getTeamBadge(team As String) As Image
        Dim badge As Image
        Select Case team
            Case "Arsenal"
                badge = My.Resources.ARS
            Case "Aston Villa"
                badge = My.Resources.AST
            Case "Burnley"
                badge = My.Resources.BUR
            Case "Chelsea"
                badge = My.Resources.CHE
            Case "Crystal Palace"
                badge = My.Resources.CRY
            Case "Everton"
                badge = My.Resources.EVE
            Case "Hull City"
                badge = My.Resources.HUL
            Case "Leicester City"
                badge = My.Resources.LEI
            Case "Liverpool"
                badge = My.Resources.LIV
            Case "Manchester City"
                badge = My.Resources.MNC
            Case "Manchester United"
                badge = My.Resources.MNU
            Case "Newcastle United"
                badge = My.Resources.NWC
            Case "Queens Park Rangers"
                badge = My.Resources.QPR
            Case "Southampton"
                badge = My.Resources.SOU
            Case "Stoke City"
                badge = My.Resources.STO
            Case "Sunderland"
                badge = My.Resources.SUN
            Case "Swansea City"
                badge = My.Resources.SWA
            Case "Tottenham Hotspur"
                badge = My.Resources.TOT
            Case "West Bromwich Albion"
                badge = My.Resources.WBA
            Case "West Ham United"
                badge = My.Resources.WHU

        End Select

        Return badge

    End Function

End Class
