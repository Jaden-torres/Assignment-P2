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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        ComputeBttn = New Button()
        ClearBttn = New Button()
        ExitBttn = New Button()
        Label4 = New Label()
        PictureBox1 = New PictureBox()
        Input = New TextBox()
        Answer = New GroupBox()
        FICALBL = New Label()
        FEDERALLBL = New Label()
        STATELBL = New Label()
        FICA = New GroupBox()
        FEDERAL = New GroupBox()
        STATE = New GroupBox()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cooper Black", 24.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(1182, 97)
        Label1.Name = "Label1"
        Label1.Size = New Size(477, 55)
        Label1.TabIndex = 0
        Label1.Text = "Payroll Calculator"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cooper Black", 18.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(1202, 276)
        Label2.Name = "Label2"
        Label2.Size = New Size(412, 41)
        Label2.TabIndex = 1
        Label2.Text = "Paycheck Calculation"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(1052, 617)
        Label3.Name = "Label3"
        Label3.Size = New Size(321, 43)
        Label3.TabIndex = 2
        Label3.Text = "Enter Gross Pay:"
        ' 
        ' ComputeBttn
        ' 
        ComputeBttn.Location = New Point(426, 704)
        ComputeBttn.Name = "ComputeBttn"
        ComputeBttn.Size = New Size(184, 72)
        ComputeBttn.TabIndex = 3
        ComputeBttn.Text = "Compute Taxes"
        ComputeBttn.UseVisualStyleBackColor = True
        ' 
        ' ClearBttn
        ' 
        ClearBttn.Location = New Point(867, 704)
        ClearBttn.Name = "ClearBttn"
        ClearBttn.Size = New Size(184, 72)
        ClearBttn.TabIndex = 4
        ClearBttn.Text = "Clear"
        ClearBttn.UseVisualStyleBackColor = True
        ' 
        ' ExitBttn
        ' 
        ExitBttn.Location = New Point(1225, 704)
        ExitBttn.Name = "ExitBttn"
        ExitBttn.Size = New Size(184, 72)
        ExitBttn.TabIndex = 5
        ExitBttn.Text = "Exit"
        ExitBttn.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(480, 910)
        Label4.Name = "Label4"
        Label4.Size = New Size(321, 43)
        Label4.TabIndex = 6
        Label4.Text = "Net Pay Income:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 12)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(998, 669)
        PictureBox1.TabIndex = 7
        PictureBox1.TabStop = False
        ' 
        ' Input
        ' 
        Input.Location = New Point(1396, 629)
        Input.Name = "Input"
        Input.Size = New Size(243, 31)
        Input.TabIndex = 8
        ' 
        ' Answer
        ' 
        Answer.Font = New Font("Tahoma", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Answer.Location = New Point(848, 915)
        Answer.Name = "Answer"
        Answer.Size = New Size(525, 38)
        Answer.TabIndex = 9
        Answer.TabStop = False
        Answer.Text = "Net Income"
        ' 
        ' FICALBL
        ' 
        FICALBL.AutoSize = True
        FICALBL.Font = New Font("Tahoma", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FICALBL.Location = New Point(438, 823)
        FICALBL.Name = "FICALBL"
        FICALBL.Size = New Size(119, 43)
        FICALBL.TabIndex = 10
        FICALBL.Text = "FICA:"
        ' 
        ' FEDERALLBL
        ' 
        FEDERALLBL.AutoSize = True
        FEDERALLBL.Font = New Font("Tahoma", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        FEDERALLBL.Location = New Point(782, 823)
        FEDERALLBL.Name = "FEDERALLBL"
        FEDERALLBL.Size = New Size(244, 43)
        FEDERALLBL.TabIndex = 11
        FEDERALLBL.Text = "Federal Tax:"
        ' 
        ' STATELBL
        ' 
        STATELBL.AutoSize = True
        STATELBL.Font = New Font("Tahoma", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        STATELBL.Location = New Point(1202, 823)
        STATELBL.Name = "STATELBL"
        STATELBL.Size = New Size(205, 43)
        STATELBL.TabIndex = 12
        STATELBL.Text = "State Tax:"
        ' 
        ' FICA
        ' 
        FICA.Font = New Font("Tahoma", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FICA.Location = New Point(583, 828)
        FICA.Name = "FICA"
        FICA.Size = New Size(173, 38)
        FICA.TabIndex = 10
        FICA.TabStop = False
        FICA.Text = "FICA Tax"
        ' 
        ' FEDERAL
        ' 
        FEDERAL.Font = New Font("Tahoma", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        FEDERAL.Location = New Point(1032, 828)
        FEDERAL.Name = "FEDERAL"
        FEDERAL.Size = New Size(173, 38)
        FEDERAL.TabIndex = 13
        FEDERAL.TabStop = False
        FEDERAL.Text = "Federal Tax"
        ' 
        ' STATE
        ' 
        STATE.Font = New Font("Tahoma", 12.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        STATE.Location = New Point(1424, 828)
        STATE.Name = "STATE"
        STATE.Size = New Size(190, 38)
        STATE.TabIndex = 14
        STATE.TabStop = False
        STATE.Text = "State Tax"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10.0F, 25.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1901, 1020)
        Controls.Add(STATE)
        Controls.Add(FEDERAL)
        Controls.Add(FICA)
        Controls.Add(STATELBL)
        Controls.Add(FEDERALLBL)
        Controls.Add(FICALBL)
        Controls.Add(Answer)
        Controls.Add(Input)
        Controls.Add(PictureBox1)
        Controls.Add(Label4)
        Controls.Add(ExitBttn)
        Controls.Add(ClearBttn)
        Controls.Add(ComputeBttn)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ComputeBttn As Button
    Friend WithEvents ClearBttn As Button
    Friend WithEvents ExitBttn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Input As TextBox
    Friend WithEvents Answer As GroupBox
    Friend WithEvents FICALBL As Label
    Friend WithEvents FEDERALLBL As Label
    Friend WithEvents STATELBL As Label
    Friend WithEvents FICA As GroupBox
    Friend WithEvents FEDERAL As GroupBox
    Friend WithEvents STATE As GroupBox

End Class
