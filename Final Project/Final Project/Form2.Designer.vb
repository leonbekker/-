﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.tmr_ghost = New System.Windows.Forms.Timer(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.tmr_blackblocks = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_playerName = New System.Windows.Forms.Label
        Me.tmr_k = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.tmr_ghostattack = New System.Windows.Forms.Timer(Me.components)
        Me.timer_kick = New System.Windows.Forms.Timer(Me.components)
        Me.black_block9 = New System.Windows.Forms.PictureBox
        Me.player = New System.Windows.Forms.PictureBox
        Me.black_block8 = New System.Windows.Forms.PictureBox
        Me.F_black_block11 = New System.Windows.Forms.PictureBox
        Me.F_black_block10 = New System.Windows.Forms.PictureBox
        Me.ghost2 = New System.Windows.Forms.PictureBox
        Me.ghost4 = New System.Windows.Forms.PictureBox
        Me.ghost3 = New System.Windows.Forms.PictureBox
        Me.ghost1 = New System.Windows.Forms.PictureBox
        Me.F_black_block7 = New System.Windows.Forms.PictureBox
        Me.F_black_block6 = New System.Windows.Forms.PictureBox
        Me.F_black_block5 = New System.Windows.Forms.PictureBox
        Me.F_black_block4 = New System.Windows.Forms.PictureBox
        Me.F_black_block3 = New System.Windows.Forms.PictureBox
        Me.F_black_block2 = New System.Windows.Forms.PictureBox
        Me.F_black_block1 = New System.Windows.Forms.PictureBox
        CType(Me.black_block9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.player, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.black_block8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F_black_block11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F_black_block10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ghost2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ghost4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ghost3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ghost1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F_black_block7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F_black_block6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F_black_block5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F_black_block4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F_black_block3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F_black_block2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.F_black_block1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmr_ghost
        '
        Me.tmr_ghost.Interval = 1
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 12)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(448, 63)
        Me.ProgressBar1.TabIndex = 9
        Me.ProgressBar1.Value = 100
        '
        'tmr_blackblocks
        '
        Me.tmr_blackblocks.Interval = 1
        '
        'lbl_playerName
        '
        Me.lbl_playerName.AutoSize = True
        Me.lbl_playerName.BackColor = System.Drawing.Color.Transparent
        Me.lbl_playerName.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_playerName.Location = New System.Drawing.Point(225, 315)
        Me.lbl_playerName.Name = "lbl_playerName"
        Me.lbl_playerName.Size = New System.Drawing.Size(82, 32)
        Me.lbl_playerName.TabIndex = 20
        Me.lbl_playerName.Text = "Player"
        '
        'tmr_k
        '
        Me.tmr_k.Enabled = True
        Me.tmr_k.Interval = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Palatino Linotype", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(684, 243)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 32)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "Player"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(567, 261)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Label2"
        '
        'tmr_ghostattack
        '
        Me.tmr_ghostattack.Interval = 1000
        '
        'timer_kick
        '
        Me.timer_kick.Interval = 250
        '
        'black_block9
        '
        Me.black_block9.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.black_block9.Location = New System.Drawing.Point(-350, 255)
        Me.black_block9.Name = "black_block9"
        Me.black_block9.Size = New System.Drawing.Size(488, 605)
        Me.black_block9.TabIndex = 17
        Me.black_block9.TabStop = False
        '
        'player
        '
        Me.player.BackColor = System.Drawing.Color.Transparent
        Me.player.Image = Global._________.My.Resources.Resources.Stickman___Normal_stand_at_fight__right_
        Me.player.Location = New System.Drawing.Point(231, 350)
        Me.player.Name = "player"
        Me.player.Size = New System.Drawing.Size(114, 172)
        Me.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.player.TabIndex = 21
        Me.player.TabStop = False
        '
        'black_block8
        '
        Me.black_block8.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.black_block8.Location = New System.Drawing.Point(1123, 255)
        Me.black_block8.Name = "black_block8"
        Me.black_block8.Size = New System.Drawing.Size(799, 605)
        Me.black_block8.TabIndex = 7
        Me.black_block8.TabStop = False
        '
        'F_black_block11
        '
        Me.F_black_block11.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.F_black_block11.Location = New System.Drawing.Point(1023, 561)
        Me.F_black_block11.Name = "F_black_block11"
        Me.F_black_block11.Size = New System.Drawing.Size(115, 964)
        Me.F_black_block11.TabIndex = 19
        Me.F_black_block11.TabStop = False
        '
        'F_black_block10
        '
        Me.F_black_block10.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.F_black_block10.Location = New System.Drawing.Point(126, 548)
        Me.F_black_block10.Name = "F_black_block10"
        Me.F_black_block10.Size = New System.Drawing.Size(100, 964)
        Me.F_black_block10.TabIndex = 18
        Me.F_black_block10.TabStop = False
        '
        'ghost2
        '
        Me.ghost2.BackColor = System.Drawing.Color.Transparent
        Me.ghost2.Image = CType(resources.GetObject("ghost2.Image"), System.Drawing.Image)
        Me.ghost2.Location = New System.Drawing.Point(1348, 83)
        Me.ghost2.Name = "ghost2"
        Me.ghost2.Size = New System.Drawing.Size(55, 107)
        Me.ghost2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ghost2.TabIndex = 12
        Me.ghost2.TabStop = False
        '
        'ghost4
        '
        Me.ghost4.BackColor = System.Drawing.Color.Transparent
        Me.ghost4.Image = CType(resources.GetObject("ghost4.Image"), System.Drawing.Image)
        Me.ghost4.Location = New System.Drawing.Point(1519, 124)
        Me.ghost4.Name = "ghost4"
        Me.ghost4.Size = New System.Drawing.Size(55, 107)
        Me.ghost4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ghost4.TabIndex = 11
        Me.ghost4.TabStop = False
        '
        'ghost3
        '
        Me.ghost3.BackColor = System.Drawing.Color.Transparent
        Me.ghost3.Image = CType(resources.GetObject("ghost3.Image"), System.Drawing.Image)
        Me.ghost3.Location = New System.Drawing.Point(1430, 102)
        Me.ghost3.Name = "ghost3"
        Me.ghost3.Size = New System.Drawing.Size(55, 107)
        Me.ghost3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ghost3.TabIndex = 10
        Me.ghost3.TabStop = False
        '
        'ghost1
        '
        Me.ghost1.BackColor = System.Drawing.Color.Transparent
        Me.ghost1.Image = CType(resources.GetObject("ghost1.Image"), System.Drawing.Image)
        Me.ghost1.Location = New System.Drawing.Point(-177, 121)
        Me.ghost1.Name = "ghost1"
        Me.ghost1.Size = New System.Drawing.Size(55, 107)
        Me.ghost1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ghost1.TabIndex = 8
        Me.ghost1.TabStop = False
        '
        'F_black_block7
        '
        Me.F_black_block7.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.F_black_block7.Location = New System.Drawing.Point(907, 548)
        Me.F_black_block7.Name = "F_black_block7"
        Me.F_black_block7.Size = New System.Drawing.Size(126, 964)
        Me.F_black_block7.TabIndex = 6
        Me.F_black_block7.TabStop = False
        '
        'F_black_block6
        '
        Me.F_black_block6.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.F_black_block6.Location = New System.Drawing.Point(756, 561)
        Me.F_black_block6.Name = "F_black_block6"
        Me.F_black_block6.Size = New System.Drawing.Size(155, 964)
        Me.F_black_block6.TabIndex = 5
        Me.F_black_block6.TabStop = False
        '
        'F_black_block5
        '
        Me.F_black_block5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.F_black_block5.Location = New System.Drawing.Point(637, 540)
        Me.F_black_block5.Name = "F_black_block5"
        Me.F_black_block5.Size = New System.Drawing.Size(127, 964)
        Me.F_black_block5.TabIndex = 4
        Me.F_black_block5.TabStop = False
        '
        'F_black_block4
        '
        Me.F_black_block4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.F_black_block4.Location = New System.Drawing.Point(530, 530)
        Me.F_black_block4.Name = "F_black_block4"
        Me.F_black_block4.Size = New System.Drawing.Size(116, 964)
        Me.F_black_block4.TabIndex = 3
        Me.F_black_block4.TabStop = False
        '
        'F_black_block3
        '
        Me.F_black_block3.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.F_black_block3.Location = New System.Drawing.Point(422, 561)
        Me.F_black_block3.Name = "F_black_block3"
        Me.F_black_block3.Size = New System.Drawing.Size(116, 964)
        Me.F_black_block3.TabIndex = 2
        Me.F_black_block3.TabStop = False
        '
        'F_black_block2
        '
        Me.F_black_block2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.F_black_block2.Location = New System.Drawing.Point(310, 548)
        Me.F_black_block2.Name = "F_black_block2"
        Me.F_black_block2.Size = New System.Drawing.Size(116, 964)
        Me.F_black_block2.TabIndex = 1
        Me.F_black_block2.TabStop = False
        '
        'F_black_block1
        '
        Me.F_black_block1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.F_black_block1.Location = New System.Drawing.Point(218, 561)
        Me.F_black_block1.Name = "F_black_block1"
        Me.F_black_block1.Size = New System.Drawing.Size(97, 964)
        Me.F_black_block1.TabIndex = 0
        Me.F_black_block1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1243, 745)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.black_block9)
        Me.Controls.Add(Me.player)
        Me.Controls.Add(Me.lbl_playerName)
        Me.Controls.Add(Me.black_block8)
        Me.Controls.Add(Me.F_black_block11)
        Me.Controls.Add(Me.F_black_block10)
        Me.Controls.Add(Me.ghost2)
        Me.Controls.Add(Me.ghost4)
        Me.Controls.Add(Me.ghost3)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ghost1)
        Me.Controls.Add(Me.F_black_block7)
        Me.Controls.Add(Me.F_black_block6)
        Me.Controls.Add(Me.F_black_block5)
        Me.Controls.Add(Me.F_black_block4)
        Me.Controls.Add(Me.F_black_block3)
        Me.Controls.Add(Me.F_black_block2)
        Me.Controls.Add(Me.F_black_block1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        CType(Me.black_block9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.player, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.black_block8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F_black_block11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F_black_block10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ghost2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ghost4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ghost3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ghost1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F_black_block7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F_black_block6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F_black_block5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F_black_block4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F_black_block3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F_black_block2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.F_black_block1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents F_black_block1 As System.Windows.Forms.PictureBox
    Friend WithEvents F_black_block2 As System.Windows.Forms.PictureBox
    Friend WithEvents F_black_block3 As System.Windows.Forms.PictureBox
    Friend WithEvents F_black_block4 As System.Windows.Forms.PictureBox
    Friend WithEvents F_black_block5 As System.Windows.Forms.PictureBox
    Friend WithEvents F_black_block6 As System.Windows.Forms.PictureBox
    Friend WithEvents F_black_block7 As System.Windows.Forms.PictureBox
    Friend WithEvents black_block8 As System.Windows.Forms.PictureBox
    Friend WithEvents ghost1 As System.Windows.Forms.PictureBox
    Friend WithEvents tmr_ghost As System.Windows.Forms.Timer
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ghost3 As System.Windows.Forms.PictureBox
    Friend WithEvents ghost4 As System.Windows.Forms.PictureBox
    Friend WithEvents ghost2 As System.Windows.Forms.PictureBox
    Friend WithEvents tmr_blackblocks As System.Windows.Forms.Timer
    Friend WithEvents black_block9 As System.Windows.Forms.PictureBox
    Friend WithEvents F_black_block10 As System.Windows.Forms.PictureBox
    Friend WithEvents F_black_block11 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_playerName As System.Windows.Forms.Label
    Friend WithEvents tmr_k As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents player As System.Windows.Forms.PictureBox
    Friend WithEvents tmr_ghostattack As System.Windows.Forms.Timer
    Friend WithEvents timer_kick As System.Windows.Forms.Timer
End Class
