Public Class Workoutday
    Public Property Day As String
    Public Property Units As List(Of WorkoutUnit)

    Sub New()
        Units = New List(Of WorkoutUnit)
    End Sub
    Sub New(ByVal _day As String, ByVal _ListofUnits As List(Of WorkoutUnit))
        Day = _day
        Units = _ListofUnits
    End Sub

End Class
