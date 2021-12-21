Public Class frmBase
    Private intHashType As Integer = 0

    Private Sub btnCalculatekWhS_Click(sender As Object, e As EventArgs) Handles btnCalculatekWh.Click
        txtkWh.Text = CType(((numWatts.Value * numTime.Value) / 1000), String)
        txtTotalCost.Text = "$" + CType((((numWatts.Value * numTime.Value) / 1000) * numCost.Value), String)
    End Sub

    Private Sub btnResetkWh_Click(sender As Object, e As EventArgs) Handles btnResetkWh.Click
        txtkWh.Text = ""
        txtTotalCost.Text = ""
        numCost.Value = 0
        numTime.Value = 0
        numWatts.Value = 0
    End Sub

    Private Sub lboxTypes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lboxTypes.SelectedIndexChanged
        lboxHash.Items.Clear()
        intHashType = getHashType()
        setHashList(intHashType)
        lboxHash.Update()
    End Sub

    Function getHashType() As Integer
        Dim temp As Integer = 0
        temp = lboxTypes.SelectedIndex
        Return temp
    End Function

    Sub setHashList(ByVal intHashType As Integer)
        Select Case intHashType
            Case 0
                lboxHash.Items.Add(numHash.Value)
                lboxHash.Items.Add(numHash.Value / 1000)
                lboxHash.Items.Add(numHash.Value / 1000000)
                lboxHash.Items.Add(numHash.Value / 1000000000)
                lboxHash.Items.Add(numHash.Value / 1000000000000)
                lboxHash.Items.Add(numHash.Value / 1000000000000000)
                lboxHash.Items.Add(numHash.Value / 1000000000000000000)
            Case 1
                lboxHash.Items.Add(numHash.Value * 1000)
                lboxHash.Items.Add(numHash.Value)
                lboxHash.Items.Add(numHash.Value / 1000)
                lboxHash.Items.Add(numHash.Value / 1000000)
                lboxHash.Items.Add(numHash.Value / 1000000000)
                lboxHash.Items.Add(numHash.Value / 1000000000000)
                lboxHash.Items.Add(numHash.Value / 1000000000000000)
            Case 2
                lboxHash.Items.Add(numHash.Value * 1000000)
                lboxHash.Items.Add(numHash.Value * 1000)
                lboxHash.Items.Add(numHash.Value)
                lboxHash.Items.Add(numHash.Value / 1000)
                lboxHash.Items.Add(numHash.Value / 1000000)
                lboxHash.Items.Add(numHash.Value / 1000000000)
                lboxHash.Items.Add(numHash.Value / 1000000000000)
            Case 3
                lboxHash.Items.Add(numHash.Value * 1000000000)
                lboxHash.Items.Add(numHash.Value * 1000000)
                lboxHash.Items.Add(numHash.Value * 1000)
                lboxHash.Items.Add(numHash.Value)
                lboxHash.Items.Add(numHash.Value / 1000)
                lboxHash.Items.Add(numHash.Value / 1000000)
                lboxHash.Items.Add(numHash.Value / 1000000000)
            Case 4
                lboxHash.Items.Add(numHash.Value * 1000000000000)
                lboxHash.Items.Add(numHash.Value * 1000000000)
                lboxHash.Items.Add(numHash.Value * 1000000)
                lboxHash.Items.Add(numHash.Value * 1000)
                lboxHash.Items.Add(numHash.Value)
                lboxHash.Items.Add(numHash.Value / 1000)
                lboxHash.Items.Add(numHash.Value / 1000000)
            Case 5
                lboxHash.Items.Add(numHash.Value * 1000000000000000)
                lboxHash.Items.Add(numHash.Value * 1000000000000)
                lboxHash.Items.Add(numHash.Value * 1000000000)
                lboxHash.Items.Add(numHash.Value * 1000000)
                lboxHash.Items.Add(numHash.Value * 1000)
                lboxHash.Items.Add(numHash.Value)
                lboxHash.Items.Add(numHash.Value / 1000)
            Case 6
                lboxHash.Items.Add(numHash.Value * 1000000000000000000)
                lboxHash.Items.Add(numHash.Value * 1000000000000000)
                lboxHash.Items.Add(numHash.Value * 1000000000000)
                lboxHash.Items.Add(numHash.Value * 1000000000)
                lboxHash.Items.Add(numHash.Value * 1000000)
                lboxHash.Items.Add(numHash.Value * 1000)
                lboxHash.Items.Add(numHash.Value)
        End Select
    End Sub
End Class