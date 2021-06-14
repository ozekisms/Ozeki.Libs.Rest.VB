Imports Ozeki.Libs.Rest

Module ReceiveSMS
    Sub Main(args As String())

        Dim configuration As New Configuration
        configuration.Username = "http_user"
        configuration.Password = "qwe123"
        configuration.ApiUrl = "http://127.0.0.1:9509/api"

        Dim msg As New Message
        msg.ID = "69022e7a-305c-4f01-8063-7f9d65f5ca49"

        Dim api As New MessageApi(configuration)

        Dim result = api.Delete(Folder.Inbox, msg)

        Console.WriteLine(result)
        Console.ReadKey()

    End Sub
End Module
