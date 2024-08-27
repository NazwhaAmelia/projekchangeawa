Module Module1

    Sub Main()
        Dim pilihan As String
        Dim ganjil As Integer
        Dim genap As Integer = 52

        Console.WriteLine()
        Console.WriteLine("program pilihan sederhana")

        Console.Write("Silahkan masukan pilihan for/star atau while/do: ")
        pilihan = Console.ReadLine()

        If pilihan = "for" Then
            For ganjil = 1 To 50 Step 2
                Console.WriteLine("kajil: " & ganjil)
            Next ganjil

        ElseIf pilihan = "star" Or pilihan = "while" Then
            Dim star As Integer = 1
            While star <= 10
                Dim bintang As Integer = 1
                Console.Write("*")
                bintang += 1
            End While
            Console.WriteLine()
            star += 1
            End While

        ElseIf pilihan = "do" Then
            Do While genap > 2
                genap -= 2
                Console.WriteLine("angka genap: " & genap)
            Loop
        End If
        Console.ReadKey()
    End Sub

End Module
