Imports Ozeki.Libs.Rest

Module Program
    Sub Main(args As String())

        Dim configuration As New Configuration
        configuration.Username = "http_user"
        configuration.Password = "qwe123"
        configuration.ApiUrl = "http://127.0.0.1:9509/api"

        Dim api As New MessageApi(configuration)

        Dim result = api.DownloadIncoming()

        Console.WriteLine($"There are {result.Length} in the inbox folder:")
        For Each message As Message In result
            Console.WriteLine($"{message}")
        Next

        Console.ReadKey()

    End Sub
End Module
