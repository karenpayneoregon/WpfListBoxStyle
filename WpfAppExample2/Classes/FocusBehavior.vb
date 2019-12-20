Namespace Classes
    ''' <summary>
    ''' attached behavior for selecting first control in a window
    ''' </summary>
    Public NotInheritable Class FocusBehavior

        Private Sub New()
        End Sub
        Public Shared ReadOnly GiveInitialFocusProperty As DependencyProperty = DependencyProperty.RegisterAttached("GiveInitialFocus", GetType(Boolean), GetType(FocusBehavior), New PropertyMetadata(False, AddressOf OnFocusFirstPropertyChanged))

        Public Shared Function GetGiveInitialFocus(ByVal control As Control) As Boolean
            Return DirectCast(control.GetValue(GiveInitialFocusProperty), Boolean)
        End Function
        Public Shared Sub SetGiveInitialFocus(ByVal control As Control, ByVal value As Boolean)
            control.SetValue(GiveInitialFocusProperty, value)
        End Sub

        Private Shared Sub OnFocusFirstPropertyChanged(ByVal sender As DependencyObject, ByVal args As DependencyPropertyChangedEventArgs)
            Dim tempVar As Boolean = TypeOf sender Is Control
            Dim control As Control = If(tempVar, CType(sender, Control), Nothing)
            If Not (tempVar) OrElse Not (TypeOf args.NewValue Is Boolean) Then
                Return
            End If

            If DirectCast(args.NewValue, Boolean) Then
                AddHandler control.Loaded, AddressOf OnControlLoaded
            Else
                RemoveHandler control.Loaded, AddressOf OnControlLoaded
            End If
        End Sub

        Private Shared Sub OnControlLoaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            DirectCast(sender, Control).MoveFocus(New TraversalRequest(FocusNavigationDirection.Next))
        End Sub
    End Class
End Namespace
