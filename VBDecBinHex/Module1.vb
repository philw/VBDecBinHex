Module Module1

    Sub Main()

        Dim Rnd As New Random
        Dim TheNumber As Integer
        Dim BinString As String
        Dim HexString As String
        Dim Answer As String
        Dim NumberAnswer As Integer
        Dim QuestionType As Integer
        Dim Again As Char


        Do
            TheNumber = Rnd.Next(3, 256)
            BinString = Convert.ToString(TheNumber, 2).PadLeft(8, "0")
            HexString = Convert.ToString(TheNumber, 16).PadLeft(2, "0").ToUpper

            QuestionType = Rnd.Next(6)
            'QuestionType = 5

            Select Case QuestionType
                Case 0
                    ' decimal to binary
                    Console.Write("What is {0} written in binary? ", TheNumber)
                    Answer = Console.ReadLine
                    Answer = Answer.PadLeft(8, "0").ToUpper
                    If Answer = BinString Then
                        Console.WriteLine("Correct")
                    Else
                        Console.WriteLine("WRONG - the answer is {0}", BinString)
                    End If

                Case 1
                    ' binary to decimal
                    Console.Write("What is the binary number {0} written as a decimal? ", BinString)
                    NumberAnswer = Console.ReadLine

                    If NumberAnswer = TheNumber Then
                        Console.WriteLine("Correct")
                    Else
                        Console.WriteLine("WRONG - the answer is {0}", TheNumber)
                    End If

                Case 2
                    ' binary to hexadecinal
                    Console.Write("What is the binary number {0} written in hexadecimal? ", BinString)
                    Answer = Console.ReadLine
                    Answer = Answer.PadLeft(2, "0").ToUpper
                    If Answer = HexString Then
                        Console.WriteLine("Correct")
                    Else
                        Console.WriteLine("WRONG - the answer is {0}", HexString)
                    End If

                Case 3
                    ' hexadecimal to binary
                    Console.Write("What is the hexadecimal number {0} written in binary? ", HexString)
                    Answer = Console.ReadLine
                    Answer = Answer.PadLeft(8, "0").ToUpper
                    If Answer = BinString Then
                        Console.WriteLine("Correct")
                    Else
                        Console.WriteLine("WRONG - the answer is {0}", BinString)
                    End If

                Case 4
                    ' decimal to hexadecimal
                    Console.Write("What is the number {0} written in hexdecimal? ", TheNumber)
                    Answer = Console.ReadLine.PadLeft(2, "0").ToUpper

                    If Answer = HexString Then
                        Console.WriteLine("Correct")
                    Else
                        Console.WriteLine("WRONG - the answer is {0}", HexString)
                    End If

                Case 5
                    ' hexadecimal to decimal
                    Console.Write("What is the hexadecimal number {0} written as a decimal? ", HexString)
                    NumberAnswer = Console.ReadLine

                    If NumberAnswer = TheNumber Then
                        Console.WriteLine("Correct")
                    Else
                        Console.WriteLine("WRONG - the answer is {0}", TheNumber)
                    End If



            End Select

            Console.Write("Another question? ")
            Again = Console.ReadLine.ToUpper


        Loop While Again = "Y"

    End Sub

End Module
