Module Module1

    Sub Main()
        Dim strVal As String = "Queens's University of Canada wants you to create a windows application Using (C# or VB.Net) for New Student Registration with a main Menu Form. The main Menu From has a Menu with Menu Items called New Registration, Exit When the New Registration menu item clicked a Student Details Form appears with a grid (data grid view) on the form and a AddNew Button and a Save Button on the form to Enter the Student details and Save"
        Dim strList As New List(Of String)(strVal.Split(" "))

        Sort(strList, "S")

    End Sub

    Public Function Sort(ByVal theList As List(Of String), ByVal theChar As Char) As List(Of String)

        Dim tempLiOb As IEnumerable(Of String) = From resultValues In theList
                Where (resultValues.StartsWith(theChar))

        Sort = tempLiOb.ToList

        Return Sort

        ' Fill me in
    End Function

End Module
