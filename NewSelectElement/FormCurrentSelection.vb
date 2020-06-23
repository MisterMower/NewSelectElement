Public Class FormCurrentSelection
    Private Sub FormCurrentSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CATIAV5 As INFITF.Application = GetCATIAV5()
        If CATIAV5 Is Nothing Then Close()
        SelectionTimer.Interval = 200
        SelectionTimer.Start()
    End Sub
    Private Sub TimerCATIAV5_Tick(sender As Object, e As EventArgs) Handles SelectionTimer.Tick
        Dim CATIAV5 As INFITF.Application = Nothing
        Try
            CATIAV5 = GetObject(vbNullString, "CATIA.Application")
        Catch ex As Exception
            MsgBox("CATIA V5 is not running.", vbOKOnly, "CATIA V5 Not Running")
            Close()
        End Try
        If CATIAV5 Is Nothing Then
            MsgBox("CATIA V5 is not running.", vbOKOnly, "CATIA V5 Not Running")
        End If
        Dim ActiveDocument As INFITF.Document = CATIAV5.ActiveDocument
        Dim Selection As INFITF.Selection = ActiveDocument.Selection
        Dim SelectionList As New List(Of INFITF.SelectedElement)
        For i As Integer = 1 To Selection.Count
            SelectionList.Add(Selection.Item(i))
        Next
        Select Case SelectionList.Count
            Case 0
                TextBoxObjectType.Text = "Nothing Selected"
                TextBoxObjectName.Text = "Nothing Selected"
            Case 1
                Dim SelectionItem As INFITF.SelectedElement = SelectionList.Item(0)
                Dim TypeName As String = SelectionItem.Type
                TextBoxObjectType.Text = TypeName
                Try
                    Dim LeafProduct As INFITF.AnyObject = SelectionItem.LeafProduct
                    If LeafProduct.Name = "InvalidLeafProduct" Then
                        TextBoxObjectName.Text = SelectionItem.Name
                    Else
                        TextBoxObjectName.Text = LeafProduct.Name
                    End If
                Catch ex As Runtime.InteropServices.COMException
                    TextBoxObjectName.Text = SelectionItem.Document.Name
                End Try
            Case Else
                TextBoxObjectType.Text = SelectionList.Count & " Items Selected"
                TextBoxObjectName.Text = SelectionList.Count & " Items Selected"
        End Select
        SelectionList.Clear()
    End Sub
    Private Sub ButtonClose_Click(sender As Object, e As EventArgs) Handles ButtonClose.Click
        Close()
    End Sub
End Class