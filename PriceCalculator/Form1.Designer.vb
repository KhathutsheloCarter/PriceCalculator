<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnClaculate = New Button()
        txtPrice = New TextBox()
        txtQuantity = New TextBox()
        lblPrice = New Label()
        lblQuantity = New Label()
        SuspendLayout()
        ' 
        ' btnClaculate
        ' 
        btnClaculate.Location = New Point(289, 218)
        btnClaculate.Name = "btnClaculate"
        btnClaculate.Size = New Size(166, 69)
        btnClaculate.TabIndex = 0
        btnClaculate.Text = "Total for Customer"
        btnClaculate.UseVisualStyleBackColor = True
        ' 
        ' txtPrice
        ' 
        txtPrice.Location = New Point(343, 59)
        txtPrice.Name = "txtPrice"
        txtPrice.Size = New Size(125, 27)
        txtPrice.TabIndex = 1
        ' 
        ' txtQuantity
        ' 
        txtQuantity.Location = New Point(343, 116)
        txtQuantity.Name = "txtQuantity"
        txtQuantity.Size = New Size(125, 27)
        txtQuantity.TabIndex = 2
        ' 
        ' lblPrice
        ' 
        lblPrice.AutoSize = True
        lblPrice.Location = New Point(187, 59)
        lblPrice.Name = "lblPrice"
        lblPrice.Size = New Size(99, 20)
        lblPrice.TabIndex = 3
        lblPrice.Text = "Price Per Item"
        ' 
        ' lblQuantity
        ' 
        lblQuantity.AutoSize = True
        lblQuantity.Location = New Point(187, 116)
        lblQuantity.Name = "lblQuantity"
        lblQuantity.Size = New Size(123, 20)
        lblQuantity.TabIndex = 4
        lblQuantity.Text = "Quantity of Items"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lblQuantity)
        Controls.Add(lblPrice)
        Controls.Add(txtQuantity)
        Controls.Add(txtPrice)
        Controls.Add(btnClaculate)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnClaculate As Button
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblPrice As Label
    Friend WithEvents lblQuantity As Label
End Class
