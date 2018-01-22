Public Class WorkoutUnit

    Public Property Name As String
    Public Property Reps As String
    Public Property Weight As String
    Public Property Info As String
    Public Property isSprset As Boolean
    Public Property isTrset As Boolean

    Sub New(_name As String, _reps As String, _weight As String, Optional _info As String = "", Optional _sprset As Boolean = False, Optional _trset As Boolean = False)
        Me.Name = _name
        Me.Reps = _reps
        Me.Weight = _weight
        Me.Info = _info
        Me.isSprset = _sprset
        Me.isTrset = _trset

    End Sub

End Class
