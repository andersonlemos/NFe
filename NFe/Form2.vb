Imports System.Text
Imports System.Xml
Imports NFe.NFe

Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim n As New NFe.TNFe
        Dim x As New XmlDocument

        x.Load("d:\nota.xml")

        n = TNFe.Deserialize(x.OuterXml)

        Dim s As New StringBuilder

        s.Append(n)

        'Dim prod As New List(Of TNFeInfNFeDet)
        'prod = n.infNFe.det
        'For Each i As TNFeInfNFeDet In prod
        '    s.Append(i.nItem)
        'Next

        's.Append(item.nItem + " - " + item.prod.cProd + " - " + item.prod.xProd)

        'Next

        TextBox1.Text = s.ToString()

    End Sub

End Class