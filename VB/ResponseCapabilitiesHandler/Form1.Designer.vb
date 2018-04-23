Namespace ResponseCapabilitiesHandler
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim imageLayer1 As New DevExpress.XtraMap.ImageLayer()
            Dim wmsDataProvider1 As New DevExpress.XtraMap.WmsDataProvider()
            Me.mapControl = New DevExpress.XtraMap.MapControl()
            Me.label1 = New System.Windows.Forms.Label()
            DirectCast(Me.mapControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' mapControl
            ' 
            wmsDataProvider1.ServerUri = "INSERT_YOUR_SERVER_URI"
            imageLayer1.DataProvider = wmsDataProvider1
            imageLayer1.Name = "WmsImageLayer"
            Me.mapControl.Layers.Add(imageLayer1)
            Me.mapControl.Location = New System.Drawing.Point(0, 0)
            Me.mapControl.Name = "mapControl"
            Me.mapControl.Size = New System.Drawing.Size(700, 700)
            Me.mapControl.TabIndex = 0
            ' 
            ' label1
            ' 
            Me.label1.AutoSize = True
            Me.label1.Location = New System.Drawing.Point(12, 710)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(35, 13)
            Me.label1.TabIndex = 1
            Me.label1.Text = "label1"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(700, 732)
            Me.Controls.Add(Me.label1)
            Me.Controls.Add(Me.mapControl)
            Me.Name = "Form1"
            Me.Text = "WmsDataProvider"
            DirectCast(Me.mapControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        #End Region

        Private mapControl As DevExpress.XtraMap.MapControl
        Private label1 As System.Windows.Forms.Label
    End Class
End Namespace

