Imports Ozeki.Libs.Rest

Module Program
    Sub Main(args As String())

        Dim configuration As New Configuration
        configuration.Username = "http_user"
        configuration.Password = "qwe123"
        configuration.ApiUrl = "http://127.0.0.1:9509/api"

        Dim msg1 As New Message
        msg1.ToAddress = "+36201111111"
        msg1.Text = "Hello, World 1"

        Dim msg2 As New Message
        msg2.ToAddress = "+36202222222"
        msg2.Text = "Hello, World 2"

        Dim msg3 As New Message
        msg3.ToAddress = "+36203333333"
        msg3.Text = "Hello, World 3"

        Dim api = New MessageApi(configuration)

        Dim result = api.Send({ msg1, msg2, msg3 })

        Console.WriteLine(result)
        Console.ReadKey()

    End Sub
End Module
