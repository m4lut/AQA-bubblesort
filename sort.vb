Module Module1
 
	Sub Main()
    	Dim NumberSet() As Integer = {67, 25, 92, 49, 38, 72, 99, 54}
    	Console.WriteLine("Original set:")
    	For j As Integer = 0 To NumberSet.Length - 1
        	Console.Write(NumberSet(j) & " ")
    	Next
    	Console.WriteLine("")
    	Dim Temp As Integer
    	Dim n As Integer = NumberSet.Length
    	n -= 2
    	For k As Integer = 0 To n
        	For i As Integer = 0 To n
            	If NumberSet(i) > NumberSet(i + 1) Then
       	         Temp = NumberSet(i + 1)
                	NumberSet(i + 1) = NumberSet(i)
                	NumberSet(i) = Temp
            	End If
        	Next
        	Console.WriteLine("Loop " & k + 1)
        	For j As Integer = 0 To NumberSet.Length - 1
            	Console.Write(NumberSet(j) & " ")
        	Next
        	Console.WriteLine("")
    	Next
    	Console.WriteLine("--NUMBER SET SORTED--")
    	Console.ReadLine()
	End Sub
 
End Module

