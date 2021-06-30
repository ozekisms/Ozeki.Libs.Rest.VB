Imports Ozeki.Libs.Rest

Module DeleteSms
    Sub Main(args As String())

        Dim configuration As New Configuration
        configuration.Username = "http_user"
        configuration.Password = "qwe123"
        configuration.ApiUrl = "http://127.0.0.1:9509/api"

        Dim msg As New Message
        msg.ID = "15548136-558c-465c-81fe-7006315c2f6a"

        Dim api As New MessageApi(configuration)

        Dim result = api.Delete(Folder.Inbox, msg)

        Console.WriteLine(result)
        Console.ReadKey()

    End Sub
End Module
