Imports Ozeki.Libs.Rest

Module Program
    Sub Main(args As String())

        Dim configuration As New Configuration
        configuration.Username = "http_user"
        configuration.Password = "qwe123"
        configuration.ApiUrl = "http://127.0.0.1:9509/api"

        Dim msg As New Message
        msg.ToAddress = "+36201111111"
        msg.Text = "Hello, World!"

        Dim api = New MessageApi(configuration)

        Dim result = api.Send(msg)

        Console.WriteLine(result)
        Console.ReadKey()

    End Sub
End Module
