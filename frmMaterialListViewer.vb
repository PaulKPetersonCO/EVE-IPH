﻿Public Class frmMaterialListViewer

    Public Sub New(MaterialList As Materials)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim matLine As ListViewItem
        Dim TotalCost As Double = 0
        For Each Mat In MaterialList.GetMaterialList
            ' Add all the mats to the grid
            matLine = New ListViewItem(Mat.GetMaterialName)
            matLine.SubItems.Add(FormatNumber(Mat.GetQuantity, 0))
            matLine.SubItems.Add(FormatNumber(Mat.GetTotalCost, 2))
            Call lstMaterials.Items.Add(matLine)
            TotalCost += Mat.GetTotalCost
        Next

        ' Add the total cost
        matLine = New ListViewItem("Total Cost")
        matLine.SubItems.Add("")
        matLine.SubItems.Add(FormatNumber(TotalCost, 2))
        Call lstMaterials.Items.Add(matLine)

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

End Class