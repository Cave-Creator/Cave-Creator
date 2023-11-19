<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UpdatingForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UpdatingForm))
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.lbl_Bytes = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Status.ForeColor = System.Drawing.Color.White
        Me.lbl_Status.Location = New System.Drawing.Point(431, 22)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(183, 20)
        Me.lbl_Status.TabIndex = 1
        Me.lbl_Status.Text = "Updating Cave Creator..."
        Me.lbl_Status.UseWaitCursor = True
        '
        'lbl_Bytes
        '
        Me.lbl_Bytes.AutoSize = True
        Me.lbl_Bytes.BackColor = System.Drawing.Color.Transparent
        Me.lbl_Bytes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Bytes.ForeColor = System.Drawing.Color.White
        Me.lbl_Bytes.Location = New System.Drawing.Point(524, 55)
        Me.lbl_Bytes.Name = "lbl_Bytes"
        Me.lbl_Bytes.Size = New System.Drawing.Size(36, 20)
        Me.lbl_Bytes.TabIndex = 3
        Me.lbl_Bytes.Text = "test"
        Me.lbl_Bytes.UseWaitCursor = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'UpdatingForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(636, 365)
        Me.Controls.Add(Me.lbl_Bytes)
        Me.Controls.Add(Me.lbl_Status)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "UpdatingForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cave Creator"
        Me.UseWaitCursor = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Status As Label
    Friend WithEvents lbl_Bytes As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
