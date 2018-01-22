Public Class Workoutplan
    Public Property DteFrom As DateTime = DateTime.Now
    Public Property DteTo As DateTime = DateTime.Now
    Public Property Plan As New List(Of Workoutday)
End Class
