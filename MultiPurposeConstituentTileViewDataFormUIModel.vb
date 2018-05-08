Public Class MultiPurposeConstituentTileViewDataFormUIModel

    Private Sub MultiPurposeConstituentTileViewDataFormUIModel_Loaded(ByVal sender As Object, ByVal e As Blackbaud.AppFx.UIModeling.Core.LoadedEventArgs) Handles Me.Loaded

        'HEADERLINK.Name = "Desta"
        If TILEHEADER.Value.ToString() <> "" Then
            HEADERLINK.Caption = TILEHEADER.Value
        Else
            HEADERLINK.Caption = "Multi-purpose Tile"
        End If


        If Me.CONSTITUENTINFO.Value.Count <= 1 Then
            Me.CONSTITUENTINFOCOUNTTEXT.Visible = False
            Me.PREVIOUSRECORD.Visible = False
            Me.NEXTRECORD.Visible = False
        End If
        If Me.CONSTITUENTINFO.Value.Count > 0 Then
            Me.CURRENTRECORDINDEX.Value = 0
            Draw()
        Else
            Me.LINEONE.Visible = False
            Me.LINETWO.Visible = False
            Me.LINETHREE.Visible = False
            Me.LINEFOUR.Visible = False
            Me.LINEFIVE.Visible = False
            Me.NOCONSTITUENTINFO.Visible = True
        End If
    End Sub
    Private Function GetCurrentRecord() As MultiPurposeConstituentTileViewDataFormCONSTITUENTINFOUIModel
        Return Me.CONSTITUENTINFO.Value(Me.CURRENTRECORDINDEX.Value)
    End Function
    Private Sub Draw()
        Dim currentRecord As MultiPurposeConstituentTileViewDataFormCONSTITUENTINFOUIModel = Nothing
        currentRecord = GetCurrentRecord()

        If currentRecord IsNot Nothing Then

            Me.CURRENTRECORDID.Value = currentRecord.ID.Value
            Me.CONSTITUENTINFOCOUNTTEXT.Value = String.Concat("(", (Me.CURRENTRECORDINDEX.Value + 1).ToString(Globalization.CultureInfo.InvariantCulture), " of ", Me.CONSTITUENTINFO.Value.Count.ToString(Globalization.CultureInfo.InvariantCulture), ")")

            Me.LINEONE.Value = currentRecord.LINEONE.Value
            Me.LINETWO.Value = currentRecord.LINETWO.Value
            Me.LINETHREE.Value = currentRecord.LINETHREE.Value
            Me.LINEFOUR.Value = currentRecord.LINEFOUR.Value
            Me.LINEFIVE.Value = currentRecord.LINEFIVE.Value
        End If

    End Sub

    Private Sub _previousrecord_InvokeAction() Handles _previousrecord.InvokeAction
        If Me.CURRENTRECORDINDEX.Value = 0 Then
            Me.CURRENTRECORDINDEX.Value = Me.CONSTITUENTINFO.Value.Count - 1
        Else
            Me.CURRENTRECORDINDEX.Value -= 1
        End If

        Draw()
    End Sub
    Private Sub _nextrecord_InvokeAction() Handles _nextrecord.InvokeAction
        If Me.CURRENTRECORDINDEX.Value = Me.CONSTITUENTINFO.Value.Count - 1 Then
            CURRENTRECORDINDEX.Value = 0
        Else
            Me.CURRENTRECORDINDEX.Value += 1
        End If

        Draw()
    End Sub
End Class