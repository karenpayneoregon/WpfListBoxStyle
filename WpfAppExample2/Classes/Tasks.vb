Imports System.Collections.ObjectModel

Namespace Classes
    Public Class Tasks
        Public Function List() As ObservableCollection(Of TaskItem)
            Return New ObservableCollection(Of TaskItem)() From {
                New TaskItem() With {
                        .Priority = 2,
                        .TaskType = TaskType.Work,
                        .TaskName = "Unit test data operations",
                        .Description = "Delegate to junior developer"
                    },
                New TaskItem() With {
                        .Priority = 1,
                        .TaskType = TaskType.Work,
                        .TaskName = "Prototype dashboard",
                        .Description = "Put together dashboard prototype"
                    },
                New TaskItem() With {
                        .Priority = 1,
                        .TaskType = TaskType.Home,
                        .TaskName = "Cook dinner",
                        .Description = "Ah, get a pizza"
                    },
                New TaskItem() With {
                        .Priority = 3,
                        .TaskType = TaskType.Work,
                        .TaskName = "Single signon discussion",
                        .Description = "Discuss options"
                    }
                }
        End Function
    End Class
End Namespace
