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
        Me.StartInput = New System.Windows.Forms.Button()
        Me.EndInput = New System.Windows.Forms.Button()
        Me.NumberInput = New System.Windows.Forms.TextBox()
        Me.LengthBox = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LargeNumberWarning = New System.Windows.Forms.Label()
        Me.DistBox = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DistGraph = New System.Windows.Forms.ListBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.StdDevBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.LabelMean = New System.Windows.Forms.Label()
        Me.MeanBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MedianBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Q1Box = New System.Windows.Forms.TextBox()
        Me.Q2Box = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Q3Box = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Q4Box = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.SkewnessBox = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StartInput
        '
        Me.StartInput.Location = New System.Drawing.Point(294, 170)
        Me.StartInput.Name = "StartInput"
        Me.StartInput.Size = New System.Drawing.Size(75, 23)
        Me.StartInput.TabIndex = 0
        Me.StartInput.Text = "Start"
        Me.StartInput.UseVisualStyleBackColor = True
        '
        'EndInput
        '
        Me.EndInput.Location = New System.Drawing.Point(294, 199)
        Me.EndInput.Name = "EndInput"
        Me.EndInput.Size = New System.Drawing.Size(75, 23)
        Me.EndInput.TabIndex = 1
        Me.EndInput.Text = "End"
        Me.EndInput.UseVisualStyleBackColor = True
        '
        'NumberInput
        '
        Me.NumberInput.Location = New System.Drawing.Point(91, 44)
        Me.NumberInput.Name = "NumberInput"
        Me.NumberInput.Size = New System.Drawing.Size(78, 23)
        Me.NumberInput.TabIndex = 2
        '
        'LengthBox
        '
        Me.LengthBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.LengthBox.FormattingEnabled = True
        Me.LengthBox.ItemHeight = 15
        Me.LengthBox.Location = New System.Drawing.Point(394, 73)
        Me.LengthBox.Name = "LengthBox"
        Me.LengthBox.Size = New System.Drawing.Size(258, 709)
        Me.LengthBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "From 0 to"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(72, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Bounds"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LargeNumberWarning)
        Me.GroupBox1.Controls.Add(Me.NumberInput)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 156)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(282, 119)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Settings"
        '
        'LargeNumberWarning
        '
        Me.LargeNumberWarning.AutoSize = True
        Me.LargeNumberWarning.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LargeNumberWarning.ForeColor = System.Drawing.Color.Red
        Me.LargeNumberWarning.Location = New System.Drawing.Point(12, 82)
        Me.LargeNumberWarning.Name = "LargeNumberWarning"
        Me.LargeNumberWarning.Size = New System.Drawing.Size(258, 15)
        Me.LargeNumberWarning.TabIndex = 10
        Me.LargeNumberWarning.Text = "Numbers over 10000 might take a long time!"
        Me.LargeNumberWarning.Visible = False
        '
        'DistBox
        '
        Me.DistBox.Font = New System.Drawing.Font("Courier New", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DistBox.FormattingEnabled = True
        Me.DistBox.ItemHeight = 15
        Me.DistBox.Location = New System.Drawing.Point(6, 24)
        Me.DistBox.Name = "DistBox"
        Me.DistBox.Size = New System.Drawing.Size(741, 679)
        Me.DistBox.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(394, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 15)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Lengths"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(658, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(128, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Distribution of Lengths"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(658, 43)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(761, 739)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label16)
        Me.TabPage1.Controls.Add(Me.DistGraph)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(753, 711)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Graphical"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DistGraph
        '
        Me.DistGraph.Font = New System.Drawing.Font("Courier New", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DistGraph.FormattingEnabled = True
        Me.DistGraph.HorizontalScrollbar = True
        Me.DistGraph.ItemHeight = 8
        Me.DistGraph.Location = New System.Drawing.Point(6, 30)
        Me.DistGraph.Name = "DistGraph"
        Me.DistGraph.Size = New System.Drawing.Size(741, 668)
        Me.DistGraph.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label17)
        Me.TabPage2.Controls.Add(Me.DistBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(753, 711)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Numerical"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'StdDevBox
        '
        Me.StdDevBox.Location = New System.Drawing.Point(196, 24)
        Me.StdDevBox.Name = "StdDevBox"
        Me.StdDevBox.ReadOnly = True
        Me.StdDevBox.Size = New System.Drawing.Size(100, 23)
        Me.StdDevBox.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(83, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 15)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Standard Deviation"
        '
        'LabelMean
        '
        Me.LabelMean.AutoSize = True
        Me.LabelMean.Location = New System.Drawing.Point(116, 63)
        Me.LabelMean.Name = "LabelMean"
        Me.LabelMean.Size = New System.Drawing.Size(37, 15)
        Me.LabelMean.TabIndex = 13
        Me.LabelMean.Text = "Mean"
        '
        'MeanBox
        '
        Me.MeanBox.Location = New System.Drawing.Point(196, 60)
        Me.MeanBox.Name = "MeanBox"
        Me.MeanBox.ReadOnly = True
        Me.MeanBox.Size = New System.Drawing.Size(100, 23)
        Me.MeanBox.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(112, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 15)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Median"
        '
        'MedianBox
        '
        Me.MedianBox.Location = New System.Drawing.Point(196, 91)
        Me.MedianBox.Name = "MedianBox"
        Me.MedianBox.ReadOnly = True
        Me.MedianBox.Size = New System.Drawing.Size(100, 23)
        Me.MedianBox.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(53, 151)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 15)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Quartile 1"
        '
        'Q1Box
        '
        Me.Q1Box.Location = New System.Drawing.Point(112, 148)
        Me.Q1Box.Name = "Q1Box"
        Me.Q1Box.ReadOnly = True
        Me.Q1Box.Size = New System.Drawing.Size(100, 23)
        Me.Q1Box.TabIndex = 18
        '
        'Q2Box
        '
        Me.Q2Box.Location = New System.Drawing.Point(112, 177)
        Me.Q2Box.Name = "Q2Box"
        Me.Q2Box.ReadOnly = True
        Me.Q2Box.Size = New System.Drawing.Size(100, 23)
        Me.Q2Box.TabIndex = 20
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(53, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(58, 15)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Quartile 2"
        '
        'Q3Box
        '
        Me.Q3Box.Location = New System.Drawing.Point(112, 206)
        Me.Q3Box.Name = "Q3Box"
        Me.Q3Box.ReadOnly = True
        Me.Q3Box.Size = New System.Drawing.Size(100, 23)
        Me.Q3Box.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(53, 209)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 15)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Quartile 3"
        '
        'Q4Box
        '
        Me.Q4Box.Location = New System.Drawing.Point(112, 235)
        Me.Q4Box.Name = "Q4Box"
        Me.Q4Box.ReadOnly = True
        Me.Q4Box.Size = New System.Drawing.Size(100, 23)
        Me.Q4Box.TabIndex = 24
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(53, 238)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(58, 15)
        Me.Label11.TabIndex = 23
        Me.Label11.Text = "Quartile 4"
        '
        'SkewnessBox
        '
        Me.SkewnessBox.Location = New System.Drawing.Point(112, 285)
        Me.SkewnessBox.Name = "SkewnessBox"
        Me.SkewnessBox.ReadOnly = True
        Me.SkewnessBox.Size = New System.Drawing.Size(100, 23)
        Me.SkewnessBox.TabIndex = 26
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(53, 288)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 15)
        Me.Label12.TabIndex = 25
        Me.Label12.Text = "Skewness"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.StdDevBox)
        Me.GroupBox3.Controls.Add(Me.SkewnessBox)
        Me.GroupBox3.Controls.Add(Me.LabelMean)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.MeanBox)
        Me.GroupBox3.Controls.Add(Me.Q4Box)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.MedianBox)
        Me.GroupBox3.Controls.Add(Me.Q3Box)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Q1Box)
        Me.GroupBox3.Controls.Add(Me.Q2Box)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Location = New System.Drawing.Point(6, 281)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(373, 336)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Statistics"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(4, 19)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(292, 15)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "This program calculates the distribution of the lengths"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(4, 34)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(133, 15)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "of Hailstone Sequences."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(4, 66)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(256, 15)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Input an upper bound and hit start to calculate."
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(6, 10)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(166, 15)
        Me.Label16.TabIndex = 33
        Me.Label16.Text = "Shows distribution graphically"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 6)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(170, 15)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Shows distribution numerically"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(394, 55)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(140, 15)
        Me.Label18.TabIndex = 34
        Me.Label18.Text = "Shows calculated lengths"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 25)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(373, 125)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Instructions"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 94)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(254, 15)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = "It will calculate statistics about the distribution."
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Linen
        Me.ClientSize = New System.Drawing.Size(1449, 794)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.LengthBox)
        Me.Controls.Add(Me.EndInput)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.StartInput)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.Text = "Hailstone Length Distribution Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StartInput As Button
    Friend WithEvents EndInput As Button
    Friend WithEvents NumberInput As TextBox
    Friend WithEvents LengthBox As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DistBox As ListBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SigDigits As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents LargeNumberWarning As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DistGraph As ListBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents StdDevBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents LabelMean As Label
    Friend WithEvents MeanBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents MedianBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Q1Box As TextBox
    Friend WithEvents Q2Box As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Q3Box As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Q4Box As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents SkewnessBox As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label19 As Label
End Class
