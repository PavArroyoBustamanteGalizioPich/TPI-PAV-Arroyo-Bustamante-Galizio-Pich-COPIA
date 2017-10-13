Module Principal

    Sub main()
        Application.EnableVisualStyles()
        Dim ordenesTrabajo As New ABMCOrdenTrabajo

        ordenesTrabajo.ShowDialog()

        Application.Exit()
    End Sub

End Module
