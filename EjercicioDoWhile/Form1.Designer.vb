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
        btnEjecuta = New Button()
        lblTitulo = New Label()
        txtNum = New TextBox()
        SuspendLayout()
        ' 
        ' btnEjecuta
        ' 
        btnEjecuta.BackColor = Color.LimeGreen
        btnEjecuta.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        btnEjecuta.ForeColor = SystemColors.ActiveCaptionText
        btnEjecuta.Location = New Point(130, 144)
        btnEjecuta.Name = "btnEjecuta"
        btnEjecuta.Size = New Size(107, 37)
        btnEjecuta.TabIndex = 0
        btnEjecuta.Text = "Ejecutar"
        btnEjecuta.UseVisualStyleBackColor = False
        ' 
        ' lblTitulo
        ' 
        lblTitulo.AutoSize = True
        lblTitulo.FlatStyle = FlatStyle.Popup
        lblTitulo.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        lblTitulo.Location = New Point(131, 52)
        lblTitulo.Name = "lblTitulo"
        lblTitulo.Size = New Size(94, 25)
        lblTitulo.TabIndex = 1
        lblTitulo.Text = "Opciones"
        ' 
        ' txtNum
        ' 
        txtNum.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        txtNum.Location = New Point(130, 90)
        txtNum.Name = "txtNum"
        txtNum.Size = New Size(100, 29)
        txtNum.TabIndex = 2
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(472, 322)
        Controls.Add(txtNum)
        Controls.Add(lblTitulo)
        Controls.Add(btnEjecuta)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnEjecuta As Button
    Friend WithEvents lblTitulo As Label
    Friend WithEvents txtNum As TextBox
End Class
