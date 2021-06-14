Imports Ozeki.Libs.Rest

Module ReceiveSMS
    Sub Main(args As String())

        Dim configuration As New Configuration
        configuration.Username = "http_user"
        configuration.Password = "qwe123"
        configuration.ApiUrl = "http://127.0.0.1:9509/api"

        Dim api As New MessageApi(configuration)

        Dim result = api.DownloadIncoming()

        If result.Length > 0 Then
            Console.WriteLine($"There are {result.Length} in the inbox folder:")
            For Each message As Message In result
                Console.WriteLine($"From: {message.FromAddress} Text: {message.Text}")
            Next
        Else
            Console.WriteLine("There are 0 messages in the inbox folder.")
        End If

        Console.ReadKey()

    End Sub
End Module
