'Christopher Pickens
'RCET0265
'Spring 2023
'Accumulate Messages
'https://github.com/Pickchr2/AccumulateMessages.git

Imports System

Module MessageProgram
    Sub Main(args As String())
        'uncomment to test interactively
        Test.Manual()
        'Test.Auto()
    End Sub

    Function UserMessages(ByVal newMessage As String, ByVal clear As Boolean) As String
        'your code here

        Static messages As String
        If clear Then
            messages = ""
        Else
            messages += newMessage + vbCrLf
        End If
        Return messages
    End Function
End Module
