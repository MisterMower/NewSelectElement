Module CATIAV5Operations
    Public Function GetCATIAV5() As INFITF.Application
        Try
            Dim CATIAV5 As INFITF.Application = GetObject(vbNullString, "CATIA.Application")
            Return CATIAV5
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
    Public Function GetRootDocument(CATIAV5 As INFITF.Application) As ProductStructureTypeLib.ProductDocument
        Try
            Dim RootDocument As ProductStructureTypeLib.ProductDocument = CATIAV5.ActiveDocument
            Return RootDocument
        Catch ex As Exception
            Return Nothing
        End Try
    End Function
End Module