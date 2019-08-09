<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAmpel
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblRot = New System.Windows.Forms.Label()
        Me.lblgelb = New System.Windows.Forms.Label()
        Me.lblGrün = New System.Windows.Forms.Label()
        Me.btnWeiter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRot
        '
        Me.lblRot.BackColor = System.Drawing.Color.Gray
        Me.lblRot.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRot.Location = New System.Drawing.Point(301, 18)
        Me.lblRot.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRot.Name = "lblRot"
        Me.lblRot.Size = New System.Drawing.Size(110, 64)
        Me.lblRot.TabIndex = 0
        '
        'lblgelb
        '
        Me.lblgelb.BackColor = System.Drawing.Color.Gray
        Me.lblgelb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblgelb.Location = New System.Drawing.Point(301, 136)
        Me.lblgelb.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblgelb.Name = "lblgelb"
        Me.lblgelb.Size = New System.Drawing.Size(110, 64)
        Me.lblgelb.TabIndex = 1
        '
        'lblGrün
        '
        Me.lblGrün.BackColor = System.Drawing.Color.Gray
        Me.lblGrün.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblGrün.Location = New System.Drawing.Point(301, 254)
        Me.lblGrün.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGrün.Name = "lblGrün"
        Me.lblGrün.Size = New System.Drawing.Size(110, 64)
        Me.lblGrün.TabIndex = 2
        '
        'btnWeiter
        '
        Me.btnWeiter.Location = New System.Drawing.Point(301, 372)
        Me.btnWeiter.Margin = New System.Windows.Forms.Padding(4)
        Me.btnWeiter.Name = "btnWeiter"
        Me.btnWeiter.Size = New System.Drawing.Size(111, 64)
        Me.btnWeiter.TabIndex = 3
        Me.btnWeiter.Tag = "0"
        Me.btnWeiter.Text = "Start"
        Me.btnWeiter.UseVisualStyleBackColor = True
        '
        'frmAmpel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnWeiter)
        Me.Controls.Add(Me.lblGrün)
        Me.Controls.Add(Me.lblgelb)
        Me.Controls.Add(Me.lblRot)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "frmAmpel"
        Me.Text = "Ampel"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblRot As Label
    Friend WithEvents lblgelb As Label
    Friend WithEvents lblGrün As Label
    Friend WithEvents btnWeiter As Button
End Class
