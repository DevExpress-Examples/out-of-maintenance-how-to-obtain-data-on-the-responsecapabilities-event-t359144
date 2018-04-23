Imports DevExpress.XtraMap
Imports System.Windows.Forms

Namespace ResponseCapabilitiesHandler
    Partial Public Class Form1
        Inherits Form

        Private ReadOnly Property WmsLayer() As ImageLayer
            Get
                Return CType(mapControl.Layers("WmsImageLayer"), ImageLayer)
            End Get
        End Property
        Private ReadOnly Property Provider() As WmsDataProvider
            Get
                Return TryCast(WmsLayer.DataProvider, WmsDataProvider)
            End Get
        End Property
        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            ' Handle the ResponseCapabilities event.
            AddHandler Provider.ResponseCapabilities, AddressOf OnResponseCapabalities
        End Sub
        Private Sub OnResponseCapabalities(ByVal sender As Object, ByVal e As CapabilitiesResponsedEventArgs)
            ' Specify an active layer for the map control.
            Provider.ActiveLayerName = e.Layers(0).Name
            ' Recieve information on the active layer.
            label1.Text = String.Format("Layer name: {0}, Layer title: {1}", e.Layers(0).Name, e.Layers(0).Title)
        End Sub
    End Class
End Namespace
