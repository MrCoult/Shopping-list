<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAdaug = New System.Windows.Forms.Button()
        Me.btnSterg = New System.Windows.Forms.Button()
        Me.btnSelect = New System.Windows.Forms.Button()
        Me.btnInversare = New System.Windows.Forms.Button()
        Me.btnStrglist = New System.Windows.Forms.Button()
        Me.btnStergtotL = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Lime", "Vodka", "Apa Plata", "Pere", "Portocale", "Coli", "Tus imprimanta"})
        Me.ListBox1.Location = New System.Drawing.Point(25, 35)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox1.Size = New System.Drawing.Size(168, 290)
        Me.ListBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(434, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 1
        '
        'btnAdaug
        '
        Me.btnAdaug.Location = New System.Drawing.Point(209, 52)
        Me.btnAdaug.Name = "btnAdaug"
        Me.btnAdaug.Size = New System.Drawing.Size(147, 23)
        Me.btnAdaug.TabIndex = 2
        Me.btnAdaug.Text = "Adauga produs"
        Me.btnAdaug.UseVisualStyleBackColor = True
        '
        'btnSterg
        '
        Me.btnSterg.Location = New System.Drawing.Point(209, 81)
        Me.btnSterg.Name = "btnSterg"
        Me.btnSterg.Size = New System.Drawing.Size(147, 23)
        Me.btnSterg.TabIndex = 3
        Me.btnSterg.Text = "Sterge produs"
        Me.btnSterg.UseVisualStyleBackColor = True
        '
        'btnSelect
        '
        Me.btnSelect.Location = New System.Drawing.Point(209, 110)
        Me.btnSelect.Name = "btnSelect"
        Me.btnSelect.Size = New System.Drawing.Size(147, 23)
        Me.btnSelect.TabIndex = 4
        Me.btnSelect.Text = "Produse selectate"
        Me.btnSelect.UseVisualStyleBackColor = True
        '
        'btnInversare
        '
        Me.btnInversare.Location = New System.Drawing.Point(209, 139)
        Me.btnInversare.Name = "btnInversare"
        Me.btnInversare.Size = New System.Drawing.Size(147, 23)
        Me.btnInversare.TabIndex = 5
        Me.btnInversare.Text = "Inversare selectie"
        Me.btnInversare.UseVisualStyleBackColor = True
        '
        'btnStrglist
        '
        Me.btnStrglist.Location = New System.Drawing.Point(209, 168)
        Me.btnStrglist.Name = "btnStrglist"
        Me.btnStrglist.Size = New System.Drawing.Size(147, 23)
        Me.btnStrglist.TabIndex = 6
        Me.btnStrglist.Text = "Sterge elemente selectate"
        Me.btnStrglist.UseVisualStyleBackColor = True
        '
        'btnStergtotL
        '
        Me.btnStergtotL.Location = New System.Drawing.Point(209, 197)
        Me.btnStergtotL.Name = "btnStergtotL"
        Me.btnStergtotL.Size = New System.Drawing.Size(147, 23)
        Me.btnStergtotL.TabIndex = 7
        Me.btnStergtotL.Text = "Sterge toata lista"
        Me.btnStergtotL.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 366)
        Me.Controls.Add(Me.btnStergtotL)
        Me.Controls.Add(Me.btnStrglist)
        Me.Controls.Add(Me.btnInversare)
        Me.Controls.Add(Me.btnSelect)
        Me.Controls.Add(Me.btnSterg)
        Me.Controls.Add(Me.btnAdaug)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ListBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnAdaug As Button
    Friend WithEvents btnSterg As Button
    Friend WithEvents btnSelect As Button
    Friend WithEvents btnInversare As Button
    Friend WithEvents btnStrglist As Button
    Friend WithEvents btnStergtotL As Button
End Class
