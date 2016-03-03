Imports System.Xml
Imports System.Xml.Schema
Imports System.IO
Imports System.Net

Public Class ValidadorXml

    Private Shared ErroValidadorXML As String

    Public Shared Sub Validar(schema As String, document As String)

        Dim booksSettings As XmlReaderSettings = New XmlReaderSettings()

        booksSettings.Schemas.Add("http://www.portalfiscal.inf.br/nfe", schema)
        booksSettings.ValidationType = ValidationType.Schema

        AddHandler booksSettings.ValidationEventHandler, New ValidationEventHandler(AddressOf booksSettingsValidationEventHandler)

        Dim books As XmlReader = XmlReader.Create(document, booksSettings)

        While books.Read()

        End While

    End Sub

    Shared Sub booksSettingsValidationEventHandler(ByVal sender As Object, ByVal e As ValidationEventArgs)

        If e.Severity = XmlSeverityType.Warning Then
            Console.Write("WARNING: ")
            Console.WriteLine(e.Message)

        ElseIf e.Severity = XmlSeverityType.Error Then
            Console.Write("ERROR: ")
            Console.WriteLine(e.Message)
        End If

    End Sub
   
End Class
