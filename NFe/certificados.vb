Imports System.Security.Cryptography.X509Certificates

Public Class certificados

    Private Sub certificados_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Function BuscaCertificado() As ICollection(Of X509Certificate2)
        Try

            Dim listaDeCertificados As New List(Of X509Certificate2)

            Dim certificado As X509Certificate2 = Nothing

            Dim store As New X509Store(StoreName.My, StoreLocation.CurrentUser)
            store.Open(OpenFlags.[ReadOnly] Or OpenFlags.OpenExistingOnly)


            For Each item As X509Certificate2 In store.Certificates
                'If item.SerialNumber.ToUpper().Equals(numeroSerial.ToUpper()) Then
                'certificado = item
                'End If
                listaDeCertificados.Add(item)
            Next

            If certificado Is Nothing Then
                Throw New Exception([String].Format("Certificado digital nº {0} não encontrado." & vbLf & "É necessário fazer a instalação do mesmo."))
            End If

            'Return certificado
            Return listaDeCertificados
        Catch be As Exception
            MessageBox.Show(be.Message)
        End Try
    End Function
    Public Function BuscaCertificados(ByVal nome As String) As X509Certificate2
        Dim _x509Cert As New X509Certificate2
        Try
            Dim store As New X509Store("MY", StoreLocation.CurrentUser)
            store.Open(OpenFlags.ReadOnly OrElse OpenFlags.OpenExistingOnly)

            Dim collection As X509Certificate2Collection = CType(store.Certificates, X509Certificate2Collection)
            Dim collection1 As X509Certificate2Collection = CType(collection.Find(X509FindType.FindByTimeValid, DateTime.Now, False), X509Certificate2Collection)
            Dim collection2 As X509Certificate2Collection = CType(collection1.Find(X509FindType.FindByKeyUsage, X509KeyUsageFlags.DigitalSignature, False), X509Certificate2Collection)

            If nome = "" Then
                Dim storeCollection As X509Certificate2Collection = X509Certificate2UI.SelectFromCollection(collection2, "Certificado(s) Digital(is) disponível(is)", "Selecione o Certificado Digital para uso no aplicativo", X509SelectionFlag.SingleSelection)
                If storeCollection.Count = 0 Then
                    _x509Cert.Reset()
                    MessageBox.Show("Nenhum certificado escolhido")
                Else
                    _x509Cert = storeCollection(0)
                End If
                store.Close()
                Return _x509Cert
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return _x509Cert
        End Try
    End Function
    
  
    '_X509Cert = scollection[0];
    '}
    '}
    'else
    '{
    'X509Certificate2Collection scollection = (X509Certificate2Collection)collection2.Find(X509FindType.FindBySubjectDistinguishedName, Nome, false);
    'if (scollection.Count == 0)
    '{
    'Console.WriteLine(”Nenhum certificado válido foi encontrado com o nome informado: ” + Nome, “Atenção”);
    '_X509Cert.Reset();
    '}
    'else
    '{
    '_X509Cert = scollection[0];
    '}
    '}
    'store.Close();
    'return _X509Cert;
    '}
    'catch (System.Exception ex)
    '{
    'Console.WriteLine(ex.Message);
    'return _X509Cert;
    '}
    '}
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'DataGridView1.DataSource = BuscaCertificado()
        BuscaCertificados("")
    End Sub
End Class