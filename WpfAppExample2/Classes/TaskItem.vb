Imports System.ComponentModel
Imports System.Runtime.CompilerServices
Imports JetBrains.Annotations

Namespace Classes
    Public Class TaskItem
        Implements INotifyPropertyChanged

        Private _description As String
        Private _taskName As String
        Private _priority As Integer

        Public Property TaskName() As String
            Get
                Return _taskName
            End Get
            Set(ByVal value As String)
                If value = _taskName Then
                    Return
                End If
                _taskName = value
                OnPropertyChanged()
            End Set
        End Property
        Public Property Description() As String
            Get
                Return _description
            End Get
            Set(ByVal value As String)
                If value = _description Then
                    Return
                End If
                _description = value
                OnPropertyChanged()
            End Set
        End Property

        Public Property TaskType() As TaskType
        Public Property Priority() As Integer
            Get
                Return _priority
            End Get
            Set(ByVal value As Integer)
                If value = _priority Then
                    Return
                End If
                _priority = value
                OnPropertyChanged()
            End Set
        End Property

        Public Overrides Function ToString() As String
            Return TaskName
        End Function
        Public Event PropertyChanged As PropertyChangedEventHandler _
            Implements INotifyPropertyChanged.PropertyChanged

        <NotifyPropertyChangedInvocator>
        Protected Overridable Sub OnPropertyChanged(<CallerMemberName>
            Optional ByVal propertyName As String = Nothing)

            PropertyChangedEvent?.Invoke(Me, New PropertyChangedEventArgs(propertyName))

        End Sub
    End Class
End Namespace
